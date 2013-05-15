namespace EstateManagement.charges
{
    partial class FormAddFee
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label10;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddFee));
            this.comboBox_comp = new System.Windows.Forms.ComboBox();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.textBox_charge = new System.Windows.Forms.TextBox();
            this.textBox_curdate = new System.Windows.Forms.TextBox();
            this.dateTimePicker_lastend = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_nextstart = new System.Windows.Forms.DateTimePicker();
            this.textBox_genmonth = new System.Windows.Forms.TextBox();
            this.textBox_comment = new System.Windows.Forms.TextBox();
            this.button_confirm = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(60, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(34, 13);
            label1.TabIndex = 0;
            label1.Text = "名目:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(60, 10);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(34, 13);
            label2.TabIndex = 0;
            label2.Text = "公司:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(36, 68);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(58, 13);
            label3.TabIndex = 0;
            label3.Text = "费用年月:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(60, 98);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(34, 13);
            label4.TabIndex = 0;
            label4.Text = "金额:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 127);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(82, 13);
            label5.TabIndex = 0;
            label5.Text = "上期截止日期:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(12, 185);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(82, 13);
            label6.TabIndex = 0;
            label6.Text = "下期起付日期:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(60, 215);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(34, 13);
            label7.TabIndex = 0;
            label7.Text = "备注:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(12, 156);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(82, 13);
            label10.TabIndex = 0;
            label10.Text = "本期结算日期:";
            // 
            // comboBox_comp
            // 
            this.comboBox_comp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_comp.FormattingEnabled = true;
            this.comboBox_comp.Location = new System.Drawing.Point(101, 7);
            this.comboBox_comp.Name = "comboBox_comp";
            this.comboBox_comp.Size = new System.Drawing.Size(171, 21);
            this.comboBox_comp.TabIndex = 1;
            this.comboBox_comp.SelectedIndexChanged += new System.EventHandler(this.comboBox_comp_SelectedIndexChanged);
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Location = new System.Drawing.Point(101, 36);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(171, 21);
            this.comboBox_type.TabIndex = 2;
            this.comboBox_type.SelectedIndexChanged += new System.EventHandler(this.comboBox_type_SelectedIndexChanged);
            // 
            // textBox_charge
            // 
            this.textBox_charge.Location = new System.Drawing.Point(101, 94);
            this.textBox_charge.Name = "textBox_charge";
            this.textBox_charge.Size = new System.Drawing.Size(171, 20);
            this.textBox_charge.TabIndex = 4;
            // 
            // textBox_curdate
            // 
            this.textBox_curdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_curdate.Location = new System.Drawing.Point(101, 153);
            this.textBox_curdate.Name = "textBox_curdate";
            this.textBox_curdate.ReadOnly = true;
            this.textBox_curdate.Size = new System.Drawing.Size(171, 20);
            this.textBox_curdate.TabIndex = 6;
            // 
            // dateTimePicker_lastend
            // 
            this.dateTimePicker_lastend.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_lastend.Location = new System.Drawing.Point(101, 120);
            this.dateTimePicker_lastend.Name = "dateTimePicker_lastend";
            this.dateTimePicker_lastend.Size = new System.Drawing.Size(171, 20);
            this.dateTimePicker_lastend.TabIndex = 5;
            // 
            // dateTimePicker_nextstart
            // 
            this.dateTimePicker_nextstart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_nextstart.Location = new System.Drawing.Point(101, 179);
            this.dateTimePicker_nextstart.Name = "dateTimePicker_nextstart";
            this.dateTimePicker_nextstart.Size = new System.Drawing.Size(171, 20);
            this.dateTimePicker_nextstart.TabIndex = 7;
            // 
            // textBox_genmonth
            // 
            this.textBox_genmonth.Location = new System.Drawing.Point(101, 65);
            this.textBox_genmonth.Name = "textBox_genmonth";
            this.textBox_genmonth.Size = new System.Drawing.Size(171, 20);
            this.textBox_genmonth.TabIndex = 3;
            // 
            // textBox_comment
            // 
            this.textBox_comment.Location = new System.Drawing.Point(101, 211);
            this.textBox_comment.Multiline = true;
            this.textBox_comment.Name = "textBox_comment";
            this.textBox_comment.Size = new System.Drawing.Size(171, 56);
            this.textBox_comment.TabIndex = 8;
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(203, 273);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(69, 42);
            this.button_confirm.TabIndex = 9;
            this.button_confirm.Text = "确定新增";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // FormAddFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 327);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.dateTimePicker_nextstart);
            this.Controls.Add(this.dateTimePicker_lastend);
            this.Controls.Add(this.textBox_curdate);
            this.Controls.Add(this.textBox_genmonth);
            this.Controls.Add(this.textBox_comment);
            this.Controls.Add(this.textBox_charge);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.comboBox_comp);
            this.Controls.Add(label10);
            this.Controls.Add(label2);
            this.Controls.Add(label5);
            this.Controls.Add(label7);
            this.Controls.Add(label4);
            this.Controls.Add(label6);
            this.Controls.Add(label3);
            this.Controls.Add(label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddFee";
            this.Text = "费用录入";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_comp;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.TextBox textBox_charge;
        private System.Windows.Forms.TextBox textBox_curdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_lastend;
        private System.Windows.Forms.DateTimePicker dateTimePicker_nextstart;
        private System.Windows.Forms.TextBox textBox_genmonth;
        private System.Windows.Forms.TextBox textBox_comment;
        private System.Windows.Forms.Button button_confirm;

    }
}