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
            this.tbServer = new System.Windows.Forms.TextBox();
            this.lbServer = new System.Windows.Forms.Label();
            this.lbDataBase = new System.Windows.Forms.Label();
            this.tbDataBase = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUID = new System.Windows.Forms.TextBox();
            this.lbUID = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbTitle2 = new System.Windows.Forms.Label();
            this.lbTitle3 = new System.Windows.Forms.Label();
            this.gbBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(297, 227);
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
            this.btnQuit.Location = new System.Drawing.Point(14, 227);
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
            this.gbBox.Location = new System.Drawing.Point(14, 90);
            this.gbBox.Name = "gbBox";
            this.gbBox.Size = new System.Drawing.Size(358, 126);
            this.gbBox.TabIndex = 2;
            this.gbBox.TabStop = false;
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(165, 18);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(165, 20);
            this.tbServer.TabIndex = 0;
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
            // lbUID
            // 
            this.lbUID.AutoSize = true;
            this.lbUID.Location = new System.Drawing.Point(22, 73);
            this.lbUID.Name = "lbUID";
            this.lbUID.Size = new System.Drawing.Size(46, 13);
            this.lbUID.TabIndex = 7;
            this.lbUID.Text = "User ID:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 10);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(141, 77);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "XFiles";
            // 
            // lbTitle2
            // 
            this.lbTitle2.AutoSize = true;
            this.lbTitle2.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle2.Location = new System.Drawing.Point(288, 10);
            this.lbTitle2.Name = "lbTitle2";
            this.lbTitle2.Size = new System.Drawing.Size(82, 40);
            this.lbTitle2.TabIndex = 4;
            this.lbTitle2.Text = "Animal";
            // 
            // lbTitle3
            // 
            this.lbTitle3.AutoSize = true;
            this.lbTitle3.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle3.Location = new System.Drawing.Point(179, 50);
            this.lbTitle3.Name = "lbTitle3";
            this.lbTitle3.Size = new System.Drawing.Size(193, 32);
            this.lbTitle3.TabIndex = 5;
            this.lbTitle3.Text = "Observation Database";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.lbTitle3);
            this.Controls.Add(this.lbTitle2);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.gbBox);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.gbBox.ResumeLayout(false);
            this.gbBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbTitle2;
        private System.Windows.Forms.Label lbTitle3;
    }
}