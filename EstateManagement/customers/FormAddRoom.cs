using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstateManagement.pub;

namespace EstateManagement.customers
{
    public partial class FormAddRoom : Form
    {
        private bool isNew = true;
        private string roomid = "-1";
        public FormAddRoom():this(true,"-1"){}
        public FormAddRoom(bool _isNew, string _roomid)
        {
            InitializeComponent();
            isNew = _isNew;
            roomid = _roomid;
            InitializeData();
        }
        private void InitializeData()
        {
            comboBox_comp.Items.Add(new ComboItem("-1", "<无公司>"));
            using (DataBase db = new DataBase())
            {
                DataTable dt = db.ExecuteDataTable("SELECT ID,COMP_NAME FROM CONTRACT_INFO WHERE TERMINATE<>1");
                foreach (DataRow dr in dt.Rows)
                {
                    comboBox_comp.Items.Add(new ComboItem(dr[0].ToString(), dr[1].ToString()));
                }
            }
            comboBox_comp.Enabled = false;//new record do not need to select company
            comboBox_comp.SelectedIndex = 0;
            if (!isNew)
            {
                comboBox_comp.Enabled = true;
                this.Text = "修改房间信息";
                button_confirm.Text = "确定修改";
                using (DataBase db = new DataBase())
                {
                    string sql = "SELECT A.ROOM_NO,A.LOCATION,A.REMARK,A.HASCOMP,A.COMP_ID,B.COMP_NAME "+
                        "FROM ROOM_INFO A LEFT JOIN CONTRACT_INFO B ON A.COMP_ID=B.ID "+
                        "WHERE A.ID="+roomid;
                    DataTable dt = db.ExecuteDataTable(sql);
                    if (dt.Rows.Count == 1)
                    {
                        textBox_roomno.Text = dt.Rows[0][0].ToString();
                        textBox_location.Text = dt.Rows[0][1].ToString();
                        textBox_remark.Text = dt.Rows[0][2].ToString();
                        if (dt.Rows[0][3] != null && (bool)dt.Rows[0][3] == true)
                        {
                            ComboItem compitem = new ComboItem(dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString());
                            comboBox_comp.SelectedItem = compitem;
                            
                        }
                    }
                }
            }
        }
        private bool SaveChanges()
        {
            string sql = "";
            string roomno = textBox_roomno.Text;
            string location = textBox_location.Text;
            string remark = textBox_remark.Text;

            if (roomno == "")
                return false;
            if (isNew)
            {
                using (DataBase db = new DataBase())
                {
                    sql = "INSERT INTO [ROOM_INFO] "+
                        "([ROOM_NO],[LOCATION],[REMARK],[HASCOMP]) " +
                        "VALUES "+
                        "(@ROOM_NO,@LOCATION,@REMARK,@HASCOMP)";
                    db.AddParameter("ROOM_NO", roomno);
                    db.AddParameter("LOCATION", location);
                    db.AddParameter("REMARK", remark);
                    db.AddParameter("HASCOMP", false);
                    db.ExecuteNonQuery(sql);
                }
            }
            else
            {
                using (DataBase db = new DataBase())
                {
                    sql = "UPDATE [ROOM_INFO] SET [ROOM_NO]=@ROOM_NO,[LOCATION]=@LOCATION " +
                        ",[REMARK]=@REMARK,[COMP_ID]=@COMP_ID,[HASCOMP]=@HASCOMP " +
                        "WHERE [ID]=@ROOM_ID";
                    db.AddParameter("ROOM_NO", roomno);
                    db.AddParameter("LOCATION", location);
                    db.AddParameter("REMARK", remark);
                    db.AddParameter("ROOM_ID", roomid);
                    if (comboBox_comp.SelectedItem != null)
                    {
                        ComboItem compitem = (ComboItem)comboBox_comp.SelectedItem;
                        if (compitem.Key == "-1")
                        {
                            db.AddParameter("COMP_ID", DBNull.Value);
                            db.AddParameter("HASCOMP", false);
                        }
                        else
                        {
                            db.AddParameter("COMP_ID", compitem.Key);
                            db.AddParameter("HASCOMP", true);
                        }
                    }
                    else
                    {
                        db.AddParameter("COMP_ID", DBNull.Value);
                        db.AddParameter("HASCOMP", false);
                    }
                    db.ExecuteNonQuery(sql);
                }
            }
            return true;
        }
        private void button_confirm_Click(object sender, EventArgs e)
        {
            string msg = (isNew ? "成功创建记录,是否继续?" : "成功修改记录");
            if (SaveChanges())
            {
                DialogResult dr = MessageBox.Show(msg, "提醒", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes && isNew)
                {
                    CleanControls();

                }
                else
                {
                    this.Close();
                }


            }
        }

        private void CleanControls()
        {
            //throw new Exception("The method or operation is not implemented.");
            textBox_roomno.Text = "";
            textBox_location.Text = "";
            textBox_remark.Text = "";
        }

    }
}
