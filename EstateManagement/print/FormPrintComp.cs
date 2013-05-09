using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstateManagement.pub;

namespace EstateManagement.print
{
    public partial class FormPrintComp : Form
    {
        private DateTime mMonthBegin;
        private DateTime mMonthEnd;
        private string mMonth = "";
        private string fileName;
        private int curPos = 0;
        public FormPrintComp()
        {
            InitializeComponent();
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            mMonthBegin = dateTimePicker_selmonth.Value;
            mMonthEnd = dateTimePicker_selmonth.Value.AddMonths(1).AddDays(-1).AddHours(23).AddMinutes(59).AddSeconds(59);
            mMonth = dateTimePicker_selmonth.Value.ToString("yyyyMM");
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel文件(*.xlsx)|*.xlsx";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            sfd.AddExtension = true;
            sfd.FileName = mMonth+"-水电煤抄表单.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //System.Threading.Thread t=new System.Threading.Thread(new System.Threading.ThreadStart(CreateExcelFromDataTable))
                //CreateExcelFromDataTable(GetCompTable(mMonth), sfd.FileName);
                fileName = sfd.FileName;
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(CreateExcelFromDataTable));
                t.Start();
                timer_compprint.Enabled = true;
                progressBar_printcomp.Style = ProgressBarStyle.Continuous;
                progressBar_printcomp.Maximum = 100;
                progressBar_printcomp.Value = 0;
            }
        }

        private void FormPrintComp_Load(object sender, EventArgs e)
        {
            dateTimePicker_selmonth.Value = dateTimePicker_selmonth.Value.AddDays(1 - dateTimePicker_selmonth.Value.Day).Date;

        }
        private DataTable GetCompTable(string genmonth)
        {
            if (CheckIfExist(genmonth))
            {
                DialogResult dr = MessageBox.Show("所选月份已收过水电煤,还是要继续吗?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    return null;
                }
            }
            DataTable dtCustomers = new DataTable();
            using (DataBase db = new DataBase())
            {
                dtCustomers = db.ExecuteDataTable("SELECT A.COMP_NAME,B.ROOM_NO,A.START_DATE,A.END_DATE,A.ID "+
                    "FROM CONTRACT_INFO A,ROOM_INFO B " +
                    "WHERE A.ID=B.COMP_ID AND A.TERMINATE<>1 ORDER BY A.COMP_NAME");
            }
            DataTable dtComps = dtCustomers.Clone();
            foreach (DataRow drCustomer in dtCustomers.Rows)
            {
                if ((DateTime)drCustomer[3] < mMonthBegin)
                    continue;
                string compid = drCustomer[4].ToString();
                DateTime? lastNextStartTime = getLastNextStartTime(compid);
                int interval = GetInterval(compid);
                if (lastNextStartTime == null)
                {
                    //新客户
                    DateTime dtContractStart = (DateTime)drCustomer["START_DATE"];
                    dtContractStart = dtContractStart.AddMonths(interval);
                    if (dtContractStart > mMonthEnd)
                    {
                        continue;
                    }
                }
                else
                {
                    if (lastNextStartTime.Value > mMonthEnd)
                        continue;
                }
                //
                DataRow drComp = dtComps.NewRow();
                drComp.ItemArray = drCustomer.ItemArray;
                dtComps.Rows.Add(drComp);
            }
            return dtComps;

        }
        private bool CheckIfExist(string genmonth)
        {
            using (DataBase db = new DataBase())
            {

                //DataTable dt = db.ExecuteDataTable("SELECT TOP 1 * FROM [CJ_MAIN_FEE] WHERE [LAST_END] >= '" + mMonthBegin.ToString() + "' AND [LAST_END] <= '" + mMonthEnd.ToString() + "'");
                DataTable dt = db.ExecuteDataTable("SELECT TOP 1 * FROM [FEE_INFO] WHERE [GEN_MONTH] = '" + mMonth + "' AND ([FEE_TYPE]='水费' OR [FEE_TYPE]='电费' OR [FEE_TYPE]='煤气费')");
                if (dt.Rows.Count > 0)
                    return true;
            }
            return false;
        }
        private DateTime? getLastNextStartTime(String company_id)
        {
            using (DataBase db = new DataBase())
            {
                db.AddParameter("COMP_ID", company_id);
                // 得到最大的NextTime。  
                // 
                DataTable dt = db.ExecuteDataTable("SELECT MAX([NEXT_START]) FROM [FEE_INFO] WHERE [COMP_ID]=@COMP_ID AND [FEE_TYPE]='房租'");
                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[0][0].ToString() == "")
                        return null;
                    return (DateTime?)dt.Rows[0][0];
                }
            }
            return null;
        }
        private int GetInterval(string compid)
        {
            int interval=3;
            using (DataBase db = new DataBase())
            {
                DataTable dt = db.ExecuteDataTable("SELECT INTERVAL FROM View_PRED_CHARGE WHERE COMP_ID=" + compid);
                if (dt.Rows.Count > 0)
                    int.TryParse(dt.Rows[0][0].ToString(), out interval);
            }
            return interval;
        }
        private void CreateExcelFromDataTable(DataTable dtComps,string filename)
        {
            if (dtComps.Rows.Count <= 0)
            {
                MessageBox.Show("没有数据");
                
                timer_compprint.Enabled = false;
                progressBar_printcomp.Value = 0;
                return;
            }
            string lastCompName = "";
            object missing = System.Reflection.Missing.Value;
            curPos = 2;
            Microsoft.Office.Interop.Excel.Application xlsApp = new Microsoft.Office.Interop.Excel.Application();
            curPos = 10;
            Microsoft.Office.Interop.Excel.Workbooks xlsWorkbooks = xlsApp.Workbooks;
            curPos = 12;
            Microsoft.Office.Interop.Excel.Workbook xlsWorkbook = xlsWorkbooks.Add(true);
            curPos = 14;
            Microsoft.Office.Interop.Excel.Sheets xlsSheets = xlsWorkbook.Sheets;
            Microsoft.Office.Interop.Excel.Worksheet xlsWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlsSheets[1];
            curPos = 20;
            xlsWorkSheet.Cells[1, 1] = "公司";
            xlsWorkSheet.Cells[1, 2] = "房间号";
            xlsWorkSheet.Cells[1, 3] = "水费抄表";
            xlsWorkSheet.Cells[1, 4] = "电费抄表";
            xlsWorkSheet.Cells[1, 5] = "煤气费抄表";
            int cnt = 0;
            int rownum = 2;
            curPos = 22;
            foreach (DataRow dr in dtComps.Rows)
            {
                if (dr[0].ToString() != lastCompName)
                {
                    xlsWorkSheet.Cells[rownum, 1] = dr[0].ToString();
                    lastCompName = dr[0].ToString();
                    if (cnt > 1 && rownum>cnt)
                    {
                        //合并上面cnt行
                        Microsoft.Office.Interop.Excel.Range compRange = xlsWorkSheet.get_Range(xlsWorkSheet.Cells[rownum - cnt, 1], xlsWorkSheet.Cells[rownum - 1, 1]);
                        compRange.Merge(compRange.MergeCells);
                    }
                    //
                    cnt = 0;
                }
                xlsWorkSheet.Cells[rownum, 2] = dr[1].ToString();
                cnt++;
                rownum++;
                if (curPos < 80) curPos++;
            }
            curPos = 80;
            if (cnt > 1 && rownum > cnt)
            {
                Microsoft.Office.Interop.Excel.Range compRange = xlsWorkSheet.get_Range(xlsWorkSheet.Cells[rownum - cnt, 1], xlsWorkSheet.Cells[rownum - 1, 1]);
                compRange.Merge(compRange.MergeCells);
            }
            curPos = 85;
            //format
            if (rownum > 1)
            {
                Microsoft.Office.Interop.Excel.Range compRange = xlsWorkSheet.get_Range(xlsWorkSheet.Cells[1 , 1], xlsWorkSheet.Cells[rownum - 1, 5]);
                compRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                compRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                
                compRange.Borders.LineStyle = 1;
                compRange.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous,
                    Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin,
                    Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic,
                    System.Drawing.Color.Black.ToArgb());
                Microsoft.Office.Interop.Excel.Range headRange = xlsWorkSheet.get_Range(xlsWorkSheet.Cells[1, 1], xlsWorkSheet.Cells[1, 5]);
                headRange.Font.Bold = true;
                headRange.Font.Size = 15;
                headRange.Cells.Interior.Color = System.Drawing.Color.FromArgb(255, 179, 102).ToArgb();  

                compRange.EntireColumn.AutoFit();
            }
            curPos = 90;
            xlsApp.DisplayAlerts = false;
            xlsWorkbook.SaveAs(filename, missing, missing, missing, missing, missing,
                Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                missing, missing, missing, missing, missing);
            xlsApp.DisplayAlerts = true;
            curPos = 100;
            if (MessageBox.Show("生成文件成功,是否打开?", "生成文件成功", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //open excel
                xlsApp.Visible = true;
            }
            else
            {
                xlsWorkbook.Close(false, missing, missing);
                xlsApp.Quit();
            }
            this.Close();
        }
        private void CreateExcelFromDataTable()
        {
            if (fileName != "" && mMonth != "")
            {
                curPos = 1;
                CreateExcelFromDataTable(GetCompTable(mMonth), fileName);
            }
        }

        private void timer_compprint_Tick(object sender, EventArgs e)
        {
            progressBar_printcomp.Value = curPos;
        }
    }
}
