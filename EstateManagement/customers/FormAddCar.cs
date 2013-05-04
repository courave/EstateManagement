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
    public partial class FormAddCar : Form
    {
        public bool isNew = true;
        public string parkid = "-1";
        public string comp_id = "-1";
        public List<ComboItem> newParkListItems = new List<ComboItem>();
        public FormAddCar():this(true,"-1","-1"){}
        public FormAddCar(bool _isNew, string _parkid):this(_isNew,_parkid,"-1"){}
        public FormAddCar(bool _isNew, string _parkid, string _compid)
        {
            InitializeComponent();
            isNew = _isNew;
            parkid = _parkid;
            comp_id = _compid;
            InitializeData();
        }
        private void InitializeData()
        {
            //combobox_room
            string sql = "";
            using (DataBase db = new DataBase())
            {
                sql = "SELECT [ID],[ROOM_NO] FROM [ROOM_INFO]";
                if (comp_id != "-1")
                {
                    sql += " WHERE COMP_ID="+comp_id;
                }
                DataTable dt = db.ExecuteDataTable(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    comboBox_room.Items.Add(new ComboItem(dr[0].ToString(), dr[1].ToString()));
                }
                sql = "SELECT [ID],[COMP_NAME] FROM [CONTRACT_INFO] WHERE [TERMINATE]<>1";
                dt = db.ExecuteDataTable(sql);
                ComboItem temp;
                if(comp_id=="-1" && parkid=="-1" && isNew)
                    comboBox_comp.Items.Add(new ComboItem("-1", "<新公司>"));
                foreach (DataRow dr in dt.Rows)
                {
                    temp = new ComboItem(dr[0].ToString(), dr[1].ToString());
                    comboBox_comp.Items.Add(temp);
                    if (temp.Key == comp_id)
                        comboBox_comp.SelectedItem = temp;
                }
            }
            dateTimePicker_start.Value = DateTime.Now;
            dateTimePicker_end.Value = DateTime.Now.AddYears(3);
            
            if (!isNew)
            {
                this.Text = "更新车位信息";
                button_confirm.Text = "确定更新";
                using (DataBase db = new DataBase())
                {
                    sql = "SELECT [CAR_PLATE],[ID_CODE],[COMP_ID],[ROOM_ID],[TELE],[START_DATE], "+
                        "[END_DATE],[PRICE_MONTH],[LOCATION],[REMARK],[CAR_USER],[TERMINATE] " +
                        "FROM [PARKING_INFO] WHERE [ID]="+parkid;
                    DataTable dt = db.ExecuteDataTable(sql);
                    if (dt.Rows.Count != 1)
                        return;
                    textBox_plate.Text = dt.Rows[0][0].ToString();
                    textBox_id.Text = dt.Rows[0][1].ToString();
                    textBox_tele.Text = dt.Rows[0][4].ToString();
                    textBox_price.Text = dt.Rows[0][7].ToString();
                    textBox_location.Text = dt.Rows[0][8].ToString();
                    textBox_remark.Text = dt.Rows[0][9].ToString();
                    textBox_user.Text = dt.Rows[0][10].ToString();
                    if (dt.Rows[0][11] == null || (bool)dt.Rows[0][11] == true)
                    {
                        button_confirm.Text = "这个车位已经停用了";
                        button_confirm.Enabled = false;
                    }
                    DateTime startdate = DateTime.Now;
                    DateTime enddate = DateTime.Now.AddYears(3);
                    DateTime.TryParse(dt.Rows[0][5].ToString(), out startdate);
                    DateTime.TryParse(dt.Rows[0][6].ToString(), out enddate);
                    dateTimePicker_start.Value = startdate;
                    dateTimePicker_end.Value = enddate;
                    foreach (ComboItem item in comboBox_room.Items)
                    {
                        if (item.Key == dt.Rows[0][3].ToString())
                        {
                            comboBox_room.SelectedItem = item;
                            break;
                        }
                    }
                    foreach (ComboItem item in comboBox_comp.Items)
                    {
                        if (item.Key == dt.Rows[0][2].ToString())
                        {
                            comboBox_comp.SelectedItem = item;
                            break;
                        }
                    }

                }
            }
        }
        private bool SaveChanges()
        {
            string username = textBox_user.Text;
            string plate = textBox_plate.Text;
            string idcode = textBox_id.Text;
            string compid = comboBox_comp.SelectedItem==null?"":((ComboItem)comboBox_comp.SelectedItem).Key;
            string roomid = comboBox_room.SelectedItem == null ? "" : ((ComboItem)comboBox_room.SelectedItem).Key;
            string tele = textBox_tele.Text;
            DateTime start = dateTimePicker_start.Value;
            DateTime end = dateTimePicker_end.Value;
            double price = 0.0;
            double.TryParse(textBox_price.Text, out price);
            string location = textBox_location.Text;
            string remark = textBox_remark.Text;
            string sql = "";
            if (isNew)
            {
                using (DataBase db = new DataBase())
                {
                    sql = "INSERT INTO [PARKING_INFO] " +
                        "([CAR_PLATE],[ID_CODE],[COMP_ID],[ROOM_ID],[TELE],[START_DATE],[END_DATE] " +
                        ",[PRICE_MONTH],[LOCATION],[REMARK],[CAR_USER],[TERMINATE]) VALUES " +
                        "(@CAR_PLATE,@ID_CODE,@COMP_ID,@ROOM_ID,@TELE,@START_DATE,@END_DATE " +
                        ",@PRICE_MONTH,@LOCATION,@REMARK,@CAR_USER,@TERMINATE) "+
                        "SELECT IDENT_CURRENT('PARKING_INFO')";
                    db.AddParameter("CAR_PLATE", plate);
                    db.AddParameter("ID_CODE", idcode);
                    db.AddParameter("COMP_ID", compid);
                    db.AddParameter("ROOM_ID", roomid);
                    db.AddParameter("TELE", tele);
                    db.AddParameter("START_DATE", start);
                    db.AddParameter("END_DATE", end);
                    db.AddParameter("PRICE_MONTH", price);
                    db.AddParameter("LOCATION", location);
                    db.AddParameter("REMARK", remark);
                    db.AddParameter("CAR_USER", username);
                    db.AddParameter("TERMINATE", false);
                    DataTable dt=db.ExecuteDataTable(sql);
                    if (dt.Rows.Count != 1)
                        return false;
                    string paringid = dt.Rows[0][0].ToString();
                    RefreshParentListBox(paringid);
                }
            }
            else
            {
                using (DataBase db = new DataBase())
                {
                    sql = "UPDATE [PARKING_INFO] SET [CAR_PLATE] = @CAR_PLATE,[ID_CODE]=@ID_CODE,[COMP_ID]=@COMP_ID,[ROOM_ID]=@ROOM_ID " +
                        ",[TELE]=@TELE,[START_DATE]=@START_DATE,[END_DATE]=@END_DATE,[PRICE_MONTH]=@PRICE_MONTH,[LOCATION]=@LOCATION " +
                        ",[REMARK]=@REMARK,[CAR_USER]=@CAR_USER,[TERMINATE]=@TERMINATE WHERE [ID]=@ID";
                    db.AddParameter("CAR_PLATE", plate);
                    db.AddParameter("ID_CODE", idcode);
                    db.AddParameter("COMP_ID", compid);
                    db.AddParameter("ROOM_ID", roomid);
                    db.AddParameter("TELE", tele);
                    db.AddParameter("START_DATE", start);
                    db.AddParameter("END_DATE", end);
                    db.AddParameter("PRICE_MONTH", price);
                    db.AddParameter("LOCATION", location);
                    db.AddParameter("REMARK", remark);
                    db.AddParameter("CAR_USER", username);
                    db.AddParameter("TERMINATE", false);
                    db.AddParameter("ID", parkid);
                    db.ExecuteNonQuery(sql);

                }
            }
            return true;
        }
        private void RefreshParentListBox(string parkingid)
        {
            //ListBox park_listBox = (ListBox)this.FindForm().Parent.FindForm().Controls["listBox_parking"];
            using (DataBase db = new DataBase())
            {
                string queryStr = "SELECT A.[ID],A.[CAR_PLATE],A.[CAR_USER],B.[ROOM_NO] FROM [PARKING_INFO] A,[ROOM_INFO] B " +
                    "WHERE A.[ROOM_ID]=B.[ID] AND A.[TERMINATE]<>1 AND A.[ID]=" + parkingid;
                DataTable dt = db.ExecuteDataTable(queryStr);
                if (dt.Rows.Count != 1) return;
                newParkListItems.Add(new ComboItem(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString() + " " + dt.Rows[0][3].ToString()));
            }
        }
        private void CleanControls()
        {
            textBox_id.Text = "";
            textBox_location.Text = "";
            textBox_plate.Text = "";
            textBox_price.Text = "";
            textBox_remark.Text = "";
            textBox_tele.Text = "";
            textBox_user.Text = "";
            //do not clear room and company info
            //comboBox_comp.Text = "";
            //comboBox_room.Text = "";
            //dateTimePicker_start.Value = DateTime.Now;
            //dateTimePicker_end.Value = DateTime.Now.AddYears(3);
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
    }
}
