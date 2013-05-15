namespace EstateManagement.customers
{
    partial class ContractList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractList));
            this.splitContainer_contract = new System.Windows.Forms.SplitContainer();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_showterminate = new System.Windows.Forms.Button();
            this.button_terminate = new System.Windows.Forms.Button();
            this.dgvContract = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMP_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTRACT_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.START_DATE = new CalendarColumn();
            this.END_DATE = new CalendarColumn();
            this.RENT_AREA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CORP_REP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTACT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEPHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOBILE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAPITAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLACE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAX_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IC_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORG_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORY = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MAIN_BUZZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendarColumn1 = new CalendarColumn();
            this.calendarColumn2 = new CalendarColumn();
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
            this.splitContainer_contract.Panel1.SuspendLayout();
            this.splitContainer_contract.Panel2.SuspendLayout();
            this.splitContainer_contract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer_contract
            // 
            this.splitContainer_contract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_contract.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_contract.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_contract.Name = "splitContainer_contract";
            this.splitContainer_contract.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_contract.Panel1
            // 
            this.splitContainer_contract.Panel1.Controls.Add(this.button_search);
            this.splitContainer_contract.Panel1.Controls.Add(this.textBox_search);
            this.splitContainer_contract.Panel1.Controls.Add(this.button_showterminate);
            this.splitContainer_contract.Panel1.Controls.Add(this.button_terminate);
            // 
            // splitContainer_contract.Panel2
            // 
            this.splitContainer_contract.Panel2.Controls.Add(this.dgvContract);
            this.splitContainer_contract.Size = new System.Drawing.Size(793, 460);
            this.splitContainer_contract.SplitterDistance = 40;
            this.splitContainer_contract.TabIndex = 0;
            // 
            // button_search
            // 
            this.button_search.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_search.Location = new System.Drawing.Point(250, 0);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 40);
            this.button_search.TabIndex = 2;
            this.button_search.Text = "搜索";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.AcceptsReturn = true;
            this.textBox_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_search.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_search.Location = new System.Drawing.Point(75, 0);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(175, 35);
            this.textBox_search.TabIndex = 1;
            this.textBox_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_search_KeyDown);
            // 
            // button_showterminate
            // 
            this.button_showterminate.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_showterminate.Location = new System.Drawing.Point(718, 0);
            this.button_showterminate.Name = "button_showterminate";
            this.button_showterminate.Size = new System.Drawing.Size(75, 40);
            this.button_showterminate.TabIndex = 0;
            this.button_showterminate.Text = "显示已终止的合同";
            this.button_showterminate.UseVisualStyleBackColor = true;
            this.button_showterminate.Click += new System.EventHandler(this.button_showterminate_Click);
            // 
            // button_terminate
            // 
            this.button_terminate.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_terminate.Location = new System.Drawing.Point(0, 0);
            this.button_terminate.Name = "button_terminate";
            this.button_terminate.Size = new System.Drawing.Size(75, 40);
            this.button_terminate.TabIndex = 0;
            this.button_terminate.Text = "终止所选中的合同";
            this.button_terminate.UseVisualStyleBackColor = true;
            this.button_terminate.Click += new System.EventHandler(this.button_terminate_Click);
            // 
            // dgvContract
            // 
            this.dgvContract.AllowUserToAddRows = false;
            this.dgvContract.AllowUserToDeleteRows = false;
            this.dgvContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContract.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.COMP_NAME,
            this.CONTRACT_NO,
            this.START_DATE,
            this.END_DATE,
            this.RENT_AREA,
            this.CORP_REP,
            this.CONTACT,
            this.TELEPHONE,
            this.MOBILE,
            this.CAPITAL,
            this.PLACE,
            this.TAX_ID,
            this.IC_ID,
            this.ORG_CODE,
            this.CATEGORY,
            this.MAIN_BUZZ});
            this.dgvContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContract.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvContract.Location = new System.Drawing.Point(0, 0);
            this.dgvContract.Name = "dgvContract";
            this.dgvContract.Size = new System.Drawing.Size(793, 416);
            this.dgvContract.TabIndex = 0;
            this.dgvContract.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContract_CellEndEdit);
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
            this.COMP_NAME.HeaderText = "公司名称";
            this.COMP_NAME.Name = "COMP_NAME";
            // 
            // CONTRACT_NO
            // 
            this.CONTRACT_NO.DataPropertyName = "CONTRACT_NO";
            this.CONTRACT_NO.HeaderText = "合同号";
            this.CONTRACT_NO.Name = "CONTRACT_NO";
            // 
            // START_DATE
            // 
            this.START_DATE.DataPropertyName = "START_DATE";
            this.START_DATE.HeaderText = "合同起始日期";
            this.START_DATE.Name = "START_DATE";
            this.START_DATE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.START_DATE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // END_DATE
            // 
            this.END_DATE.DataPropertyName = "END_DATE";
            this.END_DATE.HeaderText = "合同结束日期";
            this.END_DATE.Name = "END_DATE";
            this.END_DATE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.END_DATE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // RENT_AREA
            // 
            this.RENT_AREA.DataPropertyName = "RENT_AREA";
            this.RENT_AREA.HeaderText = "租赁面积";
            this.RENT_AREA.Name = "RENT_AREA";
            // 
            // CORP_REP
            // 
            this.CORP_REP.DataPropertyName = "CORP_REP";
            this.CORP_REP.HeaderText = "法人代表";
            this.CORP_REP.Name = "CORP_REP";
            // 
            // CONTACT
            // 
            this.CONTACT.DataPropertyName = "CONTACT";
            this.CONTACT.HeaderText = "联系人";
            this.CONTACT.Name = "CONTACT";
            // 
            // TELEPHONE
            // 
            this.TELEPHONE.DataPropertyName = "TELEPHONE";
            this.TELEPHONE.HeaderText = "办公室电话及传真";
            this.TELEPHONE.Name = "TELEPHONE";
            // 
            // MOBILE
            // 
            this.MOBILE.DataPropertyName = "MOBILE";
            this.MOBILE.HeaderText = "手机";
            this.MOBILE.Name = "MOBILE";
            // 
            // CAPITAL
            // 
            this.CAPITAL.DataPropertyName = "CAPITAL";
            this.CAPITAL.HeaderText = "注册资金";
            this.CAPITAL.Name = "CAPITAL";
            // 
            // PLACE
            // 
            this.PLACE.DataPropertyName = "PLACE";
            this.PLACE.HeaderText = "注册地";
            this.PLACE.Name = "PLACE";
            // 
            // TAX_ID
            // 
            this.TAX_ID.DataPropertyName = "TAX_ID";
            this.TAX_ID.HeaderText = "税务登记号";
            this.TAX_ID.Name = "TAX_ID";
            // 
            // IC_ID
            // 
            this.IC_ID.DataPropertyName = "IC_ID";
            this.IC_ID.HeaderText = "工商注册号";
            this.IC_ID.Name = "IC_ID";
            // 
            // ORG_CODE
            // 
            this.ORG_CODE.DataPropertyName = "ORG_CODE";
            this.ORG_CODE.HeaderText = "组织机构代码";
            this.ORG_CODE.Name = "ORG_CODE";
            // 
            // CATEGORY
            // 
            this.CATEGORY.DataPropertyName = "CATEGORY";
            this.CATEGORY.HeaderText = "产业类别";
            this.CATEGORY.Items.AddRange(new object[] {
            "工业",
            "商业",
            "服务业"});
            this.CATEGORY.Name = "CATEGORY";
            // 
            // MAIN_BUZZ
            // 
            this.MAIN_BUZZ.DataPropertyName = "MAIN_BUZZ";
            this.MAIN_BUZZ.HeaderText = "主营业务";
            this.MAIN_BUZZ.Name = "MAIN_BUZZ";
            this.MAIN_BUZZ.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MAIN_BUZZ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "公司名称";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "合同号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // calendarColumn1
            // 
            this.calendarColumn1.HeaderText = "合同起始日期";
            this.calendarColumn1.Name = "calendarColumn1";
            this.calendarColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.calendarColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // calendarColumn2
            // 
            this.calendarColumn2.HeaderText = "合同结束日期";
            this.calendarColumn2.Name = "calendarColumn2";
            this.calendarColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.calendarColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "租赁面积";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "法人代表";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "联系人";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "办公室电话及传真";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "手机";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "注册资金";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "注册地";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "税务登记号";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "工商注册号";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "组织机构代码";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "主营业务";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "备注";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // ContractList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 460);
            this.Controls.Add(this.splitContainer_contract);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContractList";
            this.Text = "合同管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContractList_FormClosing);
            this.Load += new System.EventHandler(this.ContractList_Load);
            this.splitContainer_contract.Panel1.ResumeLayout(false);
            this.splitContainer_contract.Panel1.PerformLayout();
            this.splitContainer_contract.Panel2.ResumeLayout(false);
            this.splitContainer_contract.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_contract;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private CalendarColumn calendarColumn1;
        private CalendarColumn calendarColumn2;
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
        private System.Windows.Forms.DataGridView dgvContract;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_showterminate;
        private System.Windows.Forms.Button button_terminate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMP_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTRACT_NO;
        private CalendarColumn START_DATE;
        private CalendarColumn END_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn RENT_AREA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CORP_REP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTACT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEPHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOBILE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAPITAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLACE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAX_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IC_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORG_CODE;
        private System.Windows.Forms.DataGridViewComboBoxColumn CATEGORY;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAIN_BUZZ;
    }
}