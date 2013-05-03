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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_ContractManage = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_parking = new System.Windows.Forms.ToolStripMenuItem();
            this.房间管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.押金管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.固定资费设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.费用管理FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水电煤录入按房间号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.其他费用录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水电煤费用列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.其他费用列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水电煤基数管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报表管理RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.费用报表管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印当月报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStripMain.Size = new System.Drawing.Size(768, 27);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // 客户管理CToolStripMenuItem
            // 
            this.客户管理CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_addNewCustomer,
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.ToolStripMenuItem_ContractManage,
            this.ToolStripMenuItem_parking,
            this.房间管理ToolStripMenuItem,
            this.押金管理ToolStripMenuItem,
            this.固定资费设置ToolStripMenuItem});
            this.客户管理CToolStripMenuItem.Name = "客户管理CToolStripMenuItem";
            this.客户管理CToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.客户管理CToolStripMenuItem.Text = "客户管理(&C)";
            // 
            // toolStripMenuItem_addNewCustomer
            // 
            this.toolStripMenuItem_addNewCustomer.Name = "toolStripMenuItem_addNewCustomer";
            this.toolStripMenuItem_addNewCustomer.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem_addNewCustomer.Text = "添加一个新的客户";
            this.toolStripMenuItem_addNewCustomer.Click += new System.EventHandler(this.toolStripMenuItem_addNewCustomer_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem1.Text = "客户信息管理";
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
            // 房间管理ToolStripMenuItem
            // 
            this.房间管理ToolStripMenuItem.Name = "房间管理ToolStripMenuItem";
            this.房间管理ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.房间管理ToolStripMenuItem.Text = "房间管理";
            // 
            // 押金管理ToolStripMenuItem
            // 
            this.押金管理ToolStripMenuItem.Name = "押金管理ToolStripMenuItem";
            this.押金管理ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.押金管理ToolStripMenuItem.Text = "押金管理";
            // 
            // 固定资费设置ToolStripMenuItem
            // 
            this.固定资费设置ToolStripMenuItem.Name = "固定资费设置ToolStripMenuItem";
            this.固定资费设置ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.固定资费设置ToolStripMenuItem.Text = "固定资费预设置";
            // 
            // 费用管理FToolStripMenuItem
            // 
            this.费用管理FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.水电煤录入按房间号ToolStripMenuItem,
            this.其他费用录入ToolStripMenuItem,
            this.水电煤费用列表ToolStripMenuItem,
            this.其他费用列表ToolStripMenuItem,
            this.水电煤基数管理ToolStripMenuItem});
            this.费用管理FToolStripMenuItem.Name = "费用管理FToolStripMenuItem";
            this.费用管理FToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
            this.费用管理FToolStripMenuItem.Text = "费用管理(&F)";
            // 
            // 水电煤录入按房间号ToolStripMenuItem
            // 
            this.水电煤录入按房间号ToolStripMenuItem.Name = "水电煤录入按房间号ToolStripMenuItem";
            this.水电煤录入按房间号ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.水电煤录入按房间号ToolStripMenuItem.Text = "水电煤录入(按房间号)";
            // 
            // 其他费用录入ToolStripMenuItem
            // 
            this.其他费用录入ToolStripMenuItem.Name = "其他费用录入ToolStripMenuItem";
            this.其他费用录入ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.其他费用录入ToolStripMenuItem.Text = "其他费用录入";
            // 
            // 水电煤费用列表ToolStripMenuItem
            // 
            this.水电煤费用列表ToolStripMenuItem.Name = "水电煤费用列表ToolStripMenuItem";
            this.水电煤费用列表ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.水电煤费用列表ToolStripMenuItem.Text = "水电煤费用列表";
            // 
            // 其他费用列表ToolStripMenuItem
            // 
            this.其他费用列表ToolStripMenuItem.Name = "其他费用列表ToolStripMenuItem";
            this.其他费用列表ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.其他费用列表ToolStripMenuItem.Text = "其他费用列表";
            // 
            // 水电煤基数管理ToolStripMenuItem
            // 
            this.水电煤基数管理ToolStripMenuItem.Name = "水电煤基数管理ToolStripMenuItem";
            this.水电煤基数管理ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.水电煤基数管理ToolStripMenuItem.Text = "水电煤基数管理";
            // 
            // 报表管理RToolStripMenuItem
            // 
            this.报表管理RToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.费用报表管理ToolStripMenuItem,
            this.打印当月报表ToolStripMenuItem});
            this.报表管理RToolStripMenuItem.Name = "报表管理RToolStripMenuItem";
            this.报表管理RToolStripMenuItem.Size = new System.Drawing.Size(82, 23);
            this.报表管理RToolStripMenuItem.Text = "报表管理(&R)";
            // 
            // 费用报表管理ToolStripMenuItem
            // 
            this.费用报表管理ToolStripMenuItem.Name = "费用报表管理ToolStripMenuItem";
            this.费用报表管理ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.费用报表管理ToolStripMenuItem.Text = "费用报表管理";
            // 
            // 打印当月报表ToolStripMenuItem
            // 
            this.打印当月报表ToolStripMenuItem.Name = "打印当月报表ToolStripMenuItem";
            this.打印当月报表ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.打印当月报表ToolStripMenuItem.Text = "打印当月报表";
            // 
            // 用户管理UToolStripMenuItem
            // 
            this.用户管理UToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem,
            this.角色管理ToolStripMenuItem,
            this.注销ToolStripMenuItem});
            this.用户管理UToolStripMenuItem.Name = "用户管理UToolStripMenuItem";
            this.用户管理UToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
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
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
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
            this.toolStripTextBoxUserInfo.Name = "toolStripTextBoxUserInfo";
            this.toolStripTextBoxUserInfo.ReadOnly = true;
            this.toolStripTextBoxUserInfo.Size = new System.Drawing.Size(200, 23);
            // 
            // listViewMain
            // 
            this.listViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMain.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewMain.Location = new System.Drawing.Point(0, 27);
            this.listViewMain.Name = "listViewMain";
            this.listViewMain.Size = new System.Drawing.Size(768, 427);
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
        private System.Windows.Forms.ToolStripMenuItem 房间管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 押金管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 费用管理FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水电煤录入按房间号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 其他费用录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水电煤费用列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 其他费用列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水电煤基数管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 报表管理RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 费用报表管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印当月报表ToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem 固定资费设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;


    }
}

