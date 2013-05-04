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
    public partial class DepositInfo : Form
    {
        private string queryStr = "SELECT A.[ID],B.[COMP_NAME],A.[SUM],A.[RETURNED],A.[MODIFY_COMMENT] FROM [DEPOSIT_INFO] A,[CONTRACT_INFO] B WHERE A.[COMP_ID]=B.[ID] ";

        public DepositInfo()
        {
            InitializeComponent();
            dgvDeposit.AutoGenerateColumns = false;

        }
        private void LoadData(string sql)
        {
            using (DataBase db = new DataBase())
            {
                dgvDeposit.DataSource = db.ExecuteDataTable(sql);
            }
        }
        private void LoadData()
        {
            LoadData(queryStr);
        }

        private void checkBox_daoqi_CheckedChanged(object sender, EventArgs e)
        {
            string tmp=" AND B.[END_DATE]<='"+DateTime.Now.ToShortDateString()+"' ";
            if (checkBox_daoqi.Checked)
            {
                queryStr += tmp;
            }
            else
            {
                int t = queryStr.IndexOf(tmp);
                if(t>=0)
                    queryStr=queryStr.Remove(t, tmp.Length);
            }
            LoadData();
        }

        private void checkBox_terminate_CheckedChanged(object sender, EventArgs e)
        {
            string tmp = " AND B.[TERMINATE]=1 ";
            if (checkBox_terminate.Checked)
            {
                queryStr += tmp;
            }
            else
            {
                int t = queryStr.IndexOf(tmp);
                if (t >= 0)
                    queryStr = queryStr.Remove(t, tmp.Length);
            }
            LoadData();
        }

        private void checkBox_returned_CheckedChanged(object sender, EventArgs e)
        {
            string tmp = " AND A.[RETURNED]<>1 ";
            if (checkBox_returned.Checked)
            {
                queryStr += tmp;
            }
            else
            {
                int t = queryStr.IndexOf(tmp);
                if (t >= 0)
                    queryStr = queryStr.Remove(t, tmp.Length);
            }
            LoadData();
        }

        private void DepositInfo_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            SearchAction();
        }
        private void SearchAction()
        {
            string key = textBox_search.Text.Trim();
            if (key == "") { LoadData(queryStr); return; }
            string[] searchItems = { "B.COMP_NAME"};
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

        private void button_return_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection dgvselrows = dgvDeposit.SelectedRows;
            string msg = "";
            if (dgvselrows.Count == 1)
            {
                if ((bool)dgvselrows[0].Cells["RETURNED"].Value == true)
                    return;
                msg = "确定要将 " + dgvselrows[0].Cells["COMP_NAME"].Value.ToString() + " 的押金归还吗?";
                DialogResult dr = MessageBox.Show(msg, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string sql = "UPDATE [DEPOSIT_INFO] SET [RETURNED] = @RETURNED,[MODIFY_COMMENT]=@MODIFY_COMMENT+ISNULL([MODIFY_COMMENT],'') WHERE [ID]=@ID";
                    using (DataBase db = new DataBase())
                    {
                        db.AddParameter("RETURNED", true);
                        db.AddParameter("ID", dgvselrows[0].Cells["ID"].Value);
                        db.AddParameter("MODIFY_COMMENT", DateTime.Now.ToString() + " " + pub.UserInfo.NickName + " 确认归还押金;");
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


    }
}
