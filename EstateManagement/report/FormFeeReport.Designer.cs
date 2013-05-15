namespace EstateManagement.report
{
    partial class FormFeeReport
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
            System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_contractno;
            System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_comp;
            System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_roomno;
            System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_genmonth;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFeeReport));
            this.toolStripTextBox_contractno = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBox_comp = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox_room = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox_genmonth = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_showpaid = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_reset = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_modify = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_markispaid = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_print = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvFeeReport = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTRACT_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMP_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROOMNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GEN_MONTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISPAID = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DATE_PREV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_CURRENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_NEXT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FZ_FEE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FWF_FEE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WY_FEE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WL_FEE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CW_FEE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SF_FEE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DF_FEE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MQF_FEE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QITA_FEE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_FEE = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ToolStripMenuItem_search = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItem_contractno = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItem_comp = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItem_roomno = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItem_genmonth = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeeReport)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStripMenuItem_search
            // 
            ToolStripMenuItem_search.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            ToolStripMenuItem_contractno,
            ToolStripMenuItem_comp,
            ToolStripMenuItem_roomno,
            ToolStripMenuItem_genmonth,
            this.toolStripSeparator1,
            this.ToolStripMenuItem_showpaid,
            this.ToolStripMenuItem_reset});
            ToolStripMenuItem_search.Name = "ToolStripMenuItem_search";
            ToolStripMenuItem_search.Size = new System.Drawing.Size(43, 20);
            ToolStripMenuItem_search.Text = "搜索";
            // 
            // ToolStripMenuItem_contractno
            // 
            ToolStripMenuItem_contractno.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox_contractno});
            ToolStripMenuItem_contractno.Name = "ToolStripMenuItem_contractno";
            ToolStripMenuItem_contractno.Size = new System.Drawing.Size(158, 22);
            ToolStripMenuItem_contractno.Text = "合同号";
            // 
            // toolStripTextBox_contractno
            // 
            this.toolStripTextBox_contractno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox_contractno.Name = "toolStripTextBox_contractno";
            this.toolStripTextBox_contractno.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox_contractno.TextChanged += new System.EventHandler(this.toolStripTextBox_contractno_TextChanged);
            // 
            // ToolStripMenuItem_comp
            // 
            ToolStripMenuItem_comp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_comp});
            ToolStripMenuItem_comp.Name = "ToolStripMenuItem_comp";
            ToolStripMenuItem_comp.Size = new System.Drawing.Size(158, 22);
            ToolStripMenuItem_comp.Text = "公司";
            // 
            // toolStripComboBox_comp
            // 
            this.toolStripComboBox_comp.DropDownWidth = 180;
            this.toolStripComboBox_comp.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBox_comp.Name = "toolStripComboBox_comp";
            this.toolStripComboBox_comp.Size = new System.Drawing.Size(180, 23);
            this.toolStripComboBox_comp.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_comp_SelectedIndexChanged);
            this.toolStripComboBox_comp.TextChanged += new System.EventHandler(this.toolStripComboBox_comp_TextChanged);
            // 
            // ToolStripMenuItem_roomno
            // 
            ToolStripMenuItem_roomno.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox_room});
            ToolStripMenuItem_roomno.Name = "ToolStripMenuItem_roomno";
            ToolStripMenuItem_roomno.Size = new System.Drawing.Size(158, 22);
            ToolStripMenuItem_roomno.Text = "房间";
            // 
            // toolStripTextBox_room
            // 
            this.toolStripTextBox_room.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox_room.Name = "toolStripTextBox_room";
            this.toolStripTextBox_room.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox_room.TextChanged += new System.EventHandler(this.toolStripTextBox_room_TextChanged);
            // 
            // ToolStripMenuItem_genmonth
            // 
            ToolStripMenuItem_genmonth.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox_genmonth});
            ToolStripMenuItem_genmonth.Name = "ToolStripMenuItem_genmonth";
            ToolStripMenuItem_genmonth.Size = new System.Drawing.Size(158, 22);
            ToolStripMenuItem_genmonth.Text = "费用年月";
            // 
            // toolStripTextBox_genmonth
            // 
            this.toolStripTextBox_genmonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox_genmonth.Name = "toolStripTextBox_genmonth";
            this.toolStripTextBox_genmonth.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox_genmonth.TextChanged += new System.EventHandler(this.toolStripTextBox_genmonth_TextChanged);
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
            this.ToolStripMenuItem_reset.Text = "Reset";
            this.ToolStripMenuItem_reset.Click += new System.EventHandler(this.ToolStripMenuItem_reset_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_modify,
            this.ToolStripMenuItem_markispaid,
            ToolStripMenuItem_search,
            this.ToolStripMenuItem_print});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip_feereport";
            // 
            // ToolStripMenuItem_modify
            // 
            this.ToolStripMenuItem_modify.Name = "ToolStripMenuItem_modify";
            this.ToolStripMenuItem_modify.Size = new System.Drawing.Size(67, 20);
            this.ToolStripMenuItem_modify.Text = "修改记录";
            this.ToolStripMenuItem_modify.Click += new System.EventHandler(this.ToolStripMenuItem_modify_Click);
            // 
            // ToolStripMenuItem_markispaid
            // 
            this.ToolStripMenuItem_markispaid.Name = "ToolStripMenuItem_markispaid";
            this.ToolStripMenuItem_markispaid.Size = new System.Drawing.Size(91, 20);
            this.ToolStripMenuItem_markispaid.Text = "标记为已付款";
            this.ToolStripMenuItem_markispaid.Click += new System.EventHandler(this.ToolStripMenuItem_markispaid_Click);
            // 
            // ToolStripMenuItem_print
            // 
            this.ToolStripMenuItem_print.Name = "ToolStripMenuItem_print";
            this.ToolStripMenuItem_print.Size = new System.Drawing.Size(91, 20);
            this.ToolStripMenuItem_print.Text = "打印选中记录";
            this.ToolStripMenuItem_print.Click += new System.EventHandler(this.ToolStripMenuItem_print_Click);
            // 
            // dgvFeeReport
            // 
            this.dgvFeeReport.AllowUserToAddRows = false;
            this.dgvFeeReport.AllowUserToDeleteRows = false;
            this.dgvFeeReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeeReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CONTRACT_NO,
            this.COMP_NAME,
            this.ROOMNO,
            this.GEN_MONTH,
            this.ISPAID,
            this.DATE_PREV,
            this.DATE_CURRENT,
            this.DATE_NEXT,
            this.FZ_FEE,
            this.FWF_FEE,
            this.WY_FEE,
            this.WL_FEE,
            this.CW_FEE,
            this.SF_FEE,
            this.DF_FEE,
            this.MQF_FEE,
            this.QITA_FEE,
            this.TOTAL_FEE});
            this.dgvFeeReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFeeReport.Location = new System.Drawing.Point(0, 24);
            this.dgvFeeReport.Name = "dgvFeeReport";
            this.dgvFeeReport.ReadOnly = true;
            this.dgvFeeReport.Size = new System.Drawing.Size(731, 429);
            this.dgvFeeReport.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // CONTRACT_NO
            // 
            this.CONTRACT_NO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CONTRACT_NO.DataPropertyName = "CONTRACT_NO";
            this.CONTRACT_NO.HeaderText = "合同号";
            this.CONTRACT_NO.Name = "CONTRACT_NO";
            this.CONTRACT_NO.ReadOnly = true;
            this.CONTRACT_NO.Width = 63;
            // 
            // COMP_NAME
            // 
            this.COMP_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.COMP_NAME.DataPropertyName = "COMP_NAME";
            this.COMP_NAME.HeaderText = "公司";
            this.COMP_NAME.Name = "COMP_NAME";
            this.COMP_NAME.ReadOnly = true;
            this.COMP_NAME.Width = 52;
            // 
            // ROOMNO
            // 
            this.ROOMNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ROOMNO.DataPropertyName = "ROOMNO";
            this.ROOMNO.HeaderText = "房间";
            this.ROOMNO.Name = "ROOMNO";
            this.ROOMNO.ReadOnly = true;
            this.ROOMNO.Width = 52;
            // 
            // GEN_MONTH
            // 
            this.GEN_MONTH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GEN_MONTH.DataPropertyName = "GEN_MONTH";
            this.GEN_MONTH.HeaderText = "费用年月";
            this.GEN_MONTH.Name = "GEN_MONTH";
            this.GEN_MONTH.ReadOnly = true;
            this.GEN_MONTH.Width = 63;
            // 
            // ISPAID
            // 
            this.ISPAID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ISPAID.DataPropertyName = "ISPAID";
            this.ISPAID.HeaderText = "是否付款";
            this.ISPAID.Name = "ISPAID";
            this.ISPAID.ReadOnly = true;
            this.ISPAID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ISPAID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ISPAID.Width = 63;
            // 
            // DATE_PREV
            // 
            this.DATE_PREV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DATE_PREV.DataPropertyName = "DATE_PREV";
            this.DATE_PREV.HeaderText = "上期截止日期";
            this.DATE_PREV.Name = "DATE_PREV";
            this.DATE_PREV.ReadOnly = true;
            this.DATE_PREV.Width = 74;
            // 
            // DATE_CURRENT
            // 
            this.DATE_CURRENT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DATE_CURRENT.DataPropertyName = "DATE_CURRENT";
            this.DATE_CURRENT.HeaderText = "本期结算日期";
            this.DATE_CURRENT.Name = "DATE_CURRENT";
            this.DATE_CURRENT.ReadOnly = true;
            this.DATE_CURRENT.Width = 74;
            // 
            // DATE_NEXT
            // 
            this.DATE_NEXT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DATE_NEXT.DataPropertyName = "DATE_NEXT";
            this.DATE_NEXT.HeaderText = "下期起付日期";
            this.DATE_NEXT.Name = "DATE_NEXT";
            this.DATE_NEXT.ReadOnly = true;
            this.DATE_NEXT.Width = 74;
            // 
            // FZ_FEE
            // 
            this.FZ_FEE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FZ_FEE.DataPropertyName = "FZ_FEE";
            this.FZ_FEE.HeaderText = "房租";
            this.FZ_FEE.Name = "FZ_FEE";
            this.FZ_FEE.ReadOnly = true;
            this.FZ_FEE.Width = 52;
            // 
            // FWF_FEE
            // 
            this.FWF_FEE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FWF_FEE.DataPropertyName = "FWF_FEE";
            this.FWF_FEE.HeaderText = "综合技术服务费";
            this.FWF_FEE.Name = "FWF_FEE";
            this.FWF_FEE.ReadOnly = true;
            this.FWF_FEE.Width = 85;
            // 
            // WY_FEE
            // 
            this.WY_FEE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WY_FEE.DataPropertyName = "WY_FEE";
            this.WY_FEE.HeaderText = "物业费";
            this.WY_FEE.Name = "WY_FEE";
            this.WY_FEE.ReadOnly = true;
            this.WY_FEE.Width = 63;
            // 
            // WL_FEE
            // 
            this.WL_FEE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WL_FEE.DataPropertyName = "WL_FEE";
            this.WL_FEE.HeaderText = "网络费";
            this.WL_FEE.Name = "WL_FEE";
            this.WL_FEE.ReadOnly = true;
            this.WL_FEE.Width = 63;
            // 
            // CW_FEE
            // 
            this.CW_FEE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CW_FEE.DataPropertyName = "CW_FEE";
            this.CW_FEE.HeaderText = "车位费";
            this.CW_FEE.Name = "CW_FEE";
            this.CW_FEE.ReadOnly = true;
            this.CW_FEE.Width = 63;
            // 
            // SF_FEE
            // 
            this.SF_FEE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SF_FEE.DataPropertyName = "SF_FEE";
            this.SF_FEE.HeaderText = "水费";
            this.SF_FEE.Name = "SF_FEE";
            this.SF_FEE.ReadOnly = true;
            this.SF_FEE.Width = 52;
            // 
            // DF_FEE
            // 
            this.DF_FEE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DF_FEE.DataPropertyName = "DF_FEE";
            this.DF_FEE.HeaderText = "电费";
            this.DF_FEE.Name = "DF_FEE";
            this.DF_FEE.ReadOnly = true;
            this.DF_FEE.Width = 52;
            // 
            // MQF_FEE
            // 
            this.MQF_FEE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MQF_FEE.DataPropertyName = "MQF_FEE";
            this.MQF_FEE.HeaderText = "煤气费";
            this.MQF_FEE.Name = "MQF_FEE";
            this.MQF_FEE.ReadOnly = true;
            this.MQF_FEE.Width = 63;
            // 
            // QITA_FEE
            // 
            this.QITA_FEE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QITA_FEE.DataPropertyName = "QITA_FEE";
            this.QITA_FEE.HeaderText = "其他费用";
            this.QITA_FEE.Name = "QITA_FEE";
            this.QITA_FEE.ReadOnly = true;
            this.QITA_FEE.Width = 63;
            // 
            // TOTAL_FEE
            // 
            this.TOTAL_FEE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TOTAL_FEE.DataPropertyName = "TOTAL_FEE";
            this.TOTAL_FEE.HeaderText = "总计";
            this.TOTAL_FEE.Name = "TOTAL_FEE";
            this.TOTAL_FEE.ReadOnly = true;
            this.TOTAL_FEE.Width = 52;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CONTRACT_NO";
            this.dataGridViewTextBoxColumn2.HeaderText = "合同号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "COMP_NAME";
            this.dataGridViewTextBoxColumn3.HeaderText = "公司";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ROOMNO";
            this.dataGridViewTextBoxColumn4.HeaderText = "房间";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GEN_MONTH";
            this.dataGridViewTextBoxColumn5.HeaderText = "费用年月";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DATE_PREV";
            this.dataGridViewTextBoxColumn6.HeaderText = "上期截止日期";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DATE_CURRENT";
            this.dataGridViewTextBoxColumn7.HeaderText = "本期结算日期";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DATE_NEXT";
            this.dataGridViewTextBoxColumn8.HeaderText = "下期起付日期";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "FZ_FEE";
            this.dataGridViewTextBoxColumn9.HeaderText = "房租";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "FWF_FEE";
            this.dataGridViewTextBoxColumn10.HeaderText = "综合技术服务费";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "WY_FEE";
            this.dataGridViewTextBoxColumn11.HeaderText = "物业费";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "WL_FEE";
            this.dataGridViewTextBoxColumn12.HeaderText = "网络费";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "CW_FEE";
            this.dataGridViewTextBoxColumn13.HeaderText = "车位费";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "SF_FEE";
            this.dataGridViewTextBoxColumn14.HeaderText = "水费";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "DF_FEE";
            this.dataGridViewTextBoxColumn15.HeaderText = "电费";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn16.DataPropertyName = "MQF_FEE";
            this.dataGridViewTextBoxColumn16.HeaderText = "煤气费";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn17.DataPropertyName = "QITA_FEE";
            this.dataGridViewTextBoxColumn17.HeaderText = "其他费用";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn18.DataPropertyName = "TOTAL_FEE";
            this.dataGridViewTextBoxColumn18.HeaderText = "总计";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // FormFeeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 453);
            this.Controls.Add(this.dgvFeeReport);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormFeeReport";
            this.Text = "费用报表管理";
            this.Load += new System.EventHandler(this.FormFeeReport_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeeReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dgvFeeReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTRACT_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMP_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROOMNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn GEN_MONTH;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ISPAID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_PREV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_CURRENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_NEXT;
        private System.Windows.Forms.DataGridViewTextBoxColumn FZ_FEE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FWF_FEE;
        private System.Windows.Forms.DataGridViewTextBoxColumn WY_FEE;
        private System.Windows.Forms.DataGridViewTextBoxColumn WL_FEE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CW_FEE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SF_FEE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DF_FEE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MQF_FEE;
        private System.Windows.Forms.DataGridViewTextBoxColumn QITA_FEE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_FEE;
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
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_modify;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_markispaid;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_contractno;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_comp;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_room;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_genmonth;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_showpaid;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_reset;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_print;
    }
}