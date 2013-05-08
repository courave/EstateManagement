namespace EstateManagement.charges
{
    partial class FormSdm
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
            System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_room;
            System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_type;
            System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_cbtime;
            this.toolStripComboBox_comp = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox_room = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox_type = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox_cbtime = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_showpaid = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_reset = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_sdm = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_addrecord = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_modifyrecord = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_setpaid = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvSdm = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMP_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROOM_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDM_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDM_SUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDM_CHARGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDM_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDM_CBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMMENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISPAID = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ToolStripMenuItem_search = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItem_comp = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItem_room = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItem_type = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItem_cbtime = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_sdm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSdm)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStripMenuItem_search
            // 
            ToolStripMenuItem_search.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            ToolStripMenuItem_comp,
            ToolStripMenuItem_room,
            ToolStripMenuItem_type,
            ToolStripMenuItem_cbtime,
            this.toolStripSeparator1,
            this.ToolStripMenuItem_showpaid,
            this.ToolStripMenuItem_reset});
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
            // toolStripComboBox_comp
            // 
            this.toolStripComboBox_comp.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBox_comp.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.toolStripComboBox_comp.Name = "toolStripComboBox_comp";
            this.toolStripComboBox_comp.Size = new System.Drawing.Size(121, 19);
            this.toolStripComboBox_comp.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_comp_SelectedIndexChanged);
            this.toolStripComboBox_comp.TextUpdate += new System.EventHandler(this.toolStripComboBox_comp_TextUpdate);
            // 
            // ToolStripMenuItem_room
            // 
            ToolStripMenuItem_room.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_room});
            ToolStripMenuItem_room.Name = "ToolStripMenuItem_room";
            ToolStripMenuItem_room.Size = new System.Drawing.Size(158, 22);
            ToolStripMenuItem_room.Text = "房间号";
            // 
            // toolStripComboBox_room
            // 
            this.toolStripComboBox_room.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBox_room.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.toolStripComboBox_room.Name = "toolStripComboBox_room";
            this.toolStripComboBox_room.Size = new System.Drawing.Size(121, 19);
            this.toolStripComboBox_room.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_room_SelectedIndexChanged);
            this.toolStripComboBox_room.TextUpdate += new System.EventHandler(this.toolStripComboBox_room_TextUpdate);
            // 
            // ToolStripMenuItem_type
            // 
            ToolStripMenuItem_type.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_type});
            ToolStripMenuItem_type.Name = "ToolStripMenuItem_type";
            ToolStripMenuItem_type.Size = new System.Drawing.Size(158, 22);
            ToolStripMenuItem_type.Text = "名目";
            // 
            // toolStripComboBox_type
            // 
            this.toolStripComboBox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_type.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBox_type.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.toolStripComboBox_type.Items.AddRange(new object[] {
            "水费",
            "电费",
            "煤气费"});
            this.toolStripComboBox_type.Name = "toolStripComboBox_type";
            this.toolStripComboBox_type.Size = new System.Drawing.Size(121, 19);
            this.toolStripComboBox_type.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_type_SelectedIndexChanged);
            // 
            // ToolStripMenuItem_cbtime
            // 
            ToolStripMenuItem_cbtime.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox_cbtime});
            ToolStripMenuItem_cbtime.Name = "ToolStripMenuItem_cbtime";
            ToolStripMenuItem_cbtime.Size = new System.Drawing.Size(158, 22);
            ToolStripMenuItem_cbtime.Text = "抄表时间";
            // 
            // toolStripTextBox_cbtime
            // 
            this.toolStripTextBox_cbtime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox_cbtime.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.toolStripTextBox_cbtime.Name = "toolStripTextBox_cbtime";
            this.toolStripTextBox_cbtime.Size = new System.Drawing.Size(100, 18);
            this.toolStripTextBox_cbtime.ToolTipText = ">20130612";
            this.toolStripTextBox_cbtime.TextChanged += new System.EventHandler(this.toolStripTextBox_cbtime_TextChanged);
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
            // menuStrip_sdm
            // 
            this.menuStrip_sdm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_addrecord,
            this.ToolStripMenuItem_modifyrecord,
            this.ToolStripMenuItem_setpaid,
            ToolStripMenuItem_search});
            this.menuStrip_sdm.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_sdm.Name = "menuStrip_sdm";
            this.menuStrip_sdm.Size = new System.Drawing.Size(930, 24);
            this.menuStrip_sdm.TabIndex = 0;
            this.menuStrip_sdm.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_addrecord
            // 
            this.ToolStripMenuItem_addrecord.Name = "ToolStripMenuItem_addrecord";
            this.ToolStripMenuItem_addrecord.Size = new System.Drawing.Size(67, 20);
            this.ToolStripMenuItem_addrecord.Text = "添加记录";
            this.ToolStripMenuItem_addrecord.Click += new System.EventHandler(this.ToolStripMenuItem_addrecord_Click);
            // 
            // ToolStripMenuItem_modifyrecord
            // 
            this.ToolStripMenuItem_modifyrecord.Name = "ToolStripMenuItem_modifyrecord";
            this.ToolStripMenuItem_modifyrecord.Size = new System.Drawing.Size(67, 20);
            this.ToolStripMenuItem_modifyrecord.Text = "修改记录";
            this.ToolStripMenuItem_modifyrecord.Click += new System.EventHandler(this.ToolStripMenuItem_modifyrecord_Click);
            // 
            // ToolStripMenuItem_setpaid
            // 
            this.ToolStripMenuItem_setpaid.Name = "ToolStripMenuItem_setpaid";
            this.ToolStripMenuItem_setpaid.Size = new System.Drawing.Size(91, 20);
            this.ToolStripMenuItem_setpaid.Text = "标记为已付款";
            this.ToolStripMenuItem_setpaid.Click += new System.EventHandler(this.ToolStripMenuItem_setpaid_Click);
            // 
            // dgvSdm
            // 
            this.dgvSdm.AllowUserToAddRows = false;
            this.dgvSdm.AllowUserToDeleteRows = false;
            this.dgvSdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSdm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.COMP_NAME,
            this.ROOM_NO,
            this.SDM_TYPE,
            this.SDM_SUM,
            this.SDM_CHARGE,
            this.SDM_TIME,
            this.SDM_CBER,
            this.COMMENT,
            this.ISPAID});
            this.dgvSdm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSdm.Location = new System.Drawing.Point(0, 24);
            this.dgvSdm.Name = "dgvSdm";
            this.dgvSdm.ReadOnly = true;
            this.dgvSdm.Size = new System.Drawing.Size(930, 421);
            this.dgvSdm.TabIndex = 1;
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
            // ROOM_NO
            // 
            this.ROOM_NO.DataPropertyName = "ROOM_NO";
            this.ROOM_NO.HeaderText = "房间号";
            this.ROOM_NO.Name = "ROOM_NO";
            this.ROOM_NO.ReadOnly = true;
            // 
            // SDM_TYPE
            // 
            this.SDM_TYPE.DataPropertyName = "SDM_TYPE";
            this.SDM_TYPE.HeaderText = "名目";
            this.SDM_TYPE.Name = "SDM_TYPE";
            this.SDM_TYPE.ReadOnly = true;
            // 
            // SDM_SUM
            // 
            this.SDM_SUM.DataPropertyName = "SDM_SUM";
            this.SDM_SUM.HeaderText = "抄表数";
            this.SDM_SUM.Name = "SDM_SUM";
            this.SDM_SUM.ReadOnly = true;
            // 
            // SDM_CHARGE
            // 
            this.SDM_CHARGE.DataPropertyName = "SDM_CHARGE";
            this.SDM_CHARGE.HeaderText = "金额";
            this.SDM_CHARGE.Name = "SDM_CHARGE";
            this.SDM_CHARGE.ReadOnly = true;
            // 
            // SDM_TIME
            // 
            this.SDM_TIME.DataPropertyName = "SDM_TIME";
            this.SDM_TIME.HeaderText = "抄表时间";
            this.SDM_TIME.Name = "SDM_TIME";
            this.SDM_TIME.ReadOnly = true;
            // 
            // SDM_CBER
            // 
            this.SDM_CBER.DataPropertyName = "SDM_CBER";
            this.SDM_CBER.HeaderText = "抄表员";
            this.SDM_CBER.Name = "SDM_CBER";
            this.SDM_CBER.ReadOnly = true;
            // 
            // COMMENT
            // 
            this.COMMENT.DataPropertyName = "COMMENT";
            this.COMMENT.HeaderText = "备注";
            this.COMMENT.Name = "COMMENT";
            this.COMMENT.ReadOnly = true;
            // 
            // ISPAID
            // 
            this.ISPAID.DataPropertyName = "ISPAID";
            this.ISPAID.FalseValue = "是";
            this.ISPAID.HeaderText = "是否付款";
            this.ISPAID.Name = "ISPAID";
            this.ISPAID.ReadOnly = true;
            this.ISPAID.TrueValue = "否";
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "COMP_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "公司";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ROOM_NO";
            this.dataGridViewTextBoxColumn3.HeaderText = "房间号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SDM_TYPE";
            this.dataGridViewTextBoxColumn4.HeaderText = "名目";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SDM_SUM";
            this.dataGridViewTextBoxColumn5.HeaderText = "抄表数";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SDM_CHARGE";
            this.dataGridViewTextBoxColumn6.HeaderText = "金额";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SDM_TIME";
            this.dataGridViewTextBoxColumn7.HeaderText = "抄表时间";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SDM_CBER";
            this.dataGridViewTextBoxColumn8.HeaderText = "抄表员";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "COMMENT";
            this.dataGridViewTextBoxColumn9.HeaderText = "备注";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // FormSdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 445);
            this.Controls.Add(this.dgvSdm);
            this.Controls.Add(this.menuStrip_sdm);
            this.MainMenuStrip = this.menuStrip_sdm;
            this.Name = "FormSdm";
            this.Text = "水电煤费用列表";
            this.Load += new System.EventHandler(this.FormSdm_Load);
            this.menuStrip_sdm.ResumeLayout(false);
            this.menuStrip_sdm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSdm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_sdm;
        private System.Windows.Forms.DataGridView dgvSdm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMP_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROOM_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDM_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDM_SUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDM_CHARGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDM_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDM_CBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMMENT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ISPAID;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_addrecord;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_modifyrecord;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_setpaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_comp;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_room;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_type;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_cbtime;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_showpaid;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_reset;

    }
}