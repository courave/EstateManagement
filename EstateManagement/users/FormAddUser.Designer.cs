namespace EstateManagement.users
{
    partial class FormAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUser));
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_nickname = new System.Windows.Forms.TextBox();
            this.textBox_pwd = new System.Windows.Forms.TextBox();
            this.textBox_pwdconfirm = new System.Windows.Forms.TextBox();
            this.comboBox_role = new System.Windows.Forms.ComboBox();
            this.button_confirm = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(26, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 13);
            label1.TabIndex = 0;
            label1.Text = "用户名:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(38, 46);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(34, 13);
            label2.TabIndex = 0;
            label2.Text = "昵称:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(38, 83);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(34, 13);
            label3.TabIndex = 0;
            label3.Text = "密码:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(14, 120);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(58, 13);
            label4.TabIndex = 0;
            label4.Text = "确认密码:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(38, 157);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(34, 13);
            label5.TabIndex = 0;
            label5.Text = "角色:";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(78, 6);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(134, 20);
            this.textBox_username.TabIndex = 1;
            // 
            // textBox_nickname
            // 
            this.textBox_nickname.Location = new System.Drawing.Point(78, 43);
            this.textBox_nickname.Name = "textBox_nickname";
            this.textBox_nickname.Size = new System.Drawing.Size(134, 20);
            this.textBox_nickname.TabIndex = 2;
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Location = new System.Drawing.Point(78, 80);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.Size = new System.Drawing.Size(134, 20);
            this.textBox_pwd.TabIndex = 3;
            this.textBox_pwd.Enter += new System.EventHandler(this.textBox_pwd_Enter);
            this.textBox_pwd.Leave += new System.EventHandler(this.textBox_pwd_Leave);
            // 
            // textBox_pwdconfirm
            // 
            this.textBox_pwdconfirm.Location = new System.Drawing.Point(78, 117);
            this.textBox_pwdconfirm.Name = "textBox_pwdconfirm";
            this.textBox_pwdconfirm.Size = new System.Drawing.Size(134, 20);
            this.textBox_pwdconfirm.TabIndex = 4;
            this.textBox_pwdconfirm.Enter += new System.EventHandler(this.textBox_pwdconfirm_Enter);
            this.textBox_pwdconfirm.Leave += new System.EventHandler(this.textBox_pwdconfirm_Leave);
            // 
            // comboBox_role
            // 
            this.comboBox_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_role.FormattingEnabled = true;
            this.comboBox_role.Location = new System.Drawing.Point(78, 154);
            this.comboBox_role.Name = "comboBox_role";
            this.comboBox_role.Size = new System.Drawing.Size(134, 21);
            this.comboBox_role.TabIndex = 5;
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(137, 192);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(75, 23);
            this.button_confirm.TabIndex = 6;
            this.button_confirm.Text = "确定新增";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 227);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.comboBox_role);
            this.Controls.Add(this.textBox_pwdconfirm);
            this.Controls.Add(this.textBox_pwd);
            this.Controls.Add(this.textBox_nickname);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddUser";
            this.Text = "新增用户";
            this.Load += new System.EventHandler(this.FormAddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_nickname;
        private System.Windows.Forms.TextBox textBox_pwd;
        private System.Windows.Forms.TextBox textBox_pwdconfirm;
        private System.Windows.Forms.ComboBox comboBox_role;
        private System.Windows.Forms.Button button_confirm;

    }
}