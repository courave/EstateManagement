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
    public partial class FormPredCharge : Form
    {
        private string queryStr = "SELECT A.[ID],B.[COMP_NAME],A.[CHARGE_TYPE],A.[SUM_MONTH],A.[INTERVAL] "+
            "FROM [PRED_CHARGE] A,[CONTRACT_INFO] B " +
            "WHERE A.[COMP_ID]=B.[ID] AND B.[TERMINATE]<>1 ";//do not need terminated info
        public FormPredCharge()
        {
            InitializeComponent();
            dgvPredCharge.AutoGenerateColumns = false;
            initComboComp();
        }
        private void LoadData(string sql)
        {
            using (DataBase db = new DataBase())
            {
                dgvPredCharge.DataSource = db.ExecuteDataTable(sql);
            }
        }
        private void LoadData()
        {
            LoadData(queryStr);
        }
        private void FormPredCharge_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void initComboComp()
        {
            using (DataBase db = new DataBase())
            {
                DataTable dt = db.ExecuteDataTable("SELECT ID,COMP_NAME FROM CONTRACT_INFO WHERE TERMINATE<>1");
                foreach (DataRow dr in dt.Rows)
                {
                    comboBox_comp.Items.Add(new ComboItem(dr[0].ToString(), dr[1].ToString()));
                }
            }
        }

        private void comboBox_comp_TextUpdate(object sender, EventArgs e)
        {
            if (comboBox_comp.SelectedItem != null)
            {
                LoadData(queryStr + " AND A.[COMP_ID]=" + ((ComboItem)comboBox_comp.SelectedItem).Key);
            }
            else
            {
                LoadData(queryStr + " AND B.[COMP_NAME] LIKE '%" + comboBox_comp.Text + "%'");
            }
        }

        private void comboBox_comp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_comp.SelectedItem != null)
            {
                LoadData(queryStr + " AND A.[COMP_ID]=" + ((ComboItem)comboBox_comp.SelectedItem).Key);
            }
            else
            {
                LoadData(queryStr + " AND B.[COMP_NAME] LIKE '%" + comboBox_comp.Text + "%'");
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}
