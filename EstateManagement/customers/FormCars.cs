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
