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
    public partial class FormAddFee : Form
    {
        private bool isNew=true;
        private string feeid="-1";
        public FormAddFee():this(true,"-1"){}
        public FormAddFee(bool _isNew, string _feeid)
        {
            InitializeComponent();
        }
        private void InitData()
        {
            using (DataBase db = new DataBase())
            {
                //init combobox_comp
                DataTable dt = db.ExecuteDataTable("SELECT ID,COMP_NAME FROM CONTRACT_INFO WHERE TERMINATE<>1");
                foreach (DataRow dr in dt.Rows)
                {
                    comboBox_comp.Items.Add(new ComboItem(dr[0].ToString(), dr[1].ToString()));
                }
                //init combobox_type
                dt = db.ExecuteDataTable("SELECT DISTINCT FEE_TYPE FROM FEE_INFO");
                foreach (DataRow dr in dt.Rows)
                {
                    comboBox_type.Items.Add(dr[0].ToString());
                }
                if (!isNew)
                {
                    this.Text = "更改记录";
                    button_confirm.Text = "确定更改";
                    //todo
                }
            }
        }
    }
}
