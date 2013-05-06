namespace EstateManagement.customers
{
    partial class FormPredCharge
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_reset = new System.Windows.Forms.Button();
            this.comboBox_comp = new System.Windows.Forms.ComboBox();
            this.dgvPredCharge = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMP_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHARGE_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUM_MONTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INTERVAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredCharge)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.button_reset);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_comp);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvPredCharge);
            this.splitContainer1.Size = new System.Drawing.Size(517, 441);
            this.splitContainer1.SplitterDistance = 33;
            this.splitContainer1.TabIndex = 0;
            // 
            // button_reset
            // 
            this.button_reset.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_reset.Location = new System.Drawing.Point(442, 0);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 33);
            this.button_reset.TabIndex = 1;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // comboBox_comp
            // 
            this.comboBox_comp.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_comp.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_comp.FormattingEnabled = true;
            this.comboBox_comp.Location = new System.Drawing.Point(0, 0);
            this.comboBox_comp.Name = "comboBox_comp";
            this.comboBox_comp.Size = new System.Drawing.Size(273, 27);
            this.comboBox_comp.TabIndex = 0;
            this.comboBox_comp.SelectedIndexChanged += new System.EventHandler(this.comboBox_comp_SelectedIndexChanged);
            this.comboBox_comp.TextUpdate += new System.EventHandler(this.comboBox_comp_TextUpdate);
            // 
            // dgvPredCharge
            // 
            this.dgvPredCharge.AllowUserToAddRows = false;
            this.dgvPredCharge.AllowUserToDeleteRows = false;
            this.dgvPredCharge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPredCharge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.COMP_NAME,
            this.CHARGE_TYPE,
            this.SUM_MONTH,
            this.INTERVAL});
            this.dgvPredCharge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPredCharge.Location = new System.Drawing.Point(0, 0);
            this.dgvPredCharge.Name = "dgvPredCharge";
            this.dgvPredCharge.ReadOnly = true;
            this.dgvPredCharge.RowTemplate.Height = 23;
            this.dgvPredCharge.Size = new System.Drawing.Size(517, 404);
            this.dgvPredCharge.TabIndex = 0;
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
            // CHARGE_TYPE
            // 
            this.CHARGE_TYPE.DataPropertyName = "CHARGE_TYPE";
            this.CHARGE_TYPE.HeaderText = "费用类型";
            this.CHARGE_TYPE.Name = "CHARGE_TYPE";
            this.CHARGE_TYPE.ReadOnly = true;
            // 
            // SUM_MONTH
            // 
            this.SUM_MONTH.DataPropertyName = "SUM_MONTH";
            this.SUM_MONTH.HeaderText = "数额(月)";
            this.SUM_MONTH.Name = "SUM_MONTH";
            this.SUM_MONTH.ReadOnly = true;
            // 
            // INTERVAL
            // 
            this.INTERVAL.DataPropertyName = "INTERVAL";
            this.INTERVAL.HeaderText = "收取周期";
            this.INTERVAL.Name = "INTERVAL";
            this.INTERVAL.ReadOnly = true;
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
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CHARGE_TYPE";
            this.dataGridViewTextBoxColumn3.HeaderText = "费用类型";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SUM_MONTH";
            this.dataGridViewTextBoxColumn4.HeaderText = "数额(月)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "INTERVAL";
            this.dataGridViewTextBoxColumn5.HeaderText = "收取周期";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // FormPredCharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 441);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormPredCharge";
            this.Text = "固定资费预设置管理";
            this.Load += new System.EventHandler(this.FormPredCharge_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredCharge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvPredCharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMP_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHARGE_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUM_MONTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn INTERVAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox comboBox_comp;
        private System.Windows.Forms.Button button_reset;
    }
}