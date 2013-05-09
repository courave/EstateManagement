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
    public partial class FormAddCustomer : Form
    {
        private bool isNew=true;
        private string compid = "-1";
        public FormAddCustomer():this(true,"-1"){}//default new

        public FormAddCustomer(bool _isNew,string _compid)
        {
            InitializeComponent();
            isNew = _isNew;
            compid = _compid;
            InitializeData();
        }

        private void FormAddCustomer_Load(object sender, EventArgs e)
        {

        }
        private void RefreshRoomList()
        {
            comboBoxRoomList.Items.Clear();
            using (DataBase db = new DataBase())
            {
                //load room info into comboboxroomlist
                string queryStr = "SELECT [ID],[ROOM_NO] FROM [ROOM_INFO] WHERE [HASCOMP] <> 1";
                DataTable dt = db.ExecuteDataTable(queryStr);
                foreach (DataRow _dr in dt.Rows)
                {
                    comboBoxRoomList.Items.Add(new ComboItem(_dr[0].ToString(), _dr[1].ToString()));
                }
            }
        }
        private void InitializeData()
        {
            using (DataBase db = new DataBase())
            {
                //load room info into comboboxroomlist
                string queryStr = "SELECT [ID],[ROOM_NO] FROM [ROOM_INFO] WHERE [HASCOMP] <> 1";
                DataTable dt = db.ExecuteDataTable(queryStr);
                foreach (DataRow _dr in dt.Rows)
                {
                    comboBoxRoomList.Items.Add(new ComboItem(_dr[0].ToString(), _dr[1].ToString()));
                }
                textBox_interval.Text = "3";
                dateTimePicker_start.Value = DateTime.Now;
                dateTimePicker_end.Value = DateTime.Now.AddYears(3);
                if (!isNew)
                {
                    
                    //load all data
                    //load contract data
                    queryStr = "SELECT [COMP_NAME],[CONTRACT_NO],[START_DATE],[END_DATE],[RENT_AREA], " +
                        "[CORP_REP],[CONTACT],[TELEPHONE],[MOBILE],[CAPITAL],[PLACE],[TAX_ID], " +
                        "[IC_ID],[ORG_CODE],[CATEGORY],[MAIN_BUZZ],[TERMINATE] " +
                        "FROM [CONTRACT_INFO] WHERE [ID] = "+compid;
                    dt = db.ExecuteDataTable(queryStr);
                    if (dt.Rows.Count != 1)
                        return;
                    
                    DataRow dr = dt.Rows[0];
                    this.Text = dr[0].ToString()+" 记录修改";
                    button_confirm.Text = "确定修改";
                    if ((bool)dr[16] == true) { button_confirm.Enabled = false; button_confirm.Text = "该合同已终止"; }
                    textBox_compname.Text = dr[0].ToString();
                    textBox_contractno.Text = dr[1].ToString();
                    textBox_area.Text = dr[4].ToString();
                    textBox_corprep.Text = dr[5].ToString();
                    textBox_contact.Text = dr[6].ToString();
                    textBox_tele.Text = dr[7].ToString();
                    textBox_mobile.Text = dr[8].ToString();
                    textBox_capital.Text = dr[9].ToString();
                    textBox_place.Text = dr[10].ToString();
                    textBox_tax.Text = dr[11].ToString();
                    textBox_ic.Text = dr[12].ToString();
                    textBox_org.Text = dr[13].ToString();
                    textBox_mainbuzz.Text = dr[15].ToString();
                    DateTime start = DateTime.Now;
                    DateTime end = dateTimePicker_start.MaxDate;
                    if (dr[2].ToString() != "" && dr[3].ToString() != "")
                    {
                        DateTime.TryParse(dr[2].ToString(), out start);
                        DateTime.TryParse(dr[3].ToString(), out end);
                    }
                    dateTimePicker_start.Value = start;
                    dateTimePicker_end.Value = end;

                    comboBox_category.Text = dr[14].ToString();

                    //get room info
                    queryStr = "SELECT [ID],[ROOM_NO] FROM [ROOM_INFO] WHERE [COMP_ID]="+compid;
                    dt = db.ExecuteDataTable(queryStr);
                    foreach (DataRow _dr in dt.Rows)
                    {
                        listBox_room.Items.Add(new ComboItem(_dr[0].ToString(), _dr[1].ToString()));
                    }
                    //get parking info
                    queryStr = "SELECT A.[ID],A.[CAR_PLATE],A.[CAR_USER],B.[ROOM_NO] FROM [PARKING_INFO] A,[ROOM_INFO] B " +
                        "WHERE A.[ROOM_ID]=B.[ID] AND A.[TERMINATE]<>1 AND A.[COMP_ID]="+compid;
                    dt = db.ExecuteDataTable(queryStr);
                    foreach (DataRow _dr in dt.Rows)
                    {
                        listBox_parking.Items.Add(new ComboItem(_dr[0].ToString(), _dr[1].ToString() + " " + _dr[2].ToString() + " " + _dr[3].ToString()));
                    }
                    //get pred_charge
                    queryStr = "SELECT [CHARGE_TYPE],[SUM_MONTH],[INTERVAL] "+
                        "FROM [PRED_CHARGE] WHERE [COMP_ID]="+compid;
                    dt = db.ExecuteDataTable(queryStr);
                    foreach (DataRow _dr in dt.Rows)
                    {
                        switch (_dr[0].ToString())
                        {
                            case "房租":
                                textBox_rental.Text = _dr[1].ToString();
                                break;
                            case "物业费":
                                textBox_wuye.Text = _dr[1].ToString();
                                break;
                            case "服务费":
                                textBox_service.Text = _dr[1].ToString();
                                break;
                            case "网络费":
                                textBox_network.Text = _dr[1].ToString();
                                break;
                            default:
                                break;

                        }
                        textBox_interval.Text = _dr[2].ToString();
                    }
                    //get deposit info
                    queryStr = "SELECT [SUM],[RETURNED] FROM [DEPOSIT_INFO] WHERE [COMP_ID]="+compid;
                    dt = db.ExecuteDataTable(queryStr);
                    if (dt.Rows.Count == 1)
                    {
                        textBox_deposit.Text = dt.Rows[0][0].ToString();
                        if ((bool)dt.Rows[0][1] == true)
                        {
                            lblMsg.Text = "已归还";
                        }
                        else
                        {
                            lblMsg.Text = "尚未归还";
                        }
                    }
                }                
            }

        }

        private bool SaveChanges()
        {
            //get changed value
            string cmpname = textBox_compname.Text;
            string contractno = textBox_contractno.Text;
            string corprep = textBox_corprep.Text;
            string contact = textBox_contact.Text;
            string tele = textBox_tele.Text;
            string mobile = textBox_mobile.Text;
            string place = textBox_place.Text;
            string taxid = textBox_tax.Text;
            string icid = textBox_ic.Text;
            string orgcode = textBox_org.Text;
            string category = comboBox_category.Text;
            string mainbuzz = textBox_mainbuzz.Text;
            string modify = UserInfo.NickName+" "+(isNew?"created":"modify")+" this record";
            double capital=0.0;
            DateTime startDate = dateTimePicker_start.Value;
            DateTime endDate = dateTimePicker_end.Value;
            double rentarea = 0.0;
            double.TryParse(textBox_capital.Text, out capital);
            double.TryParse(textBox_area.Text, out rentarea);
            string sql = "";
            double monthrental = 0.0;
            double wuye = 0.0;
            double fuwu = 0.0;
            double wangluo = 0.0;
            int interval = 3;
            double.TryParse(textBox_rental.Text, out monthrental);
            double.TryParse(textBox_wuye.Text, out wuye);
            double.TryParse(textBox_service.Text, out fuwu);
            double.TryParse(textBox_network.Text, out wangluo);
            int.TryParse(textBox_interval.Text, out interval);
            double depositsum=0.0;
            double.TryParse(textBox_deposit.Text,out depositsum);
            
            if (isNew)
            {
                using (DataBase db = new DataBase())
                {
                    //insert contract data
                    sql = "INSERT INTO [CONTRACT_INFO] " +
                        "([COMP_NAME],[CONTRACT_NO],[START_DATE],[END_DATE],[RENT_AREA],[CORP_REP],[CONTACT],[TELEPHONE],[MOBILE] " +
                        ",[CAPITAL],[PLACE],[TAX_ID],[IC_ID],[ORG_CODE],[CATEGORY],[MAIN_BUZZ],[TERMINATE],[MODIFY_COMMENT]) " +
                        "VALUES " +
                        "(@COMP_NAME,@CONTRACT_NO,@START_DATE,@END_DATE,@RENT_AREA,@CORP_REP,@CONTACT,@TELEPHONE,@MOBILE " +
                        ",@CAPITAL,@PLACE,@TAX_ID,@IC_ID,@ORG_CODE,@CATEGORY,@MAIN_BUZZ,@TERMINATE,@MODIFY_COMMENT) "+
                        "SELECT IDENT_CURRENT('CONTRACT_INFO')";

                    db.AddParameter("COMP_NAME", cmpname);
                    db.AddParameter("CONTRACT_NO", contractno);
                    db.AddParameter("START_DATE", startDate);
                    db.AddParameter("END_DATE", endDate);
                    db.AddParameter("RENT_AREA", rentarea);
                    db.AddParameter("CORP_REP", corprep);
                    db.AddParameter("CONTACT", contact);
                    db.AddParameter("TELEPHONE", tele);
                    db.AddParameter("MOBILE", mobile);
                    db.AddParameter("CAPITAL", capital);
                    db.AddParameter("PLACE", place);
                    db.AddParameter("TAX_ID", taxid);
                    db.AddParameter("IC_ID", icid);
                    db.AddParameter("ORG_CODE", orgcode);
                    db.AddParameter("CATEGORY", category);
                    db.AddParameter("MAIN_BUZZ", mainbuzz);
                    db.AddParameter("TERMINATE", false);
                    db.AddParameter("MODIFY_COMMENT", modify);
                    DataTable dt=db.ExecuteDataTable(sql);
                    if (dt.Rows.Count != 1 || dt.Rows[0][0].ToString()=="")
                        return false;
                    compid = dt.Rows[0][0].ToString();
                    
                    //insert pred charge data
                    sql = "INSERT INTO [PRED_CHARGE] " +
                        "([COMP_ID],[CHARGE_TYPE],[SUM_MONTH],[INTERVAL]) " +
                        "VALUES(@COMP_ID,@CHARGE_TYPE,@SUM_MONTH,@INTERVAL)";
                    db.AddParameter("COMP_ID", compid);
                    db.AddParameter("CHARGE_TYPE", "房租");
                    db.AddParameter("SUM_MONTH", monthrental);
                    db.AddParameter("INTERVAL", interval);
                    db.ExecuteNonQuery(sql);
                    db.AddParameter("COMP_ID", compid);
                    db.AddParameter("CHARGE_TYPE", "物业费");
                    db.AddParameter("SUM_MONTH", wuye);
                    db.AddParameter("INTERVAL", interval);
                    db.ExecuteNonQuery(sql);
                    db.AddParameter("COMP_ID", compid);
                    db.AddParameter("CHARGE_TYPE", "服务费");
                    db.AddParameter("SUM_MONTH", fuwu);
                    db.AddParameter("INTERVAL", interval);
                    db.ExecuteNonQuery(sql);
                    db.AddParameter("COMP_ID", compid);
                    db.AddParameter("CHARGE_TYPE", "网络费");
                    db.AddParameter("SUM_MONTH", wangluo);
                    db.AddParameter("INTERVAL", interval);
                    db.ExecuteNonQuery(sql);
                    //insert depositdata
                    sql = "INSERT INTO [DEPOSIT_INFO] "+
                        "([COMP_ID],[SUM],[RETURNED]) "+
                        "VALUES (@COMP_ID,@SUM,@RETURNED)";
                    db.AddParameter("COMP_ID", compid);
                    db.AddParameter("SUM", depositsum);
                    db.AddParameter("RETURNED", false);
                    db.ExecuteNonQuery(sql);
                    //insert room info
                    sql = "UPDATE [ROOM_INFO] SET [COMP_ID]=@COMP_ID,[HASCOMP]=@HASCOMP WHERE [ID]=@ROOM_ID";
                    foreach (ComboItem room in listBox_room.Items)
                    {
                        db.AddParameter("COMP_ID", compid);
                        db.AddParameter("ROOM_ID", room.Key);
                        db.AddParameter("HASCOMP", true);
                        db.ExecuteNonQuery(sql);
                    }
                    //insert PARKING info
                    sql = "UPDATE [PARKING_INFO] SET [COMP_ID]=@COMP_ID WHERE [ID]=@PARKING_ID";
                    foreach (ComboItem lot in listBox_parking.Items)
                    {
                        db.AddParameter("COMP_ID", compid);
                        db.AddParameter("PARKING_ID", lot.Key);
                        db.ExecuteNonQuery(sql);
                    }
                }
            }
            else
            {
                using (DataBase db = new DataBase())
                {
                    //modify contract data
                    sql = "UPDATE [CONTRACT_INFO] "+
                        "SET [COMP_NAME]=@COMP_NAME,[CONTRACT_NO]=@CONTRACT_NO,[START_DATE]=@START_DATE,[END_DATE]=@END_DATE " +
                        ",[RENT_AREA]=@RENT_AREA,[CORP_REP]=@CORP_REP,[CONTACT]=@CONTACT,[TELEPHONE]=@TELEPHONE "+
                        ",[MOBILE]=@MOBILE,[CAPITAL]=@CAPITAL,[PLACE]=@PLACE,[TAX_ID]=@TAX_ID "+
                        ",[IC_ID]=@IC_ID,[ORG_CODE]=@ORG_CODE,[CATEGORY]=@CATEGORY,[MAIN_BUZZ]=@MAIN_BUZZ "+
                        ",[TERMINATE]=@TERMINATE,[MODIFY_COMMENT]=@MODIFY_COMMENT WHERE ID=@COMP_ID";
                    db.AddParameter("COMP_NAME", cmpname);
                    db.AddParameter("CONTRACT_NO", contractno);
                    db.AddParameter("START_DATE", startDate);
                    db.AddParameter("END_DATE", endDate);
                    db.AddParameter("RENT_AREA", rentarea);
                    db.AddParameter("CORP_REP", corprep);
                    db.AddParameter("CONTACT", contact);
                    db.AddParameter("TELEPHONE", tele);
                    db.AddParameter("MOBILE", mobile);
                    db.AddParameter("CAPITAL", capital);
                    db.AddParameter("PLACE", place);
                    db.AddParameter("TAX_ID", taxid);
                    db.AddParameter("IC_ID", icid);
                    db.AddParameter("ORG_CODE", orgcode);
                    db.AddParameter("CATEGORY", category);
                    db.AddParameter("MAIN_BUZZ", mainbuzz);
                    db.AddParameter("TERMINATE", false);
                    db.AddParameter("MODIFY_COMMENT", modify);
                    db.AddParameter("COMP_ID", compid);
                    db.ExecuteNonQuery(sql);
                    //modify pred charge data
                    sql = "UPDATE [PRED_CHARGE] "+
                       "SET [SUM_MONTH] = @SUM_MONTH,[INTERVAL] = @INTERVAL "+
                       "WHERE [COMP_ID]=@COMP_ID AND [CHARGE_TYPE] = @CHARGE_TYPE";
                    db.AddParameter("COMP_ID", compid);
                    db.AddParameter("CHARGE_TYPE", "房租");
                    db.AddParameter("SUM_MONTH", monthrental);
                    db.AddParameter("INTERVAL", interval);
                    db.ExecuteNonQuery(sql);
                    db.AddParameter("COMP_ID", compid);
                    db.AddParameter("CHARGE_TYPE", "物业费");
                    db.AddParameter("SUM_MONTH", wuye);
                    db.AddParameter("INTERVAL", interval);
                    db.ExecuteNonQuery(sql);
                    db.AddParameter("COMP_ID", compid);
                    db.AddParameter("CHARGE_TYPE", "服务费");
                    db.AddParameter("SUM_MONTH", fuwu);
                    db.AddParameter("INTERVAL", interval);
                    db.ExecuteNonQuery(sql);
                    db.AddParameter("COMP_ID", compid);
                    db.AddParameter("CHARGE_TYPE", "网络费");
                    db.AddParameter("SUM_MONTH", wangluo);
                    db.AddParameter("INTERVAL", interval);
                    db.ExecuteNonQuery(sql);
                    //modify depositdata
                    sql = "UPDATE [DEPOSIT_INFO] SET [SUM] = @SUM,[RETURNED] = @RETURNED WHERE [COMP_ID] = @COMP_ID";
                    db.AddParameter("COMP_ID", compid);
                    db.AddParameter("SUM", depositsum);
                    db.AddParameter("RETURNED", false);
                    db.ExecuteNonQuery(sql);
                }
            }
            return true;
        }

        private void CleanControls()
        {
            textBox_compname.Text = "";
            textBox_contractno.Text = "";
            textBox_area.Text = "";
            textBox_corprep.Text = "";
            textBox_contact.Text = "";
            textBox_tele.Text = "";
            textBox_mobile.Text = "";
            textBox_capital.Text = "";
            textBox_place.Text = "";
            textBox_tax.Text = "";
            textBox_ic.Text = "";
            textBox_org.Text = "";
            textBox_mainbuzz.Text = "";
            listBox_parking.Items.Clear();
            listBox_room.Items.Clear();
            textBox_rental.Text = "";
            textBox_wuye.Text = "";
            textBox_service.Text = "";
            textBox_network.Text = "";
            textBox_interval.Text = "3";
            textBox_deposit.Text = "";
            comboBox_category.Text = "";
            using (DataBase db = new DataBase())
            {
                //load room info into comboboxroomlist
                string queryStr = "SELECT [ID],[ROOM_NO] FROM [ROOM_INFO] WHERE [HASCOMP] <> 1";
                DataTable dt = db.ExecuteDataTable(queryStr);
                foreach (DataRow _dr in dt.Rows)
                {
                    comboBoxRoomList.Items.Add(new ComboItem(_dr[0].ToString(), _dr[1].ToString()));
                }
            }
            dateTimePicker_start.Value = DateTime.Now;
            dateTimePicker_end.Value = DateTime.Now.AddYears(3);


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

        private void button_delcar_Click(object sender, EventArgs e)
        {
            ComboItem item = (ComboItem)listBox_parking.SelectedItems[0];
            using (DataBase db = new DataBase())
            {
                string sql = "UPDATE PARKING_INFO SET TERMINATE=1 WHERE ID=" + item.Key;
                db.ExecuteNonQuery(sql);
                listBox_parking.Items.Remove(item);
            }
            
        }

        private void button_addroom_Click(object sender, EventArgs e)
        {
            FormAddRoom frmAddRoom = new FormAddRoom();
            frmAddRoom.ShowDialog();
            RefreshRoomList();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            RefreshRoomList();
        }

        private void button_selroom_Click(object sender, EventArgs e)
        {
            ComboItem room = (ComboItem)comboBoxRoomList.SelectedItem;
            if (room == null) return;
            if (listBox_room.Items.IndexOf(room) < 0)
            {
                listBox_room.Items.Add(room);
                if (!isNew)
                {
                    using (DataBase db = new DataBase())
                    {
                        string sql = "UPDATE [ROOM_INFO] SET [COMP_ID]=@COMP_ID,[HASCOMP]=@HASCOMP WHERE [ID]=@ROOM_ID";
                        db.AddParameter("COMP_ID", compid);
                        db.AddParameter("ROOM_ID", room.Key);
                        db.AddParameter("HASCOMP", true);
                        db.ExecuteNonQuery(sql);
                    }
                }
            }
            
        }

        private void button_cancelroom_Click(object sender, EventArgs e)
        {
            ComboItem room = (ComboItem)listBox_room.SelectedItem;
            if (room == null) return;
            listBox_room.Items.Remove(room);
            using (DataBase db = new DataBase())
            {
                string sql = "UPDATE [ROOM_INFO] SET [COMP_ID]=@COMP_ID,[HASCOMP]=@HASCOMP WHERE [ID]=@ROOM_ID";
                db.AddParameter("COMP_ID", DBNull.Value);
                db.AddParameter("ROOM_ID", room.Key);
                db.AddParameter("HASCOMP", false);
                db.ExecuteNonQuery(sql);
            }
            RefreshRoomList();
        }

        private void button_addcar_Click(object sender, EventArgs e)
        {
            if (isNew)
            {
                FormAddCar frmAddCar = new FormAddCar(true, "-1");
                frmAddCar.ShowDialog();
                foreach (ComboItem item in frmAddCar.newParkListItems)
                {
                    listBox_parking.Items.Add(item);
                }
            }
            else
            {
                FormAddCar frmAddCar = new FormAddCar(true, "-1",compid);
                frmAddCar.ShowDialog();
                foreach (ComboItem item in frmAddCar.newParkListItems)
                {
                    listBox_parking.Items.Add(item);
                }
            }

        }
    }
}
