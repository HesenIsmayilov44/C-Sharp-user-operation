using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LoginTask
{
    public partial class SignUp : Form
    {
        
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
        private void formClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lbl_linkToSignIn_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            lbl_usernameError.Visible = false;
            lbl_passwordError.Visible = false;
            lbl_pconfirmError.Visible = false;

            string username = tb_username.Text;
            string password = tb_password.Text;
            string passwordConfirm = tb_passwordConfirm.Text;
            string adminKey = tb_adminAccessKey.Text;

            if(username.Length < 8 )
            {
                MessageBox.Show("The username and the password must be at least 8 characters.");
                lbl_usernameError.Visible = true;
            }
            else if(password.Length < 8)
            {
                MessageBox.Show("The username and the password must be at least 8 characters.");
                lbl_passwordError.Visible = true;
            }
            else if(password != passwordConfirm)
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
                User user = User.Add(username, password, adminKey);
                MessageBox.Show("Registration is successful.\n Redirecting to main...");
                Main main = new Main(user);
                main.Show();
                this.Hide();
            }
            
        }

        

        private void checkBox_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showPassword.Checked) tb_password.PasswordChar = '\0';
            else tb_password.PasswordChar = '•';
        }
        private void checkBox_showPConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showPConfirm.Checked) tb_passwordConfirm.PasswordChar = '\0';
            else tb_passwordConfirm.PasswordChar = '•';
        }

        private void checkBox_showAdminKey_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showAdminKey.Checked) tb_adminAccessKey.PasswordChar = '\0';
            else tb_adminAccessKey.PasswordChar = '•';
        }
    }
}
