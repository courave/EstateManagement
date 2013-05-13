using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstateManagement.pub;

namespace EstateManagement.print
{
    public partial class FormSelMonth : Form
    {
        public FormSelMonth()
        {
            InitializeComponent();
        }

        private void FormSelMonth_Load(object sender, EventArgs e)
        {
            comboBox_ispaid.SelectedIndex = 0;
            comboBox_month.Items.Add("<全部>");
            using (DataBase db = new DataBase())
            {
                string sql = "SELECT DISTINCT GEN_MONTH FROM FEE_INFO order by GEN_MONTH";
                DataTable dt = db.ExecuteDataTable(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    comboBox_month.Items.Add(dr[0].ToString());
                }
            }
            comboBox_month.SelectedItem = DateTime.Now.ToString("yyyyMM");
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            Dispose();
            FormFeePrintPreview frmPrint = new FormFeePrintPreview(comboBox_month.SelectedItem.ToString(), comboBox_ispaid.SelectedIndex);
            frmPrint.ShowDialog();
        }

        private void FormSelMonth_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }
    }
}
