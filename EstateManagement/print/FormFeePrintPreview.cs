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
    public partial class FormFeePrintPreview : Form
    {
        public string mMonth;
        private int isPaid;
        private int compid;
        public FormFeePrintPreview():this("<全部>",0){}
        public FormFeePrintPreview(string _mMonth,int _isPaid):this(_mMonth,_isPaid,-1){}
        public FormFeePrintPreview(string _mMonth,int _isPaid,int _compid)
        {
            InitializeComponent();
            mMonth = _mMonth;
            isPaid = _isPaid;
            compid = _compid;
        }

        private void FormFeePrintPreview_Load(object sender, EventArgs e)
        {
            CrystalReport_feelist feereport = new CrystalReport_feelist();
            List<ClassFeeReport> printList = new List<ClassFeeReport>();
            DataTable dtReport;
            using (DataBase db = new DataBase())
            {
                String sql = "SELECT * FROM View_FEE_REPORT WHERE 1=1 ";
                if (isPaid == 1)
                {
                    sql += " AND ISPAID=@ISPAID ";
                    db.AddParameter("ISPAID", true);
                }
                else if (isPaid == 2)
                {
                    sql += " AND ISPAID=@ISPAID ";
                    db.AddParameter("ISPAID", false);
                }
                if (mMonth != "<全部>")
                {
                    sql += " AND GEN_MONTH=@GEN_MONTH ";
                    db.AddParameter("GEN_MONTH", mMonth);
                }
                if (compid != -1)
                {
                    sql += " AND ID=@ID ";
                    db.AddParameter("ID", compid);
                }
                dtReport = db.ExecuteDataTable(sql);
            }
            if (dtReport.Rows.Count == 0)
            {
                MessageBox.Show("没有需要打印的记录");
                Dispose();
                return;
            }
            double tmp = 0;
            foreach (DataRow dr in dtReport.Rows)
            {
                double subTotal = 0;
                ClassFeeReport bill = new ClassFeeReport();
                bill.customer = dr["COMP_NAME"].ToString();
                bill.roomno = GetRoomNo(dr["ID"].ToString());
                bill.noticeDate = ((DateTime)dr["FZ_LE"]).ToString("yyyy.M.d");
                if (dr["FZ_FEE"].ToString() != "")
                {
                    bill.feeType1 = "房租";
                    bill.feeDate1 = ((DateTime)dr["FZ_LE"]).ToString("yy.M.d") + "－" + ((DateTime)dr["FZ_NS"]).AddDays(-1).ToString("yy.M.d");
                    bill.feeAmount1 = dr["FZ_FEE"].ToString();
                    bill.comment1 = dr["FZ_COMMENT"].ToString();
                    if (double.TryParse(dr["FZ_FEE"].ToString(),out tmp))
                        subTotal += tmp;
                }
                if (dr["FWF_FEE"].ToString() != "")
                {
                    bill.feeType2 = "综合技术服务费";
                    bill.feeDate2 = ((DateTime)dr["FWF_LE"]).ToString("yy.M.d") + "－" + ((DateTime)dr["FWF_NS"]).AddDays(-1).ToString("yy.M.d");
                    bill.feeAmount2 = dr["FWF_FEE"].ToString();
                    bill.comment2 = dr["FWF_COMMENT"].ToString();
                    if (double.TryParse(dr["FWF_FEE"].ToString(), out tmp))
                        subTotal += tmp;
                }
                if (dr["WY_FEE"].ToString() != "")
                {
                    bill.feeType3 = "物业费";
                    bill.feeDate3 = ((DateTime)dr["WY_LE"]).ToString("yy.M.d") + "－" + ((DateTime)dr["WY_NS"]).AddDays(-1).ToString("yy.M.d");
                    bill.feeAmount3 = dr["WY_FEE"].ToString();
                    bill.comment3 = dr["WY_COMMENT"].ToString();
                    if (double.TryParse(dr["WY_FEE"].ToString(), out tmp))
                        subTotal += tmp;
                }
                if (dr["WL_FEE"].ToString() != "")
                {
                    bill.feeType4 = "网络费";
                    bill.feeDate4 = ((DateTime)dr["WL_LE"]).ToString("yy.M.d") + "－" + ((DateTime)dr["WL_NS"]).AddDays(-1).ToString("yy.M.d");
                    bill.feeAmount4 = dr["WL_FEE"].ToString();
                    bill.comment4 = dr["WL_COMMENT"].ToString();
                    if (double.TryParse(dr["WL_FEE"].ToString(), out tmp))
                        subTotal += tmp;
                }
                if (dr["CW_FEE"].ToString() != "")
                {
                    bill.feeType5 = "车位费";
                    bill.feeDate5 = ((DateTime)dr["CW_LE"]).ToString("yy.M.d") + "－" + ((DateTime)dr["CW_NS"]).AddDays(-1).ToString("yy.M.d");
                    bill.feeAmount5 = dr["CW_FEE"].ToString();
                    bill.comment5 = dr["CW_COMMENT"].ToString();
                    if (double.TryParse(dr["CW_FEE"].ToString(), out tmp))
                        subTotal += tmp;
                }
                if (dr["QITA_FEE"].ToString() != "")
                {
                    bill.feeType6 = "其他费用";
                    bill.feeDate6 = "";//((DateTime)dr["QITA_LE"]).ToString("yy.M.d") + "－" + ((DateTime)dr["QITA_NS"]).AddDays(-1).ToString("yy.M.d");
                    bill.feeAmount6 = dr["QITA_FEE"].ToString();
                    bill.comment6 = dr["QITA_COMMENT"].ToString();
                    if (double.TryParse(dr["QITA_FEE"].ToString(), out tmp))
                        subTotal += tmp;
                }
                bill.subtotal = subTotal.ToString();
                if (dr["SF_FEE"].ToString() != "")
                {
                    bill.feeType7 = "水费";
                    bill.feeDate7 = ((DateTime)dr["SF_LE"]).ToString("yy.M.d") + "抄表";
                    bill.feeAmount7 = dr["SF_FEE"].ToString();
                    bill.comment7 = dr["SF_COMMENT"].ToString();
                    if (double.TryParse(dr["SF_FEE"].ToString(), out tmp))
                        subTotal += tmp;
                }
                if (dr["DF_FEE"].ToString() != "")
                {
                    bill.feeType8 = "电费";
                    bill.feeDate8 = ((DateTime)dr["DF_LE"]).ToString("yy.M.d") + "抄表";
                    bill.feeAmount8 = dr["DF_FEE"].ToString();
                    bill.comment8 = dr["DF_COMMENT"].ToString();
                    if (double.TryParse(dr["DF_FEE"].ToString(), out tmp))
                        subTotal += tmp;
                }
                if (dr["MQF_FEE"].ToString() != "")
                {
                    bill.feeType9 = "煤气费";
                    bill.feeDate9 = ((DateTime)dr["MQF_LE"]).ToString("yy.M.d") + "抄表";
                    bill.feeAmount9 = dr["MQF_FEE"].ToString();
                    bill.comment9 = dr["MQF_COMMENT"].ToString();
                    if (double.TryParse(dr["MQF_FEE"].ToString(), out tmp))
                        subTotal += tmp;
                }
                bill.total = subTotal.ToString();
                printList.Add(bill);
            }
            feereport.SetDataSource(printList);
            crystalReportViewer_feepreview.ReportSource = feereport;
        }
        private string GetRoomNo(string _compid)
        {
            string sql = "select ROOM_NO+';' AS [text()] from room_info where comp_id="+_compid+" for xml path('')";
            using (DataBase db = new DataBase())
            {
                DataTable dt = db.ExecuteDataTable(sql);
                if (dt.Rows.Count == 1)
                    return dt.Rows[0][0].ToString();
            }
            return "";
        }
    }
}
