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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }


        private void lbl_linkToSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void btn_signIn_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;
            if(username == "" || password == "")
            {
                MessageBox.Show("input fields cannot be left blank");
            }
            else
            {
                if (User.Verification(username, password))
                {
                    Main main = new Main(User.CurrentUser(username));
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or password incorrect");
                }
            }

        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showPassword.Checked) tb_password.PasswordChar = '\0';
            else tb_password.PasswordChar = '•';
        }
    }
}
