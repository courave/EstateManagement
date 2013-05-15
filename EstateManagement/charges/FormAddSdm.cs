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
    public partial class FormAddSdm : Form
    {
        private bool isNew = false;
        private string sdmId = "-1";
        private double shuibase = 0.0;
        private double dianbase = 0.0;
        private double meibase = 0.0;
        public FormAddSdm():this(true,"-1"){}
        public FormAddSdm(bool _isNew, string _sdmId)
        {
            isNew = _isNew;
            sdmId = _sdmId;
            InitializeComponent();
            InitializeData();
        }
        private void InitializeData()
        {
            //datetimepicker format
            dateTimePicker_cb.Format = DateTimePickerFormat.Custom;
            dateTimePicker_cb.CustomFormat = "yyyy-MM-dd HH:mm";
            dateTimePicker_cb.Value = DateTime.Now;
            using (DataBase db = new DataBase())
            {
                DataTable dt = db.ExecuteDataTable("SELECT SDM_TYPE,SDM_UNIT FROM SDM_BASE");
                foreach (DataRow dr in dt.Rows)
                {
                    switch (dr[0].ToString())
                    {
                        case "水费":
                            double.TryParse(dr[1].ToString(), out shuibase);
                            break;
                        case "电费":
                            double.TryParse(dr[1].ToString(), out dianbase);
                            break;
                        case "煤气费":
                            double.TryParse(dr[1].ToString(), out meibase);
                            break;
                    }
                }
            }
            if (!isNew)
            {
                Collapse();
                this.Text = "更改信息";
                button_confirm.Text = "确定更改";
                //load data
                comboBox_comp.DropDownStyle = ComboBoxStyle.Simple;
                comboBox_room.DropDownStyle = ComboBoxStyle.Simple;
                comboBox_type.DropDownStyle = ComboBoxStyle.Simple;
                using (DataBase db = new DataBase())
                {
                    DataTable dt = db.ExecuteDataTable("SELECT [COMP_NAME],[ROOM_NO],[SDM_TYPE],[SDM_TIME], "+
                        "[SDM_SUM],[SDM_CHARGE],[SDM_CBER],A.[COMMENT],[ISPAID] "+
                        "FROM [SDM_INFO] A, [CONTRACT_INFO] B,[ROOM_INFO] C "+
                        "WHERE A.COMP_ID=B.ID AND A.ROOM_ID=C.ID AND A.ID="+sdmId);
                    if (dt.Rows.Count == 1)
                    {
                        comboBox_comp.Text = dt.Rows[0][0].ToString();
                        comboBox_room.Text = dt.Rows[0][1].ToString();
                        comboBox_type.Text = dt.Rows[0][2].ToString();
                        textBox_sum.Text = dt.Rows[0][4].ToString();
                        textBox_charge.Text = dt.Rows[0][5].ToString();
                        textBox_cber.Text = dt.Rows[0][6].ToString();
                        textBox_comment.Text = dt.Rows[0][7].ToString();
                        if ((bool)dt.Rows[0][8])
                        {
                            button_confirm.Text = "此项目已付款";
                            button_confirm.Enabled = false;
                        }
                        DateTime cbtime = DateTime.Now;
                        if (DateTime.TryParse(dt.Rows[0][3].ToString(), out cbtime))
                        {
                            dateTimePicker_cb.Value = cbtime;
                        }
                        comboBox_comp.Enabled = false;
                        comboBox_type.Enabled = false;
                        comboBox_room.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("系统错误!");
                        this.Close();
                    }

                }

            }
            else
            {
                //get compnames
                AutoCompleteStringCollection strSuggestComps = new AutoCompleteStringCollection();
                using (DataBase db = new DataBase())
                {
                    DataTable dt = db.ExecuteDataTable("SELECT ID,COMP_NAME FROM CONTRACT_INFO WHERE TERMINATE<>1");
                    foreach (DataRow dr in dt.Rows)
                    {
                        comboBox_comp.Items.Add(new ComboItem(dr[0].ToString(), dr[1].ToString()));
                        strSuggestComps.Add(dr[1].ToString());
                    }
                }
                comboBox_comp.DropDownStyle = ComboBoxStyle.DropDown;
                comboBox_comp.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBox_comp.AutoCompleteSource = AutoCompleteSource.ListItems;
                comboBox_comp.AutoCompleteCustomSource = strSuggestComps;

                //get rooms
                AutoCompleteStringCollection strSuggestRoom = new AutoCompleteStringCollection();
                using (DataBase db = new DataBase())
                {
                    DataTable dt = db.ExecuteDataTable("SELECT ID,ROOM_NO FROM ROOM_INFO WHERE HASCOMP=1 ORDER BY ROOM_NO");
                    foreach (DataRow dr in dt.Rows)
                    {
                        comboBox_room.Items.Add(new ComboItem(dr[0].ToString(), dr[1].ToString()));
                        strSuggestRoom.Add(dr[1].ToString());
                    }
                }
                comboBox_room.DropDownStyle = ComboBoxStyle.DropDown;
                comboBox_room.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBox_room.AutoCompleteSource = AutoCompleteSource.ListItems;
                comboBox_room.AutoCompleteCustomSource = strSuggestRoom;

                comboBox_comp.Enabled = false;
                comboBox_type.Enabled = false;
            }

        }
        
        private void Collapse()
        {
            panel_last.Visible = false;
            this.Height -= panel_last.Height;
            panel_move.Location = panel_last.Location;
        }

        private void comboBox_comp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_room_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_room.SelectedItem != null)
            {
                using (DataBase db = new DataBase())
                {
                    DataTable dt = db.ExecuteDataTable("SELECT COMP_ID FROM ROOM_INFO WHERE ID="+((ComboItem)comboBox_room.SelectedItem).Key);
                    if (dt.Rows.Count != 1) return;
                    
                    foreach (ComboItem item in comboBox_comp.Items)
                    {
                        if (item.Key == dt.Rows[0][0].ToString())
                        {
                            comboBox_comp.Enabled = true;
                            comboBox_comp.SelectedItem = item;
                            break;
                        }
                    }
                }
            }
            if (comboBox_comp.Enabled == false) return;
            if (comboBox_comp.SelectedItem != null)
            {
                comboBox_type.Enabled = true;
            }
            else
            {
                comboBox_type.Enabled = false;
            }
            comboBox_comp.Enabled = false;
        }

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_type.Text == "" || !isNew) return;
            //load last data
            string sql = "SELECT TOP 1 [SDM_TIME],[SDM_SUM],[SDM_CHARGE] " +
                "FROM [SDM_INFO] " +
                "WHERE COMP_ID=@COMP_ID AND ROOM_ID=@ROOM_ID AND SDM_TYPE='"+comboBox_type.Text+"'" +
                "ORDER BY SDM_TIME DESC";
            using (DataBase db = new DataBase())
            {
                db.AddParameter("COMP_ID", ((ComboItem)comboBox_comp.SelectedItem).Key);
                db.AddParameter("ROOM_ID", ((ComboItem)comboBox_room.SelectedItem).Key);
                DataTable dt = db.ExecuteDataTable(sql);
                if (dt.Rows.Count == 1)
                {
                    textBox_lasttime.Text = dt.Rows[0][0].ToString();
                    textBox_lastsum.Text = dt.Rows[0][1].ToString();
                    textBox_lastcharge.Text = dt.Rows[0][2].ToString();
                    DateTime lastmonth = DateTime.Now;
                    if(DateTime.TryParse(dt.Rows[0][0].ToString(),out lastmonth))
                    {
                        if (lastmonth.Year == DateTime.Now.Year && lastmonth.Month == DateTime.Now.Month)
                        {
                            DialogResult dr = MessageBox.Show("本月记录已存在,确定还是要更新吗?", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dr == DialogResult.No)
                                ClearControls();
                        }
                    }
                }
                else
                {
                    textBox_lasttime.Text = "";
                    textBox_lastsum.Text = "";
                    textBox_lastcharge.Text = "";

                }
            }
        }

        private void textBox_sum_TextChanged(object sender, EventArgs e)
        {
            double lastsum = 0.0;
            double cursum = 0.0;
            double unitbase = 0.0;
            if (textBox_lastsum.Text != "")
            {
                double.TryParse(textBox_lastsum.Text, out lastsum);
            }
            if (double.TryParse(textBox_sum.Text, out cursum))
            {
                cursum -= lastsum;
                if (cursum > 0 && comboBox_type.SelectedItem!=null)
                {
                    switch (comboBox_type.SelectedItem.ToString())
                    {
                        case "水费":
                            unitbase = shuibase;
                            break;
                        case "电费":
                            unitbase = dianbase;
                            break;
                        case "煤气费":
                            unitbase = meibase;
                            break;
                    }
                    if (unitbase > 0)
                    {
                        textBox_charge.Text = (cursum * unitbase).ToString();
                    }
                }
            }
        }

        private bool SaveChanges()
        {
            DateTime sdmtime = dateTimePicker_cb.Value;
            double sdmsum = 0.0;
            if (!double.TryParse(textBox_sum.Text, out sdmsum))
                return false;
            double sdmcharge = 0.0;
            if (!double.TryParse(textBox_charge.Text, out sdmcharge))
                return false;
            string cber = textBox_cber.Text;
            string comment = textBox_comment.Text;
            string sql = "";
            if (isNew)
            {
                if (comboBox_comp.SelectedItem == null ||
                    comboBox_room.SelectedItem == null ||
                    comboBox_type.SelectedItem == null)
                    return false;
                string compid = ((ComboItem)comboBox_comp.SelectedItem).Key;
                string roomid = ((ComboItem)comboBox_room.SelectedItem).Key;
                string sdmtype = comboBox_type.SelectedItem.ToString();
                sql = "INSERT INTO [SDM_INFO]([SDM_TYPE],[SDM_SUM],[SDM_CHARGE], "+
                    "[SDM_TIME],[COMP_ID],[ISPAID],[COMMENT],[SDM_CBER],[ROOM_ID]) " +
                    "VALUES(@SDM_TYPE,@SDM_SUM,@SDM_CHARGE,@SDM_TIME "+
                    ",@COMP_ID,@ISPAID,@COMMENT,@SDM_CBER,@ROOM_ID)";
                if (textBox_lastsum.Text != "")
                {
                    comment = "上期抄表数为:" + textBox_lastsum.Text + ";" + comment;
                }
                using (DataBase db = new DataBase())
                {
                    db.AddParameter("SDM_TYPE", sdmtype);
                    db.AddParameter("SDM_SUM", sdmsum);
                    db.AddParameter("SDM_CHARGE", sdmcharge);
                    db.AddParameter("SDM_TIME", sdmtime);
                    db.AddParameter("COMP_ID", compid);
                    db.AddParameter("SDM_CBER", cber);
                    db.AddParameter("ISPAID", false);
                    db.AddParameter("COMMENT", comment);
                    db.AddParameter("ROOM_ID", roomid);
                    db.ExecuteNonQuery(sql);
                }
            }
            else
            {
                sql="UPDATE [SDM_INFO] SET [SDM_SUM]=@SDM_SUM,[SDM_CHARGE]=@SDM_CHARGE "+
                    ",[SDM_TIME]=@SDM_TIME,[COMMENT]=@COMMENT,[SDM_CBER]=@SDM_CBER " +
                    "WHERE [ID]=@ID";
                using (DataBase db = new DataBase())
                {
                    db.AddParameter("SDM_SUM", sdmsum);
                    db.AddParameter("SDM_CHARGE", sdmcharge);
                    db.AddParameter("SDM_TIME", sdmtime);
                    db.AddParameter("SDM_CBER", cber);
                    db.AddParameter("COMMENT", comment);
                    db.AddParameter("ID", sdmId);
                    db.ExecuteNonQuery(sql);


                }
            }
            return true;
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            if (SaveChanges())
            {
                MessageBox.Show("成功" + (isNew ? "录入" : "更新"));
                ClearControls();
            }
            else
            {
                MessageBox.Show((isNew ? "录入" : "更新")+"失败");
            }
        }
        private void ClearControls()
        {
            comboBox_comp.SelectedItem = null;
            comboBox_type.SelectedItem = null;
            comboBox_type.Enabled = false;
            textBox_lastcharge.Text = "";
            textBox_lastsum.Text = "";
            textBox_lasttime.Text = "";
            textBox_cber.Text = "";
            textBox_charge.Text = "";
            textBox_comment.Text = "";
            textBox_sum.Text = "";
            dateTimePicker_cb.Value = DateTime.Now;
        }
    }
}
