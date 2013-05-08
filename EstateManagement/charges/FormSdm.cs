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
    public partial class FormSdm : Form
    {
        private string queryStr = "SELECT A.[ID],B.COMP_NAME,C.ROOM_NO,[SDM_TYPE] ,[SDM_SUM]," +
            "[SDM_CHARGE],[SDM_TIME],[SDM_CBER],A.[COMMENT],A.[ISPAID] " +
            "FROM [SDM_INFO] A,[CONTRACT_INFO] B,[ROOM_INFO] C " +
            "WHERE A.COMP_ID=B.ID AND A.ROOM_ID=C.ID AND ISPAID<>1 ";
        private void LoadData(string sql)
        {
            using (DataBase db = new DataBase())
            {
                dgvSdm.DataSource = db.ExecuteDataTable(sql);
            }
        }
        private void LoadData()
        {
            LoadData(queryStr);
        }
        public FormSdm()
        {
            InitializeComponent();
            dgvSdm.AutoGenerateColumns = false;
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
                dt = db.ExecuteDataTable("SELECT ID,ROOM_NO FROM ROOM_INFO WHERE HASCOMP=1");
                foreach (DataRow dr in dt.Rows)
                {
                    toolStripComboBox_room.Items.Add(new ComboItem(dr[0].ToString(), dr[1].ToString()));
                }
            }
        }
        private void FormSdm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ToolStripMenuItem_addrecord_Click(object sender, EventArgs e)
        {
            FormAddSdm frmAddSdm = new FormAddSdm();
            frmAddSdm.ShowDialog();
            LoadData();
        }

        private void ToolStripMenuItem_modifyrecord_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection dgvselrows = dgvSdm.SelectedRows;
            if (dgvselrows.Count == 1)
            {
                FormAddSdm frmAddSdm = new FormAddSdm(false,dgvselrows[0].Cells["ID"].Value.ToString());
                frmAddSdm.ShowDialog();
                LoadData();
            }

        }

        private void ToolStripMenuItem_setpaid_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection dgvselrows = dgvSdm.SelectedRows;
            if (dgvselrows.Count == 1)
            {
                string sdmid = dgvselrows[0].Cells["ID"].Value.ToString();
                string compname = dgvselrows[0].Cells["COMP_NAME"].Value.ToString();
                string roomno = dgvselrows[0].Cells["ROOM_NO"].Value.ToString();
                string sdmtype = dgvselrows[0].Cells["SDM_TYPE"].Value.ToString();
                string cbtime = dgvselrows[0].Cells["SDM_TIME"].Value.ToString();
                string msg = "确定要将如下记录设置为 已付款吗?\n\n公司:" + compname + "\n房间号:" + roomno + "\n名目:" + sdmtype + "\n抄表时间:" + cbtime + "\n";
                DialogResult dr = MessageBox.Show(msg, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (DataBase db = new DataBase())
                    {
                        db.AddParameter("ISPAID", true);
                        db.AddParameter("ID", sdmid);
                        db.ExecuteNonQuery("UPDATE SDM_INFO SET ISPAID=@ISPAID WHERE ID=@ID");
                    }
                    LoadData();
                }
            }
        }

        private void ToolStripMenuItem_reset_Click(object sender, EventArgs e)
        {
            toolStripComboBox_comp.SelectedItem = null;
            toolStripComboBox_room.SelectedItem = null;
            toolStripComboBox_type.SelectedItem = null;
            toolStripTextBox_cbtime.Text = "";
            ToolStripMenuItem_showpaid.Text = "显示已付款项目";
            LoadData();
        }

        private void ToolStripMenuItem_showpaid_Click(object sender, EventArgs e)
        {
            if (ToolStripMenuItem_showpaid.Text == "显示已付款项目")
            {
                ToolStripMenuItem_showpaid.Text = "显示未付款项目";
                string sql = "SELECT A.[ID],B.COMP_NAME,C.ROOM_NO,[SDM_TYPE] ,[SDM_SUM]," +
                    "[SDM_CHARGE],[SDM_TIME],[SDM_CBER],A.[COMMENT],A.[ISPAID] " +
                    "FROM [SDM_INFO] A,[CONTRACT_INFO] B,[ROOM_INFO] C " +
                    "WHERE A.COMP_ID=B.ID AND A.ROOM_ID=C.ID AND ISPAID=1 " +
                    "ORDER BY COMP_NAME,ROOM_NO,SDM_TIME";
                LoadData(sql);
            }
            else
            {
                ToolStripMenuItem_showpaid.Text = "显示已付款项目";
                LoadData();
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
            if (toolStripComboBox_room.SelectedItem != null || toolStripComboBox_room.Text != "")
            {
                if (toolStripComboBox_room.SelectedItem != null)
                {
                    sb.Append(" AND A.ROOM_ID=" + ((ComboItem)toolStripComboBox_room.SelectedItem).Key + " ");
                }
                else
                {
                    sb.Append(" AND C.ROOM_NO LIKE '%" + toolStripComboBox_room.Text + "%' ");
                }
            }
            if (toolStripComboBox_type.SelectedItem != null)
            {
                sb.Append(" AND A.SDM_TYPE='" + toolStripComboBox_type.SelectedItem.ToString() + "' ");
            }
            if (toolStripTextBox_cbtime.Text.Length > 8)
            {
                string key = toolStripTextBox_cbtime.Text.Trim();
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
                            sb.Append(" AND [SDM_TIME]>='" + tmpdate.ToShortDateString() + "' ");
                        }

                    }
                    else//>
                    {
                        if (key.Length == 8 && int.TryParse(key.Substring(0, 4), out year) &&
                            int.TryParse(key.Substring(4, 2), out month) &&
                            int.TryParse(key.Substring(6, 2), out day))
                        {
                            DateTime tmpdate = new DateTime(year, month, day);
                            sb.Append(" AND [SDM_TIME]>'" + tmpdate.ToShortDateString() + "' ");
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
                            sb.Append(" AND [SDM_TIME]<='" + tmpdate.ToShortDateString() + "' ");
                        }

                    }
                    else//<
                    {
                        if (key.Length == 8 && int.TryParse(key.Substring(0, 4), out year) &&
                            int.TryParse(key.Substring(4, 2), out month) &&
                            int.TryParse(key.Substring(6, 2), out day))
                        {
                            DateTime tmpdate = new DateTime(year, month, day);
                            sb.Append(" AND [SDM_TIME]<'" + tmpdate.ToShortDateString() + "' ");
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
                        sb.Append(" AND YEAR([SDM_TIME])=" + year + " AND MONTH([SDM_TIME])=" + month + " AND DAY([SDM_TIME])=" + day);
                    }
                }
            }
            LoadData(sb.ToString());
        }

        private void toolStripTextBox_cbtime_TextChanged(object sender, EventArgs e)
        {
            SearchAction();
        }

        private void toolStripComboBox_comp_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchAction();
        }

        private void toolStripComboBox_comp_TextUpdate(object sender, EventArgs e)
        {
            SearchAction();
        }

        private void toolStripComboBox_room_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchAction();
        }

        private void toolStripComboBox_room_TextUpdate(object sender, EventArgs e)
        {
            SearchAction();
        }

        private void toolStripComboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchAction();
        }
    }
}
