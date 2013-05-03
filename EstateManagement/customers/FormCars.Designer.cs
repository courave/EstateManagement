namespace EstateManagement.customers
{
    partial class FormCars
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
            this.splitContainer_cars = new System.Windows.Forms.SplitContainer();
            this.button_add = new System.Windows.Forms.Button();
            this.button_modify = new System.Windows.Forms.Button();
            this.button_showterminate = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_terminate = new System.Windows.Forms.Button();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAR_USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAR_PLATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMP_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROOM_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.START_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.END_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE_MONTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOCATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REMARK = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.splitContainer_cars.Panel1.SuspendLayout();
            this.splitContainer_cars.Panel2.SuspendLayout();
            this.splitContainer_cars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer_cars
            // 
            this.splitContainer_cars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_cars.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_cars.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_cars.Name = "splitContainer_cars";
            this.splitContainer_cars.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_cars.Panel1
            // 
            this.splitContainer_cars.Panel1.Controls.Add(this.button_add);
            this.splitContainer_cars.Panel1.Controls.Add(this.button_modify);
            this.splitContainer_cars.Panel1.Controls.Add(this.button_showterminate);
            this.splitContainer_cars.Panel1.Controls.Add(this.button_search);
            this.splitContainer_cars.Panel1.Controls.Add(this.textBox_search);
            this.splitContainer_cars.Panel1.Controls.Add(this.button_terminate);
            // 
            // splitContainer_cars.Panel2
            // 
            this.splitContainer_cars.Panel2.Controls.Add(this.dgvCars);
            this.splitContainer_cars.Size = new System.Drawing.Size(638, 464);
            this.splitContainer_cars.SplitterDistance = 38;
            this.splitContainer_cars.TabIndex = 0;
            // 
            // button_add
            // 
            this.button_add.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_add.Location = new System.Drawing.Point(370, 0);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(63, 38);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "新增车位";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_modify
            // 
            this.button_modify.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_modify.Location = new System.Drawing.Point(307, 0);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(63, 38);
            this.button_modify.TabIndex = 4;
            this.button_modify.Text = "修改选中车位";
            this.button_modify.UseVisualStyleBackColor = true;
            this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
            // 
            // button_showterminate
            // 
            this.button_showterminate.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_showterminate.Location = new System.Drawing.Point(563, 0);
            this.button_showterminate.Name = "button_showterminate";
            this.button_showterminate.Size = new System.Drawing.Size(75, 38);
            this.button_showterminate.TabIndex = 3;
            this.button_showterminate.Text = "显示已删除的车位";
            this.button_showterminate.UseVisualStyleBackColor = true;
            this.button_showterminate.Click += new System.EventHandler(this.button_showterminate_Click);
            // 
            // button_search
            // 
            this.button_search.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_search.Location = new System.Drawing.Point(244, 0);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(63, 38);
            this.button_search.TabIndex = 2;
            this.button_search.Text = "搜索";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.AcceptsReturn = true;
            this.textBox_search.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_search.Location = new System.Drawing.Point(63, 0);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(181, 35);
            this.textBox_search.TabIndex = 1;
            this.textBox_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_search_KeyDown);
            // 
            // button_terminate
            // 
            this.button_terminate.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_terminate.Location = new System.Drawing.Point(0, 0);
            this.button_terminate.Name = "button_terminate";
            this.button_terminate.Size = new System.Drawing.Size(63, 38);
            this.button_terminate.TabIndex = 0;
            this.button_terminate.Text = "删除所选车位";
            this.button_terminate.UseVisualStyleBackColor = true;
            this.button_terminate.Click += new System.EventHandler(this.button_terminate_Click);
            // 
            // dgvCars
            // 
            this.dgvCars.AllowUserToAddRows = false;
            this.dgvCars.AllowUserToDeleteRows = false;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CAR_USER,
            this.CAR_PLATE,
            this.ID_CODE,
            this.COMP_NAME,
            this.ROOM_NO,
            this.TELE,
            this.START_DATE,
            this.END_DATE,
            this.PRICE_MONTH,
            this.LOCATION,
            this.REMARK});
            this.dgvCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCars.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvCars.Location = new System.Drawing.Point(0, 0);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.ReadOnly = true;
            this.dgvCars.Size = new System.Drawing.Size(638, 422);
            this.dgvCars.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // CAR_USER
            // 
            this.CAR_USER.DataPropertyName = "CAR_USER";
            this.CAR_USER.HeaderText = "车主姓名";
            this.CAR_USER.Name = "CAR_USER";
            this.CAR_USER.ReadOnly = true;
            // 
            // CAR_PLATE
            // 
            this.CAR_PLATE.DataPropertyName = "CAR_PLATE";
            this.CAR_PLATE.HeaderText = "车牌号";
            this.CAR_PLATE.Name = "CAR_PLATE";
            this.CAR_PLATE.ReadOnly = true;
            // 
            // ID_CODE
            // 
            this.ID_CODE.DataPropertyName = "ID_CODE";
            this.ID_CODE.HeaderText = "证号";
            this.ID_CODE.Name = "ID_CODE";
            this.ID_CODE.ReadOnly = true;
            // 
            // COMP_NAME
            // 
            this.COMP_NAME.DataPropertyName = "COMP_NAME";
            this.COMP_NAME.HeaderText = "公司";
            this.COMP_NAME.Name = "COMP_NAME";
            this.COMP_NAME.ReadOnly = true;
            // 
            // ROOM_NO
            // 
            this.ROOM_NO.DataPropertyName = "ROOM_NO";
            this.ROOM_NO.HeaderText = "房间号";
            this.ROOM_NO.Name = "ROOM_NO";
            this.ROOM_NO.ReadOnly = true;
            // 
            // TELE
            // 
            this.TELE.DataPropertyName = "TELE";
            this.TELE.HeaderText = "电话";
            this.TELE.Name = "TELE";
            this.TELE.ReadOnly = true;
            // 
            // START_DATE
            // 
            this.START_DATE.DataPropertyName = "START_DATE";
            this.START_DATE.HeaderText = "起租日期";
            this.START_DATE.Name = "START_DATE";
            this.START_DATE.ReadOnly = true;
            // 
            // END_DATE
            // 
            this.END_DATE.DataPropertyName = "END_DATE";
            this.END_DATE.HeaderText = "结束日期";
            this.END_DATE.Name = "END_DATE";
            this.END_DATE.ReadOnly = true;
            // 
            // PRICE_MONTH
            // 
            this.PRICE_MONTH.DataPropertyName = "PRICE_MONTH";
            this.PRICE_MONTH.HeaderText = "车位价格/月";
            this.PRICE_MONTH.Name = "PRICE_MONTH";
            this.PRICE_MONTH.ReadOnly = true;
            // 
            // LOCATION
            // 
            this.LOCATION.DataPropertyName = "LOCATION";
            this.LOCATION.HeaderText = "车位位置";
            this.LOCATION.Name = "LOCATION";
            this.LOCATION.ReadOnly = true;
            // 
            // REMARK
            // 
            this.REMARK.DataPropertyName = "REMARK";
            this.REMARK.HeaderText = "备注";
            this.REMARK.Name = "REMARK";
            this.REMARK.ReadOnly = true;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CAR_USER";
            this.dataGridViewTextBoxColumn2.HeaderText = "车主姓名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CAR_PLATE";
            this.dataGridViewTextBoxColumn3.HeaderText = "车牌号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_CODE";
            this.dataGridViewTextBoxColumn4.HeaderText = "证号";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "COMP_NAME";
            this.dataGridViewTextBoxColumn5.HeaderText = "公司";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ROOM_NO";
            this.dataGridViewTextBoxColumn6.HeaderText = "房间号";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TELE";
            this.dataGridViewTextBoxColumn7.HeaderText = "电话";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "START_DATE";
            this.dataGridViewTextBoxColumn8.HeaderText = "起租日期";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "END_DATE";
            this.dataGridViewTextBoxColumn9.HeaderText = "结束日期";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PRICE_MONTH";
            this.dataGridViewTextBoxColumn10.HeaderText = "车位价格/月";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "LOCATION";
            this.dataGridViewTextBoxColumn11.HeaderText = "车位位置";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "REMARK";
            this.dataGridViewTextBoxColumn12.HeaderText = "备注";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // FormCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 464);
            this.Controls.Add(this.splitContainer_cars);
            this.Name = "FormCars";
            this.Text = "车位管理";
            this.Load += new System.EventHandler(this.FormCars_Load);
            this.splitContainer_cars.Panel1.ResumeLayout(false);
            this.splitContainer_cars.Panel1.PerformLayout();
            this.splitContainer_cars.Panel2.ResumeLayout(false);
            this.splitContainer_cars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_cars;
        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAR_USER;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAR_PLATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMP_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROOM_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELE;
        private System.Windows.Forms.DataGridViewTextBoxColumn START_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn END_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE_MONTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOCATION;
        private System.Windows.Forms.DataGridViewTextBoxColumn REMARK;
        private System.Windows.Forms.Button button_terminate;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_showterminate;
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
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_modify;
    }
}