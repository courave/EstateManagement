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
            itemsImageList.ColorDepth = ColorDepth.Depth32Bit;
            Image customerPic = Properties.Resources.customers;
            Image feereportPic = Properties.Resources.feereport;
            Image printPic = Properties.Resources.printreport;
            Image sdmPic = Properties.Resources.sdm;
            itemsImageList.ImageSize = new Size(100, 100);
            itemsImageList.Images.Add(customerPic);
            itemsImageList.Images.Add(feereportPic);
            itemsImageList.Images.Add(printPic);
            itemsImageList.Images.Add(sdmPic);
            listViewMain.LargeImageList = itemsImageList;
            listViewMain.Items.Add(new ListViewItem("客户信息管理", 0));
            listViewMain.Items.Add(new ListViewItem("费用报表管理", 1));
            listViewMain.Items.Add(new ListViewItem("打印当月报表", 2));
            listViewMain.Items.Add(new ListViewItem("水电煤录入", 3));
            
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

        private void ToolStripMenuItem_Rooms_Click(object sender, EventArgs e)
        {
            customers.FormRooms frmRooms = new customers.FormRooms();
            frmRooms.Show();
        }

        private void ToolStripMenuItem_deposit_Click(object sender, EventArgs e)
        {
            customers.DepositInfo frmDeposit = new customers.DepositInfo();
            frmDeposit.Show();
        }

        private void ToolStripMenuItem_predcharge_Click(object sender, EventArgs e)
        {
            customers.FormPredCharge frmPredCharge = new customers.FormPredCharge();
            frmPredCharge.Show();
        }

        private void toolStripMenuItem_customers_Click(object sender, EventArgs e)
        {
            customers.FormCustomers frmCustomers = new customers.FormCustomers();
            frmCustomers.Show();
        }

        private void ToolStripMenuItem_addsdm_Click(object sender, EventArgs e)
        {
            charges.FormAddSdm frmSdm = new charges.FormAddSdm();
            frmSdm.Show();
        }

        private void ToolStripMenuItem_sdmbase_Click(object sender, EventArgs e)
        {
            charges.FormSdmBase frmSdmBase = new charges.FormSdmBase();
            frmSdmBase.Show();
        }

        private void ToolStripMenuItem_sdm_Click(object sender, EventArgs e)
        {
            charges.FormSdm frmSdm = new charges.FormSdm();
            frmSdm.Show();
        }

        private void ToolStripMenuItem_addfee_Click(object sender, EventArgs e)
        {
            charges.FormAddFee frmAddFee = new charges.FormAddFee();
            frmAddFee.Show();
        }

        private void ToolStripMenuItem_feelist_Click(object sender, EventArgs e)
        {
            charges.FormFee frmFee = new charges.FormFee();
            frmFee.Show();
        }

        private void ToolStripMenuItem_print_Click(object sender, EventArgs e)
        {
            print.FormSelMonth frmSelMonth = new print.FormSelMonth();
            frmSelMonth.Show();
        }

        private void ToolStripMenuItem_generate_Click(object sender, EventArgs e)
        {
            report.FormGenerate frmGen = new report.FormGenerate();
            frmGen.Show();
        }

        private void ToolStripMenuItem_printcomp_Click(object sender, EventArgs e)
        {
            print.FormPrintComp frmPrintcomp = new print.FormPrintComp();
            frmPrintcomp.Show();
        }

        private void ToolStripMenuItem_feereport_Click(object sender, EventArgs e)
        {
            report.FormFeeReport frmFeeReport = new report.FormFeeReport();
            frmFeeReport.Show();
        }


        private void ToolStripMenuItem_rolelist_Click(object sender, EventArgs e)
        {
            users.FormRoles frmRoles = new users.FormRoles();
            frmRoles.Show();
        }


        private void ToolStripMenuItem_userlist_Click(object sender, EventArgs e)
        {
            users.FormUsers frmUsers = new users.FormUsers();
            frmUsers.Show();
        }

        private void ToolStripMenuItem_logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            users.FormLogin frmLogin = new users.FormLogin();
            frmLogin.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about.FormAbout frmAbout = new about.FormAbout();
            frmAbout.ShowDialog();
        }

        private void listViewMain_DoubleClick(object sender, EventArgs e)
        {
            if (listViewMain.SelectedItems.Count != 1) return;
            ListViewItem item = listViewMain.SelectedItems[0];
            switch (item.ImageIndex)
            {
                case 0:
                    customers.FormCustomers frmCustomer = new customers.FormCustomers();
                    frmCustomer.Show();
                    break;
                case 1:
                    report.FormFeeReport frmReport = new report.FormFeeReport();
                    frmReport.Show();
                    break;
                case 2:
                    print.FormSelMonth frmSelMonth = new print.FormSelMonth();
                    frmSelMonth.Show();
                    break;
                case 3:
                    charges.FormAddSdm frmSdm = new charges.FormAddSdm();
                    frmSdm.Show();
                    break;
            }
        }

        private void FormMainPanel_Load(object sender, EventArgs e)
        {
            notification.FormNotification frmNotification = new notification.FormNotification();
            frmNotification.Show();
        }



    }
}
