namespace XFiles.Forms.Observation_Forms
{
    partial class Add_Observer
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
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.btnAddObserver = new System.Windows.Forms.Button();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbPhone2 = new System.Windows.Forms.Label();
            this.tbPhone2 = new System.Windows.Forms.TextBox();
            this.tbPhone1 = new System.Windows.Forms.TextBox();
            this.lbPhone1 = new System.Windows.Forms.Label();
            this.cbxCredentials = new System.Windows.Forms.ComboBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.cbxAddress = new System.Windows.Forms.ComboBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.lbEmail);
            this.gbAdd.Controls.Add(this.tbEmail);
            this.gbAdd.Controls.Add(this.lbPhone2);
            this.gbAdd.Controls.Add(this.tbPhone2);
            this.gbAdd.Controls.Add(this.tbPhone1);
            this.gbAdd.Controls.Add(this.lbPhone1);
            this.gbAdd.Controls.Add(this.cbxCredentials);
            this.gbAdd.Controls.Add(this.tbLastName);
            this.gbAdd.Controls.Add(this.lbLastName);
            this.gbAdd.Controls.Add(this.cbxAddress);
            this.gbAdd.Controls.Add(this.tbFirstName);
            this.gbAdd.Controls.Add(this.lbFirstName);
            this.gbAdd.Location = new System.Drawing.Point(12, 12);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(350, 183);
            this.gbAdd.TabIndex = 9;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Add New Observer";
            // 
            // btnAddObserver
            // 
            this.btnAddObserver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddObserver.Location = new System.Drawing.Point(241, 204);
            this.btnAddObserver.Name = "btnAddObserver";
            this.btnAddObserver.Size = new System.Drawing.Size(121, 23);
            this.btnAddObserver.TabIndex = 7;
            this.btnAddObserver.Text = "Add New Observer";
            this.btnAddObserver.UseVisualStyleBackColor = true;
            this.btnAddObserver.Click += new System.EventHandler(this.btnAddObserver_Click);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(6, 153);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(76, 13);
            this.lbEmail.TabIndex = 19;
            this.lbEmail.Text = "Email Address:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(155, 150);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(189, 20);
            this.tbEmail.TabIndex = 6;
            // 
            // lbPhone2
            // 
            this.lbPhone2.AutoSize = true;
            this.lbPhone2.Location = new System.Drawing.Point(6, 127);
            this.lbPhone2.Name = "lbPhone2";
            this.lbPhone2.Size = new System.Drawing.Size(90, 13);
            this.lbPhone2.TabIndex = 17;
            this.lbPhone2.Text = "Phone Number 2:";
            // 
            // tbPhone2
            // 
            this.tbPhone2.Location = new System.Drawing.Point(155, 124);
            this.tbPhone2.Name = "tbPhone2";
            this.tbPhone2.Size = new System.Drawing.Size(189, 20);
            this.tbPhone2.TabIndex = 5;
            // 
            // tbPhone1
            // 
            this.tbPhone1.Location = new System.Drawing.Point(155, 98);
            this.tbPhone1.Name = "tbPhone1";
            this.tbPhone1.Size = new System.Drawing.Size(189, 20);
            this.tbPhone1.TabIndex = 4;
            // 
            // lbPhone1
            // 
            this.lbPhone1.AutoSize = true;
            this.lbPhone1.Location = new System.Drawing.Point(6, 101);
            this.lbPhone1.Name = "lbPhone1";
            this.lbPhone1.Size = new System.Drawing.Size(90, 13);
            this.lbPhone1.TabIndex = 13;
            this.lbPhone1.Text = "Phone Number 1:";
            // 
            // cbxCredentials
            // 
            this.cbxCredentials.FormattingEnabled = true;
            this.cbxCredentials.Location = new System.Drawing.Point(199, 71);
            this.cbxCredentials.Name = "cbxCredentials";
            this.cbxCredentials.Size = new System.Drawing.Size(145, 21);
            this.cbxCredentials.TabIndex = 3;
            this.cbxCredentials.Text = "Credentials";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(155, 45);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(189, 20);
            this.tbLastName.TabIndex = 1;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(6, 48);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(61, 13);
            this.lbLastName.TabIndex = 10;
            this.lbLastName.Text = "Last Name:";
            // 
            // cbxAddress
            // 
            this.cbxAddress.FormattingEnabled = true;
            this.cbxAddress.Items.AddRange(new object[] {
            "New Address"});
            this.cbxAddress.Location = new System.Drawing.Point(9, 71);
            this.cbxAddress.Name = "cbxAddress";
            this.cbxAddress.Size = new System.Drawing.Size(184, 21);
            this.cbxAddress.TabIndex = 2;
            this.cbxAddress.Text = "Address";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(155, 19);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(189, 20);
            this.tbFirstName.TabIndex = 0;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(6, 22);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(60, 13);
            this.lbFirstName.TabIndex = 0;
            this.lbFirstName.Text = "First Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(12, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Add_Observer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 239);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddObserver);
            this.Controls.Add(this.gbAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Add_Observer";
            this.Text = "Add Observer";
            this.TopMost = true;
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.Button btnAddObserver;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbPhone2;
        private System.Windows.Forms.TextBox tbPhone2;
        private System.Windows.Forms.TextBox tbPhone1;
        private System.Windows.Forms.Label lbPhone1;
        private System.Windows.Forms.ComboBox cbxCredentials;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.ComboBox cbxAddress;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Button btnCancel;
    }
}