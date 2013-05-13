using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstateManagement.pub;

namespace EstateManagement.report
{
    public partial class FormFeeReport : Form
    {
        string queryStr = "SELECT [ID],[CONTRACT_NO],[COMP_NAME],[ROOMNO],[GEN_MONTH],[ISPAID] "+
            ",[DATE_PREV],[DATE_CURRENT],[DATE_NEXT],[FZ_FEE],[FWF_FEE],[WY_FEE] "+
            ",[WL_FEE],[CW_FEE],[MQF_FEE],[SF_FEE],[DF_FEE],[QITA_FEE],[TOTAL_FEE] "+
            "FROM [View_FEE_REPORT] WHERE ISPAID<>1 ";
        public FormFeeReport()
        {
            InitializeComponent();
        }

        private void FormFeeReport_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData(string sql)
        {
            using (DataBase db = new DataBase())
            {
                dgvFeeReport.DataSource = db.ExecuteDataTable(sql);
            }
        }
        private void LoadData()
        {
            LoadData(queryStr);
        }
    }
}
