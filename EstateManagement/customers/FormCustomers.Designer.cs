namespace EstateManagement.customers
{
    partial class FormCustomers
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
            this.menuStrip_customers = new System.Windows.Forms.MenuStrip();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.ToolStripMenuItem_newcustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_modify = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_terminate = new System.Windows.Forms.ToolStripMenuItem();
            this.搜索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMP_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTRACT_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.START_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.END_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RENT_AREA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROOMCOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PARKINGCOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FANGZU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WUYE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUWU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WANGLUO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INTERVAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YAJIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CORP_REP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTACT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEPHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOBILE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip_customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip_customers
            // 
            this.menuStrip_customers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_newcustomer,
            this.ToolStripMenuItem_modify,
            this.ToolStripMenuItem_terminate,
            this.搜索ToolStripMenuItem});
            this.menuStrip_customers.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_customers.Name = "menuStrip_customers";
            this.menuStrip_customers.Size = new System.Drawing.Size(853, 25);
            this.menuStrip_customers.TabIndex = 0;
            this.menuStrip_customers.Text = "menuStrip1";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.COMP_NAME,
            this.CONTRACT_NO,
            this.START_DATE,
            this.END_DATE,
            this.RENT_AREA,
            this.ROOMCOUNT,
            this.PARKINGCOUNT,
            this.FANGZU,
            this.WUYE,
            this.FUWU,
            this.WANGLUO,
            this.INTERVAL,
            this.YAJIN,
            this.CORP_REP,
            this.CONTACT,
            this.TELEPHONE,
            this.MOBILE});
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.Location = new System.Drawing.Point(0, 25);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowTemplate.Height = 23;
            this.dgvCustomers.Size = new System.Drawing.Size(853, 414);
            this.dgvCustomers.TabIndex = 1;
            // 
            // ToolStripMenuItem_newcustomer
            // 
            this.ToolStripMenuItem_newcustomer.Name = "ToolStripMenuItem_newcustomer";
            this.ToolStripMenuItem_newcustomer.Size = new System.Drawing.Size(68, 21);
            this.ToolStripMenuItem_newcustomer.Text = "新增客户";
            this.ToolStripMenuItem_newcustomer.Click += new System.EventHandler(this.ToolStripMenuItem_newcustomer_Click);
            // 
            // ToolStripMenuItem_modify
            // 
            this.ToolStripMenuItem_modify.Name = "ToolStripMenuItem_modify";
            this.ToolStripMenuItem_modify.Size = new System.Drawing.Size(116, 21);
            this.ToolStripMenuItem_modify.Text = "修改选中客户信息";
            this.ToolStripMenuItem_modify.Click += new System.EventHandler(this.ToolStripMenuItem_modify_Click);
            // 
            // ToolStripMenuItem_terminate
            // 
            this.ToolStripMenuItem_terminate.Name = "ToolStripMenuItem_terminate";
            this.ToolStripMenuItem_terminate.Size = new System.Drawing.Size(116, 21);
            this.ToolStripMenuItem_terminate.Text = "终止选中客户合同";
            this.ToolStripMenuItem_terminate.Click += new System.EventHandler(this.ToolStripMenuItem_terminate_Click);
            // 
            // 搜索ToolStripMenuItem
            // 
            this.搜索ToolStripMenuItem.Name = "搜索ToolStripMenuItem";
            this.搜索ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.搜索ToolStripMenuItem.Text = "搜索";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "COMP_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "公司";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CONTRACT_NO";
            this.dataGridViewTextBoxColumn3.HeaderText = "合同号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "START_DATE";
            this.dataGridViewTextBoxColumn4.HeaderText = "合同起始日期";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "END_DATE";
            this.dataGridViewTextBoxColumn5.HeaderText = "合同终止日期";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RENT_AREA";
            this.dataGridViewTextBoxColumn6.HeaderText = "租赁面积(平方米)";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ROOMCOUNT";
            this.dataGridViewTextBoxColumn7.HeaderText = "房间数";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PARKINGCOUNT";
            this.dataGridViewTextBoxColumn8.HeaderText = "车位数";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "FANGZU";
            this.dataGridViewTextBoxColumn9.HeaderText = "月租";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "WUYE";
            this.dataGridViewTextBoxColumn10.HeaderText = "物业";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "FUWU";
            this.dataGridViewTextBoxColumn11.HeaderText = "服务费";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "WANGLUO";
            this.dataGridViewTextBoxColumn12.HeaderText = "网络";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "INTERVAL";
            this.dataGridViewTextBoxColumn13.HeaderText = "收费周期";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "YAJIN";
            this.dataGridViewTextBoxColumn14.HeaderText = "押金";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "CORP_REP";
            this.dataGridViewTextBoxColumn15.HeaderText = "法人代表";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "CONTACT";
            this.dataGridViewTextBoxColumn16.HeaderText = "联系人";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "TELEPHONE";
            this.dataGridViewTextBoxColumn17.HeaderText = "办公室电话及传真";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "MOBILE";
            this.dataGridViewTextBoxColumn18.HeaderText = "联系电话(手机)";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // COMP_NAME
            // 
            this.COMP_NAME.DataPropertyName = "COMP_NAME";
            this.COMP_NAME.HeaderText = "公司";
            this.COMP_NAME.Name = "COMP_NAME";
            this.COMP_NAME.ReadOnly = true;
            // 
            // CONTRACT_NO
            // 
            this.CONTRACT_NO.DataPropertyName = "CONTRACT_NO";
            this.CONTRACT_NO.HeaderText = "合同号";
            this.CONTRACT_NO.Name = "CONTRACT_NO";
            this.CONTRACT_NO.ReadOnly = true;
            // 
            // START_DATE
            // 
            this.START_DATE.DataPropertyName = "START_DATE";
            this.START_DATE.HeaderText = "合同起始日期";
            this.START_DATE.Name = "START_DATE";
            this.START_DATE.ReadOnly = true;
            // 
            // END_DATE
            // 
            this.END_DATE.DataPropertyName = "END_DATE";
            this.END_DATE.HeaderText = "合同终止日期";
            this.END_DATE.Name = "END_DATE";
            this.END_DATE.ReadOnly = true;
            // 
            // RENT_AREA
            // 
            this.RENT_AREA.DataPropertyName = "RENT_AREA";
            this.RENT_AREA.HeaderText = "租赁面积(平方米)";
            this.RENT_AREA.Name = "RENT_AREA";
            this.RENT_AREA.ReadOnly = true;
            // 
            // ROOMCOUNT
            // 
            this.ROOMCOUNT.DataPropertyName = "ROOMCOUNT";
            this.ROOMCOUNT.HeaderText = "房间数";
            this.ROOMCOUNT.Name = "ROOMCOUNT";
            this.ROOMCOUNT.ReadOnly = true;
            // 
            // PARKINGCOUNT
            // 
            this.PARKINGCOUNT.DataPropertyName = "PARKINGCOUNT";
            this.PARKINGCOUNT.HeaderText = "车位数";
            this.PARKINGCOUNT.Name = "PARKINGCOUNT";
            this.PARKINGCOUNT.ReadOnly = true;
            // 
            // FANGZU
            // 
            this.FANGZU.DataPropertyName = "FANGZU";
            this.FANGZU.HeaderText = "月租";
            this.FANGZU.Name = "FANGZU";
            this.FANGZU.ReadOnly = true;
            // 
            // WUYE
            // 
            this.WUYE.DataPropertyName = "WUYE";
            this.WUYE.HeaderText = "物业";
            this.WUYE.Name = "WUYE";
            this.WUYE.ReadOnly = true;
            // 
            // FUWU
            // 
            this.FUWU.DataPropertyName = "FUWU";
            this.FUWU.HeaderText = "服务费";
            this.FUWU.Name = "FUWU";
            this.FUWU.ReadOnly = true;
            // 
            // WANGLUO
            // 
            this.WANGLUO.DataPropertyName = "WANGLUO";
            this.WANGLUO.HeaderText = "网络";
            this.WANGLUO.Name = "WANGLUO";
            this.WANGLUO.ReadOnly = true;
            // 
            // INTERVAL
            // 
            this.INTERVAL.DataPropertyName = "INTERVAL";
            this.INTERVAL.HeaderText = "收费周期";
            this.INTERVAL.Name = "INTERVAL";
            this.INTERVAL.ReadOnly = true;
            // 
            // YAJIN
            // 
            this.YAJIN.DataPropertyName = "YAJIN";
            this.YAJIN.HeaderText = "押金";
            this.YAJIN.Name = "YAJIN";
            this.YAJIN.ReadOnly = true;
            // 
            // CORP_REP
            // 
            this.CORP_REP.DataPropertyName = "CORP_REP";
            this.CORP_REP.HeaderText = "法人代表";
            this.CORP_REP.Name = "CORP_REP";
            this.CORP_REP.ReadOnly = true;
            // 
            // CONTACT
            // 
            this.CONTACT.DataPropertyName = "CONTACT";
            this.CONTACT.HeaderText = "联系人";
            this.CONTACT.Name = "CONTACT";
            this.CONTACT.ReadOnly = true;
            // 
            // TELEPHONE
            // 
            this.TELEPHONE.DataPropertyName = "TELEPHONE";
            this.TELEPHONE.HeaderText = "办公室电话及传真";
            this.TELEPHONE.Name = "TELEPHONE";
            this.TELEPHONE.ReadOnly = true;
            // 
            // MOBILE
            // 
            this.MOBILE.DataPropertyName = "MOBILE";
            this.MOBILE.HeaderText = "联系电话(手机)";
            this.MOBILE.Name = "MOBILE";
            this.MOBILE.ReadOnly = true;
            // 
            // FormCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 439);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.menuStrip_customers);
            this.MainMenuStrip = this.menuStrip_customers;
            this.Name = "FormCustomers";
            this.Text = "客户信息管理";
            this.Load += new System.EventHandler(this.FormCustomers_Load);
            this.menuStrip_customers.ResumeLayout(false);
            this.menuStrip_customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_customers;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMP_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTRACT_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn START_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn END_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn RENT_AREA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROOMCOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARKINGCOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn FANGZU;
        private System.Windows.Forms.DataGridViewTextBoxColumn WUYE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUWU;
        private System.Windows.Forms.DataGridViewTextBoxColumn WANGLUO;
        private System.Windows.Forms.DataGridViewTextBoxColumn INTERVAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn YAJIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CORP_REP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTACT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEPHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOBILE;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_newcustomer;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_modify;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_terminate;
        private System.Windows.Forms.ToolStripMenuItem 搜索ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;

    }
}