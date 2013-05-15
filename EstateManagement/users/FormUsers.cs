using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstateManagement.pub;

namespace EstateManagement.users
{
    public partial class FormUsers : Form
    {
        public string queryStr = "SELECT A.ID,USERNAME,NICKNAME,ROLE_NAME FROM [CJ_ADMIN] A,[CJ_ROLE] B WHERE A.ROLE_ID=B.ID";
        public FormUsers()
        {
            InitializeComponent();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            using (DataBase db = new DataBase())
            {
                dgvUsers.DataSource = db.ExecuteDataTable(queryStr);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            FormAddUser frmAddUser = new FormAddUser();
            frmAddUser.ShowDialog();
            LoadData();
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count != 1) return;
            DataGridViewRow dgvr = dgvUsers.SelectedRows[0];
            FormAddUser frmAddUser = new FormAddUser(false,dgvr.Cells["ID"].Value.ToString());
            frmAddUser.ShowDialog();
            LoadData();
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count != 1) return;
            string userid = dgvUsers.SelectedRows[0].Cells["ID"].Value.ToString();
            using (DataBase db = new DataBase())
            {
                db.ExecuteNonQuery("DELETE FROM CJ_ADMIN WHERE ID="+userid);
                MessageBox.Show("删除成功");
                LoadData();
            }

        }
    }
}
