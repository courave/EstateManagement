using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using EstateManagement.pub;
using System.Text;
using System.Windows.Forms;

namespace EstateManagement.users
{
    public partial class FormRoles : Form
    {
        public String queryStr="SELECT ID,ROLE_NAME,PERMISSIONS FROM CJ_ROLE";
        public FormRoles()
        {
            InitializeComponent();
        }

        private void FormRoles_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            using (DataBase db = new DataBase())
            {
                dgvRole.DataSource = db.ExecuteDataTable(queryStr);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            FormAddRole frmAddRole = new FormAddRole();
            frmAddRole.ShowDialog();
            LoadData();
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            if (dgvRole.SelectedRows.Count != 1) return;
            DataGridViewRow dgvr = dgvRole.SelectedRows[0];
            FormAddRole frmAddRole = new FormAddRole(false,dgvr.Cells["ID"].Value.ToString());
            frmAddRole.ShowDialog();
            LoadData();
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            if (dgvRole.SelectedRows.Count != 1) return;
            DataGridViewRow dgvr = dgvRole.SelectedRows[0];
            string roleid = dgvr.Cells["ID"].Value.ToString();
            using (DataBase db = new DataBase())
            {
                db.ExecuteNonQuery("DELETE FROM CJ_ROLE WHERE ID="+roleid);
                MessageBox.Show("删除成功!");
            }
            LoadData();
        }
    }
}
