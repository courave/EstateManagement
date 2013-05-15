namespace EstateManagement.report
{
    partial class FormGenerate
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGenerate));
            this.lblMsg = new System.Windows.Forms.Label();
            this.dateTimePicker_selmonth = new System.Windows.Forms.DateTimePicker();
            this.button_generate = new System.Windows.Forms.Button();
            this.progressBar_report = new System.Windows.Forms.ProgressBar();
            this.timer_fee = new System.Windows.Forms.Timer(this.components);
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(49, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 13);
            label1.TabIndex = 0;
            label1.Text = "选择月份:";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(110, 72);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(160, 13);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "正在生成费用报表,请稍候......";
            this.lblMsg.Visible = false;
            // 
            // dateTimePicker_selmonth
            // 
            this.dateTimePicker_selmonth.CustomFormat = "yyyy年MM月";
            this.dateTimePicker_selmonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_selmonth.Location = new System.Drawing.Point(113, 25);
            this.dateTimePicker_selmonth.Name = "dateTimePicker_selmonth";
            this.dateTimePicker_selmonth.ShowUpDown = true;
            this.dateTimePicker_selmonth.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker_selmonth.TabIndex = 1;
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(286, 22);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(75, 23);
            this.button_generate.TabIndex = 2;
            this.button_generate.Text = "生成";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // progressBar_report
            // 
            this.progressBar_report.Location = new System.Drawing.Point(12, 105);
            this.progressBar_report.Name = "progressBar_report";
            this.progressBar_report.Size = new System.Drawing.Size(349, 23);
            this.progressBar_report.TabIndex = 3;
            // 
            // timer_fee
            // 
            this.timer_fee.Interval = 200;
            this.timer_fee.Tick += new System.EventHandler(this.timer_fee_Tick);
            // 
            // FormGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 140);
            this.Controls.Add(this.progressBar_report);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.dateTimePicker_selmonth);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGenerate";
            this.Text = "生成费用报表";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGenerate_FormClosing);
            this.Load += new System.EventHandler(this.FormGenerate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_selmonth;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.ProgressBar progressBar_report;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Timer timer_fee;

    }
}