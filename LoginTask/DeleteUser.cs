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
    public partial class DeleteUser : Form
    {
        private User user;
        public DeleteUser(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void checkBox_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showAdminKey.Checked) tb_adminKey.PasswordChar = '\0';
            else tb_adminKey.PasswordChar = '•';
        }

        private void btn_deleteUser_Click(object sender, EventArgs e)
        {
            if(User.AdminKey == tb_adminKey.Text)
            {
                if (User.Exist(tb_username.Text))
                {
                    if(tb_username.Text == user.username)
                    {
                        MessageBox.Show("You cannot delete your profile here");
                        return;
                    }
                    User.CurrentUser(tb_username.Text).Delete();
                    /*Main main = new Main();
                    main.lbl_userList_Click();*/
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("The user you are looking for has not been found");
                }
            }
            else
            {
                MessageBox.Show("Admin Key is incorrect");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
