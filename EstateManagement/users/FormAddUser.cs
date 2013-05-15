using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EstateManagement.pub;

namespace EstateManagement.users
{
    public partial class FormAddUser : Form
    {
        public bool isNew = true;
        public string userid="-1";
        public FormAddUser():this(true,"-1"){}
        public FormAddUser(bool _isNew,string _userid)
        {
            InitializeComponent();
            isNew = _isNew;
            userid = _userid;
        }
        private void button_confirm_Click(object sender, EventArgs e)
        {
            if (SaveChanges())
                this.Close();

        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {
            InitData();
        }
        private void InitData()
        {
            //init combo role
            using (DataBase db = new DataBase())
            {
                DataTable dt = db.ExecuteDataTable("SELECT ID,ROLE_NAME FROM CJ_ROLE");
                foreach (DataRow dr in dt.Rows)
                {
                    comboBox_role.Items.Add(new ComboItem(dr[0].ToString(), dr[1].ToString()));
                }
            }
            if (isNew) { textBox_pwd.PasswordChar = '*';textBox_pwdconfirm.PasswordChar='*'; return; }
            this.Text = "更改用户信息";
            button_confirm.Text = "确定更改";
            using (DataBase db = new DataBase())
            {
                DataTable dt = db.ExecuteDataTable("SELECT [USERNAME],[NICKNAME],[ROLE_ID] FROM [CJ_ADMIN] WHERE ID="+userid);
                if (dt.Rows.Count != 1)
                    return;
                textBox_pwd.Text = "<未更改>";
                textBox_pwdconfirm.Text = "<未更改>";
                textBox_username.Text = dt.Rows[0][0].ToString();
                textBox_nickname.Text = dt.Rows[0][1].ToString();
                foreach (ComboItem item in comboBox_role.Items)
                {
                    if (item.Key == dt.Rows[0][2].ToString())
                    {
                        comboBox_role.SelectedItem = item;
                        break;
                    }
                }


            }
        }

        private void textBox_pwd_Enter(object sender, EventArgs e)
        {
            if (textBox_pwd.Text != "<未更改>") return;
            textBox_pwd.Text = "";
            textBox_pwd.PasswordChar = '*';
        }

        private void textBox_pwd_Leave(object sender, EventArgs e)
        {
            if (textBox_pwd.Text == "")
            {
                textBox_pwd.PasswordChar = '\0';
                textBox_pwd.Text = "<未更改>";
            }
        }

        private void textBox_pwdconfirm_Enter(object sender, EventArgs e)
        {
            if (textBox_pwdconfirm.Text != "<未更改>") return;
            textBox_pwdconfirm.Text = "";
            textBox_pwdconfirm.PasswordChar = '*';
        }

        private void textBox_pwdconfirm_Leave(object sender, EventArgs e)
        {
            if (textBox_pwdconfirm.Text == "")
            {
                textBox_pwdconfirm.PasswordChar = '\0';
                textBox_pwdconfirm.Text = "<未更改>";
            }
        }

        private bool SaveChanges()
        {
            if (!CheckDataValidation())
            {
                MessageBox.Show("输入有误,请核查后输入!");
                return false;
            }
            using (DataBase db = new DataBase())
            {
                db.AddParameter("USERNAME", textBox_username.Text);
                db.AddParameter("NICKNAME", textBox_nickname.Text);
                db.AddParameter("ROLE_ID", ((ComboItem)comboBox_role.SelectedItem).Key);
                if (isNew)
                {
                    db.AddParameter("PASSWORD", Cryptography.Encrypt(textBox_pwd.Text));
                    db.ExecuteNonQuery("INSERT INTO [CJ_ADMIN]([USERNAME],[PASSWORD],[NICKNAME],[ROLE_ID]) "+
                                        "VALUES (@USERNAME,@PASSWORD,@NICKNAME,@ROLE_ID)");

                }
                else
                {
                    db.AddParameter("ID", userid);
                    if (textBox_pwd.Text == "<未更改>" || textBox_pwd.Text == "")
                    {
                        db.ExecuteNonQuery("UPDATE [CJ_ADMIN] SET [USERNAME]=@USERNAME,[NICKNAME]=@NICKNAME,[ROLE_ID]=@ROLE_ID WHERE ID=@ID");
                    }
                    else
                    {
                        db.AddParameter("PASSWORD", Cryptography.Encrypt(textBox_pwd.Text));
                        db.ExecuteNonQuery("UPDATE [CJ_ADMIN] SET [USERNAME]=@USERNAME,[PASSWORD]=@PASSWORD,[NICKNAME]=@NICKNAME,[ROLE_ID]=@ROLE_ID WHERE ID=@ID");
                    }
                }
            }
            return true;
        }
        private bool CheckDataValidation()
        {
            if (textBox_username.Text == "") return false;
            if (textBox_nickname.Text == "") return false;
            if (textBox_pwd.Text != textBox_pwdconfirm.Text) return false;
            if (isNew && textBox_pwd.Text == "") return false;
            if (comboBox_role.SelectedItem == null) return false;
            return true;
        }
    }
}
