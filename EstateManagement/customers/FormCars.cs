using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using EstateManagement.pub;
using System.Data.SqlClient;

namespace EstateManagement.customers
{
    public partial class FormCars : Form
    {
        private DataSet ds;
        private SqlDataAdapter adapter;
        private string tbname = "PARKING_INFO";
        private string queryStr = "SELECT A.[ID],A.[CAR_USER],A.[CAR_PLATE],A.[ID_CODE],C.[COMP_NAME], "+
            "B.[ROOM_NO],A.[TELE],A.[START_DATE],A.[END_DATE],A.[PRICE_MONTH], " +
            "A.[LOCATION],A.[REMARK]  "+
            "FROM [PARKING_INFO] A,[ROOM_INFO] B,[CONTRACT_INFO] C "+
            "WHERE A.[COMP_ID]=C.[ID] AND A.[ROOM_ID]=B.ID AND A.[TERMINATE]<>1";
        private void InitAdapter(string sql)
        {
            SqlConnection conn = new SqlConnection(DataBase.connStr);
            SqlCommand selComm = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter(selComm);
            ds = new DataSet();
        }
        public FormCars()
        {
            InitializeComponent();
            dgvCars.AutoGenerateColumns = false;
            InitAdapter(queryStr);
        }

        private void FormCars_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData(string sql)
        {
            ds.Clear();
            InitAdapter(sql);
            adapter.Fill(ds, tbname);
            this.dgvCars.DataSource = ds.Tables[tbname];
        }
        private void LoadData()
        {
            LoadData(queryStr);
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
        private DateTime? getLastLastEndTime(string company_id)
        {
            using (DataBase db = new DataBase())
            {
                db.AddParameter("COMP_ID", company_id);
                // 得到最大的lastend。  
                // 
                DataTable dt = db.ExecuteDataTable("SELECT MAX([LAST_END]) FROM [FEE_INFO] WHERE [COMP_ID]=@COMP_ID AND [FEE_TYPE]='房租'");
                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[0][0].ToString() == "")
                        return null;
                    return (DateTime?)dt.Rows[0][0];
                }
            }
            return null;

        }
        private int addMainFee(String FEE_TYPE, double FEE, DateTime LAST_END, DateTime? NEXT_START, String COMMENT, int COMPANY_ID,string genmonth)
        {
            String sql = "INSERT INTO [FEE_INFO]([FEE_TYPE],[FEE_CHARGE],[LAST_END],[NEXT_START] "+
                ",[COMP_ID],[COMMENT],[GEN_MONTH],[ISPAID]) VALUES (@FEE_TYPE,@FEE_CHARGE " +
                ",@LAST_END,@NEXT_START,@COMP_ID,@COMMENT,@GEN_MONTH,@ISPAID)";

            using (DataBase db = new DataBase())
            {
                db.AddParameter("FEE_TYPE", FEE_TYPE);
                db.AddParameter("FEE_CHARGE", FEE);
                db.AddParameter("LAST_END", LAST_END);
                if (NEXT_START == null)
                    db.AddParameter("NEXT_START", DBNull.Value);
                else
                    db.AddParameter("NEXT_START", NEXT_START);
                db.AddParameter("COMMENT", COMMENT);
                db.AddParameter("COMP_ID", COMPANY_ID);
                db.AddParameter("GEN_MONTH", genmonth);
                db.AddParameter("ISPAID", false);

                return db.ExecuteNonQuery(sql);
            }


        }
        private void button_terminate_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection dgvselrows = dgvCars.SelectedRows;
            string msg = "";
            if (dgvselrows.Count == 1)
            {
                msg = "确定要将车牌号为:"+dgvselrows[0].Cells["CAR_PLATE"].Value.ToString()+"的车位删除吗?";
                DialogResult dr = MessageBox.Show(msg, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string sql = "UPDATE "+tbname+" SET [TERMINATE] = @TERMINATE WHERE [ID]=@ID";
                    using (DataBase db = new DataBase())
                    {
                        db.AddParameter("TERMINATE", true);
                        db.AddParameter("ID", dgvselrows[0].Cells["ID"].Value);
                        db.ExecuteNonQuery(sql);

                        DataTable dt = db.ExecuteDataTable("SELECT PRICE_MONTH,COMP_ID,START_DATE FROM PARKING_INFO WHERE ID=" + dgvselrows[0].Cells["ID"].Value.ToString());
                        if (dt.Rows.Count == 1)
                        {
                            //get nextstart date,(nextstart+interval-curdate)/30*pricepermonth
                            string compid = dt.Rows[0][1].ToString();
                            double pricemonth = 0;
                            double.TryParse(dt.Rows[0][0].ToString(), out pricemonth);
                            DateTime startdate = (DateTime)dt.Rows[0][2];
                            DateTime curdate = DateTime.Now;
                            DateTime? lastend = getLastLastEndTime(compid);
                            DateTime? nextstart = getLastNextStartTime(compid);
                            string genmonth = nextstart.Value.Year + "" + (nextstart.Value.Month < 10 ? "0" + nextstart.Value.Month : nextstart.Value.Month.ToString());
                            if (lastend == null || nextstart == null) { MessageBox.Show("系统错误,请手动录入该'车位费补'"); }
                            if (curdate < nextstart.Value)
                            {
                                if (startdate > lastend.Value)//补收
                                {
                                    //(curdate-startdate)/30*pricemonth
                                    pricemonth = ((double)(curdate - startdate).Days) / 30 * pricemonth;
                                }
                                else//退
                                {
                                    //(nextstart-curdate)/30*pricemonth
                                    pricemonth = 0 - ((double)(nextstart.Value - curdate).Days) / 30 * pricemonth;
                                }
                            }
                            if (pricemonth != 0)
                            {
                                //add to fee_info as 车位费补
                                int icompid = 0;
                                if (int.TryParse(compid, out icompid))
                                    addMainFee("车位费补", pricemonth, lastend.Value, nextstart, curdate.ToShortDateString(), icompid, genmonth);
                            }
                        }
                        LoadData();
                    }

                }
            }
            else
            {
                msg = "您选择了" + dgvselrows.Count + "条记录,不建议您这样操作!";
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            SearchAction();
        }

