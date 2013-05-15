namespace EstateManagement.charges
{
    partial class FormAddSdm
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label7;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddSdm));
            this.comboBox_comp = new System.Windows.Forms.ComboBox();
            this.comboBox_room = new System.Windows.Forms.ComboBox();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.panel_last = new System.Windows.Forms.Panel();
            this.textBox_lastcharge = new System.Windows.Forms.TextBox();
            this.textBox_lastsum = new System.Windows.Forms.TextBox();
            this.textBox_lasttime = new System.Windows.Forms.TextBox();
            this.panel_move = new System.Windows.Forms.Panel();
            this.button_confirm = new System.Windows.Forms.Button();
            this.dateTimePicker_cb = new System.Windows.Forms.DateTimePicker();
            this.textBox_comment = new System.Windows.Forms.TextBox();
            this.textBox_cber = new System.Windows.Forms.TextBox();
            this.textBox_charge = new System.Windows.Forms.TextBox();
            this.textBox_sum = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.panel_last.SuspendLayout();
            this.panel_move.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(60, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(34, 13);
            label1.TabIndex = 0;
            label1.Text = "公司:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(48, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(46, 13);
            label2.TabIndex = 0;
            label2.Text = "房间号:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(60, 66);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(34, 13);
            label3.TabIndex = 0;
            label3.Text = "名目:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(36, 64);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(58, 13);
            label6.TabIndex = 3;
            label6.Text = "上期费用:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(24, 36);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(70, 13);
            label5.TabIndex = 2;
            label5.Text = "上期抄表数:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 8);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(82, 13);
            label4.TabIndex = 4;
            label4.Text = "上期抄表时间:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(60, 126);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(34, 13);
            label11.TabIndex = 6;
            label11.Text = "备注:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(48, 98);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(46, 13);
            label10.TabIndex = 5;
            label10.Text = "抄表员:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(60, 69);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(34, 13);
            label9.TabIndex = 7;
            label9.Text = "金额:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(48, 41);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(46, 13);
            label8.TabIndex = 9;
            label8.Text = "抄表数:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(36, 13);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(58, 13);
            label7.TabIndex = 8;
            label7.Text = "抄表时间:";
            // 
            // comboBox_comp
            // 
            this.comboBox_comp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_comp.FormattingEnabled = true;
            this.comboBox_comp.Location = new System.Drawing.Point(101, 36);
            this.comboBox_comp.Name = "comboBox_comp";
            this.comboBox_comp.Size = new System.Drawing.Size(171, 21);
            this.comboBox_comp.TabIndex = 1;
            this.comboBox_comp.SelectedIndexChanged += new System.EventHandler(this.comboBox_comp_SelectedIndexChanged);
            // 
            // comboBox_room
            // 
            this.comboBox_room.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_room.FormattingEnabled = true;
            this.comboBox_room.Location = new System.Drawing.Point(101, 6);
            this.comboBox_room.Name = "comboBox_room";
            this.comboBox_room.Size = new System.Drawing.Size(171, 21);
            this.comboBox_room.TabIndex = 2;
            this.comboBox_room.SelectedIndexChanged += new System.EventHandler(this.comboBox_room_SelectedIndexChanged);
            // 
            // comboBox_type
            // 
            this.comboBox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "水费",
            "电费",
            "煤气费"});
            this.comboBox_type.Location = new System.Drawing.Point(101, 63);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(171, 21);
            this.comboBox_type.TabIndex = 3;
            this.comboBox_type.SelectedIndexChanged += new System.EventHandler(this.comboBox_type_SelectedIndexChanged);
            // 
            // panel_last
            // 
            this.panel_last.Controls.Add(this.textBox_lastcharge);
            this.panel_last.Controls.Add(this.textBox_lastsum);
            this.panel_last.Controls.Add(this.textBox_lasttime);
            this.panel_last.Controls.Add(label6);
            this.panel_last.Controls.Add(label5);
            this.panel_last.Controls.Add(label4);
            this.panel_last.Location = new System.Drawing.Point(0, 89);
            this.panel_last.Name = "panel_last";
            this.panel_last.Size = new System.Drawing.Size(283, 83);
            this.panel_last.TabIndex = 4;
            // 
            // textBox_lastcharge
            // 
            this.textBox_lastcharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_lastcharge.Location = new System.Drawing.Point(101, 61);
            this.textBox_lastcharge.Name = "textBox_lastcharge";
            this.textBox_lastcharge.ReadOnly = true;
            this.textBox_lastcharge.Size = new System.Drawing.Size(171, 20);
            this.textBox_lastcharge.TabIndex = 3;
            // 
            // textBox_lastsum
            // 
            this.textBox_lastsum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_lastsum.Location = new System.Drawing.Point(101, 33);
            this.textBox_lastsum.Name = "textBox_lastsum";
            this.textBox_lastsum.ReadOnly = true;
            this.textBox_lastsum.Size = new System.Drawing.Size(171, 20);
            this.textBox_lastsum.TabIndex = 2;
            // 
            // textBox_lasttime
            // 
            this.textBox_lasttime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_lasttime.Location = new System.Drawing.Point(101, 4);
            this.textBox_lasttime.Name = "textBox_lasttime";
            this.textBox_lasttime.ReadOnly = true;
            this.textBox_lasttime.Size = new System.Drawing.Size(171, 20);
            this.textBox_lasttime.TabIndex = 1;
            // 
            // panel_move
            // 
            this.panel_move.Controls.Add(this.button_confirm);
            this.panel_move.Controls.Add(this.dateTimePicker_cb);
            this.panel_move.Controls.Add(this.textBox_comment);
            this.panel_move.Controls.Add(this.textBox_cber);
            this.panel_move.Controls.Add(this.textBox_charge);
            this.panel_move.Controls.Add(this.textBox_sum);
            this.panel_move.Controls.Add(label11);
            this.panel_move.Controls.Add(label10);
            this.panel_move.Controls.Add(label9);
            this.panel_move.Controls.Add(label8);
            this.panel_move.Controls.Add(label7);
            this.panel_move.Location = new System.Drawing.Point(0, 172);
            this.panel_move.Name = "panel_move";
            this.panel_move.Size = new System.Drawing.Size(283, 216);
            this.panel_move.TabIndex = 5;
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(197, 184);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(75, 25);
            this.button_confirm.TabIndex = 6;
            this.button_confirm.Text = "确定录入";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // dateTimePicker_cb
            // 
            this.dateTimePicker_cb.Location = new System.Drawing.Point(101, 7);
            this.dateTimePicker_cb.Name = "dateTimePicker_cb";
            this.dateTimePicker_cb.Size = new System.Drawing.Size(171, 20);
            this.dateTimePicker_cb.TabIndex = 1;
            // 
            // textBox_comment
            // 
            this.textBox_comment.Location = new System.Drawing.Point(101, 122);
            this.textBox_comment.Multiline = true;
            this.textBox_comment.Name = "textBox_comment";
            this.textBox_comment.Size = new System.Drawing.Size(171, 55);
            this.textBox_comment.TabIndex = 5;
            // 
            // textBox_cber
            // 
            this.textBox_cber.Location = new System.Drawing.Point(101, 94);
            this.textBox_cber.Name = "textBox_cber";
            this.textBox_cber.Size = new System.Drawing.Size(171, 20);
            this.textBox_cber.TabIndex = 4;
            // 
            // textBox_charge
            // 
            this.textBox_charge.Location = new System.Drawing.Point(101, 66);
            this.textBox_charge.Name = "textBox_charge";
            this.textBox_charge.Size = new System.Drawing.Size(171, 20);
            this.textBox_charge.TabIndex = 3;
            // 
            // textBox_sum
            // 
            this.textBox_sum.Location = new System.Drawing.Point(101, 38);
            this.textBox_sum.Name = "textBox_sum";
            this.textBox_sum.Size = new System.Drawing.Size(171, 20);
            this.textBox_sum.TabIndex = 2;
            this.textBox_sum.TextChanged += new System.EventHandler(this.textBox_sum_TextChanged);
            // 
            // FormAddSdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 388);
            this.Controls.Add(this.panel_move);
            this.Controls.Add(this.panel_last);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.comboBox_room);
            this.Controls.Add(this.comboBox_comp);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddSdm";
            this.Text = "水电煤等录入(按房间号)";
            this.panel_last.ResumeLayout(false);
            this.panel_last.PerformLayout();
            this.panel_move.ResumeLayout(false);
            this.panel_move.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_comp;
        private System.Windows.Forms.ComboBox comboBox_room;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Panel panel_last;
        private System.Windows.Forms.TextBox textBox_lastcharge;
        private System.Windows.Forms.TextBox textBox_lastsum;
        private System.Windows.Forms.TextBox textBox_lasttime;
        private System.Windows.Forms.Panel panel_move;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.DateTimePicker dateTimePicker_cb;
        private System.Windows.Forms.TextBox textBox_comment;
        private System.Windows.Forms.TextBox textBox_cber;
        private System.Windows.Forms.TextBox textBox_charge;
        private System.Windows.Forms.TextBox textBox_sum;

    }
}