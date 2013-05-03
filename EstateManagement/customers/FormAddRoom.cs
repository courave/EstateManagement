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
            if (!isNew)
            {
                using (DataBase db = new DataBase())
                {
                    DataTable dt = db.ExecuteDataTable("SELECT [ROOM_NO],[LOCATION],[REMARK],[HASCOMP] FROM [ROOM_INFO] WHERE [ID]="+roomid);
                    if (dt.Rows.Count == 1)
                    {
                        textBox_roomno.Text = dt.Rows[0][0].ToString();
                        textBox_location.Text = dt.Rows[0][1].ToString();
                        textBox_remark.Text = dt.Rows[0][2].ToString();
                        if (dt.Rows[0][3] != null && dt.Rows[0][3].ToString() == "True")
                        {
                            button_confirm.Text = "这个房间已经有公司入驻";
                            button_confirm.Enabled = false;
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
                //todo
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
