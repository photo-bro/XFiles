namespace XFiles.Forms.Observation_Forms
{
    partial class Add_Address
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
            this.lbZipcode = new System.Windows.Forms.Label();
            this.tbZipcode = new System.Windows.Forms.TextBox();
            this.tbState = new System.Windows.Forms.TextBox();
            this.lbState = new System.Windows.Forms.Label();
            this.tbBuildingNo = new System.Windows.Forms.TextBox();
            this.lbBuildingNo = new System.Windows.Forms.Label();
            this.tbStreetName = new System.Windows.Forms.TextBox();
            this.lbStreetName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.lbZipcode);
            this.gbAdd.Controls.Add(this.tbZipcode);
            this.gbAdd.Controls.Add(this.tbState);
            this.gbAdd.Controls.Add(this.lbState);
            this.gbAdd.Controls.Add(this.tbBuildingNo);
            this.gbAdd.Controls.Add(this.lbBuildingNo);
            this.gbAdd.Controls.Add(this.tbStreetName);
            this.gbAdd.Controls.Add(this.lbStreetName);
            this.gbAdd.Location = new System.Drawing.Point(12, 20);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(350, 141);
            this.gbAdd.TabIndex = 9;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Add Address";
            // 
            // lbZipcode
            // 
            this.lbZipcode.AutoSize = true;
            this.lbZipcode.Location = new System.Drawing.Point(6, 100);
            this.lbZipcode.Name = "lbZipcode";
            this.lbZipcode.Size = new System.Drawing.Size(49, 13);
            this.lbZipcode.TabIndex = 17;
            this.lbZipcode.Text = "Zipcode:";
            // 
            // tbZipcode
            // 
            this.tbZipcode.Location = new System.Drawing.Point(155, 97);
            this.tbZipcode.Name = "tbZipcode";
            this.tbZipcode.Size = new System.Drawing.Size(189, 20);
            this.tbZipcode.TabIndex = 16;
            // 
            // tbState
            // 
            this.tbState.Location = new System.Drawing.Point(155, 71);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(189, 20);
            this.tbState.TabIndex = 14;
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Location = new System.Drawing.Point(6, 74);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(38, 13);
            this.lbState.TabIndex = 13;
            this.lbState.Text = "State: ";
            // 
            // tbBuildingNo
            // 
            this.tbBuildingNo.Location = new System.Drawing.Point(155, 45);
            this.tbBuildingNo.Name = "tbBuildingNo";
            this.tbBuildingNo.Size = new System.Drawing.Size(189, 20);
            this.tbBuildingNo.TabIndex = 11;
            // 
            // lbBuildingNo
            // 
            this.lbBuildingNo.AutoSize = true;
            this.lbBuildingNo.Location = new System.Drawing.Point(6, 48);
            this.lbBuildingNo.Name = "lbBuildingNo";
            this.lbBuildingNo.Size = new System.Drawing.Size(87, 13);
            this.lbBuildingNo.TabIndex = 10;
            this.lbBuildingNo.Text = "Building Number:";
            // 
            // tbStreetName
            // 
            this.tbStreetName.Location = new System.Drawing.Point(155, 19);
            this.tbStreetName.Name = "tbStreetName";
            this.tbStreetName.Size = new System.Drawing.Size(189, 20);
            this.tbStreetName.TabIndex = 1;
            // 
            // lbStreetName
            // 
            this.lbStreetName.AutoSize = true;
            this.lbStreetName.Location = new System.Drawing.Point(6, 22);
            this.lbStreetName.Name = "lbStreetName";
            this.lbStreetName.Size = new System.Drawing.Size(63, 13);
            this.lbStreetName.TabIndex = 0;
            this.lbStreetName.Text = "StreetName";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(12, 167);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(254, 167);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Address";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // Add_Address
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 202);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Add_Address";
            this.Text = "Add Address";
            this.TopMost = true;
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.Label lbZipcode;
        private System.Windows.Forms.TextBox tbZipcode;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.TextBox tbBuildingNo;
        private System.Windows.Forms.Label lbBuildingNo;
        private System.Windows.Forms.TextBox tbStreetName;
        private System.Windows.Forms.Label lbStreetName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
    }
}