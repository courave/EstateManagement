namespace EstateManagement.charges
{
    partial class FormSdmBase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSdmBase = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDM_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDM_UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSdmBase)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSdmBase
            // 
            this.dgvSdmBase.AllowUserToAddRows = false;
            this.dgvSdmBase.AllowUserToDeleteRows = false;
            this.dgvSdmBase.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSdmBase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSdmBase.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSdmBase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSdmBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSdmBase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SDM_TYPE,
            this.SDM_UNIT});
            this.dgvSdmBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSdmBase.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvSdmBase.Location = new System.Drawing.Point(0, 0);
            this.dgvSdmBase.Name = "dgvSdmBase";
            this.dgvSdmBase.Size = new System.Drawing.Size(243, 118);
            this.dgvSdmBase.TabIndex = 0;
            this.dgvSdmBase.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSdmBase_CellEndEdit);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SDM_TYPE";
            this.dataGridViewTextBoxColumn2.HeaderText = "名目";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SDM_UNIT";
            this.dataGridViewTextBoxColumn3.HeaderText = "单价";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // SDM_TYPE
            // 
            this.SDM_TYPE.DataPropertyName = "SDM_TYPE";
            this.SDM_TYPE.HeaderText = "名目";
            this.SDM_TYPE.Name = "SDM_TYPE";
            this.SDM_TYPE.ReadOnly = true;
            // 
            // SDM_UNIT
            // 
            this.SDM_UNIT.DataPropertyName = "SDM_UNIT";
            this.SDM_UNIT.HeaderText = "单价";
            this.SDM_UNIT.Name = "SDM_UNIT";
            // 
            // FormSdmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 118);
            this.Controls.Add(this.dgvSdmBase);
            this.Name = "FormSdmBase";
            this.Text = "水电煤基数管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSdmBase_FormClosing);
            this.Load += new System.EventHandler(this.FormSdmBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSdmBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSdmBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDM_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDM_UNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}