        private void SearchAction()
        {
            string key = textBox_search.Text.Trim();
            if (key == "") { LoadData(queryStr); return; }
            string[] searchItems = {"A.CAR_USER","A.CAR_PLATE","A.ID_CODE","C.COMP_NAME","B.ROOM_NO","A.TELE","A.LOCATION","A.REMARK" };
            StringBuilder sb = new StringBuilder(queryStr + " AND (1=2 ");
            foreach (string item in searchItems)
            {
                sb.Append("OR " + item + " LIKE '%" + key + "%' ");
            }
            sb.Append(" )");
            LoadData(sb.ToString());
        }

        private void textBox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchAction();
            }
        }

        private void button_showterminate_Click(object sender, EventArgs e)
        {
            if (button_showterminate.Text == "显示现有车位")
            {
                button_showterminate.Text = "显示已删除的车位";
                queryStr = "SELECT A.[ID],A.[CAR_USER],A.[CAR_PLATE],A.[ID_CODE],C.[COMP_NAME], "+
                    "B.[ROOM_NO],A.[TELE],A.[START_DATE],A.[END_DATE],A.[PRICE_MONTH], " +
                    "A.[LOCATION],A.[REMARK]  "+
                    "FROM [PARKING_INFO] A,[ROOM_INFO] B,[CONTRACT_INFO] C "+
                    "WHERE A.[COMP_ID]=C.[ID] AND A.[ROOM_ID]=B.ID AND A.[TERMINATE]<>1";
                LoadData();

            }
            else
            {
                button_showterminate.Text = "显示现有车位";
                queryStr = "SELECT A.[ID],A.[CAR_USER],A.[CAR_PLATE],A.[ID_CODE],C.[COMP_NAME], " +
                    "B.[ROOM_NO],A.[TELE],A.[START_DATE],A.[END_DATE],A.[PRICE_MONTH], " +
                    "A.[LOCATION],A.[REMARK]  " +
                    "FROM [PARKING_INFO] A,[ROOM_INFO] B,[CONTRACT_INFO] C " +
                    "WHERE A.[COMP_ID]=C.[ID] AND A.[ROOM_ID]=B.ID AND A.[TERMINATE]=1";
                LoadData();

            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            FormAddCar frmAddCar = new FormAddCar();
            frmAddCar.ShowDialog();
            LoadData();
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection dgvselrows = dgvCars.SelectedRows;
            
            if (dgvselrows.Count == 1)
            {
                FormAddCar frmAddCar = new FormAddCar(false, dgvselrows[0].Cells["ID"].Value.ToString());
                frmAddCar.ShowDialog();
                LoadData();
            }
        }
    }
}
