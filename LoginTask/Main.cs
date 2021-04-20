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
    public partial class Main : Form
    {
        private static User user;
        public Main()
        {
            InitializeComponent();
        }
        public Main(User userr)
        {
            InitializeComponent();
             user = userr;
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lbl_username.Text = user.username;
            if(user.isAdmin == "False")
            {
                lbl_userList.Visible = false;
                tb_userListLine.Visible = false;

            }
            else
            {
                lbl_userList.Visible = true;
                tb_userListLine.Visible = true;
            }
        }

        private void lbl_userList_Click(object sender, EventArgs e)
        {
            tb_profile.BackColor = Color.FromArgb(255, 255, 255);
            tb_userListLine.BackColor = Color.FromArgb(255, 43, 88);
            listView_userList.Items.Clear();
            panel_userList.Visible = true;
            panel_profile.Visible = false;
            foreach (var user in User.UsersList())
            {                
                ListViewItem lvi = new ListViewItem();
                lvi.Text = user.id;
                lvi.SubItems.Add(user.username);
                lvi.SubItems.Add(user.password);
                lvi.SubItems.Add(user.isAdmin);
                listView_userList.Items.Add(lvi);
            }
        }
        /*public  void lbl_userList_Click()
        {
            tb_profile.BackColor = Color.FromArgb(255, 255, 255);
            listView_userList.Items.Clear();
            panel_userList.Visible = true;
            panel_profile.Visible = false;
            tb_userListLine.BackColor = Color.FromArgb(255, 43, 88);
            foreach (var user in User.UsersList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = user.id;
                lvi.SubItems.Add(user.username);
                lvi.SubItems.Add(user.password);
                lvi.SubItems.Add(user.isAdmin);
                listView_userList.Items.Add(lvi);
            }
        }*/

        private void btn_signIn_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel_userList.Visible = true;
            panel_profile.Visible = true;
            tb_userListLine.BackColor = Color.FromArgb(255, 225, 225);
            tb_profile.BackColor = Color.FromArgb(255, 43, 88);
        }

        private void lbl_username_Click(object sender, EventArgs e)
        {
            panel_userList.Visible = false;
        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            //Change password
            string currentPassword = tb_currentPassword.Text;
            string newPassword = tb_newPassword.Text;
            string confirmPassword = tb_passwordConfirm.Text;
            if(currentPassword != user.password)
            {
                MessageBox.Show("Current password doesn't correct");
                lbl_ShowCurrentPasswordError.Visible = true;
                lbl_pconfirmError.Visible = false;
                lbl_newPasswordError.Visible = false;
            }
            else if(newPassword.Length < 8)
            {
                MessageBox.Show("The password must be at least 8 characters.");
                lbl_ShowCurrentPasswordError.Visible = false;
                lbl_newPasswordError.Visible = true;
                lbl_pconfirmError.Visible = false;
            }
            else if(newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match");
                lbl_ShowCurrentPasswordError.Visible = false;
                lbl_pconfirmError.Visible = true;
                lbl_newPasswordError.Visible = true;
            }
            else
            {
                user.password = newPassword;
                user.changePassword();
                MessageBox.Show("The password changed successfully");
            }
            
        }

        private void btn_deleteProfile_Click(object sender, EventArgs e)
        {
            DeleteProfileDialog dpd = new DeleteProfileDialog(user);
            if(dpd.ShowDialog() == DialogResult.OK)
            {
                user.Delete();
                MessageBox.Show("Your profile has been successfully deleted");
                SignIn signIn = new SignIn();
                signIn.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Your profile could not be deleted");
            }
            
            
        }

        private void checkBox_currentPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_currentPassword.Checked) tb_currentPassword.PasswordChar = '\0';
            else tb_currentPassword.PasswordChar = '•';
        }

        private void checkBox_showNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showNewPassword.Checked) tb_newPassword.PasswordChar = '\0';
            else tb_newPassword.PasswordChar = '•';
        }

        private void checkBox_showPConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showPConfirm.Checked) tb_passwordConfirm.PasswordChar = '\0';
            else tb_passwordConfirm.PasswordChar = '•';
        }

        private void tb_profile_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_deleteUser_Click(object sender, EventArgs e)
        {
            DeleteUser du = new DeleteUser(user);
            if(du.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("User successfully deleted");
                listView_userList.Items.Clear();
                panel_userList.Visible = true;
                panel_profile.Visible = false;
                foreach (var user in User.UsersList())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = user.id;
                    lvi.SubItems.Add(user.username);
                    lvi.SubItems.Add(user.password);
                    lvi.SubItems.Add(user.isAdmin);
                    listView_userList.Items.Add(lvi);
                }
            }
            else
            {
                MessageBox.Show("The user could not be deleted");
            }
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            AddUser au = new AddUser();
            if(au.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("The user added successfully");
                listView_userList.Items.Clear();
                panel_userList.Visible = true;
                panel_profile.Visible = false;
                foreach (var user in User.UsersList())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = user.id;
                    lvi.SubItems.Add(user.username);
                    lvi.SubItems.Add(user.password);
                    lvi.SubItems.Add(user.isAdmin);
                    listView_userList.Items.Add(lvi);
                }
            }
            else
            {
                MessageBox.Show("The user cann't added");
            }
        }
    }
    
}
