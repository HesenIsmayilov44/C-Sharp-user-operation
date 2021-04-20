namespace LoginTask
{
    partial class AddUser
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
            this.lbl_pconfirmError = new System.Windows.Forms.Label();
            this.lbl_passwordError = new System.Windows.Forms.Label();
            this.lbl_usernameError = new System.Windows.Forms.Label();
            this.tb_line1 = new System.Windows.Forms.TextBox();
            this.lbl_passwordConfirm = new System.Windows.Forms.Label();
            this.panel_passwordConfirm = new System.Windows.Forms.Panel();
            this.checkBox_showPConfirm = new System.Windows.Forms.CheckBox();
            this.tb_passwordConfirm = new System.Windows.Forms.TextBox();
            this.btn_addUser = new System.Windows.Forms.Button();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.panel_password = new System.Windows.Forms.Panel();
            this.checkBox_showPassword = new System.Windows.Forms.CheckBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.panel_username = new System.Windows.Forms.Panel();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lbl_addUser = new System.Windows.Forms.Label();
            this.lbl_adminAccessKey = new System.Windows.Forms.Label();
            this.panel_adminAccessKey = new System.Windows.Forms.Panel();
            this.checkBox_showAdminKey = new System.Windows.Forms.CheckBox();
            this.tb_adminAccessKey = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cb_adminAccess = new System.Windows.Forms.CheckBox();
            this.panel_passwordConfirm.SuspendLayout();
            this.panel_password.SuspendLayout();
            this.panel_username.SuspendLayout();
            this.panel_adminAccessKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_pconfirmError
            // 
            this.lbl_pconfirmError.AutoSize = true;
            this.lbl_pconfirmError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pconfirmError.ForeColor = System.Drawing.Color.Red;
            this.lbl_pconfirmError.Location = new System.Drawing.Point(236, 299);
            this.lbl_pconfirmError.Name = "lbl_pconfirmError";
            this.lbl_pconfirmError.Size = new System.Drawing.Size(19, 25);
            this.lbl_pconfirmError.TabIndex = 45;
            this.lbl_pconfirmError.Text = "!";
            this.lbl_pconfirmError.Visible = false;
            // 
            // lbl_passwordError
            // 
            this.lbl_passwordError.AutoSize = true;
            this.lbl_passwordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passwordError.ForeColor = System.Drawing.Color.Red;
            this.lbl_passwordError.Location = new System.Drawing.Point(236, 218);
            this.lbl_passwordError.Name = "lbl_passwordError";
            this.lbl_passwordError.Size = new System.Drawing.Size(19, 25);
            this.lbl_passwordError.TabIndex = 44;
            this.lbl_passwordError.Text = "!";
            this.lbl_passwordError.Visible = false;
            // 
            // lbl_usernameError
            // 
            this.lbl_usernameError.AutoSize = true;
            this.lbl_usernameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usernameError.ForeColor = System.Drawing.Color.Red;
            this.lbl_usernameError.Location = new System.Drawing.Point(236, 138);
            this.lbl_usernameError.Name = "lbl_usernameError";
            this.lbl_usernameError.Size = new System.Drawing.Size(19, 25);
            this.lbl_usernameError.TabIndex = 43;
            this.lbl_usernameError.Text = "!";
            this.lbl_usernameError.Visible = false;
            // 
            // tb_line1
            // 
            this.tb_line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.tb_line1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_line1.Location = new System.Drawing.Point(2, 81);
            this.tb_line1.Multiline = true;
            this.tb_line1.Name = "tb_line1";
            this.tb_line1.ReadOnly = true;
            this.tb_line1.Size = new System.Drawing.Size(308, 1);
            this.tb_line1.TabIndex = 36;
            // 
            // lbl_passwordConfirm
            // 
            this.lbl_passwordConfirm.AutoSize = true;
            this.lbl_passwordConfirm.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passwordConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.lbl_passwordConfirm.Location = new System.Drawing.Point(49, 270);
            this.lbl_passwordConfirm.Name = "lbl_passwordConfirm";
            this.lbl_passwordConfirm.Size = new System.Drawing.Size(157, 22);
            this.lbl_passwordConfirm.TabIndex = 35;
            this.lbl_passwordConfirm.Text = "Confirm Password :";
            // 
            // panel_passwordConfirm
            // 
            this.panel_passwordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_passwordConfirm.Controls.Add(this.checkBox_showPConfirm);
            this.panel_passwordConfirm.Controls.Add(this.tb_passwordConfirm);
            this.panel_passwordConfirm.Location = new System.Drawing.Point(53, 295);
            this.panel_passwordConfirm.Name = "panel_passwordConfirm";
            this.panel_passwordConfirm.Size = new System.Drawing.Size(177, 35);
            this.panel_passwordConfirm.TabIndex = 34;
            // 
            // checkBox_showPConfirm
            // 
            this.checkBox_showPConfirm.AutoSize = true;
            this.checkBox_showPConfirm.Location = new System.Drawing.Point(157, 10);
            this.checkBox_showPConfirm.Name = "checkBox_showPConfirm";
            this.checkBox_showPConfirm.Size = new System.Drawing.Size(15, 14);
            this.checkBox_showPConfirm.TabIndex = 7;
            this.checkBox_showPConfirm.UseVisualStyleBackColor = true;
            this.checkBox_showPConfirm.CheckedChanged += new System.EventHandler(this.checkBox_showPConfirm_CheckedChanged_1);
            // 
            // tb_passwordConfirm
            // 
            this.tb_passwordConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.tb_passwordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_passwordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_passwordConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.tb_passwordConfirm.Location = new System.Drawing.Point(5, 7);
            this.tb_passwordConfirm.Name = "tb_passwordConfirm";
            this.tb_passwordConfirm.PasswordChar = '•';
            this.tb_passwordConfirm.Size = new System.Drawing.Size(143, 19);
            this.tb_passwordConfirm.TabIndex = 5;
            // 
            // btn_addUser
            // 
            this.btn_addUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.btn_addUser.FlatAppearance.BorderSize = 0;
            this.btn_addUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addUser.ForeColor = System.Drawing.Color.White;
            this.btn_addUser.Location = new System.Drawing.Point(41, 533);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(100, 46);
            this.btn_addUser.TabIndex = 32;
            this.btn_addUser.Text = "Add User";
            this.btn_addUser.UseVisualStyleBackColor = false;
            this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.lbl_password.Location = new System.Drawing.Point(49, 189);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(92, 22);
            this.lbl_password.TabIndex = 31;
            this.lbl_password.Text = "Password :";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.lbl_username.Location = new System.Drawing.Point(49, 109);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(97, 22);
            this.lbl_username.TabIndex = 30;
            this.lbl_username.Text = "Username :";
            // 
            // panel_password
            // 
            this.panel_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_password.Controls.Add(this.checkBox_showPassword);
            this.panel_password.Controls.Add(this.tb_password);
            this.panel_password.Location = new System.Drawing.Point(53, 214);
            this.panel_password.Name = "panel_password";
            this.panel_password.Size = new System.Drawing.Size(177, 35);
            this.panel_password.TabIndex = 29;
            // 
            // checkBox_showPassword
            // 
            this.checkBox_showPassword.AutoSize = true;
            this.checkBox_showPassword.Location = new System.Drawing.Point(157, 10);
            this.checkBox_showPassword.Name = "checkBox_showPassword";
            this.checkBox_showPassword.Size = new System.Drawing.Size(15, 14);
            this.checkBox_showPassword.TabIndex = 6;
            this.checkBox_showPassword.UseVisualStyleBackColor = true;
            this.checkBox_showPassword.CheckedChanged += new System.EventHandler(this.checkBox_showPassword_CheckedChanged_1);
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.tb_password.Location = new System.Drawing.Point(5, 7);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '•';
            this.tb_password.Size = new System.Drawing.Size(143, 19);
            this.tb_password.TabIndex = 5;
            // 
            // panel_username
            // 
            this.panel_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_username.Controls.Add(this.tb_username);
            this.panel_username.Location = new System.Drawing.Point(53, 134);
            this.panel_username.Name = "panel_username";
            this.panel_username.Size = new System.Drawing.Size(177, 35);
            this.panel_username.TabIndex = 28;
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.tb_username.Location = new System.Drawing.Point(5, 7);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(159, 19);
            this.tb_username.TabIndex = 6;
            // 
            // lbl_addUser
            // 
            this.lbl_addUser.AutoSize = true;
            this.lbl_addUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.lbl_addUser.Location = new System.Drawing.Point(76, 35);
            this.lbl_addUser.Name = "lbl_addUser";
            this.lbl_addUser.Size = new System.Drawing.Size(135, 31);
            this.lbl_addUser.TabIndex = 27;
            this.lbl_addUser.Text = "Add User";
            // 
            // lbl_adminAccessKey
            // 
            this.lbl_adminAccessKey.AutoSize = true;
            this.lbl_adminAccessKey.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminAccessKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.lbl_adminAccessKey.Location = new System.Drawing.Point(42, 418);
            this.lbl_adminAccessKey.Name = "lbl_adminAccessKey";
            this.lbl_adminAccessKey.Size = new System.Drawing.Size(213, 22);
            this.lbl_adminAccessKey.TabIndex = 47;
            this.lbl_adminAccessKey.Text = "Admin  Key to validate you ";
            // 
            // panel_adminAccessKey
            // 
            this.panel_adminAccessKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_adminAccessKey.Controls.Add(this.checkBox_showAdminKey);
            this.panel_adminAccessKey.Controls.Add(this.tb_adminAccessKey);
            this.panel_adminAccessKey.Location = new System.Drawing.Point(53, 452);
            this.panel_adminAccessKey.Name = "panel_adminAccessKey";
            this.panel_adminAccessKey.Size = new System.Drawing.Size(177, 35);
            this.panel_adminAccessKey.TabIndex = 46;
            // 
            // checkBox_showAdminKey
            // 
            this.checkBox_showAdminKey.AutoSize = true;
            this.checkBox_showAdminKey.Location = new System.Drawing.Point(157, 10);
            this.checkBox_showAdminKey.Name = "checkBox_showAdminKey";
            this.checkBox_showAdminKey.Size = new System.Drawing.Size(15, 14);
            this.checkBox_showAdminKey.TabIndex = 8;
            this.checkBox_showAdminKey.UseVisualStyleBackColor = true;
            this.checkBox_showAdminKey.CheckedChanged += new System.EventHandler(this.checkBox_showAdminKey_CheckedChanged_1);
            // 
            // tb_adminAccessKey
            // 
            this.tb_adminAccessKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.tb_adminAccessKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_adminAccessKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_adminAccessKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.tb_adminAccessKey.Location = new System.Drawing.Point(5, 7);
            this.tb_adminAccessKey.Name = "tb_adminAccessKey";
            this.tb_adminAccessKey.PasswordChar = '•';
            this.tb_adminAccessKey.Size = new System.Drawing.Size(143, 19);
            this.tb_adminAccessKey.TabIndex = 5;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(164, 533);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 46);
            this.btn_cancel.TabIndex = 48;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(2, 404);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(308, 1);
            this.textBox1.TabIndex = 49;
            // 
            // cb_adminAccess
            // 
            this.cb_adminAccess.AutoSize = true;
            this.cb_adminAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_adminAccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.cb_adminAccess.Location = new System.Drawing.Point(53, 360);
            this.cb_adminAccess.Name = "cb_adminAccess";
            this.cb_adminAccess.Size = new System.Drawing.Size(200, 24);
            this.cb_adminAccess.TabIndex = 50;
            this.cb_adminAccess.Text = "Give user Admin Access";
            this.cb_adminAccess.UseVisualStyleBackColor = true;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(308, 606);
            this.Controls.Add(this.cb_adminAccess);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_adminAccessKey);
            this.Controls.Add(this.panel_adminAccessKey);
            this.Controls.Add(this.lbl_pconfirmError);
            this.Controls.Add(this.lbl_passwordError);
            this.Controls.Add(this.lbl_usernameError);
            this.Controls.Add(this.tb_line1);
            this.Controls.Add(this.lbl_passwordConfirm);
            this.Controls.Add(this.panel_passwordConfirm);
            this.Controls.Add(this.btn_addUser);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.panel_password);
            this.Controls.Add(this.panel_username);
            this.Controls.Add(this.lbl_addUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.panel_passwordConfirm.ResumeLayout(false);
            this.panel_passwordConfirm.PerformLayout();
            this.panel_password.ResumeLayout(false);
            this.panel_password.PerformLayout();
            this.panel_username.ResumeLayout(false);
            this.panel_username.PerformLayout();
            this.panel_adminAccessKey.ResumeLayout(false);
            this.panel_adminAccessKey.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pconfirmError;
        private System.Windows.Forms.Label lbl_passwordError;
        private System.Windows.Forms.Label lbl_usernameError;
        private System.Windows.Forms.TextBox tb_line1;
        private System.Windows.Forms.Label lbl_passwordConfirm;
        private System.Windows.Forms.Panel panel_passwordConfirm;
        private System.Windows.Forms.CheckBox checkBox_showPConfirm;
        private System.Windows.Forms.TextBox tb_passwordConfirm;
        private System.Windows.Forms.Button btn_addUser;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Panel panel_password;
        private System.Windows.Forms.CheckBox checkBox_showPassword;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Panel panel_username;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lbl_addUser;
        private System.Windows.Forms.Label lbl_adminAccessKey;
        private System.Windows.Forms.Panel panel_adminAccessKey;
        private System.Windows.Forms.CheckBox checkBox_showAdminKey;
        private System.Windows.Forms.TextBox tb_adminAccessKey;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox cb_adminAccess;
    }
}