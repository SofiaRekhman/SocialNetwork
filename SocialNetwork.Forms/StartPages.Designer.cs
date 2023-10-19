namespace SocialNetwork.Forms
{
    partial class StartPages
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLogIn = new System.Windows.Forms.TabPage();
            this.pLogin = new System.Windows.Forms.Panel();
            this.buttomLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSignIn = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbEmailSignIn = new System.Windows.Forms.TextBox();
            this.tbPasswordSignIn = new System.Windows.Forms.TextBox();
            this.tbUsernameSignIn = new System.Windows.Forms.TextBox();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.tbLastNameSignIn = new System.Windows.Forms.TextBox();
            this.tbFirstnameSignIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageDeleteAccount = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.tbPasswordDelete = new System.Windows.Forms.TextBox();
            this.tbUsernameDelete = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageLogIn.SuspendLayout();
            this.pLogin.SuspendLayout();
            this.tabPageSignIn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageDeleteAccount.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLogIn);
            this.tabControl1.Controls.Add(this.tabPageSignIn);
            this.tabControl1.Controls.Add(this.tabPageDeleteAccount);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(765, 340);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageLogIn
            // 
            this.tabPageLogIn.Controls.Add(this.pLogin);
            this.tabPageLogIn.Location = new System.Drawing.Point(4, 22);
            this.tabPageLogIn.Name = "tabPageLogIn";
            this.tabPageLogIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogIn.Size = new System.Drawing.Size(757, 314);
            this.tabPageLogIn.TabIndex = 0;
            this.tabPageLogIn.Text = "log in";
            this.tabPageLogIn.UseVisualStyleBackColor = true;
            // 
            // pLogin
            // 
            this.pLogin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pLogin.Controls.Add(this.buttomLogin);
            this.pLogin.Controls.Add(this.tbPassword);
            this.pLogin.Controls.Add(this.tbLogin);
            this.pLogin.Controls.Add(this.label1);
            this.pLogin.Location = new System.Drawing.Point(220, 21);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(335, 269);
            this.pLogin.TabIndex = 2;
            // 
            // buttomLogin
            // 
            this.buttomLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttomLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttomLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttomLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttomLogin.Font = new System.Drawing.Font("Sitka Heading", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttomLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttomLogin.Location = new System.Drawing.Point(191, 199);
            this.buttomLogin.Name = "buttomLogin";
            this.buttomLogin.Size = new System.Drawing.Size(97, 32);
            this.buttomLogin.TabIndex = 3;
            this.buttomLogin.Text = "Log in";
            this.buttomLogin.UseVisualStyleBackColor = false;
            this.buttomLogin.Click += new System.EventHandler(this.buttomLogin_Click_1);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.Location = new System.Drawing.Point(48, 151);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(240, 28);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Tag = "";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter_1);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave_1);
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.Location = new System.Drawing.Point(48, 97);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(240, 28);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.Tag = "";
            this.tbLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLogin.Enter += new System.EventHandler(this.tbLogin_Enter_1);
            this.tbLogin.Leave += new System.EventHandler(this.tbLogin_Leave_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "SociaVerse";
            // 
            // tabPageSignIn
            // 
            this.tabPageSignIn.Controls.Add(this.panel1);
            this.tabPageSignIn.Location = new System.Drawing.Point(4, 22);
            this.tabPageSignIn.Name = "tabPageSignIn";
            this.tabPageSignIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSignIn.Size = new System.Drawing.Size(757, 314);
            this.tabPageSignIn.TabIndex = 1;
            this.tabPageSignIn.Text = "Sign up";
            this.tabPageSignIn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tbEmailSignIn);
            this.panel1.Controls.Add(this.tbPasswordSignIn);
            this.panel1.Controls.Add(this.tbUsernameSignIn);
            this.panel1.Controls.Add(this.buttonSignUp);
            this.panel1.Controls.Add(this.tbLastNameSignIn);
            this.panel1.Controls.Add(this.tbFirstnameSignIn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(211, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 269);
            this.panel1.TabIndex = 3;
            // 
            // tbEmailSignIn
            // 
            this.tbEmailSignIn.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEmailSignIn.Location = new System.Drawing.Point(48, 164);
            this.tbEmailSignIn.Name = "tbEmailSignIn";
            this.tbEmailSignIn.Size = new System.Drawing.Size(240, 28);
            this.tbEmailSignIn.TabIndex = 6;
            this.tbEmailSignIn.Tag = "";
            this.tbEmailSignIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEmailSignIn.Enter += new System.EventHandler(this.tbEmailSignIn_Enter);
            this.tbEmailSignIn.Leave += new System.EventHandler(this.tbEmailSignIn_Leave);
            // 
            // tbPasswordSignIn
            // 
            this.tbPasswordSignIn.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPasswordSignIn.Location = new System.Drawing.Point(48, 198);
            this.tbPasswordSignIn.Name = "tbPasswordSignIn";
            this.tbPasswordSignIn.Size = new System.Drawing.Size(240, 28);
            this.tbPasswordSignIn.TabIndex = 5;
            this.tbPasswordSignIn.Tag = "";
            this.tbPasswordSignIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPasswordSignIn.Enter += new System.EventHandler(this.tbPasswordSignIn_Enter);
            this.tbPasswordSignIn.Leave += new System.EventHandler(this.tbPasswordSignIn_Leave);
            // 
            // tbUsernameSignIn
            // 
            this.tbUsernameSignIn.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUsernameSignIn.Location = new System.Drawing.Point(48, 130);
            this.tbUsernameSignIn.Name = "tbUsernameSignIn";
            this.tbUsernameSignIn.Size = new System.Drawing.Size(240, 28);
            this.tbUsernameSignIn.TabIndex = 4;
            this.tbUsernameSignIn.Tag = "";
            this.tbUsernameSignIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUsernameSignIn.Enter += new System.EventHandler(this.tbUsernameSignIn_Enter);
            this.tbUsernameSignIn.Leave += new System.EventHandler(this.tbUsernameSignIn_Leave);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignUp.Font = new System.Drawing.Font("Sitka Heading", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSignUp.Location = new System.Drawing.Point(213, 230);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(97, 32);
            this.buttonSignUp.TabIndex = 3;
            this.buttonSignUp.Text = "Sign up";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // tbLastNameSignIn
            // 
            this.tbLastNameSignIn.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLastNameSignIn.Location = new System.Drawing.Point(48, 96);
            this.tbLastNameSignIn.Name = "tbLastNameSignIn";
            this.tbLastNameSignIn.Size = new System.Drawing.Size(240, 28);
            this.tbLastNameSignIn.TabIndex = 2;
            this.tbLastNameSignIn.Tag = "";
            this.tbLastNameSignIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLastNameSignIn.Enter += new System.EventHandler(this.tbLastNameSignIn_Enter);
            this.tbLastNameSignIn.Leave += new System.EventHandler(this.tbLastNameSignIn_Leave);
            // 
            // tbFirstnameSignIn
            // 
            this.tbFirstnameSignIn.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFirstnameSignIn.Location = new System.Drawing.Point(48, 62);
            this.tbFirstnameSignIn.Name = "tbFirstnameSignIn";
            this.tbFirstnameSignIn.Size = new System.Drawing.Size(240, 28);
            this.tbFirstnameSignIn.TabIndex = 1;
            this.tbFirstnameSignIn.Tag = "";
            this.tbFirstnameSignIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFirstnameSignIn.Enter += new System.EventHandler(this.tbFirstnameSignIn_Enter);
            this.tbFirstnameSignIn.Leave += new System.EventHandler(this.tbFirstnameSignIn_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun-ExtB", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "SociaVerse";
            // 
            // tabPageDeleteAccount
            // 
            this.tabPageDeleteAccount.Controls.Add(this.panel2);
            this.tabPageDeleteAccount.Location = new System.Drawing.Point(4, 22);
            this.tabPageDeleteAccount.Name = "tabPageDeleteAccount";
            this.tabPageDeleteAccount.Size = new System.Drawing.Size(757, 314);
            this.tabPageDeleteAccount.TabIndex = 2;
            this.tabPageDeleteAccount.Text = "Delete Account";
            this.tabPageDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buttonDeleteUser);
            this.panel2.Controls.Add(this.tbPasswordDelete);
            this.panel2.Controls.Add(this.tbUsernameDelete);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(211, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 269);
            this.panel2.TabIndex = 3;
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonDeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteUser.Font = new System.Drawing.Font("Sitka Heading", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDeleteUser.Location = new System.Drawing.Point(191, 199);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(97, 32);
            this.buttonDeleteUser.TabIndex = 3;
            this.buttonDeleteUser.Text = "Delete";
            this.buttonDeleteUser.UseVisualStyleBackColor = false;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // tbPasswordDelete
            // 
            this.tbPasswordDelete.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPasswordDelete.Location = new System.Drawing.Point(48, 151);
            this.tbPasswordDelete.Name = "tbPasswordDelete";
            this.tbPasswordDelete.Size = new System.Drawing.Size(240, 28);
            this.tbPasswordDelete.TabIndex = 2;
            this.tbPasswordDelete.Tag = "";
            this.tbPasswordDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPasswordDelete.Enter += new System.EventHandler(this.tbPasswordDelete_Enter);
            this.tbPasswordDelete.Leave += new System.EventHandler(this.tbPasswordDelete_Leave);
            // 
            // tbUsernameDelete
            // 
            this.tbUsernameDelete.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUsernameDelete.Location = new System.Drawing.Point(48, 97);
            this.tbUsernameDelete.Name = "tbUsernameDelete";
            this.tbUsernameDelete.Size = new System.Drawing.Size(240, 28);
            this.tbUsernameDelete.TabIndex = 1;
            this.tbUsernameDelete.Tag = "";
            this.tbUsernameDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUsernameDelete.Enter += new System.EventHandler(this.tbUsernameDelete_Enter);
            this.tbUsernameDelete.Leave += new System.EventHandler(this.tbUsernameDelete_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun-ExtB", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 50);
            this.label3.TabIndex = 0;
            this.label3.Text = "SociaVerse";
            // 
            // StartPages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "StartPages";
            this.Text = "StartPages";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageLogIn.ResumeLayout(false);
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            this.tabPageSignIn.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageDeleteAccount.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLogIn;
        public System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.Button buttomLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageSignIn;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbPasswordSignIn;
        private System.Windows.Forms.TextBox tbUsernameSignIn;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.TextBox tbLastNameSignIn;
        private System.Windows.Forms.TextBox tbFirstnameSignIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageDeleteAccount;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.TextBox tbPasswordDelete;
        private System.Windows.Forms.TextBox tbUsernameDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmailSignIn;
    }
}

