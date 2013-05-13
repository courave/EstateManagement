namespace EstateManagement
{
    partial class FormMainPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.客户管理CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_addNewCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_customers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_ContractManage = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_parking = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Rooms = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_deposit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_predcharge = new System.Windows.Forms.ToolStripMenuItem();
            this.费用管理FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_addsdm = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_sdm = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_sdmbase = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_addfee = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_feelist = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_printcomp = new System.Windows.Forms.ToolStripMenuItem();
            this.报表管理RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_generate = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_print = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_feereport = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.角色管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxUserInfo = new System.Windows.Forms.ToolStripTextBox();
            this.listViewMain = new System.Windows.Forms.ListView();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.客户管理CToolStripMenuItem,
            this.费用管理FToolStripMenuItem,
            this.报表管理RToolStripMenuItem,
            this.用户管理UToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.toolStripTextBoxUserInfo});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(768, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // 客户管理CToolStripMenuItem
            // 
            this.客户管理CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_addNewCustomer,
            this.toolStripMenuItem_customers,
            this.toolStripSeparator1,
            this.ToolStripMenuItem_ContractManage,
            this.ToolStripMenuItem_parking,
            this.ToolStripMenuItem_Rooms,
            this.ToolStripMenuItem_deposit,
            this.ToolStripMenuItem_predcharge});
            this.客户管理CToolStripMenuItem.Name = "客户管理CToolStripMenuItem";
            this.客户管理CToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.客户管理CToolStripMenuItem.Text = "客户管理(&C)";
            // 
            // toolStripMenuItem_addNewCustomer
            // 
            this.toolStripMenuItem_addNewCustomer.Name = "toolStripMenuItem_addNewCustomer";
            this.toolStripMenuItem_addNewCustomer.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem_addNewCustomer.Text = "添加一个新的客户";
            this.toolStripMenuItem_addNewCustomer.Click += new System.EventHandler(this.toolStripMenuItem_addNewCustomer_Click);
            // 
            // toolStripMenuItem_customers
            // 
            this.toolStripMenuItem_customers.Name = "toolStripMenuItem_customers";
            this.toolStripMenuItem_customers.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem_customers.Text = "客户信息管理";
            this.toolStripMenuItem_customers.Click += new System.EventHandler(this.toolStripMenuItem_customers_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // ToolStripMenuItem_ContractManage
            // 
            this.ToolStripMenuItem_ContractManage.Name = "ToolStripMenuItem_ContractManage";
            this.ToolStripMenuItem_ContractManage.Size = new System.Drawing.Size(170, 22);
            this.ToolStripMenuItem_ContractManage.Text = "合同管理";
            this.ToolStripMenuItem_ContractManage.Click += new System.EventHandler(this.ToolStripMenuItem_ContractManage_Click);
            // 
            // ToolStripMenuItem_parking
            // 
            this.ToolStripMenuItem_parking.Name = "ToolStripMenuItem_parking";
            this.ToolStripMenuItem_parking.Size = new System.Drawing.Size(170, 22);
            this.ToolStripMenuItem_parking.Text = "车位管理";
            this.ToolStripMenuItem_parking.Click += new System.EventHandler(this.ToolStripMenuItem_parking_Click);
            // 
            // ToolStripMenuItem_Rooms
            // 
            this.ToolStripMenuItem_Rooms.Name = "ToolStripMenuItem_Rooms";
            this.ToolStripMenuItem_Rooms.Size = new System.Drawing.Size(170, 22);
            this.ToolStripMenuItem_Rooms.Text = "房间管理";
            this.ToolStripMenuItem_Rooms.Click += new System.EventHandler(this.ToolStripMenuItem_Rooms_Click);
            // 
            // ToolStripMenuItem_deposit
            // 
            this.ToolStripMenuItem_deposit.Name = "ToolStripMenuItem_deposit";
            this.ToolStripMenuItem_deposit.Size = new System.Drawing.Size(170, 22);
            this.ToolStripMenuItem_deposit.Text = "押金管理";
            this.ToolStripMenuItem_deposit.Click += new System.EventHandler(this.ToolStripMenuItem_deposit_Click);
            // 
            // ToolStripMenuItem_predcharge
            // 
            this.ToolStripMenuItem_predcharge.Name = "ToolStripMenuItem_predcharge";
            this.ToolStripMenuItem_predcharge.Size = new System.Drawing.Size(170, 22);
            this.ToolStripMenuItem_predcharge.Text = "固定资费预设置";
            this.ToolStripMenuItem_predcharge.Click += new System.EventHandler(this.ToolStripMenuItem_predcharge_Click);
            // 
            // 费用管理FToolStripMenuItem
            // 
            this.费用管理FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_addsdm,
            this.ToolStripMenuItem_sdm,
            this.ToolStripMenuItem_sdmbase,
            this.ToolStripMenuItem_addfee,
            this.ToolStripMenuItem_feelist,
            this.toolStripSeparator2,
            this.ToolStripMenuItem_printcomp});
            this.费用管理FToolStripMenuItem.Name = "费用管理FToolStripMenuItem";
            this.费用管理FToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.费用管理FToolStripMenuItem.Text = "费用管理(&F)";
            // 
            // ToolStripMenuItem_addsdm
            // 
            this.ToolStripMenuItem_addsdm.Name = "ToolStripMenuItem_addsdm";
            this.ToolStripMenuItem_addsdm.Size = new System.Drawing.Size(206, 22);
            this.ToolStripMenuItem_addsdm.Text = "水电煤录入(按房间号)";
            this.ToolStripMenuItem_addsdm.Click += new System.EventHandler(this.ToolStripMenuItem_addsdm_Click);
            // 
            // ToolStripMenuItem_sdm
            // 
            this.ToolStripMenuItem_sdm.Name = "ToolStripMenuItem_sdm";
            this.ToolStripMenuItem_sdm.Size = new System.Drawing.Size(206, 22);
            this.ToolStripMenuItem_sdm.Text = "水电煤费用列表";
            this.ToolStripMenuItem_sdm.Click += new System.EventHandler(this.ToolStripMenuItem_sdm_Click);
            // 
            // ToolStripMenuItem_sdmbase
            // 
            this.ToolStripMenuItem_sdmbase.Name = "ToolStripMenuItem_sdmbase";
            this.ToolStripMenuItem_sdmbase.Size = new System.Drawing.Size(206, 22);
            this.ToolStripMenuItem_sdmbase.Text = "水电煤基数管理";
            this.ToolStripMenuItem_sdmbase.Click += new System.EventHandler(this.ToolStripMenuItem_sdmbase_Click);
            // 
            // ToolStripMenuItem_addfee
            // 
            this.ToolStripMenuItem_addfee.Name = "ToolStripMenuItem_addfee";
            this.ToolStripMenuItem_addfee.Size = new System.Drawing.Size(206, 22);
            this.ToolStripMenuItem_addfee.Text = "通用费用录入";
            this.ToolStripMenuItem_addfee.Click += new System.EventHandler(this.ToolStripMenuItem_addfee_Click);
            // 
            // ToolStripMenuItem_feelist
            // 
            this.ToolStripMenuItem_feelist.Name = "ToolStripMenuItem_feelist";
            this.ToolStripMenuItem_feelist.Size = new System.Drawing.Size(206, 22);
            this.ToolStripMenuItem_feelist.Text = "通用费用列表";
            this.ToolStripMenuItem_feelist.Click += new System.EventHandler(this.ToolStripMenuItem_feelist_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(203, 6);
            // 
            // ToolStripMenuItem_printcomp
            // 
            this.ToolStripMenuItem_printcomp.Name = "ToolStripMenuItem_printcomp";
            this.ToolStripMenuItem_printcomp.Size = new System.Drawing.Size(206, 22);
            this.ToolStripMenuItem_printcomp.Text = "生成需要收费的公司列表";
            this.ToolStripMenuItem_printcomp.Click += new System.EventHandler(this.ToolStripMenuItem_printcomp_Click);
            // 
            // 报表管理RToolStripMenuItem
            // 
            this.报表管理RToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_generate,
            this.ToolStripMenuItem_print,
            this.ToolStripMenuItem_feereport});
            this.报表管理RToolStripMenuItem.Name = "报表管理RToolStripMenuItem";
            this.报表管理RToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.报表管理RToolStripMenuItem.Text = "报表管理(&R)";
            // 
            // ToolStripMenuItem_generate
            // 
            this.ToolStripMenuItem_generate.Name = "ToolStripMenuItem_generate";
            this.ToolStripMenuItem_generate.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_generate.Text = "生成费用报表";
            this.ToolStripMenuItem_generate.Click += new System.EventHandler(this.ToolStripMenuItem_generate_Click);
            // 
            // ToolStripMenuItem_print
            // 
            this.ToolStripMenuItem_print.Name = "ToolStripMenuItem_print";
            this.ToolStripMenuItem_print.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_print.Text = "打印当月报表";
            this.ToolStripMenuItem_print.Click += new System.EventHandler(this.ToolStripMenuItem_print_Click);
            // 
            // ToolStripMenuItem_feereport
            // 
            this.ToolStripMenuItem_feereport.Name = "ToolStripMenuItem_feereport";
            this.ToolStripMenuItem_feereport.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_feereport.Text = "费用报表管理";
            this.ToolStripMenuItem_feereport.Click += new System.EventHandler(this.ToolStripMenuItem_feereport_Click);
            // 
            // 用户管理UToolStripMenuItem
            // 
            this.用户管理UToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem,
            this.角色管理ToolStripMenuItem,
            this.注销ToolStripMenuItem});
            this.用户管理UToolStripMenuItem.Name = "用户管理UToolStripMenuItem";
            this.用户管理UToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.用户管理UToolStripMenuItem.Text = "用户管理(&U)";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // 角色管理ToolStripMenuItem
            // 
            this.角色管理ToolStripMenuItem.Name = "角色管理ToolStripMenuItem";
            this.角色管理ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.角色管理ToolStripMenuItem.Text = "角色管理";
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.注销ToolStripMenuItem.Text = "注销";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // toolStripTextBoxUserInfo
            // 
            this.toolStripTextBoxUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBoxUserInfo.CausesValidation = false;
            this.toolStripTextBoxUserInfo.Name = "toolStripTextBoxUserInfo";
            this.toolStripTextBoxUserInfo.ReadOnly = true;
            this.toolStripTextBoxUserInfo.Size = new System.Drawing.Size(200, 20);
            // 
            // listViewMain
            // 
            this.listViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMain.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewMain.Location = new System.Drawing.Point(0, 24);
            this.listViewMain.Name = "listViewMain";
            this.listViewMain.Size = new System.Drawing.Size(768, 430);
            this.listViewMain.TabIndex = 1;
            this.listViewMain.UseCompatibleStateImageBehavior = false;
            // 
            // FormMainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 454);
            this.Controls.Add(this.listViewMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMainPanel";
            this.Text = "小蔡物业管理软件(陈姐特别版)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMainPanel_FormClosed);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem 客户管理CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ContractManage;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_parking;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Rooms;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_deposit;
        private System.Windows.Forms.ToolStripMenuItem 费用管理FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_addsdm;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_addfee;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_sdm;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_feelist;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_sdmbase;
        private System.Windows.Forms.ToolStripMenuItem 报表管理RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_feereport;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_print;
        private System.Windows.Forms.ToolStripMenuItem 用户管理UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 角色管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxUserInfo;
        private System.Windows.Forms.ListView listViewMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_addNewCustomer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_predcharge;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_customers;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_generate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_printcomp;


    }
}

