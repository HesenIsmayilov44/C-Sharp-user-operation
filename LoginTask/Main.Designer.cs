namespace LoginTask
{
    partial class Main
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Panel();
            this.tb_line1 = new System.Windows.Forms.TextBox();
            this.btn_signIn = new System.Windows.Forms.Button();
            this.panel_navbar = new System.Windows.Forms.Panel();
            this.tb_profile = new System.Windows.Forms.TextBox();
            this.lbl_profile = new System.Windows.Forms.Label();
            this.tb_line2 = new System.Windows.Forms.TextBox();
            this.tb_userListLine = new System.Windows.Forms.TextBox();
            this.lbl_userList = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_userList = new System.Windows.Forms.Panel();
            this.panel_profile = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_pconfirmError = new System.Windows.Forms.Label();
            this.lbl_ShowCurrentPasswordError = new System.Windows.Forms.Label();
            this.btn_changePassword = new System.Windows.Forms.Button();
            this.panel_newPassword = new System.Windows.Forms.Panel();
            this.checkBox_showNewPassword = new System.Windows.Forms.CheckBox();
            this.tb_newPassword = new System.Windows.Forms.TextBox();
            this.lbl_currentPassword = new System.Windows.Forms.Label();
            this.lbl_newPassword = new System.Windows.Forms.Label();
            this.panel_currentPassword = new System.Windows.Forms.Panel();
            this.checkBox_currentPassword = new System.Windows.Forms.CheckBox();
            this.tb_currentPassword = new System.Windows.Forms.TextBox();
            this.panel_passwordConfirm = new System.Windows.Forms.Panel();
            this.tb_passwordConfirm = new System.Windows.Forms.TextBox();
            this.checkBox_showPConfirm = new System.Windows.Forms.CheckBox();
            this.lbl_passwordConfirm = new System.Windows.Forms.Label();
            this.lbl_newPasswordError = new System.Windows.Forms.Label();
            this.btn_deleteProfile = new System.Windows.Forms.Button();
            this.listView_userList = new System.Windows.Forms.ListView();
            this.columnHeader_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_isAdmin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_addUser = new System.Windows.Forms.Button();
            this.btn_deleteUser = new System.Windows.Forms.Button();
            this.columnHeader_password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_header.SuspendLayout();
            this.panel_navbar.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.panel_userList.SuspendLayout();
            this.panel_profile.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_newPassword.SuspendLayout();
            this.panel_currentPassword.SuspendLayout();
            this.panel_passwordConfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.lbl_username.Location = new System.Drawing.Point(12, 15);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(147, 31);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Username";
            this.lbl_username.Click += new System.EventHandler(this.lbl_username_Click);
            // 
            // panel_header
            // 
            this.panel_header.Controls.Add(this.tb_line1);
            this.panel_header.Controls.Add(this.btn_signIn);
            this.panel_header.Controls.Add(this.lbl_username);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(834, 60);
            this.panel_header.TabIndex = 1;
            // 
            // tb_line1
            // 
            this.tb_line1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_line1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_line1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_line1.Location = new System.Drawing.Point(18, 53);
            this.tb_line1.Multiline = true;
            this.tb_line1.Name = "tb_line1";
            this.tb_line1.ReadOnly = true;
            this.tb_line1.Size = new System.Drawing.Size(803, 1);
            this.tb_line1.TabIndex = 2;
            // 
            // btn_signIn
            // 
            this.btn_signIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_signIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.btn_signIn.FlatAppearance.BorderSize = 0;
            this.btn_signIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signIn.ForeColor = System.Drawing.Color.White;
            this.btn_signIn.Location = new System.Drawing.Point(744, 15);
            this.btn_signIn.Name = "btn_signIn";
            this.btn_signIn.Size = new System.Drawing.Size(75, 30);
            this.btn_signIn.TabIndex = 6;
            this.btn_signIn.Text = "Log Out";
            this.btn_signIn.UseVisualStyleBackColor = false;
            this.btn_signIn.Click += new System.EventHandler(this.btn_signIn_Click);
            // 
            // panel_navbar
            // 
            this.panel_navbar.Controls.Add(this.lbl_userList);
            this.panel_navbar.Controls.Add(this.tb_userListLine);
            this.panel_navbar.Controls.Add(this.tb_profile);
            this.panel_navbar.Controls.Add(this.lbl_profile);
            this.panel_navbar.Controls.Add(this.tb_line2);
            this.panel_navbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_navbar.Location = new System.Drawing.Point(0, 60);
            this.panel_navbar.Name = "panel_navbar";
            this.panel_navbar.Size = new System.Drawing.Size(182, 401);
            this.panel_navbar.TabIndex = 2;
            // 
            // tb_profile
            // 
            this.tb_profile.BackColor = System.Drawing.Color.White;
            this.tb_profile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_profile.Location = new System.Drawing.Point(18, 64);
            this.tb_profile.Multiline = true;
            this.tb_profile.Name = "tb_profile";
            this.tb_profile.Size = new System.Drawing.Size(130, 1);
            this.tb_profile.TabIndex = 5;
            this.tb_profile.TextChanged += new System.EventHandler(this.tb_profile_TextChanged);
            // 
            // lbl_profile
            // 
            this.lbl_profile.AutoSize = true;
            this.lbl_profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.lbl_profile.Location = new System.Drawing.Point(14, 33);
            this.lbl_profile.Name = "lbl_profile";
            this.lbl_profile.Size = new System.Drawing.Size(69, 24);
            this.lbl_profile.TabIndex = 4;
            this.lbl_profile.Text = "Profile";
            this.lbl_profile.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_line2
            // 
            this.tb_line2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_line2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tb_line2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_line2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_line2.Location = new System.Drawing.Point(175, 6);
            this.tb_line2.Multiline = true;
            this.tb_line2.Name = "tb_line2";
            this.tb_line2.ReadOnly = true;
            this.tb_line2.Size = new System.Drawing.Size(1, 383);
            this.tb_line2.TabIndex = 3;
            // 
            // tb_userListLine
            // 
            this.tb_userListLine.BackColor = System.Drawing.Color.White;
            this.tb_userListLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_userListLine.Location = new System.Drawing.Point(18, 129);
            this.tb_userListLine.Multiline = true;
            this.tb_userListLine.Name = "tb_userListLine";
            this.tb_userListLine.Size = new System.Drawing.Size(130, 1);
            this.tb_userListLine.TabIndex = 1;
            // 
            // lbl_userList
            // 
            this.lbl_userList.AutoSize = true;
            this.lbl_userList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_userList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.lbl_userList.Location = new System.Drawing.Point(14, 98);
            this.lbl_userList.Name = "lbl_userList";
            this.lbl_userList.Size = new System.Drawing.Size(90, 24);
            this.lbl_userList.TabIndex = 0;
            this.lbl_userList.Text = "User List";
            this.lbl_userList.Click += new System.EventHandler(this.lbl_userList_Click);
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_userList);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(182, 60);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(652, 401);
            this.panel_main.TabIndex = 3;
            // 
            // panel_userList
            // 
            this.panel_userList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.panel_userList.Controls.Add(this.panel_profile);
            this.panel_userList.Controls.Add(this.btn_deleteUser);
            this.panel_userList.Controls.Add(this.btn_addUser);
            this.panel_userList.Controls.Add(this.listView_userList);
            this.panel_userList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_userList.Location = new System.Drawing.Point(0, 0);
            this.panel_userList.Name = "panel_userList";
            this.panel_userList.Size = new System.Drawing.Size(652, 401);
            this.panel_userList.TabIndex = 0;
            this.panel_userList.Visible = false;
            // 
            // panel_profile
            // 
            this.panel_profile.Controls.Add(this.groupBox1);
            this.panel_profile.Controls.Add(this.btn_deleteProfile);
            this.panel_profile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_profile.Location = new System.Drawing.Point(0, 0);
            this.panel_profile.Name = "panel_profile";
            this.panel_profile.Size = new System.Drawing.Size(652, 401);
            this.panel_profile.TabIndex = 1;
            this.panel_profile.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_pconfirmError);
            this.groupBox1.Controls.Add(this.lbl_ShowCurrentPasswordError);
            this.groupBox1.Controls.Add(this.btn_changePassword);
            this.groupBox1.Controls.Add(this.panel_newPassword);
            this.groupBox1.Controls.Add(this.lbl_currentPassword);
            this.groupBox1.Controls.Add(this.lbl_newPassword);
            this.groupBox1.Controls.Add(this.panel_currentPassword);
            this.groupBox1.Controls.Add(this.panel_passwordConfirm);
            this.groupBox1.Controls.Add(this.lbl_passwordConfirm);
            this.groupBox1.Controls.Add(this.lbl_newPasswordError);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 371);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Password";
            // 
            // lbl_pconfirmError
            // 
            this.lbl_pconfirmError.AutoSize = true;
            this.lbl_pconfirmError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pconfirmError.ForeColor = System.Drawing.Color.Red;
            this.lbl_pconfirmError.Location = new System.Drawing.Point(200, 240);
            this.lbl_pconfirmError.Name = "lbl_pconfirmError";
            this.lbl_pconfirmError.Size = new System.Drawing.Size(19, 25);
            this.lbl_pconfirmError.TabIndex = 32;
            this.lbl_pconfirmError.Text = "!";
            this.lbl_pconfirmError.Visible = false;
            // 
            // lbl_ShowCurrentPasswordError
            // 
            this.lbl_ShowCurrentPasswordError.AutoSize = true;
            this.lbl_ShowCurrentPasswordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShowCurrentPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lbl_ShowCurrentPasswordError.Location = new System.Drawing.Point(200, 70);
            this.lbl_ShowCurrentPasswordError.Name = "lbl_ShowCurrentPasswordError";
            this.lbl_ShowCurrentPasswordError.Size = new System.Drawing.Size(19, 25);
            this.lbl_ShowCurrentPasswordError.TabIndex = 35;
            this.lbl_ShowCurrentPasswordError.Text = "!";
            this.lbl_ShowCurrentPasswordError.Visible = false;
            // 
            // btn_changePassword
            // 
            this.btn_changePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_changePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.btn_changePassword.FlatAppearance.BorderSize = 0;
            this.btn_changePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changePassword.ForeColor = System.Drawing.Color.White;
            this.btn_changePassword.Location = new System.Drawing.Point(39, 315);
            this.btn_changePassword.Name = "btn_changePassword";
            this.btn_changePassword.Size = new System.Drawing.Size(166, 44);
            this.btn_changePassword.TabIndex = 7;
            this.btn_changePassword.Text = "Change Password";
            this.btn_changePassword.UseVisualStyleBackColor = false;
            this.btn_changePassword.Click += new System.EventHandler(this.btn_changePassword_Click);
            // 
            // panel_newPassword
            // 
            this.panel_newPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_newPassword.Controls.Add(this.checkBox_showNewPassword);
            this.panel_newPassword.Controls.Add(this.tb_newPassword);
            this.panel_newPassword.Location = new System.Drawing.Point(17, 146);
            this.panel_newPassword.Name = "panel_newPassword";
            this.panel_newPassword.Size = new System.Drawing.Size(177, 35);
            this.panel_newPassword.TabIndex = 27;
            // 
            // checkBox_showNewPassword
            // 
            this.checkBox_showNewPassword.AutoSize = true;
            this.checkBox_showNewPassword.Location = new System.Drawing.Point(157, 10);
            this.checkBox_showNewPassword.Name = "checkBox_showNewPassword";
            this.checkBox_showNewPassword.Size = new System.Drawing.Size(15, 14);
            this.checkBox_showNewPassword.TabIndex = 6;
            this.checkBox_showNewPassword.UseVisualStyleBackColor = true;
            this.checkBox_showNewPassword.CheckedChanged += new System.EventHandler(this.checkBox_showNewPassword_CheckedChanged);
            // 
            // tb_newPassword
            // 
            this.tb_newPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.tb_newPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_newPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_newPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.tb_newPassword.Location = new System.Drawing.Point(3, 7);
            this.tb_newPassword.Name = "tb_newPassword";
            this.tb_newPassword.PasswordChar = '•';
            this.tb_newPassword.Size = new System.Drawing.Size(143, 19);
            this.tb_newPassword.TabIndex = 5;
            // 
            // lbl_currentPassword
            // 
            this.lbl_currentPassword.AutoSize = true;
            this.lbl_currentPassword.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.lbl_currentPassword.Location = new System.Drawing.Point(13, 41);
            this.lbl_currentPassword.Name = "lbl_currentPassword";
            this.lbl_currentPassword.Size = new System.Drawing.Size(84, 20);
            this.lbl_currentPassword.TabIndex = 34;
            this.lbl_currentPassword.Text = "Password :";
            // 
            // lbl_newPassword
            // 
            this.lbl_newPassword.AutoSize = true;
            this.lbl_newPassword.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.lbl_newPassword.Location = new System.Drawing.Point(13, 121);
            this.lbl_newPassword.Name = "lbl_newPassword";
            this.lbl_newPassword.Size = new System.Drawing.Size(119, 20);
            this.lbl_newPassword.TabIndex = 28;
            this.lbl_newPassword.Text = "New Password :";
            // 
            // panel_currentPassword
            // 
            this.panel_currentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_currentPassword.Controls.Add(this.checkBox_currentPassword);
            this.panel_currentPassword.Controls.Add(this.tb_currentPassword);
            this.panel_currentPassword.Location = new System.Drawing.Point(17, 66);
            this.panel_currentPassword.Name = "panel_currentPassword";
            this.panel_currentPassword.Size = new System.Drawing.Size(177, 35);
            this.panel_currentPassword.TabIndex = 33;
            // 
            // checkBox_currentPassword
            // 
            this.checkBox_currentPassword.AutoSize = true;
            this.checkBox_currentPassword.Location = new System.Drawing.Point(157, 10);
            this.checkBox_currentPassword.Name = "checkBox_currentPassword";
            this.checkBox_currentPassword.Size = new System.Drawing.Size(15, 14);
            this.checkBox_currentPassword.TabIndex = 6;
            this.checkBox_currentPassword.UseVisualStyleBackColor = true;
            this.checkBox_currentPassword.CheckedChanged += new System.EventHandler(this.checkBox_currentPassword_CheckedChanged);
            // 
            // tb_currentPassword
            // 
            this.tb_currentPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.tb_currentPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_currentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_currentPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.tb_currentPassword.Location = new System.Drawing.Point(5, 7);
            this.tb_currentPassword.Name = "tb_currentPassword";
            this.tb_currentPassword.PasswordChar = '•';
            this.tb_currentPassword.Size = new System.Drawing.Size(143, 19);
            this.tb_currentPassword.TabIndex = 5;
            // 
            // panel_passwordConfirm
            // 
            this.panel_passwordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_passwordConfirm.Controls.Add(this.tb_passwordConfirm);
            this.panel_passwordConfirm.Controls.Add(this.checkBox_showPConfirm);
            this.panel_passwordConfirm.Location = new System.Drawing.Point(17, 236);
            this.panel_passwordConfirm.Name = "panel_passwordConfirm";
            this.panel_passwordConfirm.Size = new System.Drawing.Size(177, 35);
            this.panel_passwordConfirm.TabIndex = 29;
            // 
            // tb_passwordConfirm
            // 
            this.tb_passwordConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.tb_passwordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_passwordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_passwordConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.tb_passwordConfirm.Location = new System.Drawing.Point(3, 7);
            this.tb_passwordConfirm.Name = "tb_passwordConfirm";
            this.tb_passwordConfirm.PasswordChar = '•';
            this.tb_passwordConfirm.Size = new System.Drawing.Size(143, 19);
            this.tb_passwordConfirm.TabIndex = 5;
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
            // lbl_passwordConfirm
            // 
            this.lbl_passwordConfirm.AutoSize = true;
            this.lbl_passwordConfirm.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passwordConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.lbl_passwordConfirm.Location = new System.Drawing.Point(13, 211);
            this.lbl_passwordConfirm.Name = "lbl_passwordConfirm";
            this.lbl_passwordConfirm.Size = new System.Drawing.Size(144, 20);
            this.lbl_passwordConfirm.TabIndex = 30;
            this.lbl_passwordConfirm.Text = "Confirm Password :";
            // 
            // lbl_newPasswordError
            // 
            this.lbl_newPasswordError.AutoSize = true;
            this.lbl_newPasswordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lbl_newPasswordError.Location = new System.Drawing.Point(200, 150);
            this.lbl_newPasswordError.Name = "lbl_newPasswordError";
            this.lbl_newPasswordError.Size = new System.Drawing.Size(19, 25);
            this.lbl_newPasswordError.TabIndex = 31;
            this.lbl_newPasswordError.Text = "!";
            this.lbl_newPasswordError.Visible = false;
            // 
            // btn_deleteProfile
            // 
            this.btn_deleteProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deleteProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.btn_deleteProfile.FlatAppearance.BorderSize = 0;
            this.btn_deleteProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteProfile.ForeColor = System.Drawing.Color.White;
            this.btn_deleteProfile.Location = new System.Drawing.Point(474, 345);
            this.btn_deleteProfile.Name = "btn_deleteProfile";
            this.btn_deleteProfile.Size = new System.Drawing.Size(163, 44);
            this.btn_deleteProfile.TabIndex = 8;
            this.btn_deleteProfile.Text = "Delete Profile";
            this.btn_deleteProfile.UseVisualStyleBackColor = false;
            this.btn_deleteProfile.Click += new System.EventHandler(this.btn_deleteProfile_Click);
            // 
            // listView_userList
            // 
            this.listView_userList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_userList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.listView_userList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_userList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Id,
            this.columnHeader_username,
            this.columnHeader_password,
            this.columnHeader_isAdmin});
            this.listView_userList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_userList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.listView_userList.HideSelection = false;
            this.listView_userList.Location = new System.Drawing.Point(275, 3);
            this.listView_userList.Name = "listView_userList";
            this.listView_userList.Size = new System.Drawing.Size(374, 395);
            this.listView_userList.TabIndex = 1;
            this.listView_userList.UseCompatibleStateImageBehavior = false;
            this.listView_userList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Id
            // 
            this.columnHeader_Id.Text = "# Id";
            this.columnHeader_Id.Width = 47;
            // 
            // columnHeader_username
            // 
            this.columnHeader_username.Text = "Username";
            this.columnHeader_username.Width = 104;
            // 
            // columnHeader_isAdmin
            // 
            this.columnHeader_isAdmin.DisplayIndex = 2;
            this.columnHeader_isAdmin.Text = "Is Admin";
            this.columnHeader_isAdmin.Width = 98;
            // 
            // btn_addUser
            // 
            this.btn_addUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.btn_addUser.FlatAppearance.BorderSize = 0;
            this.btn_addUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addUser.ForeColor = System.Drawing.Color.White;
            this.btn_addUser.Location = new System.Drawing.Point(12, 12);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(125, 45);
            this.btn_addUser.TabIndex = 7;
            this.btn_addUser.Text = "Add User";
            this.btn_addUser.UseVisualStyleBackColor = false;
            this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
            // 
            // btn_deleteUser
            // 
            this.btn_deleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.btn_deleteUser.FlatAppearance.BorderSize = 0;
            this.btn_deleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteUser.ForeColor = System.Drawing.Color.White;
            this.btn_deleteUser.Location = new System.Drawing.Point(12, 77);
            this.btn_deleteUser.Name = "btn_deleteUser";
            this.btn_deleteUser.Size = new System.Drawing.Size(125, 45);
            this.btn_deleteUser.TabIndex = 8;
            this.btn_deleteUser.Text = "Delete User";
            this.btn_deleteUser.UseVisualStyleBackColor = false;
            this.btn_deleteUser.Click += new System.EventHandler(this.btn_deleteUser_Click);
            // 
            // columnHeader_password
            // 
            this.columnHeader_password.Text = "Password";
            this.columnHeader_password.Width = 75;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_navbar);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1080, 635);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.panel_navbar.ResumeLayout(false);
            this.panel_navbar.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_userList.ResumeLayout(false);
            this.panel_profile.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_newPassword.ResumeLayout(false);
            this.panel_newPassword.PerformLayout();
            this.panel_currentPassword.ResumeLayout(false);
            this.panel_currentPassword.PerformLayout();
            this.panel_passwordConfirm.ResumeLayout(false);
            this.panel_passwordConfirm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Button btn_signIn;
        private System.Windows.Forms.Panel panel_navbar;
        private System.Windows.Forms.TextBox tb_userListLine;
        private System.Windows.Forms.Label lbl_userList;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_userList;
        private System.Windows.Forms.TextBox tb_line1;
        private System.Windows.Forms.TextBox tb_line2;
        private System.Windows.Forms.ListView listView_userList;
        private System.Windows.Forms.ColumnHeader columnHeader_Id;
        private System.Windows.Forms.ColumnHeader columnHeader_username;
        private System.Windows.Forms.ColumnHeader columnHeader_isAdmin;
        private System.Windows.Forms.TextBox tb_profile;
        private System.Windows.Forms.Label lbl_profile;
        private System.Windows.Forms.Panel panel_profile;
        private System.Windows.Forms.Button btn_deleteProfile;
        private System.Windows.Forms.Button btn_changePassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_ShowCurrentPasswordError;
        private System.Windows.Forms.Label lbl_currentPassword;
        private System.Windows.Forms.Panel panel_currentPassword;
        private System.Windows.Forms.CheckBox checkBox_currentPassword;
        private System.Windows.Forms.TextBox tb_currentPassword;
        private System.Windows.Forms.Label lbl_pconfirmError;
        private System.Windows.Forms.Label lbl_newPasswordError;
        private System.Windows.Forms.Label lbl_passwordConfirm;
        private System.Windows.Forms.Panel panel_passwordConfirm;
        private System.Windows.Forms.CheckBox checkBox_showPConfirm;
        private System.Windows.Forms.TextBox tb_passwordConfirm;
        private System.Windows.Forms.Label lbl_newPassword;
        private System.Windows.Forms.Panel panel_newPassword;
        private System.Windows.Forms.CheckBox checkBox_showNewPassword;
        private System.Windows.Forms.TextBox tb_newPassword;
        private System.Windows.Forms.Button btn_deleteUser;
        private System.Windows.Forms.Button btn_addUser;
        private System.Windows.Forms.ColumnHeader columnHeader_password;
    }
}

