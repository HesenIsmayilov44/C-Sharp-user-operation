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
    public partial class DeleteProfileDialog : Form
    {
        private static User user;
        public DeleteProfileDialog(User userr)
        {
            user = userr;
            InitializeComponent();
        }

        private void btn_deleteProfile_Click(object sender, EventArgs e)
        {
            if(tb_password.Text == user.password)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void checkBox_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showPassword.Checked) tb_password.PasswordChar = '\0';
            else tb_password.PasswordChar = '•';
        }
    }
}
