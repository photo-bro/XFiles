namespace XFiles.Forms
{
    partial class Login
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.gbBox = new System.Windows.Forms.GroupBox();
            this.lbUID = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUID = new System.Windows.Forms.TextBox();
            this.lbDataBase = new System.Windows.Forms.Label();
            this.tbDataBase = new System.Windows.Forms.TextBox();
            this.lbServer = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.SplashLogo = new System.Windows.Forms.PictureBox();
            this.gbBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplashLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(295, 275);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Location = new System.Drawing.Point(12, 275);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // gbBox
            // 
            this.gbBox.Controls.Add(this.lbUID);
            this.gbBox.Controls.Add(this.lbPassword);
            this.gbBox.Controls.Add(this.tbPassword);
            this.gbBox.Controls.Add(this.tbUID);
            this.gbBox.Controls.Add(this.lbDataBase);
            this.gbBox.Controls.Add(this.tbDataBase);
            this.gbBox.Controls.Add(this.lbServer);
            this.gbBox.Controls.Add(this.tbServer);
            this.gbBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbBox.Location = new System.Drawing.Point(12, 138);
            this.gbBox.Name = "gbBox";
            this.gbBox.Size = new System.Drawing.Size(358, 126);
            this.gbBox.TabIndex = 2;
            this.gbBox.TabStop = false;
            // 
            // lbUID
            // 
            this.lbUID.AutoSize = true;
            this.lbUID.Location = new System.Drawing.Point(22, 73);
            this.lbUID.Name = "lbUID";
            this.lbUID.Size = new System.Drawing.Size(46, 13);
            this.lbUID.TabIndex = 7;
            this.lbUID.Text = "User ID:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(22, 99);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(56, 13);
            this.lbPassword.TabIndex = 6;
            this.lbPassword.Text = "Password:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(165, 96);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(165, 20);
            this.tbPassword.TabIndex = 5;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbUID
            // 
            this.tbUID.Location = new System.Drawing.Point(165, 70);
            this.tbUID.Name = "tbUID";
            this.tbUID.Size = new System.Drawing.Size(165, 20);
            this.tbUID.TabIndex = 4;
            // 
            // lbDataBase
            // 
            this.lbDataBase.AutoSize = true;
            this.lbDataBase.Location = new System.Drawing.Point(22, 47);
            this.lbDataBase.Name = "lbDataBase";
            this.lbDataBase.Size = new System.Drawing.Size(87, 13);
            this.lbDataBase.TabIndex = 3;
            this.lbDataBase.Text = "Database Name:";
            // 
            // tbDataBase
            // 
            this.tbDataBase.Location = new System.Drawing.Point(165, 44);
            this.tbDataBase.Name = "tbDataBase";
            this.tbDataBase.Size = new System.Drawing.Size(165, 20);
            this.tbDataBase.TabIndex = 2;
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.Location = new System.Drawing.Point(22, 21);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(72, 13);
            this.lbServer.TabIndex = 1;
            this.lbServer.Text = "Server Name:";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(165, 18);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(165, 20);
            this.tbServer.TabIndex = 0;
            // 
            // SplashLogo
            // 
            this.SplashLogo.Image = global::XFiles.Properties.Resources.XFiles_Splash;
            this.SplashLogo.Location = new System.Drawing.Point(12, 12);
            this.SplashLogo.Name = "SplashLogo";
            this.SplashLogo.Size = new System.Drawing.Size(360, 120);
            this.SplashLogo.TabIndex = 3;
            this.SplashLogo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 308);
            this.Controls.Add(this.SplashLogo);
            this.Controls.Add(this.gbBox);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.gbBox.ResumeLayout(false);
            this.gbBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplashLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.GroupBox gbBox;
        private System.Windows.Forms.Label lbUID;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUID;
        private System.Windows.Forms.Label lbDataBase;
        private System.Windows.Forms.TextBox tbDataBase;
        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.PictureBox SplashLogo;
    }
}