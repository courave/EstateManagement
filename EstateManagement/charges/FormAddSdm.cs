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
            if (!isNew)
            {
                Collapse();
                this.Text = "更改信息";
                button_confirm.Text = "确定更改";
                //load data
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
                using (DataBase db = new DataBase())
                {
                    DataTable dt = db.ExecuteDataTable("SELECT ID,COMP_NAME FROM CONTRACT_INFO WHERE TERMINATE<>1");
                    foreach (DataRow dr in dt.Rows)
                    {
                        comboBox_comp.Items.Add(new ComboItem(dr[0].ToString(), dr[1].ToString()));
                    }
                }
                comboBox_room.Enabled = false;
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
            if (comboBox_comp.SelectedItem != null)
            {
                comboBox_room.Enabled = true;
                ComboItem compitem = (ComboItem)comboBox_comp.SelectedItem;
                using (DataBase db = new DataBase())
                {
                    DataTable dt = db.ExecuteDataTable("SELECT ID,ROOM_NO FROM ROOM_INFO WHERE COMP_ID="+compitem.Key);
                    foreach (DataRow dr in dt.Rows)
                    {
                        comboBox_room.Items.Add(new ComboItem(dr[0].ToString(), dr[1].ToString()));
                    }
                }
            }
            else
            {
                comboBox_room.Items.Clear();
                comboBox_room.Enabled = false;
            }
        }

        private void comboBox_room_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_room.SelectedItem != null)
            {
                comboBox_type.Enabled = true;
            }
            else
            {
                comboBox_type.Enabled = false;
            }
        }

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_type.Text == "") return;
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
                }
                else
                {
                    textBox_lasttime.Text = "";
                    textBox_lastsum.Text = "";
                    textBox_lastcharge.Text = "";

                }
            }
        }
    }
}
