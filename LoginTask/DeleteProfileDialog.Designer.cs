namespace LoginTask
{
    partial class DeleteProfileDialog
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
            this.btn_deleteProfile = new System.Windows.Forms.Button();
            this.lbl_passwordError = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.panel_password = new System.Windows.Forms.Panel();
            this.checkBox_showPassword = new System.Windows.Forms.CheckBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.panel_password.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_deleteProfile
            // 
            this.btn_deleteProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.btn_deleteProfile.FlatAppearance.BorderSize = 0;
            this.btn_deleteProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteProfile.ForeColor = System.Drawing.Color.White;
            this.btn_deleteProfile.Location = new System.Drawing.Point(12, 154);
            this.btn_deleteProfile.Name = "btn_deleteProfile";
            this.btn_deleteProfile.Size = new System.Drawing.Size(115, 35);
            this.btn_deleteProfile.TabIndex = 13;
            this.btn_deleteProfile.Text = "Delete Profile";
            this.btn_deleteProfile.UseVisualStyleBackColor = false;
            this.btn_deleteProfile.Click += new System.EventHandler(this.btn_deleteProfile_Click);
            // 
            // lbl_passwordError
            // 
            this.lbl_passwordError.AutoSize = true;
            this.lbl_passwordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passwordError.ForeColor = System.Drawing.Color.Red;
            this.lbl_passwordError.Location = new System.Drawing.Point(236, 92);
            this.lbl_passwordError.Name = "lbl_passwordError";
            this.lbl_passwordError.Size = new System.Drawing.Size(19, 25);
            this.lbl_passwordError.TabIndex = 28;
            this.lbl_passwordError.Text = "!";
            this.lbl_passwordError.Visible = false;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.lbl_password.Location = new System.Drawing.Point(37, 22);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(229, 26);
            this.lbl_password.TabIndex = 27;
            this.lbl_password.Text = "Your Current Password ";
            // 
            // panel_password
            // 
            this.panel_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_password.Controls.Add(this.checkBox_showPassword);
            this.panel_password.Controls.Add(this.tb_password);
            this.panel_password.Location = new System.Drawing.Point(53, 88);
            this.panel_password.Name = "panel_password";
            this.panel_password.Size = new System.Drawing.Size(177, 35);
            this.panel_password.TabIndex = 26;
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
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(180, 154);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(115, 35);
            this.btn_cancel.TabIndex = 29;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // DeleteProfileDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(307, 221);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_passwordError);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.panel_password);
            this.Controls.Add(this.btn_deleteProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteProfileDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Profile Dialog";
            this.panel_password.ResumeLayout(false);
            this.panel_password.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_deleteProfile;
        private System.Windows.Forms.Label lbl_passwordError;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Panel panel_password;
        private System.Windows.Forms.CheckBox checkBox_showPassword;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_cancel;
    }
}