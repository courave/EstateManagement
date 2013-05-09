namespace EstateManagement.print
{
    partial class FormPrintComp
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
            this.dateTimePicker_selmonth = new System.Windows.Forms.DateTimePicker();
            this.button_print = new System.Windows.Forms.Button();
            this.progressBar_printcomp = new System.Windows.Forms.ProgressBar();
            this.timer_compprint = new System.Windows.Forms.Timer(this.components);
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(28, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 13);
            label1.TabIndex = 0;
            label1.Text = "选择月份:";
            // 
            // dateTimePicker_selmonth
            // 
            this.dateTimePicker_selmonth.CustomFormat = "yyyy年MM月";
            this.dateTimePicker_selmonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_selmonth.Location = new System.Drawing.Point(103, 29);
            this.dateTimePicker_selmonth.Name = "dateTimePicker_selmonth";
            this.dateTimePicker_selmonth.ShowUpDown = true;
            this.dateTimePicker_selmonth.Size = new System.Drawing.Size(92, 20);
            this.dateTimePicker_selmonth.TabIndex = 1;
            // 
            // button_print
            // 
            this.button_print.Location = new System.Drawing.Point(215, 27);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(75, 23);
            this.button_print.TabIndex = 2;
            this.button_print.Text = "生成";
            this.button_print.UseVisualStyleBackColor = true;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // progressBar_printcomp
            // 
            this.progressBar_printcomp.Location = new System.Drawing.Point(12, 83);
            this.progressBar_printcomp.Name = "progressBar_printcomp";
            this.progressBar_printcomp.Size = new System.Drawing.Size(278, 23);
            this.progressBar_printcomp.TabIndex = 3;
            // 
            // timer_compprint
            // 
            this.timer_compprint.Interval = 200;
            this.timer_compprint.Tick += new System.EventHandler(this.timer_compprint_Tick);
            // 
            // FormPrintComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 118);
            this.Controls.Add(this.progressBar_printcomp);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.dateTimePicker_selmonth);
            this.Controls.Add(label1);
            this.Name = "FormPrintComp";
            this.Text = "打印待收费公司名单";
            this.Load += new System.EventHandler(this.FormPrintComp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_selmonth;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.ProgressBar progressBar_printcomp;
        private System.Windows.Forms.Timer timer_compprint;
    }
}