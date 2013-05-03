using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EstateManagement.pub;
using System.Data.SqlClient;

namespace EstateManagement.customers
{
    public partial class ContractList : Form
    {
        private DataSet ds;
        private SqlDataAdapter adapter;
        private string tbname = "CONTRACT_INFO";
        
        private string queryStr = "SELECT[ID],[COMP_NAME],[CONTRACT_NO],[START_DATE],[END_DATE],[RENT_AREA],[CORP_REP] " +
                ",[CONTACT],[TELEPHONE],[MOBILE],[CAPITAL],[PLACE],[TAX_ID],[IC_ID],[ORG_CODE],[CATEGORY] " +
                ",[MAIN_BUZZ] FROM [CONTRACT_INFO] WHERE [TERMINATE]<>1 ";
        private void InitAdapter(string sql)
        {
            SqlConnection conn = new SqlConnection(DataBase.connStr);
            SqlCommand selComm = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter(selComm);
            ds = new DataSet();
        }
        public ContractList()
        {
            InitializeComponent();
            dgvContract.AutoGenerateColumns = false;
            InitAdapter(queryStr);
        }

        private void ContractList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            LoadData(queryStr);
        }
        private void LoadData(string sql)
        {
            ds.Clear();
            InitAdapter(sql);
            adapter.Fill(ds, tbname);
            
            this.dgvContract.DataSource = ds.Tables[tbname];
        }
        private void SaveChanges()
        {
            if (ds.GetChanges() != null)
            {

                SqlCommandBuilder commBuilder = new SqlCommandBuilder(adapter);
                try
                {
                    adapter.Update(ds, tbname);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.dgvContract.Update();
            }
        }

        private void dgvContract_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SaveChanges();
            
        }

        private void ContractList_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveChanges();
        }

        private void button_showterminate_Click(object sender, EventArgs e)
        {
            if (button_showterminate.Text == "显示未终止的合同")
            {
                button_showterminate.Text = "显示已终止的合同";
                queryStr = "SELECT[ID],[COMP_NAME],[CONTRACT_NO],[START_DATE],[END_DATE],[RENT_AREA],[CORP_REP] " +
                    ",[CONTACT],[TELEPHONE],[MOBILE],[CAPITAL],[PLACE],[TAX_ID],[IC_ID],[ORG_CODE],[CATEGORY] " +
                    ",[MAIN_BUZZ] FROM [CONTRACT_INFO] WHERE [TERMINATE]<>1 ";
                LoadData();
            }
            else
            {
                button_showterminate.Text = "显示未终止的合同";
                queryStr = "SELECT[ID],[COMP_NAME],[CONTRACT_NO],[START_DATE],[END_DATE],[RENT_AREA],[CORP_REP] " +
                    ",[CONTACT],[TELEPHONE],[MOBILE],[CAPITAL],[PLACE],[TAX_ID],[IC_ID],[ORG_CODE],[CATEGORY] " +
                    ",[MAIN_BUZZ] FROM [CONTRACT_INFO] WHERE [TERMINATE]=1 ";
                LoadData();
            }

        }

        private void button_terminate_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection dgvselrows = dgvContract.SelectedRows;
            string msg = "";
            if (dgvselrows.Count == 1)
            {
                msg = "确定要将合同:" + dgvselrows[0].Cells["CONTRACT_NO"].Value.ToString() + "终止吗?";
                DialogResult dr=MessageBox.Show(msg, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string sql = "UPDATE "+tbname+" SET TERMINATE=@TERMINATE WHERE ID=@ID";
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
                //msg = "确定要将所选的" + dgvselrows.Count + "条合同终止吗?";
                //DialogResult dr = MessageBox.Show(msg, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (dr == DialogResult.Yes)
                //{
                //    foreach (DataGridViewRow dgvr in dgvselrows)
                //    {
                //        string sql = "UPDATE " + tbname + " SET TERMINATE=@TERMINATE WHERE ID=@ID";
                //        using (DataBase db = new DataBase())
                //        {
                //            db.AddParameter("TERMINATE", true);
                //            db.AddParameter("ID", dgvr.Cells["ID"].Value);
                //            db.ExecuteNonQuery(sql);
                //        }
                //    }
                //    LoadData();
                //}
                msg = "您选择了" + dgvselrows.Count+"条记录,不建议您这样操作!";
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            SearchAction();
        }

        private void textBox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchAction();
            }
        }

        private void SearchAction()
        {
            string key = textBox_search.Text.Trim();
            if (key == "") { LoadData(queryStr); return; }
            string[] searchItems = { "COMP_NAME", "CONTRACT_NO", "CORP_REP", "CONTACT", "TELEPHONE", "MOBILE", "PLACE", "TAX_ID", "IC_ID", "ORG_CODE", "CATEGORY", "MAIN_BUZZ" };
            StringBuilder sb = new StringBuilder(queryStr + " AND ( 1=2 ");
            foreach (string item in searchItems)
            {
                sb.Append("OR " + item + " LIKE '%" + key + "%' ");
            }
            sb.Append(" )");
            LoadData(sb.ToString());
        }
        

    }
}
