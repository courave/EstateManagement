using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstateManagement.pub;
using System.Data.SqlClient;


namespace EstateManagement.customers
{
    public partial class FormRooms : Form
    {
        private DataSet ds;
        private SqlDataAdapter adapter;
        private string tbname = "ROOM_INFO";
        private string queryStr = "SELECT A.ID,A.ROOM_NO,A.LOCATION,B.COMP_NAME,A.REMARK FROM ROOM_INFO A LEFT JOIN CONTRACT_INFO B ON A.COMP_ID=B.ID WHERE 1=1 ";
        private void InitAdapter(string sql)
        {
            SqlConnection conn = new SqlConnection(DataBase.connStr);
            SqlCommand selComm = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter(selComm);
            ds = new DataSet();
        }


        public FormRooms()
        {
            InitializeComponent();
            dgvRooms.AutoGenerateColumns = false;
            InitAdapter(queryStr);
        }
        private void LoadData(string sql)
        {
            ds.Clear();
            InitAdapter(sql);
            adapter.Fill(ds, tbname);
            this.dgvRooms.DataSource = ds.Tables[tbname];
        }
        private void LoadData()
        {
            LoadData(queryStr);
        }

        private void FormRooms_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            FormAddRoom frmAddRoom = new FormAddRoom();
            frmAddRoom.ShowDialog();
            LoadData();
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection dgvselrows = dgvRooms.SelectedRows;
            if (dgvselrows.Count == 1)
            {
                string roomid = dgvselrows[0].Cells["ID"].Value.ToString();
                FormAddRoom frmAddRoom = new FormAddRoom(false,roomid);
                frmAddRoom.ShowDialog();
                LoadData();

            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection dgvselrows = dgvRooms.SelectedRows;
            if (dgvselrows.Count == 1)
            {
                string roomid = dgvselrows[0].Cells["ID"].Value.ToString();
                string roomno = dgvselrows[0].Cells["ROOM_NO"].Value.ToString();
                DialogResult dr = MessageBox.Show("确定要将房间" + roomno + "删除吗?\n删除了就不能恢复了.", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    //
                    using (DataBase db = new DataBase())
                    {
                        db.ExecuteNonQuery("DELETE FROM ROOM_INFO WHERE ID="+roomid);
                    }
                    LoadData();
                }
                

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
            string[] searchItems = { "A.ROOM_NO", "A.LOCATION", "A.REMARK", "B.COMP_NAME"};
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

        private void button_showspecify_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(queryStr);
            if (button_showspecify.Text == "显示未分配房间")
            {
                button_showspecify.Text = "显示已分配房间";
                sb.Append(" AND HASCOMP<>1 ");
            }
            else
            {
                button_showspecify.Text = "显示未分配房间";
                sb.Append(" AND HASCOMP=1 ");
            }
            LoadData(sb.ToString());
        }

    }
}
