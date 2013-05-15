namespace EstateManagement.customers
{
    partial class DepositInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositInfo));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_return = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.checkBox_returned = new System.Windows.Forms.CheckBox();
            this.checkBox_terminate = new System.Windows.Forms.CheckBox();
            this.checkBox_daoqi = new System.Windows.Forms.CheckBox();
            this.dgvDeposit = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMP_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RETURNED = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MODIFY_COMMENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposit)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button_return);
            this.splitContainer1.Panel1.Controls.Add(this.button_search);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_search);
            this.splitContainer1.Panel1.Controls.Add(this.checkBox_returned);
            this.splitContainer1.Panel1.Controls.Add(this.checkBox_terminate);
            this.splitContainer1.Panel1.Controls.Add(this.checkBox_daoqi);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDeposit);
            this.splitContainer1.Size = new System.Drawing.Size(498, 417);
            this.splitContainer1.SplitterDistance = 34;
            this.splitContainer1.TabIndex = 0;
            // 
            // button_return
            // 
            this.button_return.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_return.Location = new System.Drawing.Point(435, 0);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(63, 34);
            this.button_return.TabIndex = 3;
            this.button_return.Text = "归还选中押金";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // button_search
            // 
            this.button_search.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_search.Location = new System.Drawing.Point(286, 0);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(63, 34);
            this.button_search.TabIndex = 2;
            this.button_search.Text = "搜索";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.AcceptsReturn = true;
            this.textBox_search.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox_search.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_search.Location = new System.Drawing.Point(186, 0);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(100, 29);
            this.textBox_search.TabIndex = 1;
            this.textBox_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_search_KeyDown);
            // 
            // checkBox_returned
            // 
            this.checkBox_returned.AutoSize = true;
            this.checkBox_returned.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox_returned.Location = new System.Drawing.Point(124, 0);
            this.checkBox_returned.Name = "checkBox_returned";
            this.checkBox_returned.Size = new System.Drawing.Size(62, 34);
            this.checkBox_returned.TabIndex = 0;
            this.checkBox_returned.Text = "未归还";
            this.checkBox_returned.UseVisualStyleBackColor = true;
            this.checkBox_returned.CheckedChanged += new System.EventHandler(this.checkBox_returned_CheckedChanged);
            // 
            // checkBox_terminate
            // 
            this.checkBox_terminate.AutoSize = true;
            this.checkBox_terminate.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox_terminate.Location = new System.Drawing.Point(62, 0);
            this.checkBox_terminate.Name = "checkBox_terminate";
            this.checkBox_terminate.Size = new System.Drawing.Size(62, 34);
            this.checkBox_terminate.TabIndex = 0;
            this.checkBox_terminate.Text = "已终止";
            this.checkBox_terminate.UseVisualStyleBackColor = true;
            this.checkBox_terminate.CheckedChanged += new System.EventHandler(this.checkBox_terminate_CheckedChanged);
            // 
            // checkBox_daoqi
            // 
            this.checkBox_daoqi.AutoSize = true;
            this.checkBox_daoqi.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox_daoqi.Location = new System.Drawing.Point(0, 0);
            this.checkBox_daoqi.Name = "checkBox_daoqi";
            this.checkBox_daoqi.Size = new System.Drawing.Size(62, 34);
            this.checkBox_daoqi.TabIndex = 0;
            this.checkBox_daoqi.Text = "已到期";
            this.checkBox_daoqi.UseVisualStyleBackColor = true;
            this.checkBox_daoqi.CheckedChanged += new System.EventHandler(this.checkBox_daoqi_CheckedChanged);
            // 
            // dgvDeposit
            // 
            this.dgvDeposit.AllowUserToAddRows = false;
            this.dgvDeposit.AllowUserToDeleteRows = false;
            this.dgvDeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeposit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.COMP_NAME,
            this.SUM,
            this.RETURNED,
            this.MODIFY_COMMENT});
            this.dgvDeposit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeposit.Location = new System.Drawing.Point(0, 0);
            this.dgvDeposit.Name = "dgvDeposit";
            this.dgvDeposit.ReadOnly = true;
            this.dgvDeposit.RowTemplate.Height = 23;
            this.dgvDeposit.Size = new System.Drawing.Size(498, 379);
            this.dgvDeposit.TabIndex = 0;
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
            // SUM
            // 
            this.SUM.DataPropertyName = "SUM";
            this.SUM.HeaderText = "押金";
            this.SUM.Name = "SUM";
            this.SUM.ReadOnly = true;
            // 
            // RETURNED
            // 
            this.RETURNED.DataPropertyName = "RETURNED";
            this.RETURNED.FalseValue = "否";
            this.RETURNED.HeaderText = "是否已归还";
            this.RETURNED.Name = "RETURNED";
            this.RETURNED.ReadOnly = true;
            this.RETURNED.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RETURNED.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RETURNED.TrueValue = "是";
            // 
            // MODIFY_COMMENT
            // 
            this.MODIFY_COMMENT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MODIFY_COMMENT.DataPropertyName = "MODIFY_COMMENT";
            this.MODIFY_COMMENT.HeaderText = "归还记录";
            this.MODIFY_COMMENT.Name = "MODIFY_COMMENT";
            this.MODIFY_COMMENT.ReadOnly = true;
            this.MODIFY_COMMENT.Width = 80;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SUM";
            this.dataGridViewTextBoxColumn3.HeaderText = "押金";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "归还记录";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // DepositInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 417);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepositInfo";
            this.Text = "押金管理";
            this.Load += new System.EventHandler(this.DepositInfo_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.CheckBox checkBox_returned;
        private System.Windows.Forms.CheckBox checkBox_terminate;
        private System.Windows.Forms.CheckBox checkBox_daoqi;
        private System.Windows.Forms.DataGridView dgvDeposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMP_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUM;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RETURNED;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODIFY_COMMENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}