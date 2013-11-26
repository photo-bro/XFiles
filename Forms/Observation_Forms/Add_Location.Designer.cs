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
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.cbxAddress = new System.Windows.Forms.ComboBox();
            this.gbAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(12, 153);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(265, 153);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Location";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbOfficialName
            // 
            this.lbOfficialName.AutoSize = true;
            this.lbOfficialName.Location = new System.Drawing.Point(6, 99);
            this.lbOfficialName.Name = "lbOfficialName";
            this.lbOfficialName.Size = new System.Drawing.Size(72, 13);
            this.lbOfficialName.TabIndex = 0;
            this.lbOfficialName.Text = "Formal Name:";
            // 
            // tbOfficialName
            // 
            this.tbOfficialName.Location = new System.Drawing.Point(155, 96);
            this.tbOfficialName.Name = "tbOfficialName";
            this.tbOfficialName.Size = new System.Drawing.Size(189, 20);
            this.tbOfficialName.TabIndex = 1;
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.cbxAddress);
            this.gbAdd.Controls.Add(this.tbOfficialName);
            this.gbAdd.Controls.Add(this.lbOfficialName);
            this.gbAdd.Location = new System.Drawing.Point(12, 12);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(350, 135);
            this.gbAdd.TabIndex = 5;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Add Location";
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
            this.cbxAddress.SelectedIndexChanged += new System.EventHandler(this.cbxAddress_SelectedIndexChanged);
            // 
            // Add_Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 188);
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
        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.ComboBox cbxAddress;
    }
}