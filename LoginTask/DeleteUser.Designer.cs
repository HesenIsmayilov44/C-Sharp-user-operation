namespace LoginTask
{
    partial class DeleteUser
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_passwordError = new System.Windows.Forms.Label();
            this.lbl_adminKey = new System.Windows.Forms.Label();
            this.panel_password = new System.Windows.Forms.Panel();
            this.checkBox_showAdminKey = new System.Windows.Forms.CheckBox();
            this.tb_adminKey = new System.Windows.Forms.TextBox();
            this.btn_deleteUser = new System.Windows.Forms.Button();
            this.lbl_usernameError = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.panel_username = new System.Windows.Forms.Panel();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_line1 = new System.Windows.Forms.TextBox();
            this.lbl_deleteUser = new System.Windows.Forms.Label();
            this.panel_password.SuspendLayout();
            this.panel_username.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(174, 337);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(115, 35);
            this.btn_cancel.TabIndex = 34;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_passwordError
            // 
            this.lbl_passwordError.AutoSize = true;
            this.lbl_passwordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passwordError.ForeColor = System.Drawing.Color.Red;
            this.lbl_passwordError.Location = new System.Drawing.Point(240, 256);
            this.lbl_passwordError.Name = "lbl_passwordError";
            this.lbl_passwordError.Size = new System.Drawing.Size(19, 25);
            this.lbl_passwordError.TabIndex = 33;
            this.lbl_passwordError.Text = "!";
            this.lbl_passwordError.Visible = false;
            // 
            // lbl_adminKey
            // 
            this.lbl_adminKey.AutoSize = true;
            this.lbl_adminKey.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.lbl_adminKey.Location = new System.Drawing.Point(53, 225);
            this.lbl_adminKey.Name = "lbl_adminKey";
            this.lbl_adminKey.Size = new System.Drawing.Size(92, 22);
            this.lbl_adminKey.TabIndex = 32;
            this.lbl_adminKey.Text = "Admin Key";
            // 
            // panel_password
            // 
            this.panel_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_password.Controls.Add(this.checkBox_showAdminKey);
            this.panel_password.Controls.Add(this.tb_adminKey);
            this.panel_password.Location = new System.Drawing.Point(57, 252);
            this.panel_password.Name = "panel_password";
            this.panel_password.Size = new System.Drawing.Size(177, 35);
            this.panel_password.TabIndex = 31;
            // 
            // checkBox_showAdminKey
            // 
            this.checkBox_showAdminKey.AutoSize = true;
            this.checkBox_showAdminKey.Location = new System.Drawing.Point(157, 10);
            this.checkBox_showAdminKey.Name = "checkBox_showAdminKey";
            this.checkBox_showAdminKey.Size = new System.Drawing.Size(15, 14);
            this.checkBox_showAdminKey.TabIndex = 6;
            this.checkBox_showAdminKey.UseVisualStyleBackColor = true;
            this.checkBox_showAdminKey.CheckedChanged += new System.EventHandler(this.checkBox_showPassword_CheckedChanged);
            // 
            // tb_adminKey
            // 
            this.tb_adminKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.tb_adminKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_adminKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_adminKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.tb_adminKey.Location = new System.Drawing.Point(5, 7);
            this.tb_adminKey.Name = "tb_adminKey";
            this.tb_adminKey.PasswordChar = '•';
            this.tb_adminKey.Size = new System.Drawing.Size(143, 19);
            this.tb_adminKey.TabIndex = 5;
            // 
            // btn_deleteUser
            // 
            this.btn_deleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.btn_deleteUser.FlatAppearance.BorderSize = 0;
            this.btn_deleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteUser.ForeColor = System.Drawing.Color.White;
            this.btn_deleteUser.Location = new System.Drawing.Point(29, 337);
            this.btn_deleteUser.Name = "btn_deleteUser";
            this.btn_deleteUser.Size = new System.Drawing.Size(115, 35);
            this.btn_deleteUser.TabIndex = 30;
            this.btn_deleteUser.Text = "Delete User";
            this.btn_deleteUser.UseVisualStyleBackColor = false;
            this.btn_deleteUser.Click += new System.EventHandler(this.btn_deleteUser_Click);
            // 
            // lbl_usernameError
            // 
            this.lbl_usernameError.AutoSize = true;
            this.lbl_usernameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usernameError.ForeColor = System.Drawing.Color.Red;
            this.lbl_usernameError.Location = new System.Drawing.Point(240, 158);
            this.lbl_usernameError.Name = "lbl_usernameError";
            this.lbl_usernameError.Size = new System.Drawing.Size(19, 25);
            this.lbl_usernameError.TabIndex = 37;
            this.lbl_usernameError.Text = "!";
            this.lbl_usernameError.Visible = false;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.lbl_username.Location = new System.Drawing.Point(62, 100);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(175, 44);
            this.lbl_username.TabIndex = 36;
            this.lbl_username.Text = "The name of the user \r\nyou want to delete";
            // 
            // panel_username
            // 
            this.panel_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_username.Controls.Add(this.tb_username);
            this.panel_username.Location = new System.Drawing.Point(57, 154);
            this.panel_username.Name = "panel_username";
            this.panel_username.Size = new System.Drawing.Size(177, 35);
            this.panel_username.TabIndex = 35;
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
            // tb_line1
            // 
            this.tb_line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.tb_line1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_line1.Location = new System.Drawing.Point(2, 74);
            this.tb_line1.Multiline = true;
            this.tb_line1.Name = "tb_line1";
            this.tb_line1.ReadOnly = true;
            this.tb_line1.Size = new System.Drawing.Size(308, 1);
            this.tb_line1.TabIndex = 39;
            // 
            // lbl_deleteUser
            // 
            this.lbl_deleteUser.AutoSize = true;
            this.lbl_deleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deleteUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.lbl_deleteUser.Location = new System.Drawing.Point(68, 22);
            this.lbl_deleteUser.Name = "lbl_deleteUser";
            this.lbl_deleteUser.Size = new System.Drawing.Size(169, 31);
            this.lbl_deleteUser.TabIndex = 38;
            this.lbl_deleteUser.Text = "Delete User";
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(312, 404);
            this.Controls.Add(this.tb_line1);
            this.Controls.Add(this.lbl_deleteUser);
            this.Controls.Add(this.lbl_usernameError);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.panel_username);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_passwordError);
            this.Controls.Add(this.lbl_adminKey);
            this.Controls.Add(this.panel_password);
            this.Controls.Add(this.btn_deleteUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete User";
            this.panel_password.ResumeLayout(false);
            this.panel_password.PerformLayout();
            this.panel_username.ResumeLayout(false);
            this.panel_username.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_passwordError;
        private System.Windows.Forms.Label lbl_adminKey;
        private System.Windows.Forms.Panel panel_password;
        private System.Windows.Forms.CheckBox checkBox_showAdminKey;
        private System.Windows.Forms.TextBox tb_adminKey;
        private System.Windows.Forms.Button btn_deleteUser;
        private System.Windows.Forms.Label lbl_usernameError;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Panel panel_username;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_line1;
        private System.Windows.Forms.Label lbl_deleteUser;
    }
}