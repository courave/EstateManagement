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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dgvFeeReport = new System.Windows.Forms.DataGridView();
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
            this.CONTRACT_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMP_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROOMNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GEN_MONTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeeReport)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip_feereport";
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
            // ISPAID
            // 
            this.ISPAID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ISPAID.DataPropertyName = "ISPAID";
            this.ISPAID.HeaderText = "是否付款";
            this.ISPAID.Name = "ISPAID";
            this.ISPAID.ReadOnly = true;
            this.ISPAID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ISPAID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ISPAID.Width = 80;
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
            this.dataGridViewTextBoxColumn2.Width = 68;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "COMP_NAME";
            this.dataGridViewTextBoxColumn3.HeaderText = "公司";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 56;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ROOMNO";
            this.dataGridViewTextBoxColumn4.HeaderText = "房间";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 56;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GEN_MONTH";
            this.dataGridViewTextBoxColumn5.HeaderText = "费用年月";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DATE_PREV";
            this.dataGridViewTextBoxColumn6.HeaderText = "上期截止日期";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 74;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DATE_CURRENT";
            this.dataGridViewTextBoxColumn7.HeaderText = "本期结算日期";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 74;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DATE_NEXT";
            this.dataGridViewTextBoxColumn8.HeaderText = "下期起付日期";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 74;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "FZ_FEE";
            this.dataGridViewTextBoxColumn9.HeaderText = "房租";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 52;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "FWF_FEE";
            this.dataGridViewTextBoxColumn10.HeaderText = "综合技术服务费";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 85;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "WY_FEE";
            this.dataGridViewTextBoxColumn11.HeaderText = "物业费";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 63;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "WL_FEE";
            this.dataGridViewTextBoxColumn12.HeaderText = "网络费";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 63;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "CW_FEE";
            this.dataGridViewTextBoxColumn13.HeaderText = "车位费";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 63;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "SF_FEE";
            this.dataGridViewTextBoxColumn14.HeaderText = "水费";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 52;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "DF_FEE";
            this.dataGridViewTextBoxColumn15.HeaderText = "电费";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 52;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn16.DataPropertyName = "MQF_FEE";
            this.dataGridViewTextBoxColumn16.HeaderText = "煤气费";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 63;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn17.DataPropertyName = "QITA_FEE";
            this.dataGridViewTextBoxColumn17.HeaderText = "其他费用";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 63;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn18.DataPropertyName = "TOTAL_FEE";
            this.dataGridViewTextBoxColumn18.HeaderText = "总计";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 52;
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
            this.CONTRACT_NO.Width = 68;
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
            // ROOMNO
            // 
            this.ROOMNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ROOMNO.DataPropertyName = "ROOMNO";
            this.ROOMNO.HeaderText = "房间";
            this.ROOMNO.Name = "ROOMNO";
            this.ROOMNO.ReadOnly = true;
            this.ROOMNO.Width = 56;
            // 
            // GEN_MONTH
            // 
            this.GEN_MONTH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GEN_MONTH.DataPropertyName = "GEN_MONTH";
            this.GEN_MONTH.HeaderText = "费用年月";
            this.GEN_MONTH.Name = "GEN_MONTH";
            this.GEN_MONTH.ReadOnly = true;
            this.GEN_MONTH.Width = 80;
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
            // FormFeeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 453);
            this.Controls.Add(this.dgvFeeReport);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormFeeReport";
            this.Text = "FormFeeReport";
            this.Load += new System.EventHandler(this.FormFeeReport_Load);
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
    }
}