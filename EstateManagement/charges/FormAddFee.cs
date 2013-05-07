using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstateManagement.pub;

namespace EstateManagement.charges
{
    public partial class FormAddFee : Form
    {
        private bool isNew=true;
        private string feeid="-1";
        public FormAddFee():this(true,"-1"){}
        public FormAddFee(bool _isNew, string _feeid)
        {
            InitializeComponent();
            isNew = _isNew;
            feeid = _feeid;
            InitData();
        }
        private void InitData()
        {
            using (DataBase db = new DataBase())
            {
                //init combobox_comp
                DataTable dt = db.ExecuteDataTable("SELECT ID,COMP_NAME FROM CONTRACT_INFO WHERE TERMINATE<>1");
                foreach (DataRow dr in dt.Rows)
                {
                    comboBox_comp.Items.Add(new ComboItem(dr[0].ToString(), dr[1].ToString()));
                }
                //init combobox_type
                dt = db.ExecuteDataTable("SELECT DISTINCT FEE_TYPE FROM FEE_INFO");
                foreach (DataRow dr in dt.Rows)
                {
                    comboBox_type.Items.Add(dr[0].ToString());
                }
                textBox_genmonth.Text = DateTime.Now.ToString("yyyyMM");
                if (!isNew)
                {
                    this.Text = "更改记录";
                    button_confirm.Text = "确定更改";
                    dt = db.ExecuteDataTable("SELECT [FEE_TYPE],[FEE_CHARGE],[LAST_END],[NEXT_START],[COMP_ID],A.[COMMENT] " +
                        ",[GEN_MONTH],[ISPAID],[COMP_NAME] FROM [FEE_INFO] A,[CONTRACT_INFO] B  " +
                        "WHERE A.COMP_ID=B.ID AND A.ID="+feeid);
                    if (dt.Rows.Count != 1) return;
                    ComboItem combocomp = new ComboItem(dt.Rows[0][4].ToString(), dt.Rows[0][8].ToString());
                    comboBox_comp.SelectedItem = combocomp;
                    comboBox_type.SelectedItem = dt.Rows[0][0].ToString();
                    textBox_genmonth.Text = dt.Rows[0][6].ToString();
                    textBox_comment.Text = dt.Rows[0][5].ToString();
                    textBox_charge.Text = dt.Rows[0][1].ToString();
                    DateTime lastend = DateTime.Now;
                    DateTime nextstart = DateTime.Now;
                    DateTime.TryParse(dt.Rows[0][2].ToString(), out lastend);
                    DateTime.TryParse(dt.Rows[0][3].ToString(), out nextstart);
                    dateTimePicker_lastend.Value = lastend;
                    dateTimePicker_nextstart.Value = nextstart;
                    textBox_curdate.Text = lastend.ToShortDateString() + " - " + nextstart.ToShortDateString();
                    if ((bool)dt.Rows[0][7])
                    {
                        button_confirm.Text = "这项费用已付款";
                        button_confirm.Enabled = false;
                    }

                }
            }
        }
        private void LoadLastEnd()
        {
            if (comboBox_comp.SelectedItem == null ||
                comboBox_type.SelectedItem == null)
                return;
            ComboItem combocomp = (ComboItem)comboBox_comp.SelectedItem;
            string combotype = comboBox_type.SelectedItem.ToString();
            string sql = "SELECT TOP 1 NEXT_START FROM FEE_INFO "+
                "WHERE COMP_ID="+combocomp.Key+" AND FEE_TYPE='"+combotype+"' ORDER BY NEXT_START DESC";
            using (DataBase db = new DataBase())
            {
                DataTable dt = db.ExecuteDataTable(sql);
                DateTime lastend = DateTime.Now;
                if (dt.Rows.Count == 1 && DateTime.TryParse(dt.Rows[0][0].ToString(),out lastend))
                {
                    dateTimePicker_lastend.Value = lastend;
                    dt = db.ExecuteDataTable("SELECT INTERVAL FROM PRED_CHARGE WHERE COMP_ID=" + combocomp.Key);
                    int interval=3;
                    if (dt.Rows.Count > 0)
                        int.TryParse(dt.Rows[0][0].ToString(), out interval);
                    DateTime nextstart = lastend.AddMonths(interval);
                    dateTimePicker_nextstart.Value = nextstart;
                    textBox_curdate.Text = lastend.ToShortDateString() + " - " + nextstart.ToShortDateString();
                }
            }
        }
        private bool CheckDataValidation()
        {
            if(comboBox_comp.SelectedItem==null ||
                comboBox_type.SelectedItem==null ||
                textBox_genmonth.Text.Length != 6)
            {
                return false;
            }
            string genmonth = textBox_genmonth.Text;
            int month = 0,year=0;
            if (int.TryParse(genmonth.Substring(0, 4), out year) &&
                int.TryParse(genmonth.Substring(4), out month))
            {
                if (month < 1 || month > 12) return false;
            }
            else
                return false;
            double charge = 0.0;
            if (!double.TryParse(textBox_charge.Text, out charge))
            {
                return false;
            }

            return true;
        }

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLastEnd();
        }

