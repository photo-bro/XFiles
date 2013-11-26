namespace XFiles.Forms.Observation_Forms
{
    partial class Add_Location
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbOfficialName = new System.Windows.Forms.Label();
            this.tbOfficialName = new System.Windows.Forms.TextBox();
            this.lbLocality = new System.Windows.Forms.Label();
            this.tbLocality = new System.Windows.Forms.TextBox();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.tbLatitude = new System.Windows.Forms.TextBox();
            this.lbLatitude = new System.Windows.Forms.Label();
            this.tbLongitude = new System.Windows.Forms.TextBox();
            this.lbLongitude = new System.Windows.Forms.Label();
            this.cbxAddress = new System.Windows.Forms.ComboBox();
            this.gbAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(12, 341);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(265, 341);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Location";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lbOfficialName
            // 
            this.lbOfficialName.AutoSize = true;
            this.lbOfficialName.Location = new System.Drawing.Point(6, 96);
            this.lbOfficialName.Name = "lbOfficialName";
            this.lbOfficialName.Size = new System.Drawing.Size(72, 13);
            this.lbOfficialName.TabIndex = 0;
            this.lbOfficialName.Text = "Formal Name:";
            // 
            // tbOfficialName
            // 
            this.tbOfficialName.Location = new System.Drawing.Point(155, 93);
            this.tbOfficialName.Name = "tbOfficialName";
            this.tbOfficialName.Size = new System.Drawing.Size(189, 20);
            this.tbOfficialName.TabIndex = 1;
            // 
            // lbLocality
            // 
            this.lbLocality.AutoSize = true;
            this.lbLocality.Location = new System.Drawing.Point(6, 122);
            this.lbLocality.Name = "lbLocality";
            this.lbLocality.Size = new System.Drawing.Size(46, 13);
            this.lbLocality.TabIndex = 2;
            this.lbLocality.Text = "Locality:";
            // 
            // tbLocality
            // 
            this.tbLocality.Location = new System.Drawing.Point(155, 119);
            this.tbLocality.Name = "tbLocality";
            this.tbLocality.Size = new System.Drawing.Size(189, 20);
            this.tbLocality.TabIndex = 3;
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.cbxAddress);
            this.gbAdd.Controls.Add(this.tbLongitude);
            this.gbAdd.Controls.Add(this.lbLongitude);
            this.gbAdd.Controls.Add(this.tbLatitude);
            this.gbAdd.Controls.Add(this.lbLatitude);
            this.gbAdd.Controls.Add(this.tbLocality);
            this.gbAdd.Controls.Add(this.lbLocality);
            this.gbAdd.Controls.Add(this.tbOfficialName);
            this.gbAdd.Controls.Add(this.lbOfficialName);
            this.gbAdd.Location = new System.Drawing.Point(12, 12);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(350, 313);
            this.gbAdd.TabIndex = 5;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Add Location";
            // 
            // tbLatitude
            // 
            this.tbLatitude.Location = new System.Drawing.Point(155, 145);
            this.tbLatitude.Name = "tbLatitude";
            this.tbLatitude.Size = new System.Drawing.Size(189, 20);
            this.tbLatitude.TabIndex = 5;
            // 
            // lbLatitude
            // 
            this.lbLatitude.AutoSize = true;
            this.lbLatitude.Location = new System.Drawing.Point(6, 148);
            this.lbLatitude.Name = "lbLatitude";
            this.lbLatitude.Size = new System.Drawing.Size(48, 13);
            this.lbLatitude.TabIndex = 4;
            this.lbLatitude.Text = "Latitude:";
            // 
            // tbLongitude
            // 
            this.tbLongitude.Location = new System.Drawing.Point(155, 171);
            this.tbLongitude.Name = "tbLongitude";
            this.tbLongitude.Size = new System.Drawing.Size(189, 20);
            this.tbLongitude.TabIndex = 7;
            // 
            // lbLongitude
            // 
            this.lbLongitude.AutoSize = true;
            this.lbLongitude.Location = new System.Drawing.Point(6, 174);
            this.lbLongitude.Name = "lbLongitude";
            this.lbLongitude.Size = new System.Drawing.Size(57, 13);
            this.lbLongitude.TabIndex = 6;
            this.lbLongitude.Text = "Longitude:";
            // 
            // cbxAddress
            // 
            this.cbxAddress.FormattingEnabled = true;
            this.cbxAddress.Items.AddRange(new object[] {
            "New Address"});
            this.cbxAddress.Location = new System.Drawing.Point(90, 39);
            this.cbxAddress.Name = "cbxAddress";
            this.cbxAddress.Size = new System.Drawing.Size(184, 21);
            this.cbxAddress.TabIndex = 8;
            this.cbxAddress.Text = "Address";
            // 
            // Add_Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 376);
            this.Controls.Add(this.gbAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Add_Location";
            this.Text = "Add Location";
            this.TopMost = true;
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbOfficialName;
        private System.Windows.Forms.TextBox tbOfficialName;
        private System.Windows.Forms.Label lbLocality;
        private System.Windows.Forms.TextBox tbLocality;
        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.ComboBox cbxAddress;
        private System.Windows.Forms.TextBox tbLongitude;
        private System.Windows.Forms.Label lbLongitude;
        private System.Windows.Forms.TextBox tbLatitude;
        private System.Windows.Forms.Label lbLatitude;
    }
}