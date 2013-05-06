﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using EstateManagement.pub;

namespace EstateManagement.charges
{
    public partial class FormSdmBase : Form
    {
        private DataSet ds;
        private SqlDataAdapter adapter;
        private string tbname = "SDM_BASE";
        private string queryStr = "SELECT[ID],[SDM_TYPE],[SDM_UNIT] FROM [SDM_BASE]";
        private void InitAdapter(string sql)
        {
            SqlConnection conn = new SqlConnection(DataBase.connStr);
            SqlCommand selComm = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter(selComm);
            ds = new DataSet();
        }

        public FormSdmBase()
        {
            InitializeComponent();
            dgvSdmBase.AutoGenerateColumns = false;
            InitAdapter(queryStr);
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

            this.dgvSdmBase.DataSource = ds.Tables[tbname];
        }

        private void FormSdmBase_Load(object sender, EventArgs e)
        {
            LoadData();
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
                this.dgvSdmBase.Update();
            }
        }

        private void dgvSdmBase_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SaveChanges();
        }

        private void FormSdmBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveChanges();
        }

    }
}
