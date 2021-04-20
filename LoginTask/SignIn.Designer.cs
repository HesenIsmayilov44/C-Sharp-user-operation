namespace LoginTask
{
    partial class SignIn
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
            this.lbl_signIn = new System.Windows.Forms.Label();
            this.panel_username = new System.Windows.Forms.Panel();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.panel_password = new System.Windows.Forms.Panel();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_signIn = new System.Windows.Forms.Button();
            this.lbl_linkToSignUp = new System.Windows.Forms.Label();
            this.tb_line1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox_showPassword = new System.Windows.Forms.CheckBox();
            this.panel_username.SuspendLayout();
            this.panel_password.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_signIn
            // 
            this.lbl_signIn.AutoSize = true;
            this.lbl_signIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.lbl_signIn.Location = new System.Drawing.Point(95, 24);
            this.lbl_signIn.Name = "lbl_signIn";
            this.lbl_signIn.Size = new System.Drawing.Size(103, 31);
            this.lbl_signIn.TabIndex = 0;
            this.lbl_signIn.Text = "Sign in";
            // 
            // panel_username
            // 
            this.panel_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_username.Controls.Add(this.tb_username);
            this.panel_username.Location = new System.Drawing.Point(64, 135);
            this.panel_username.Name = "panel_username";
            this.panel_username.Size = new System.Drawing.Size(177, 35);
            this.panel_username.TabIndex = 1;
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
            // panel_password
            // 
            this.panel_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_password.Controls.Add(this.checkBox_showPassword);
            this.panel_password.Controls.Add(this.tb_password);
            this.panel_password.Location = new System.Drawing.Point(64, 215);
            this.panel_password.Name = "panel_password";
            this.panel_password.Size = new System.Drawing.Size(177, 35);
            this.panel_password.TabIndex = 2;
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
            this.tb_password.Size = new System.Drawing.Size(139, 19);
            this.tb_password.TabIndex = 5;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.lbl_username.Location = new System.Drawing.Point(60, 110);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(97, 22);
            this.lbl_username.TabIndex = 3;
            this.lbl_username.Text = "Username :";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.lbl_password.Location = new System.Drawing.Point(60, 190);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(92, 22);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Password :";
            // 
            // btn_signIn
            // 
            this.btn_signIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.btn_signIn.FlatAppearance.BorderSize = 0;
            this.btn_signIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signIn.ForeColor = System.Drawing.Color.White;
            this.btn_signIn.Location = new System.Drawing.Point(98, 355);
            this.btn_signIn.Name = "btn_signIn";
            this.btn_signIn.Size = new System.Drawing.Size(100, 46);
            this.btn_signIn.TabIndex = 5;
            this.btn_signIn.Text = "Sign In";
            this.btn_signIn.UseVisualStyleBackColor = false;
            this.btn_signIn.Click += new System.EventHandler(this.btn_signIn_Click);
            // 
            // lbl_linkToSignUp
            // 
            this.lbl_linkToSignUp.AutoSize = true;
            this.lbl_linkToSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_linkToSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(179)))), ((int)(((byte)(193)))));
            this.lbl_linkToSignUp.Location = new System.Drawing.Point(67, 274);
            this.lbl_linkToSignUp.Name = "lbl_linkToSignUp";
            this.lbl_linkToSignUp.Size = new System.Drawing.Size(142, 13);
            this.lbl_linkToSignUp.TabIndex = 6;
            this.lbl_linkToSignUp.Text = "Don\'t you have an account?";
            this.lbl_linkToSignUp.Click += new System.EventHandler(this.lbl_linkToSignUp_Click);
            // 
            // tb_line1
            // 
            this.tb_line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.tb_line1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_line1.Location = new System.Drawing.Point(-1, 73);
            this.tb_line1.Multiline = true;
            this.tb_line1.Name = "tb_line1";
            this.tb_line1.ReadOnly = true;
            this.tb_line1.Size = new System.Drawing.Size(308, 1);
            this.tb_line1.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(64, 270);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(177, 1);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(64, 290);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(177, 1);
            this.textBox2.TabIndex = 19;
            // 
            // checkBox_showPassword
            // 
            this.checkBox_showPassword.AutoSize = true;
            this.checkBox_showPassword.Location = new System.Drawing.Point(157, 9);
            this.checkBox_showPassword.Name = "checkBox_showPassword";
            this.checkBox_showPassword.Size = new System.Drawing.Size(15, 14);
            this.checkBox_showPassword.TabIndex = 6;
            this.checkBox_showPassword.UseVisualStyleBackColor = true;
            this.checkBox_showPassword.CheckedChanged += new System.EventHandler(this.checkBox_showPassword_CheckedChanged);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(304, 431);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tb_line1);
            this.Controls.Add(this.lbl_linkToSignUp);
            this.Controls.Add(this.btn_signIn);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.panel_password);
            this.Controls.Add(this.panel_username);
            this.Controls.Add(this.lbl_signIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.panel_username.ResumeLayout(false);
            this.panel_username.PerformLayout();
            this.panel_password.ResumeLayout(false);
            this.panel_password.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_signIn;
        private System.Windows.Forms.Panel panel_username;
        private System.Windows.Forms.Panel panel_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_signIn;
        private System.Windows.Forms.Label lbl_linkToSignUp;
        private System.Windows.Forms.TextBox tb_line1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox_showPassword;
    }
}