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
                ",[MAIN_BUZZ],[COMMENT] FROM [CONTRACT_INFO] WHERE [TERMINATE]<>1 ";
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
            InitAdapter(queryStr);
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
                    ",[MAIN_BUZZ],[COMMENT] FROM [CONTRACT_INFO] WHERE [TERMINATE]<>1 ";
                LoadData();
            }
            else
            {
                button_showterminate.Text = "显示未终止的合同";
                queryStr = "SELECT[ID],[COMP_NAME],[CONTRACT_NO],[START_DATE],[END_DATE],[RENT_AREA],[CORP_REP] " +
                    ",[CONTACT],[TELEPHONE],[MOBILE],[CAPITAL],[PLACE],[TAX_ID],[IC_ID],[ORG_CODE],[CATEGORY] " +
                    ",[MAIN_BUZZ],[COMMENT] FROM [CONTRACT_INFO] WHERE [TERMINATE]=1 ";
                LoadData();
            }

        }

        private void button_terminate_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection dgvselrows = dgvContract.SelectedRows;
            string msg = "";
            if (dgvselrows.Count == 1)
            {
                msg = "确定要将合同:" + dgvselrows[0].Cells["CONTRACT_NO"].ToString() + "终止吗?";
                DialogResult dr=MessageBox.Show(msg, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string sql = "DELETE FROM " + tbname + " WHERE ID=" + dgvselrows[0].Cells["ID"].ToString();
                    using (DataBase DB = new DataBase())
                    {

                    }
                }
            }
        }
        

    }
}