        private void comboBox_comp_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLastEnd();
        }

        private void SaveChanges()
        {
            if (!CheckDataValidation())
            {
                MessageBox.Show("数据不完整!");
                return;
            }
            string sql = "";
            string feetype = comboBox_type.SelectedItem.ToString();
            double feecharge = 0.0;
            double.TryParse(textBox_charge.Text,out feecharge);
            string compid = ((ComboItem)comboBox_comp.SelectedItem).Key;
            DateTime lastend = dateTimePicker_lastend.Value;
            DateTime nextstart = dateTimePicker_nextstart.Value;
            string comment = textBox_comment.Text;
            string genmonth = textBox_genmonth.Text;
            
            if (isNew)
            {
                sql = "INSERT INTO [FEE_INFO]([FEE_TYPE],[FEE_CHARGE],[LAST_END],[NEXT_START] "+
                    ",[COMP_ID],[COMMENT],[GEN_MONTH],[ISPAID]) VALUES (@FEE_TYPE,@FEE_CHARGE "+
                    ",@LAST_END,@NEXT_START,@COMP_ID,@COMMENT,@GEN_MONTH,@ISPAID)";
                using (DataBase db = new DataBase())
                {
                    db.AddParameter("FEE_TYPE", feetype);
                    db.AddParameter("FEE_CHARGE", feecharge);
                    db.AddParameter("LAST_END", lastend);
                    db.AddParameter("NEXT_START", nextstart);
                    db.AddParameter("COMP_ID", compid);
                    db.AddParameter("COMMENT", comment);
                    db.AddParameter("GEN_MONTH", genmonth);
                    db.AddParameter("ISPAID", false);
                    db.ExecuteNonQuery(sql);
                }
            }
            else
            {
                sql = "UPDATE [FEE_INFO] SET[FEE_TYPE]=@FEE_TYPE,[FEE_CHARGE]=@FEE_CHARGE " +
                    ",[LAST_END]=@LAST_END,[NEXT_START]=@NEXT_START,[COMP_ID]=@COMP_ID " +
                    ",[COMMENT]=@COMMENT,[GEN_MONTH]=@GEN_MONTH WHERE ID=@ID";
                using (DataBase db = new DataBase())
                {
                    db.AddParameter("FEE_TYPE", feetype);
                    db.AddParameter("FEE_CHARGE", feecharge);
                    db.AddParameter("LAST_END", lastend);
                    db.AddParameter("NEXT_START", nextstart);
                    db.AddParameter("COMP_ID", compid);
                    db.AddParameter("COMMENT", comment);
                    db.AddParameter("GEN_MONTH", genmonth);
                    db.AddParameter("ID", feeid);
                    db.ExecuteNonQuery(sql);
                }
            }
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            SaveChanges();
            if (isNew)
                ClearControls();
            else
                this.Close();
        }
        private void ClearControls()
        {
            comboBox_comp.SelectedItem = null;
            comboBox_type.SelectedItem = null;
            textBox_genmonth.Text = DateTime.Now.ToString("yyyyMM");
            textBox_charge.Text = "";
            dateTimePicker_lastend.Value = DateTime.Now;
            dateTimePicker_nextstart.Value = DateTime.Now;
            textBox_curdate.Text = "";
            textBox_comment.Text = "";
        }
    }
}
