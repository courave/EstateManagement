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
            InitComp();
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

        private void ToolStripMenuItem_modify_Click(object sender, EventArgs e)
        {
            if (dgvFeeReport.SelectedRows.Count == 1)
            {
                DataGridViewRow selrow = dgvFeeReport.SelectedRows[0];
                //customers.FormAddCustomer frmAddCustomer = new customers.FormAddCustomer(false, selrow.Cells["ID"].Value.ToString());
                //frmAddCustomer.ShowDialog();
                charges.FormFee frmFee = new charges.FormFee(selrow.Cells["ID"].Value.ToString(), selrow.Cells["GEN_MONTH"].Value.ToString());
                frmFee.ShowDialog();
            }
        }

        private void ToolStripMenuItem_markispaid_Click(object sender, EventArgs e)
        {
            if (dgvFeeReport.SelectedRows.Count < 1) return;
            if (MessageBox.Show("确定将所选 " + dgvFeeReport.SelectedRows.Count + " 条记录标记为已付款吗?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            string genmonth = "";
            string compid = "";
            string sql = "";
            foreach (DataGridViewRow selrow in dgvFeeReport.SelectedRows)
            {
                genmonth = selrow.Cells["GEN_MONTH"].Value.ToString();
                compid = selrow.Cells["ID"].Value.ToString();
                sql = "UPDATE FEE_INFO SET ISPAID=1 WHERE COMP_ID="+compid+" AND GEN_MONTH='"+genmonth+"'";
                using (DataBase db = new DataBase())
                {
                    db.ExecuteNonQuery(sql);
                    
                }
            }
            LoadData();
        }

        private void ToolStripMenuItem_showpaid_Click(object sender, EventArgs e)
        {
            if (ToolStripMenuItem_showpaid.Text == "显示已付款项目")
            {
                ToolStripMenuItem_showpaid.Text = "显示未付款项目";
                queryStr = "SELECT [ID],[CONTRACT_NO],[COMP_NAME],[ROOMNO],[GEN_MONTH],[ISPAID] " +
            ",[DATE_PREV],[DATE_CURRENT],[DATE_NEXT],[FZ_FEE],[FWF_FEE],[WY_FEE] " +
            ",[WL_FEE],[CW_FEE],[MQF_FEE],[SF_FEE],[DF_FEE],[QITA_FEE],[TOTAL_FEE] " +
            "FROM [View_FEE_REPORT] WHERE ISPAID=1 ";
                LoadData();
            }
            else
            {
                ToolStripMenuItem_showpaid.Text = "显示已付款项目";
                queryStr = "SELECT [ID],[CONTRACT_NO],[COMP_NAME],[ROOMNO],[GEN_MONTH],[ISPAID] " +
            ",[DATE_PREV],[DATE_CURRENT],[DATE_NEXT],[FZ_FEE],[FWF_FEE],[WY_FEE] " +
            ",[WL_FEE],[CW_FEE],[MQF_FEE],[SF_FEE],[DF_FEE],[QITA_FEE],[TOTAL_FEE] " +
            "FROM [View_FEE_REPORT] WHERE ISPAID<>1 ";
                LoadData();
            }
        }

        private void ToolStripMenuItem_reset_Click(object sender, EventArgs e)
        {
            queryStr = "SELECT [ID],[CONTRACT_NO],[COMP_NAME],[ROOMNO],[GEN_MONTH],[ISPAID] " +
            ",[DATE_PREV],[DATE_CURRENT],[DATE_NEXT],[FZ_FEE],[FWF_FEE],[WY_FEE] " +
            ",[WL_FEE],[CW_FEE],[MQF_FEE],[SF_FEE],[DF_FEE],[QITA_FEE],[TOTAL_FEE] " +
            "FROM [View_FEE_REPORT] WHERE ISPAID<>1 ";
            LoadData();
            ToolStripMenuItem_showpaid.Text = "显示已付款项目";
            toolStripTextBox_contractno.Text = "";
            toolStripTextBox_genmonth.Text = "";
            toolStripTextBox_room.Text = "";
            toolStripComboBox_comp.Text = "";
            toolStripComboBox_comp.SelectedItem = null;
        }

        private void SearchAction()
        {
            String sql = queryStr;
            if (toolStripTextBox_contractno.Text != "")
            {
                sql += " AND CONTRACT_NO LIKE '%" + toolStripTextBox_contractno.Text + "%' ";
            }
            if (toolStripTextBox_genmonth.Text != "")
            {
                sql += " AND GEN_MONTH LIKE '%" + toolStripTextBox_genmonth.Text + "%' ";
            }
            if (toolStripTextBox_room.Text != "")
            {
                sql += " AND ROOMNO LIKE '%" + toolStripTextBox_room.Text + "%' ";
            }
            if (toolStripComboBox_comp.SelectedItem != null)
            {
                sql += " AND ID=" + ((ComboItem)toolStripComboBox_comp.SelectedItem).Key;
            }
            else if (toolStripComboBox_comp.Text != "")
            {
                sql += " AND COMP_NAME LIKE '%" + toolStripComboBox_comp.Text + "%' ";
            }
            LoadData(sql);
        }

        private void InitComp()
        {
            string sql = "SELECT DISTINCT ID,COMP_NAME FROM View_FEE_REPORT";
            using (DataBase db = new DataBase())
            {
                DataTable dt = db.ExecuteDataTable(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    toolStripComboBox_comp.Items.Add(new ComboItem(dr[0].ToString(), dr[1].ToString()));
                }
            }
        }

        private void toolStripTextBox_contractno_TextChanged(object sender, EventArgs e)
        {
            SearchAction();
        }

        private void toolStripComboBox_comp_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchAction();
        }

        private void toolStripComboBox_comp_TextChanged(object sender, EventArgs e)
        {
            SearchAction();
        }

        private void toolStripTextBox_room_TextChanged(object sender, EventArgs e)
        {
            SearchAction();
        }

        private void toolStripTextBox_genmonth_TextChanged(object sender, EventArgs e)
        {
            SearchAction();
        }

        private void ToolStripMenuItem_print_Click(object sender, EventArgs e)
        {
            if (dgvFeeReport.SelectedRows.Count < 1) return;
            ToolStripMenuItem_print.Text = "正在准备..";
            ToolStripMenuItem_print.Enabled = false;
            String sql = "SELECT * FROM View_FEE_REPORT WHERE 1=2 ";
            foreach (DataGridViewRow dgvr in dgvFeeReport.SelectedRows)
            {
                sql += " OR (ID="+dgvr.Cells["ID"].Value.ToString()+
                    " AND GEN_MONTH='" + dgvr.Cells["GEN_MONTH"].Value.ToString() + "') ";
            }
            using (DataBase db = new DataBase())
            {
                DataTable dt = db.ExecuteDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    print.FormFeePrintPreview frmPrint = new print.FormFeePrintPreview(true, dt);
                    frmPrint.ShowDialog();
                }
            }
            ToolStripMenuItem_print.Text = "打印选中记录";
            ToolStripMenuItem_print.Enabled = true;
        }
    }
}
