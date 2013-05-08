namespace EstateManagement.charges
{
    partial class FormFee
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
            System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_search;
            System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_comp;
            System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_type;
            System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_lastend;
            System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_nextstart;
            System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_genmonth;
            this.menuStrip_fee = new System.Windows.Forms.MenuStrip();
            this.dgvFee = new System.Windows.Forms.DataGridView();
            this.ISPAID = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ToolStripMenuItem_add = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_modify = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_setpaid = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_showpaid = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_reset = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_comp = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox_type = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox_lastend = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox_nextstart = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox_genmonth = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMP_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FEE_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FEE_CHARGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAST_END = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUR_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NEXT_START = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMMENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GEN_MONTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolStripMenuItem_showall = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItem_search = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItem_comp = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItem_type = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItem_lastend = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItem_nextstart = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItem_genmonth = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_fee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFee)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip_fee
            // 
            this.menuStrip_fee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_add,
            this.ToolStripMenuItem_modify,
            this.ToolStripMenuItem_setpaid,
            ToolStripMenuItem_search});
            this.menuStrip_fee.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_fee.Name = "menuStrip_fee";
            this.menuStrip_fee.Size = new System.Drawing.Size(821, 24);
            this.menuStrip_fee.TabIndex = 0;
            this.menuStrip_fee.Text = "menuStrip1";
            // 
            // dgvFee
            // 
            this.dgvFee.AllowUserToAddRows = false;
            this.dgvFee.AllowUserToDeleteRows = false;
            this.dgvFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.COMP_NAME,
            this.FEE_TYPE,
            this.FEE_CHARGE,
            this.LAST_END,
            this.CUR_DATE,
            this.NEXT_START,
            this.COMMENT,
            this.GEN_MONTH,
            this.ISPAID});
            this.dgvFee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFee.Location = new System.Drawing.Point(0, 24);
            this.dgvFee.Name = "dgvFee";
            this.dgvFee.ReadOnly = true;
            this.dgvFee.Size = new System.Drawing.Size(821, 450);
            this.dgvFee.TabIndex = 1;
            // 
            // ISPAID
            // 
            this.ISPAID.DataPropertyName = "ISPAID";
            this.ISPAID.HeaderText = "是否付款";
            this.ISPAID.Name = "ISPAID";
            this.ISPAID.ReadOnly = true;
            this.ISPAID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ISPAID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ToolStripMenuItem_add
            // 
            this.ToolStripMenuItem_add.Name = "ToolStripMenuItem_add";
            this.ToolStripMenuItem_add.Size = new System.Drawing.Size(67, 20);
            this.ToolStripMenuItem_add.Text = "添加记录";
            this.ToolStripMenuItem_add.Click += new System.EventHandler(this.ToolStripMenuItem_add_Click);
            // 
            // ToolStripMenuItem_modify
            // 
            this.ToolStripMenuItem_modify.Name = "ToolStripMenuItem_modify";
            this.ToolStripMenuItem_modify.Size = new System.Drawing.Size(67, 20);
            this.ToolStripMenuItem_modify.Text = "修改记录";
            this.ToolStripMenuItem_modify.Click += new System.EventHandler(this.ToolStripMenuItem_modify_Click);
            // 
            // ToolStripMenuItem_setpaid
            // 
            this.ToolStripMenuItem_setpaid.Name = "ToolStripMenuItem_setpaid";
            this.ToolStripMenuItem_setpaid.Size = new System.Drawing.Size(91, 20);
            this.ToolStripMenuItem_setpaid.Text = "标记为已付款";
            this.ToolStripMenuItem_setpaid.Click += new System.EventHandler(this.ToolStripMenuItem_setpaid_Click);
            // 
            // ToolStripMenuItem_search
            // 
            ToolStripMenuItem_search.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            ToolStripMenuItem_comp,
            ToolStripMenuItem_type,
            ToolStripMenuItem_lastend,
            ToolStripMenuItem_nextstart,
            ToolStripMenuItem_genmonth,
            this.toolStripSeparator1,
            this.ToolStripMenuItem_showpaid,
            this.ToolStripMenuItem_reset,
            this.ToolStripMenuItem_showall});
            ToolStripMenuItem_search.Name = "ToolStripMenuItem_search";
            ToolStripMenuItem_search.Size = new System.Drawing.Size(43, 20);
            ToolStripMenuItem_search.Text = "搜索";
            // 
            // ToolStripMenuItem_comp
            // 
            ToolStripMenuItem_comp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_comp});
            ToolStripMenuItem_comp.Name = "ToolStripMenuItem_comp";
            ToolStripMenuItem_comp.Size = new System.Drawing.Size(158, 22);
            ToolStripMenuItem_comp.Text = "公司";
            // 
            // ToolStripMenuItem_type
            // 
            ToolStripMenuItem_type.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_type});
            ToolStripMenuItem_type.Name = "ToolStripMenuItem_type";
            ToolStripMenuItem_type.Size = new System.Drawing.Size(158, 22);
            ToolStripMenuItem_type.Text = "名目";
            // 
            // ToolStripMenuItem_lastend
            // 
            ToolStripMenuItem_lastend.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox_lastend});
            ToolStripMenuItem_lastend.Name = "ToolStripMenuItem_lastend";
            ToolStripMenuItem_lastend.Size = new System.Drawing.Size(158, 22);
            ToolStripMenuItem_lastend.Text = "上期截止日期";
            // 
            // ToolStripMenuItem_nextstart
            // 
            ToolStripMenuItem_nextstart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox_nextstart});
            ToolStripMenuItem_nextstart.Name = "ToolStripMenuItem_nextstart";
            ToolStripMenuItem_nextstart.Size = new System.Drawing.Size(158, 22);
            ToolStripMenuItem_nextstart.Text = "下期开始日期";
            // 
            // ToolStripMenuItem_genmonth
            // 
            ToolStripMenuItem_genmonth.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox_genmonth});
            ToolStripMenuItem_genmonth.Name = "ToolStripMenuItem_genmonth";
            ToolStripMenuItem_genmonth.Size = new System.Drawing.Size(158, 22);
            ToolStripMenuItem_genmonth.Text = "生成年月";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // ToolStripMenuItem_showpaid
            // 
            this.ToolStripMenuItem_showpaid.Name = "ToolStripMenuItem_showpaid";
            this.ToolStripMenuItem_showpaid.Size = new System.Drawing.Size(158, 22);
            this.ToolStripMenuItem_showpaid.Text = "显示已付款项目";
            this.ToolStripMenuItem_showpaid.Click += new System.EventHandler(this.ToolStripMenuItem_showpaid_Click);
            // 
            // ToolStripMenuItem_reset
            // 
            this.ToolStripMenuItem_reset.Name = "ToolStripMenuItem_reset";
            this.ToolStripMenuItem_reset.Size = new System.Drawing.Size(158, 22);
            this.ToolStripMenuItem_reset.Text = "reset";
            this.ToolStripMenuItem_reset.Click += new System.EventHandler(this.ToolStripMenuItem_reset_Click);
            // 
            // toolStripComboBox_comp
            // 
            this.toolStripComboBox_comp.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBox_comp.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.toolStripComboBox_comp.Name = "toolStripComboBox_comp";
            this.toolStripComboBox_comp.Size = new System.Drawing.Size(121, 19);
            this.toolStripComboBox_comp.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_comp_SelectedIndexChanged);
            this.toolStripComboBox_comp.TextUpdate += new System.EventHandler(this.toolStripComboBox_comp_TextUpdate);
            // 
            // toolStripComboBox_type
            // 
            this.toolStripComboBox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_type.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBox_type.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.toolStripComboBox_type.Name = "toolStripComboBox_type";
            this.toolStripComboBox_type.Size = new System.Drawing.Size(121, 19);
            this.toolStripComboBox_type.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_type_SelectedIndexChanged);
            // 
            // toolStripTextBox_lastend
            // 
            this.toolStripTextBox_lastend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox_lastend.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.toolStripTextBox_lastend.Name = "toolStripTextBox_lastend";
            this.toolStripTextBox_lastend.Size = new System.Drawing.Size(100, 18);
            this.toolStripTextBox_lastend.ToolTipText = ">20130521";
            this.toolStripTextBox_lastend.TextChanged += new System.EventHandler(this.toolStripTextBox_lastend_TextChanged);
            // 
            // toolStripTextBox_nextstart
            // 
            this.toolStripTextBox_nextstart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox_nextstart.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.toolStripTextBox_nextstart.Name = "toolStripTextBox_nextstart";
            this.toolStripTextBox_nextstart.Size = new System.Drawing.Size(100, 18);
            this.toolStripTextBox_nextstart.ToolTipText = "<20130521";
            this.toolStripTextBox_nextstart.TextChanged += new System.EventHandler(this.toolStripTextBox_nextstart_TextChanged);
            // 
            // toolStripTextBox_genmonth
            // 
            this.toolStripTextBox_genmonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox_genmonth.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.toolStripTextBox_genmonth.Name = "toolStripTextBox_genmonth";
            this.toolStripTextBox_genmonth.Size = new System.Drawing.Size(100, 18);
            this.toolStripTextBox_genmonth.ToolTipText = "20130923";
            this.toolStripTextBox_genmonth.TextChanged += new System.EventHandler(this.toolStripTextBox_genmonth_TextChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "COMP_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "公司";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 56;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FEE_TYPE";
            this.dataGridViewTextBoxColumn3.HeaderText = "名目";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FEE_CHARGE";
            this.dataGridViewTextBoxColumn4.HeaderText = "金额";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LAST_END";
            this.dataGridViewTextBoxColumn5.HeaderText = "上期截止日期";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 74;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CUR_DATE";
            this.dataGridViewTextBoxColumn6.HeaderText = "本期结算日期";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 74;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NEXT_START";
            this.dataGridViewTextBoxColumn7.HeaderText = "下期开始日期";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 74;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "COMMENT";
            this.dataGridViewTextBoxColumn8.HeaderText = "备注";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "GEN_MONTH";
            this.dataGridViewTextBoxColumn9.HeaderText = "生成年月";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
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
            this.COMP_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.COMP_NAME.DataPropertyName = "COMP_NAME";
            this.COMP_NAME.HeaderText = "公司";
            this.COMP_NAME.Name = "COMP_NAME";
            this.COMP_NAME.ReadOnly = true;
            this.COMP_NAME.Width = 56;
            // 
            // FEE_TYPE
            // 
            this.FEE_TYPE.DataPropertyName = "FEE_TYPE";
            this.FEE_TYPE.HeaderText = "名目";
            this.FEE_TYPE.Name = "FEE_TYPE";
            this.FEE_TYPE.ReadOnly = true;
            // 
            // FEE_CHARGE
            // 
            this.FEE_CHARGE.DataPropertyName = "FEE_CHARGE";
            this.FEE_CHARGE.HeaderText = "金额";
            this.FEE_CHARGE.Name = "FEE_CHARGE";
            this.FEE_CHARGE.ReadOnly = true;
            // 
            // LAST_END
            // 
            this.LAST_END.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LAST_END.DataPropertyName = "LAST_END";
            this.LAST_END.HeaderText = "上期截止日期";
            this.LAST_END.Name = "LAST_END";
            this.LAST_END.ReadOnly = true;
            this.LAST_END.Width = 74;
            // 
            // CUR_DATE
            // 
            this.CUR_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CUR_DATE.DataPropertyName = "CUR_DATE";
            this.CUR_DATE.HeaderText = "本期结算日期";
            this.CUR_DATE.Name = "CUR_DATE";
            this.CUR_DATE.ReadOnly = true;
            this.CUR_DATE.Width = 74;
            // 
            // NEXT_START
            // 
            this.NEXT_START.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NEXT_START.DataPropertyName = "NEXT_START";
            this.NEXT_START.HeaderText = "下期开始日期";
            this.NEXT_START.Name = "NEXT_START";
            this.NEXT_START.ReadOnly = true;
            this.NEXT_START.Width = 74;
            // 
            // COMMENT
            // 
            this.COMMENT.DataPropertyName = "COMMENT";
            this.COMMENT.HeaderText = "备注";
            this.COMMENT.Name = "COMMENT";
            this.COMMENT.ReadOnly = true;
            // 
            // GEN_MONTH
            // 
            this.GEN_MONTH.DataPropertyName = "GEN_MONTH";
            this.GEN_MONTH.HeaderText = "生成年月";
            this.GEN_MONTH.Name = "GEN_MONTH";
            this.GEN_MONTH.ReadOnly = true;
            // 
            // ToolStripMenuItem_showall
            // 
            this.ToolStripMenuItem_showall.Name = "ToolStripMenuItem_showall";
            this.ToolStripMenuItem_showall.Size = new System.Drawing.Size(158, 22);
            this.ToolStripMenuItem_showall.Text = "显示所有";
            this.ToolStripMenuItem_showall.Click += new System.EventHandler(this.ToolStripMenuItem_showall_Click);
            // 
            // FormFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 474);
            this.Controls.Add(this.dgvFee);
            this.Controls.Add(this.menuStrip_fee);
            this.MainMenuStrip = this.menuStrip_fee;
            this.Name = "FormFee";
            this.Text = "费用列表";
            this.menuStrip_fee.ResumeLayout(false);
            this.menuStrip_fee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_fee;
        private System.Windows.Forms.DataGridView dgvFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMP_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FEE_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FEE_CHARGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn LAST_END;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUR_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NEXT_START;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMMENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GEN_MONTH;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ISPAID;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_add;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_modify;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_setpaid;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_showpaid;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_reset;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_comp;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_type;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_lastend;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_nextstart;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_genmonth;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_showall;
    }
}