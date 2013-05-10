namespace EstateManagement.print
{
    partial class FormFeePrintPreview
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
            this.crystalReportViewer_feepreview = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer_feepreview
            // 
            this.crystalReportViewer_feepreview.ActiveViewIndex = -1;
            this.crystalReportViewer_feepreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer_feepreview.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer_feepreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer_feepreview.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer_feepreview.Name = "crystalReportViewer_feepreview";
            this.crystalReportViewer_feepreview.ShowCloseButton = false;
            this.crystalReportViewer_feepreview.ShowGroupTreeButton = false;
            this.crystalReportViewer_feepreview.ShowParameterPanelButton = false;
            this.crystalReportViewer_feepreview.ShowRefreshButton = false;
            this.crystalReportViewer_feepreview.ShowTextSearchButton = false;
            this.crystalReportViewer_feepreview.Size = new System.Drawing.Size(649, 549);
            this.crystalReportViewer_feepreview.TabIndex = 0;
            this.crystalReportViewer_feepreview.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FormFeePrintPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 549);
            this.Controls.Add(this.crystalReportViewer_feepreview);
            this.Name = "FormFeePrintPreview";
            this.Text = "FormFeePrintPreview";
            this.Load += new System.EventHandler(this.FormFeePrintPreview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer_feepreview;

    }
}