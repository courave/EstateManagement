using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstateManagement.pub;

namespace EstateManagement.charges
{
    public partial class FormFee : Form
    {
        private string queryStr = "SELECT A.[ID],B.[COMP_NAME],A.[FEE_TYPE],A.[FEE_CHARGE],CONVERT(CHAR(10), A.[LAST_END], 111) AS LAST_END, " +
                                    "CONVERT(CHAR(10), A.[LAST_END], 111) + ' - '+CONVERT(CHAR(10), A.[NEXT_START], 111) AS CUR_DATE, " +
                                    "CONVERT(CHAR(10), A.[NEXT_START], 111) AS NEXT_START,A.[COMMENT],A.[GEN_MONTH],A.[ISPAID] " +
                                    "FROM [FEE_INFO] A,[CONTRACT_INFO] B WHERE A.COMP_ID=B.ID AND ISPAID<>1";
        public FormFee()
        {
            InitializeComponent();
            LoadData();
            InitComboData();
        }
        private void InitComboData()
        {
            using (DataBase db = new DataBase())
            {
                DataTable dt = db.ExecuteDataTable("SELECT ID,COMP_NAME FROM CONTRACT_INFO WHERE TERMINATE<>1");
                foreach (DataRow dr in dt.Rows)
                {
                    toolStripComboBox_comp.Items.Add(new ComboItem(dr[0].ToString(), dr[1].ToString()));
                }
                dt = db.ExecuteDataTable("SELECT DISTINCT FEE_TYPE FROM FEE_INFO");
                foreach (DataRow dr in dt.Rows)
                {
                    toolStripComboBox_type.Items.Add(dr[0].ToString());
                }
            }
        }
        private void LoadData(string sql)
        {
            using (DataBase db = new DataBase())
            {
                DataTable dt = db.ExecuteDataTable(sql);
                dgvFee.DataSource = dt;
            }

        }
        private void LoadData()
        {
            LoadData(queryStr);
        }

        private void ToolStripMenuItem_add_Click(object sender, EventArgs e)
        {
            FormAddFee frmAddFee = new FormAddFee();
            frmAddFee.ShowDialog();
            LoadData();
        }

        private void ToolStripMenuItem_modify_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection dgvselrows = dgvFee.SelectedRows;
            if (dgvselrows.Count == 1)
            {
                FormAddFee frmAddFee = new FormAddFee(false, dgvselrows[0].Cells["ID"].Value.ToString());
                frmAddFee.ShowDialog();
                LoadData();
            }
        }

