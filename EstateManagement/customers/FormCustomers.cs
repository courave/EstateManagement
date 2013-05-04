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
    public partial class FormCustomers : Form
    {
        private string queryStr = "SELECT [ID],[COMP_NAME],[CONTRACT_NO],[START_DATE],[END_DATE],[RENT_AREA] " +
            ",[CORP_REP],[CONTACT],[TELEPHONE],[MOBILE],[FANGZU],[WUYE],[FUWU],[WANGLUO] " +
            ",[INTERVAL],[ROOMCOUNT],[PARKINGCOUNT],[YAJIN] " +
            "FROM [View_CUSTOMERS] WHERE [TERMINATE]<>1 ";
        public FormCustomers()
        {
            InitializeComponent();
            dgvCustomers.AutoGenerateColumns = false;
        }
        private void LoadData(string sql)
        {
            using(DataBase db=new DataBase())
            {
                dgvCustomers.DataSource = db.ExecuteDataTable(sql);
            }
        }
        private void LoadData()
        {
            LoadData(queryStr);
        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ToolStripMenuItem_newcustomer_Click(object sender, EventArgs e)
        {
            FormAddCustomer frmAddCustomer = new FormAddCustomer();
            frmAddCustomer.ShowDialog();
            LoadData();
        }

        private void ToolStripMenuItem_modify_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection dgvselrows = dgvCustomers.SelectedRows;
            
            if (dgvselrows.Count == 1)
            {
                string compid = dgvselrows[0].Cells["ID"].Value.ToString();
                FormAddCustomer frmAddCustomer = new FormAddCustomer(false, compid);
                frmAddCustomer.ShowDialog();
                LoadData();
            }
        }

        private void ToolStripMenuItem_terminate_Click(object sender, EventArgs e)
        {
            //terminate contract,release room,terminate parking,ask deposit
            DataGridViewSelectedRowCollection dgvselrows = dgvCustomers.SelectedRows;

            if (dgvselrows.Count == 1)
            {
                string compid = dgvselrows[0].Cells["ID"].Value.ToString();
                string compname=dgvselrows[0].Cells["COMP_NAME"].Value.ToString();
                string roomcount=dgvselrows[0].Cells["ROOMCOUNT"].Value.ToString();
                string parkingcount = dgvselrows[0].Cells["PARKINGCOUNT"].Value.ToString();
                bool fcontract = false, froom = false, fparking = false, fdeposit = false;
                string msg="确定要终止 " + compname + " 的合同吗?";
                DialogResult dr = showMsg(msg);
                if (dr == DialogResult.Yes)
                {
                    fcontract = true;
                }
                if (fcontract)
                {


                    msg = compname + " 共租有" + roomcount + "间房:\n";
                    using (DataBase db = new DataBase())
                    {
                        DataTable dt = db.ExecuteDataTable("SELECT ROOM_NO FROM ROOM_INFO WHERE COMP_ID=" + compid);
                        foreach (DataRow dataRow in dt.Rows)
                        {
                            msg += dataRow[0].ToString() + "\n";
                        }
                    }
                    msg += "确定要清空这些房间吗?";
                    dr = showMsg(msg);
                    if (dr == DialogResult.Yes)
                        froom = true;
                    msg = compname + " 共租有" + parkingcount + "个车位:\n";
                    using (DataBase db = new DataBase())
                    {
                        DataTable dt = db.ExecuteDataTable("SELECT CAR_USER,LOCATION,TELE FROM PARKING_INFO WHERE COMP_ID=" + compid);
                        foreach (DataRow dataRow in dt.Rows)
                        {
                            msg += dataRow[0].ToString() + " " + dataRow[1].ToString() + " " +
                                dataRow[2].ToString() + " " + "\n";
                        }
                    }
                    msg += "确定要清空这些车位吗?";
                    dr = showMsg(msg);
                    if (dr == DialogResult.Yes)
                        fparking = true;
                    using (DataBase db = new DataBase())
                    {
                        DataTable dt = db.ExecuteDataTable("SELECT ID FROM DEPOSIT_INFO WHERE COMP_ID=" + compid + " AND RETURNED<>1");
                        if (dt.Rows.Count > 0)
                        {
                            msg = compname + " 的押金是否已经归还?";
                            dr = showMsg(msg);
                            if (dr == DialogResult.Yes)
                                fdeposit = true;
                        }
                        else
                        {
                            fdeposit = false;
                        }
                    }
                    msg = "再次确认操作:\n终止合同:" + (fcontract ? "是" : "否") + "\n清空房间:" +
                        (froom ? "是" : "否") + "\n清空车位:" + (fparking ? "是" : "否") + "\n归还押金:" +
                        (fdeposit ? "是" : "否") + "\n\n确定要继续吗?";
                    dr = showMsg(msg);
                    if (dr == DialogResult.Yes)
                    {
                        terminateCustomer(compid,fcontract, froom, fparking, fdeposit);
                    }

                }

            }
        }
        private DialogResult showMsg(string msg)
        {
            return  MessageBox.Show(msg, "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }
        private void terminateCustomer(string compid,bool fcontract, bool froom, bool fparking, bool fdeposit)
        {
            if (!fcontract)
                return;
            string sql = "UPDATE [CONTRACT_INFO] SET [TERMINATE]=@TERMINATE,[MODIFY_COMMENT]=@MODIFY_COMMENT+ISNULL([MODIFY_COMMENT],'') WHERE [ID]=@COMP_ID";
            using (DataBase db = new DataBase())
            {
                db.AddParameter("TERMINATE", true);
                db.AddParameter("COMP_ID", compid);
                db.AddParameter("MODIFY_COMMENT",DateTime.Now.ToString()+" "+UserInfo.NickName+" "+"终止了合同;");
                db.ExecuteNonQuery(sql);
                //room
                if (froom)
                {
                    sql = "UPDATE [ROOM_INFO] SET [COMP_ID]=@COMP_ID_NULL,[HASCOMP]=@HASCOMP WHERE [COMP_ID]=@COMP_ID";
                    db.AddParameter("COMP_ID_NULL", DBNull.Value);
                    db.AddParameter("HASCOMP", false);
                    db.AddParameter("COMP_ID", compid);
                    db.ExecuteNonQuery(sql);
                }

                //parking
                if (fparking)
                {
                    sql = "UPDATE [PARKING_INFO] SET [TERMINATE]=@TERMINATE WHERE [COMP_ID]=@COMP_ID";
                    db.AddParameter("TERMINATE", true);
                    db.AddParameter("COMP_ID", compid);
                    db.ExecuteNonQuery(sql);
                }
                //deposit
                if (fdeposit)
                {
                    sql = "UPDATE [DEPOSIT_INFO] SET [RETURNED]=@RETURNED WHERE [COMP_ID]=@COMP_ID";
                    db.AddParameter("RETURNED", true);
                    db.AddParameter("COMP_ID", compid);
                    db.ExecuteNonQuery(sql);
                }
            }
            LoadData();

        }

    }
}
