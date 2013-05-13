﻿using System;
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



    }
}
