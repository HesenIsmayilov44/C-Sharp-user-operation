namespace LoginTask
{
    partial class SignUp
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
            this.lbl_linkToSignIn = new System.Windows.Forms.Label();
            this.btn_signUp = new System.Windows.Forms.Button();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.panel_password = new System.Windows.Forms.Panel();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.panel_username = new System.Windows.Forms.Panel();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lbl_signUp = new System.Windows.Forms.Label();
            this.lbl_passwordConfirm = new System.Windows.Forms.Label();
            this.panel_passwordConfirm = new System.Windows.Forms.Panel();
            this.tb_passwordConfirm = new System.Windows.Forms.TextBox();
            this.tb_line1 = new System.Windows.Forms.TextBox();
            this.lbl_adminAccessKey = new System.Windows.Forms.Label();
            this.panel_adminAccessKey = new System.Windows.Forms.Panel();
            this.tb_adminAccessKey = new System.Windows.Forms.TextBox();
            this.tb_line2 = new System.Windows.Forms.TextBox();
            this.tb_line3 = new System.Windows.Forms.TextBox();
            this.lbl_keyText1 = new System.Windows.Forms.Label();
            this.lbl_keyText2 = new System.Windows.Forms.Label();
            this.lbl_usernameError = new System.Windows.Forms.Label();
            this.lbl_passwordError = new System.Windows.Forms.Label();
            this.lbl_pconfirmError = new System.Windows.Forms.Label();
            this.checkBox_showPassword = new System.Windows.Forms.CheckBox();
            this.checkBox_showPConfirm = new System.Windows.Forms.CheckBox();
            this.checkBox_showAdminKey = new System.Windows.Forms.CheckBox();
            this.panel_password.SuspendLayout();
            this.panel_username.SuspendLayout();
            this.panel_passwordConfirm.SuspendLayout();
            this.panel_adminAccessKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_linkToSignIn
            // 
            this.lbl_linkToSignIn.AutoSize = true;
            this.lbl_linkToSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_linkToSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(193)))));
            this.lbl_linkToSignIn.Location = new System.Drawing.Point(63, 454);
            this.lbl_linkToSignIn.Name = "lbl_linkToSignIn";
            this.lbl_linkToSignIn.Size = new System.Drawing.Size(131, 13);
            this.lbl_linkToSignIn.TabIndex = 13;
            this.lbl_linkToSignIn.Text = "Do you have an account?";
            this.lbl_linkToSignIn.Click += new System.EventHandler(this.lbl_linkToSignIn_Click);
            // 
            // btn_signUp
            // 
            this.btn_signUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.btn_signUp.FlatAppearance.BorderSize = 0;
            this.btn_signUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signUp.ForeColor = System.Drawing.Color.White;
            this.btn_signUp.Location = new System.Drawing.Point(103, 500);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(100, 46);
            this.btn_signUp.TabIndex = 12;
            this.btn_signUp.Text = "Sign Up";
            this.btn_signUp.UseVisualStyleBackColor = false;
            this.btn_signUp.Click += new System.EventHandler(this.btn_signUp_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.lbl_password.Location = new System.Drawing.Point(62, 177);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(92, 22);
            this.lbl_password.TabIndex = 11;
            this.lbl_password.Text = "Password :";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.lbl_username.Location = new System.Drawing.Point(62, 97);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(97, 22);
            this.lbl_username.TabIndex = 10;
            this.lbl_username.Text = "Username :";
            // 
            // panel_password
            // 
            this.panel_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_password.Controls.Add(this.checkBox_showPassword);
            this.panel_password.Controls.Add(this.tb_password);
            this.panel_password.Location = new System.Drawing.Point(66, 202);
            this.panel_password.Name = "panel_password";
            this.panel_password.Size = new System.Drawing.Size(177, 35);
            this.panel_password.TabIndex = 9;
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
            this.panel_username.Location = new System.Drawing.Point(66, 122);
            this.panel_username.Name = "panel_username";
            this.panel_username.Size = new System.Drawing.Size(177, 35);
            this.panel_username.TabIndex = 8;
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
            // lbl_signUp
            // 
            this.lbl_signUp.AutoSize = true;
            this.lbl_signUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.lbl_signUp.Location = new System.Drawing.Point(97, 27);
            this.lbl_signUp.Name = "lbl_signUp";
            this.lbl_signUp.Size = new System.Drawing.Size(117, 31);
            this.lbl_signUp.TabIndex = 7;
            this.lbl_signUp.Text = "Sign Up";
            // 
            // lbl_passwordConfirm
            // 
            this.lbl_passwordConfirm.AutoSize = true;
            this.lbl_passwordConfirm.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passwordConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.lbl_passwordConfirm.Location = new System.Drawing.Point(62, 258);
            this.lbl_passwordConfirm.Name = "lbl_passwordConfirm";
            this.lbl_passwordConfirm.Size = new System.Drawing.Size(157, 22);
            this.lbl_passwordConfirm.TabIndex = 15;
            this.lbl_passwordConfirm.Text = "Confirm Password :";
            // 
            // panel_passwordConfirm
            // 
            this.panel_passwordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_passwordConfirm.Controls.Add(this.checkBox_showPConfirm);
            this.panel_passwordConfirm.Controls.Add(this.tb_passwordConfirm);
            this.panel_passwordConfirm.Location = new System.Drawing.Point(66, 283);
            this.panel_passwordConfirm.Name = "panel_passwordConfirm";
            this.panel_passwordConfirm.Size = new System.Drawing.Size(177, 35);
            this.panel_passwordConfirm.TabIndex = 14;
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
            // tb_line1
            // 
            this.tb_line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.tb_line1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_line1.Location = new System.Drawing.Point(1, 70);
            this.tb_line1.Multiline = true;
            this.tb_line1.Name = "tb_line1";
            this.tb_line1.ReadOnly = true;
            this.tb_line1.Size = new System.Drawing.Size(308, 1);
            this.tb_line1.TabIndex = 16;
            // 
            // lbl_adminAccessKey
            // 
            this.lbl_adminAccessKey.AutoSize = true;
            this.lbl_adminAccessKey.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminAccessKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.lbl_adminAccessKey.Location = new System.Drawing.Point(62, 336);
            this.lbl_adminAccessKey.Name = "lbl_adminAccessKey";
            this.lbl_adminAccessKey.Size = new System.Drawing.Size(153, 22);
            this.lbl_adminAccessKey.TabIndex = 18;
            this.lbl_adminAccessKey.Text = "Admin Access Key :";
            // 
            // panel_adminAccessKey
            // 
            this.panel_adminAccessKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_adminAccessKey.Controls.Add(this.checkBox_showAdminKey);
            this.panel_adminAccessKey.Controls.Add(this.tb_adminAccessKey);
            this.panel_adminAccessKey.Location = new System.Drawing.Point(66, 400);
            this.panel_adminAccessKey.Name = "panel_adminAccessKey";
            this.panel_adminAccessKey.Size = new System.Drawing.Size(177, 35);
            this.panel_adminAccessKey.TabIndex = 17;
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
            // tb_line2
            // 
            this.tb_line2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.tb_line2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_line2.Location = new System.Drawing.Point(66, 450);
            this.tb_line2.Multiline = true;
            this.tb_line2.Name = "tb_line2";
            this.tb_line2.ReadOnly = true;
            this.tb_line2.Size = new System.Drawing.Size(177, 1);
            this.tb_line2.TabIndex = 20;
            // 
            // tb_line3
            // 
            this.tb_line3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.tb_line3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_line3.Location = new System.Drawing.Point(66, 470);
            this.tb_line3.Multiline = true;
            this.tb_line3.Name = "tb_line3";
            this.tb_line3.ReadOnly = true;
            this.tb_line3.Size = new System.Drawing.Size(177, 1);
            this.tb_line3.TabIndex = 21;
            // 
            // lbl_keyText1
            // 
            this.lbl_keyText1.AutoSize = true;
            this.lbl_keyText1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_keyText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(193)))));
            this.lbl_keyText1.Location = new System.Drawing.Point(63, 360);
            this.lbl_keyText1.Name = "lbl_keyText1";
            this.lbl_keyText1.Size = new System.Drawing.Size(171, 13);
            this.lbl_keyText1.TabIndex = 22;
            this.lbl_keyText1.Text = "If you want access to admin panel ";
            // 
            // lbl_keyText2
            // 
            this.lbl_keyText2.AutoSize = true;
            this.lbl_keyText2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_keyText2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(193)))));
            this.lbl_keyText2.Location = new System.Drawing.Point(63, 376);
            this.lbl_keyText2.Name = "lbl_keyText2";
            this.lbl_keyText2.Size = new System.Drawing.Size(117, 13);
            this.lbl_keyText2.TabIndex = 23;
            this.lbl_keyText2.Text = "you need admin key : ).";
            // 
            // lbl_usernameError
            // 
            this.lbl_usernameError.AutoSize = true;
            this.lbl_usernameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usernameError.ForeColor = System.Drawing.Color.Red;
            this.lbl_usernameError.Location = new System.Drawing.Point(249, 126);
            this.lbl_usernameError.Name = "lbl_usernameError";
            this.lbl_usernameError.Size = new System.Drawing.Size(19, 25);
            this.lbl_usernameError.TabIndex = 24;
            this.lbl_usernameError.Text = "!";
            this.lbl_usernameError.Visible = false;
            // 
            // lbl_passwordError
            // 
            this.lbl_passwordError.AutoSize = true;
            this.lbl_passwordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passwordError.ForeColor = System.Drawing.Color.Red;
            this.lbl_passwordError.Location = new System.Drawing.Point(249, 206);
            this.lbl_passwordError.Name = "lbl_passwordError";
            this.lbl_passwordError.Size = new System.Drawing.Size(19, 25);
            this.lbl_passwordError.TabIndex = 25;
            this.lbl_passwordError.Text = "!";
            this.lbl_passwordError.Visible = false;
            // 
            // lbl_pconfirmError
            // 
            this.lbl_pconfirmError.AutoSize = true;
            this.lbl_pconfirmError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pconfirmError.ForeColor = System.Drawing.Color.Red;
            this.lbl_pconfirmError.Location = new System.Drawing.Point(249, 287);
            this.lbl_pconfirmError.Name = "lbl_pconfirmError";
            this.lbl_pconfirmError.Size = new System.Drawing.Size(19, 25);
            this.lbl_pconfirmError.TabIndex = 26;
            this.lbl_pconfirmError.Text = "!";
            this.lbl_pconfirmError.Visible = false;
            // 
            // checkBox_showPassword
            // 
            this.checkBox_showPassword.AutoSize = true;
            this.checkBox_showPassword.Location = new System.Drawing.Point(157, 10);
            this.checkBox_showPassword.Name = "checkBox_showPassword";
            this.checkBox_showPassword.Size = new System.Drawing.Size(15, 14);
            this.checkBox_showPassword.TabIndex = 6;
            this.checkBox_showPassword.UseVisualStyleBackColor = true;
            this.checkBox_showPassword.CheckedChanged += new System.EventHandler(this.checkBox_showPassword_CheckedChanged);
            // 
            // checkBox_showPConfirm
            // 
            this.checkBox_showPConfirm.AutoSize = true;
            this.checkBox_showPConfirm.Location = new System.Drawing.Point(157, 10);
            this.checkBox_showPConfirm.Name = "checkBox_showPConfirm";
            this.checkBox_showPConfirm.Size = new System.Drawing.Size(15, 14);
            this.checkBox_showPConfirm.TabIndex = 7;
            this.checkBox_showPConfirm.UseVisualStyleBackColor = true;
            this.checkBox_showPConfirm.CheckedChanged += new System.EventHandler(this.checkBox_showPConfirm_CheckedChanged);
            // 
            // checkBox_showAdminKey
            // 
            this.checkBox_showAdminKey.AutoSize = true;
            this.checkBox_showAdminKey.Location = new System.Drawing.Point(157, 10);
            this.checkBox_showAdminKey.Name = "checkBox_showAdminKey";
            this.checkBox_showAdminKey.Size = new System.Drawing.Size(15, 14);
            this.checkBox_showAdminKey.TabIndex = 8;
            this.checkBox_showAdminKey.UseVisualStyleBackColor = true;
            this.checkBox_showAdminKey.CheckedChanged += new System.EventHandler(this.checkBox_showAdminKey_CheckedChanged);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(304, 561);
            this.Controls.Add(this.lbl_pconfirmError);
            this.Controls.Add(this.lbl_passwordError);
            this.Controls.Add(this.lbl_usernameError);
            this.Controls.Add(this.lbl_keyText2);
            this.Controls.Add(this.lbl_keyText1);
            this.Controls.Add(this.tb_line3);
            this.Controls.Add(this.tb_line2);
            this.Controls.Add(this.lbl_adminAccessKey);
            this.Controls.Add(this.panel_adminAccessKey);
            this.Controls.Add(this.tb_line1);
            this.Controls.Add(this.lbl_passwordConfirm);
            this.Controls.Add(this.panel_passwordConfirm);
            this.Controls.Add(this.lbl_linkToSignIn);
            this.Controls.Add(this.btn_signUp);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.panel_password);
            this.Controls.Add(this.panel_username);
            this.Controls.Add(this.lbl_signUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.panel_password.ResumeLayout(false);
            this.panel_password.PerformLayout();
            this.panel_username.ResumeLayout(false);
            this.panel_username.PerformLayout();
            this.panel_passwordConfirm.ResumeLayout(false);
            this.panel_passwordConfirm.PerformLayout();
            this.panel_adminAccessKey.ResumeLayout(false);
            this.panel_adminAccessKey.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_linkToSignIn;
        private System.Windows.Forms.Button btn_signUp;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Panel panel_password;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Panel panel_username;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lbl_signUp;
        private System.Windows.Forms.Label lbl_passwordConfirm;
        private System.Windows.Forms.Panel panel_passwordConfirm;
        private System.Windows.Forms.TextBox tb_passwordConfirm;
        private System.Windows.Forms.TextBox tb_line1;
        private System.Windows.Forms.Label lbl_adminAccessKey;
        private System.Windows.Forms.Panel panel_adminAccessKey;
        private System.Windows.Forms.TextBox tb_adminAccessKey;
        private System.Windows.Forms.TextBox tb_line2;
        private System.Windows.Forms.TextBox tb_line3;
        private System.Windows.Forms.Label lbl_keyText1;
        private System.Windows.Forms.Label lbl_keyText2;
        private System.Windows.Forms.Label lbl_usernameError;
        private System.Windows.Forms.Label lbl_passwordError;
        private System.Windows.Forms.Label lbl_pconfirmError;
        private System.Windows.Forms.CheckBox checkBox_showPassword;
        private System.Windows.Forms.CheckBox checkBox_showPConfirm;
        private System.Windows.Forms.CheckBox checkBox_showAdminKey;
    }
}