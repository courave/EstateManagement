namespace EstateManagement.users
{
    partial class FormAddRole
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("合同管理");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("车位管理");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("房间管理");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("预定资费管理");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("客户", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("费用");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("报表");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("打印");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("用户");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddRole));
            this.textBox_rolename = new System.Windows.Forms.TextBox();
            this.treeView_permissions = new System.Windows.Forms.TreeView();
            this.button_confirm = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 13);
            label1.TabIndex = 0;
            label1.Text = "角色名:";
            // 
            // textBox_rolename
            // 
            this.textBox_rolename.Location = new System.Drawing.Point(64, 6);
            this.textBox_rolename.Name = "textBox_rolename";
            this.textBox_rolename.Size = new System.Drawing.Size(208, 20);
            this.textBox_rolename.TabIndex = 1;
            // 
            // treeView_permissions
            // 
            this.treeView_permissions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView_permissions.CheckBoxes = true;
            this.treeView_permissions.Location = new System.Drawing.Point(15, 32);
            this.treeView_permissions.Name = "treeView_permissions";
            treeNode1.Name = "Node_contract";
            treeNode1.Text = "合同管理";
            treeNode2.Name = "Node_parking";
            treeNode2.Text = "车位管理";
            treeNode3.Name = "Node_room";
            treeNode3.Text = "房间管理";
            treeNode4.Name = "Node_predcharge";
            treeNode4.Text = "预定资费管理";
            treeNode5.Name = "Node_customers";
            treeNode5.Text = "客户";
            treeNode6.Name = "Node_charges";
            treeNode6.Text = "费用";
            treeNode7.Name = "Node_report";
            treeNode7.Text = "报表";
            treeNode8.Name = "Node_print";
            treeNode8.Text = "打印";
            treeNode9.Name = "Node_users";
            treeNode9.Text = "用户";
            this.treeView_permissions.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            this.treeView_permissions.Size = new System.Drawing.Size(257, 189);
            this.treeView_permissions.TabIndex = 2;
            this.treeView_permissions.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView_permissions_AfterCheck);
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(197, 227);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(75, 23);
            this.button_confirm.TabIndex = 3;
            this.button_confirm.Text = "确定新增";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // FormAddRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.treeView_permissions);
            this.Controls.Add(this.textBox_rolename);
            this.Controls.Add(label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddRole";
            this.Text = "新增角色";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_rolename;
        private System.Windows.Forms.TreeView treeView_permissions;
        private System.Windows.Forms.Button button_confirm;
    }
}