        private void ToolStripMenuItem_setpaid_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection dgvselrows = dgvFee.SelectedRows;
            if (dgvselrows.Count == 1)
            {
                if ((bool)dgvselrows[0].Cells["ISPAID"].Value) return;
                string feeid = dgvselrows[0].Cells["ID"].Value.ToString();
                string compname = dgvselrows[0].Cells["COMP_NAME"].Value.ToString();
                string feetype = dgvselrows[0].Cells["FEE_TYPE"].Value.ToString();
                string curdate = dgvselrows[0].Cells["CUR_DATE"].Value.ToString();
                string msg = "确定要将如下记录设置为 已付款吗?\n\n公司:" + compname + "\n名目:" + feetype + "\n本期结算日期:" + curdate + "\n";
                DialogResult dr = MessageBox.Show(msg, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (DataBase db = new DataBase())
                    {
                        db.AddParameter("ISPAID", true);
                        db.AddParameter("ID", feeid);
                        db.ExecuteNonQuery("UPDATE FEE_INFO SET ISPAID=@ISPAID WHERE ID=@ID");
                    }
                    LoadData();
                }
            }
            else
            {
                string msg = "确定要批量设置所选 "+dgvselrows.Count +" 条记录标记为 已付款 吗?\n";
                DialogResult dr = MessageBox.Show(msg, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (DataBase db = new DataBase())
                    {
                        foreach (DataGridViewRow dgvr in dgvselrows)
                        {
                            if ((bool)dgvr.Cells["ISPAID"].Value) continue;
                            db.AddParameter("ISPAID", true);
                            db.AddParameter("ID", dgvr.Cells["ID"].Value);
                            db.ExecuteNonQuery("UPDATE FEE_INFO SET ISPAID=@ISPAID WHERE ID=@ID");
                        }
                        LoadData();
                    }
                }
            }
        }

        private void ToolStripMenuItem_reset_Click(object sender, EventArgs e)
        {
            toolStripComboBox_comp.Text = "";
            toolStripComboBox_comp.SelectedItem = null;
            toolStripComboBox_type.SelectedItem = null;
            toolStripTextBox_genmonth.Text = "";
            toolStripTextBox_lastend.Text = "";
            toolStripTextBox_nextstart.Text = "";
            ToolStripMenuItem_showpaid.Text = "显示已付款项目";
            queryStr = "SELECT A.[ID],B.[COMP_NAME],A.[FEE_TYPE],A.[FEE_CHARGE],CONVERT(CHAR(10), A.[LAST_END], 111) AS LAST_END, " +
                                    "CONVERT(CHAR(10), A.[LAST_END], 111) + ' - '+CONVERT(CHAR(10), A.[NEXT_START], 111) AS CUR_DATE, " +
                                    "CONVERT(CHAR(10), A.[NEXT_START], 111) AS NEXT_START,A.[COMMENT],A.[GEN_MONTH],A.[ISPAID] " +
                                    "FROM [FEE_INFO] A,[CONTRACT_INFO] B WHERE A.COMP_ID=B.ID AND ISPAID<>1";
            LoadData();
        }

        private void ToolStripMenuItem_showpaid_Click(object sender, EventArgs e)
        {
            if (ToolStripMenuItem_showpaid.Text == "显示已付款项目")
            {
                ToolStripMenuItem_showpaid.Text = "显示未付款项目";
                string sql = "SELECT A.[ID],B.[COMP_NAME],A.[FEE_TYPE],A.[FEE_CHARGE],CONVERT(CHAR(10), A.[LAST_END], 111) AS LAST_END, " +
                                    "CONVERT(CHAR(10), A.[LAST_END], 111) + ' - '+CONVERT(CHAR(10), A.[NEXT_START], 111) AS CUR_DATE, " +
                                    "CONVERT(CHAR(10), A.[NEXT_START], 111) AS NEXT_START,A.[COMMENT],A.[GEN_MONTH],A.[ISPAID] " +
                                    "FROM [FEE_INFO] A,[CONTRACT_INFO] B WHERE A.COMP_ID=B.ID AND ISPAID=1";
                LoadData(sql);
            }
            else
            {
                ToolStripMenuItem_showpaid.Text = "显示已付款项目";
                string sql = "SELECT A.[ID],B.[COMP_NAME],A.[FEE_TYPE],A.[FEE_CHARGE],CONVERT(CHAR(10), A.[LAST_END], 111) AS LAST_END, " +
                                    "CONVERT(CHAR(10), A.[LAST_END], 111) + ' - '+CONVERT(CHAR(10), A.[NEXT_START], 111) AS CUR_DATE, " +
                                    "CONVERT(CHAR(10), A.[NEXT_START], 111) AS NEXT_START,A.[COMMENT],A.[GEN_MONTH],A.[ISPAID] " +
                                    "FROM [FEE_INFO] A,[CONTRACT_INFO] B WHERE A.COMP_ID=B.ID AND ISPAID<>1";
                LoadData(sql);
            }
        }

        private void SearchAction()
        {
            StringBuilder sb = new StringBuilder(queryStr);
            if (toolStripComboBox_comp.SelectedItem != null || toolStripComboBox_comp.Text != "")
            {
                if (toolStripComboBox_comp.SelectedItem != null)
                {
                    sb.Append(" AND A.COMP_ID=" + ((ComboItem)toolStripComboBox_comp.SelectedItem).Key + " ");
                }
                else
                {
                    sb.Append(" AND B.COMP_NAME LIKE '%" + toolStripComboBox_comp.Text + "%' ");
                }
            }
            if (toolStripComboBox_type.SelectedItem != null)
            {
                sb.Append(" AND A.FEE_TYPE='" + toolStripComboBox_type.SelectedItem.ToString() + "' ");
            }
            if (toolStripTextBox_lastend.Text.Length > 8)
            {
                string key = toolStripTextBox_lastend.Text.Trim();
                int year = 0;
                int month = 0;
                int day = 0;
                if (key.StartsWith(">"))
                {
                    key = key.Remove(0, 1);
                    if (key.StartsWith("="))//>=
                    {
                        key = key.Remove(0, 1);

                        if (key.Length == 8 && int.TryParse(key.Substring(0, 4), out year) &&
                            int.TryParse(key.Substring(4, 2), out month) &&
                            int.TryParse(key.Substring(6, 2), out day))
                        {
                            DateTime tmpdate = new DateTime(year, month, day);
                            sb.Append(" AND [LAST_END]>='" + tmpdate.ToShortDateString() + "' ");
                        }

                    }
                    else//>
                    {
                        if (key.Length == 8 && int.TryParse(key.Substring(0, 4), out year) &&
                            int.TryParse(key.Substring(4, 2), out month) &&
                            int.TryParse(key.Substring(6, 2), out day))
                        {
                            DateTime tmpdate = new DateTime(year, month, day);
                            sb.Append(" AND [LAST_END]>'" + tmpdate.ToShortDateString() + "' ");
                        }
                    }
                }
                else if (key.StartsWith("<"))
                {
                    key = key.Remove(0, 1);
                    if (key.StartsWith("="))//<=
                    {
                        key = key.Remove(0, 1);
                        if (key.Length == 8 && int.TryParse(key.Substring(0, 4), out year) &&
                            int.TryParse(key.Substring(4, 2), out month) &&
                            int.TryParse(key.Substring(6, 2), out day))
                        {
                            DateTime tmpdate = new DateTime(year, month, day);
                            sb.Append(" AND [LAST_END]<='" + tmpdate.ToShortDateString() + "' ");
                        }

                    }
                    else//<
                    {
                        if (key.Length == 8 && int.TryParse(key.Substring(0, 4), out year) &&
                            int.TryParse(key.Substring(4, 2), out month) &&
                            int.TryParse(key.Substring(6, 2), out day))
                        {
                            DateTime tmpdate = new DateTime(year, month, day);
                            sb.Append(" AND [LAST_END]<'" + tmpdate.ToShortDateString() + "' ");
                        }
                    }
                }
                else if (key.StartsWith("="))
                {
                    key = key.Remove(0, 1);
                    if (key.Length == 8 && int.TryParse(key.Substring(0, 4), out year) &&
                        int.TryParse(key.Substring(4, 2), out month) &&
                        int.TryParse(key.Substring(6, 2), out day))
                    {
                        sb.Append(" AND YEAR([LAST_END])=" + year + " AND MONTH([LAST_END])=" + month + " AND DAY([LAST_END])=" + day);
                    }
                }
            }
            if (toolStripTextBox_nextstart.Text.Length > 8)
            {
                string key = toolStripTextBox_nextstart.Text.Trim();
                int year = 0;
                int month = 0;
                int day = 0;
                if (key.StartsWith(">"))
                {
                    key = key.Remove(0, 1);
                    if (key.StartsWith("="))//>=
                    {
                        key = key.Remove(0, 1);

                        if (key.Length == 8 && int.TryParse(key.Substring(0, 4), out year) &&
                            int.TryParse(key.Substring(4, 2), out month) &&
                            int.TryParse(key.Substring(6, 2), out day))
                        {
                            DateTime tmpdate = new DateTime(year, month, day);
                            sb.Append(" AND [NEXT_START]>='" + tmpdate.ToShortDateString() + "' ");
                        }

                    }
                    else//>
                    {
                        if (key.Length == 8 && int.TryParse(key.Substring(0, 4), out year) &&
                            int.TryParse(key.Substring(4, 2), out month) &&
                            int.TryParse(key.Substring(6, 2), out day))
                        {
                            DateTime tmpdate = new DateTime(year, month, day);
                            sb.Append(" AND [NEXT_START]>'" + tmpdate.ToShortDateString() + "' ");
                        }
                    }
                }
                else if (key.StartsWith("<"))
                {
                    key = key.Remove(0, 1);
                    if (key.StartsWith("="))//<=
                    {
                        key = key.Remove(0, 1);
                        if (key.Length == 8 && int.TryParse(key.Substring(0, 4), out year) &&
                            int.TryParse(key.Substring(4, 2), out month) &&
                            int.TryParse(key.Substring(6, 2), out day))
                        {
                            DateTime tmpdate = new DateTime(year, month, day);
                            sb.Append(" AND [NEXT_START]<='" + tmpdate.ToShortDateString() + "' ");
                        }

                    }
                    else//<
                    {
                        if (key.Length == 8 && int.TryParse(key.Substring(0, 4), out year) &&
                            int.TryParse(key.Substring(4, 2), out month) &&
                            int.TryParse(key.Substring(6, 2), out day))
                        {
                            DateTime tmpdate = new DateTime(year, month, day);
                            sb.Append(" AND [NEXT_START]<'" + tmpdate.ToShortDateString() + "' ");
                        }
                    }
                }
                else if (key.StartsWith("="))
                {
                    key = key.Remove(0, 1);
                    if (key.Length == 8 && int.TryParse(key.Substring(0, 4), out year) &&
                        int.TryParse(key.Substring(4, 2), out month) &&
                        int.TryParse(key.Substring(6, 2), out day))
                    {
                        sb.Append(" AND YEAR([NEXT_START])=" + year + " AND MONTH([NEXT_START])=" + month + " AND DAY([NEXT_START])=" + day);
                    }
                }
            }
            if (toolStripTextBox_genmonth.Text.Length>3)
            {
                string key = toolStripTextBox_genmonth.Text.Trim();
                sb.Append(" AND GEN_MONTH LIKE '%" + key + "%'");
            }
            LoadData(sb.ToString());
        }

        private void ToolStripMenuItem_showall_Click(object sender, EventArgs e)
        {
            queryStr = "SELECT A.[ID],B.[COMP_NAME],A.[FEE_TYPE],A.[FEE_CHARGE],CONVERT(CHAR(10), A.[LAST_END], 111) AS LAST_END, " +
                                                "CONVERT(CHAR(10), A.[LAST_END], 111) + ' - '+CONVERT(CHAR(10), A.[NEXT_START], 111) AS CUR_DATE, " +
                                                "CONVERT(CHAR(10), A.[NEXT_START], 111) AS NEXT_START,A.[COMMENT],A.[GEN_MONTH],A.[ISPAID] " +
                                                "FROM [FEE_INFO] A,[CONTRACT_INFO] B WHERE A.COMP_ID=B.ID";
            LoadData();
        }

        private void toolStripComboBox_comp_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchAction();
        }

        private void toolStripComboBox_comp_TextUpdate(object sender, EventArgs e)
        {
            SearchAction();
        }

        private void toolStripComboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchAction();
        }

        private void toolStripTextBox_lastend_TextChanged(object sender, EventArgs e)
        {
            SearchAction();
        }

        private void toolStripTextBox_nextstart_TextChanged(object sender, EventArgs e)
        {
            SearchAction();
        }

        private void toolStripTextBox_genmonth_TextChanged(object sender, EventArgs e)
        {
            SearchAction();
        }

    }
}
