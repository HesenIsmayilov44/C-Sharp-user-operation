using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginTask
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void checkBox_showPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox_showPassword.Checked) tb_password.PasswordChar = '\0';
            else tb_password.PasswordChar = '•';
        }

        private void checkBox_showPConfirm_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox_showPConfirm.Checked) tb_passwordConfirm.PasswordChar = '\0';
            else tb_passwordConfirm.PasswordChar = '•';
        }

        private void checkBox_showAdminKey_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox_showAdminKey.Checked) tb_adminAccessKey.PasswordChar = '\0';
            else tb_adminAccessKey.PasswordChar = '•';
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            lbl_usernameError.Visible = false;
            lbl_passwordError.Visible = false;
            lbl_pconfirmError.Visible = false;

            string username = tb_username.Text;
            string password = tb_password.Text;
            string passwordConfirm = tb_passwordConfirm.Text;
            string adminKey = tb_adminAccessKey.Text;

            if (!username.All(c => Char.IsLetterOrDigit(c)) || !password.All(c => Char.IsLetterOrDigit(c)))
            {
                lbl_passwordError.Visible = (password.All(c => Char.IsLetterOrDigit(c))) ? false : true;
                lbl_usernameError.Visible = (username.All(c => Char.IsLetterOrDigit(c))) ? false : true;

                MessageBox.Show("The value of inputs can only contain letters and numbers");
                return;
            }
            if (adminKey != User.AdminKey)
            {
                MessageBox.Show("Invalid Admin Key");
                return;
            }
            if (username.Length < 8)
            {
                MessageBox.Show("The username and the password must be at least 8 characters.");
                lbl_usernameError.Visible = true;
            }
            else if (password.Length < 8)
            {
                MessageBox.Show("The username and the password must be at least 8 characters.");
                lbl_passwordError.Visible = true;
            }
            else if (password != passwordConfirm)
            {
                MessageBox.Show("Passwords do not match");
                lbl_pconfirmError.Visible = true;
                lbl_passwordError.Visible = true;
            }
            else if (User.Exist(username))
            {
                MessageBox.Show("This username already taken try another one");
                lbl_usernameError.Visible = true;
            }
            else
            {
                if (!cb_adminAccess.Checked)
                {
                    adminKey = "";
                }
                User user = User.Add(username, password, adminKey);
                /*Main main = new Main();
                main.lbl_userList_Click();*/
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
