using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EstateManagement
{
    public partial class FormMainPanel : Form
    {
        public FormMainPanel()
        {
            InitializeComponent();
            if (pub.UserInfo.UserName != null)
            {
                toolStripTextBoxUserInfo.Text = "当前登陆用户:"+pub.UserInfo.NickName;
            }
            else
            {
                MessageBox.Show("Error", "出现异常,系统即将退出!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            InitListView();
        }

        private void FormMainPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void InitListView()
        {
            ImageList itemsImageList = new ImageList();

            Image pic=Image.FromFile(Application.StartupPath+"\\resources\\customer.jpg");
            itemsImageList.ImageSize = new Size(150, 150);
            itemsImageList.Images.Add(pic);
            listViewMain.LargeImageList = itemsImageList;
            listViewMain.Items.Add(new ListViewItem("客户管理", 0));
        }

        private void ToolStripMenuItem_ContractManage_Click(object sender, EventArgs e)
        {
            customers.ContractList frmContract = new customers.ContractList();
            frmContract.Show();
        }

        private void toolStripMenuItem_addNewCustomer_Click(object sender, EventArgs e)
        {
            customers.FormAddCustomer frmAddCustomer = new customers.FormAddCustomer();
            frmAddCustomer.Show();
        }

        private void ToolStripMenuItem_parking_Click(object sender, EventArgs e)
        {
            customers.FormCars frmCars = new customers.FormCars();
            frmCars.Show();
        }



    }
}
