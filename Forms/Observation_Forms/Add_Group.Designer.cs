namespace XFiles.Forms.Observation_Forms
{
    partial class Add_Group
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
            this.tbGroup = new System.Windows.Forms.GroupBox();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.lbGroupName = new System.Windows.Forms.Label();
            this.cbxGroupStatus = new System.Windows.Forms.ComboBox();
            this.tbGroupName = new System.Windows.Forms.TextBox();
            this.lbxMembers = new System.Windows.Forms.ListBox();
            this.gbExisting = new System.Windows.Forms.GroupBox();
            this.btnAddNewObserver = new System.Windows.Forms.Button();
            this.lbxExisting = new System.Windows.Forms.ListBox();
            this.btnAddExisiting = new System.Windows.Forms.Button();
            this.tbGroup.SuspendLayout();
            this.gbExisting.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(12, 512);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(292, 512);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Group";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbGroup
            // 
            this.tbGroup.Controls.Add(this.btnRemoveMember);
            this.tbGroup.Controls.Add(this.lbGroupName);
            this.tbGroup.Controls.Add(this.cbxGroupStatus);
            this.tbGroup.Controls.Add(this.tbGroupName);
            this.tbGroup.Controls.Add(this.lbxMembers);
            this.tbGroup.Location = new System.Drawing.Point(12, 292);
            this.tbGroup.Name = "tbGroup";
            this.tbGroup.Size = new System.Drawing.Size(350, 209);
            this.tbGroup.TabIndex = 9;
            this.tbGroup.TabStop = false;
            this.tbGroup.Text = "Group";
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveMember.Location = new System.Drawing.Point(6, 53);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(105, 23);
            this.btnRemoveMember.TabIndex = 21;
            this.btnRemoveMember.Text = "Remove Member";
            this.btnRemoveMember.UseVisualStyleBackColor = true;
            this.btnRemoveMember.Click += new System.EventHandler(this.btnRemoveMember_Click);
            // 
            // lbGroupName
            // 
            this.lbGroupName.AutoSize = true;
            this.lbGroupName.Location = new System.Drawing.Point(6, 22);
            this.lbGroupName.Name = "lbGroupName";
            this.lbGroupName.Size = new System.Drawing.Size(64, 13);
            this.lbGroupName.TabIndex = 22;
            this.lbGroupName.Text = "GroupName";
            // 
            // cbxGroupStatus
            // 
            this.cbxGroupStatus.FormattingEnabled = true;
            this.cbxGroupStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cbxGroupStatus.Location = new System.Drawing.Point(223, 53);
            this.cbxGroupStatus.Name = "cbxGroupStatus";
            this.cbxGroupStatus.Size = new System.Drawing.Size(121, 21);
            this.cbxGroupStatus.TabIndex = 11;
            this.cbxGroupStatus.Text = "Group Status";
            // 
            // tbGroupName
            // 
            this.tbGroupName.Location = new System.Drawing.Point(155, 19);
            this.tbGroupName.Name = "tbGroupName";
            this.tbGroupName.Size = new System.Drawing.Size(189, 20);
            this.tbGroupName.TabIndex = 21;
            // 
            // lbxMembers
            // 
            this.lbxMembers.FormattingEnabled = true;
            this.lbxMembers.Location = new System.Drawing.Point(6, 82);
            this.lbxMembers.Name = "lbxMembers";
            this.lbxMembers.Size = new System.Drawing.Size(338, 121);
            this.lbxMembers.TabIndex = 10;
            // 
            // gbExisting
            // 
            this.gbExisting.Controls.Add(this.btnAddNewObserver);
            this.gbExisting.Controls.Add(this.lbxExisting);
            this.gbExisting.Controls.Add(this.btnAddExisiting);
            this.gbExisting.Location = new System.Drawing.Point(12, 12);
            this.gbExisting.Name = "gbExisting";
            this.gbExisting.Size = new System.Drawing.Size(350, 274);
            this.gbExisting.TabIndex = 10;
            this.gbExisting.TabStop = false;
            this.gbExisting.Text = "Add Exisiting Observer";
            // 
            // btnAddNewObserver
            // 
            this.btnAddNewObserver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewObserver.Location = new System.Drawing.Point(220, 19);
            this.btnAddNewObserver.Name = "btnAddNewObserver";
            this.btnAddNewObserver.Size = new System.Drawing.Size(121, 23);
            this.btnAddNewObserver.TabIndex = 23;
            this.btnAddNewObserver.Text = "Add New Observer";
            this.btnAddNewObserver.UseVisualStyleBackColor = true;
            this.btnAddNewObserver.Click += new System.EventHandler(this.btnAddNewObserver_Click);
            // 
            // lbxExisting
            // 
            this.lbxExisting.FormattingEnabled = true;
            this.lbxExisting.Location = new System.Drawing.Point(6, 19);
            this.lbxExisting.Name = "lbxExisting";
            this.lbxExisting.Size = new System.Drawing.Size(205, 238);
            this.lbxExisting.TabIndex = 22;
            // 
            // btnAddExisiting
            // 
            this.btnAddExisiting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExisiting.Location = new System.Drawing.Point(220, 234);
            this.btnAddExisiting.Name = "btnAddExisiting";
            this.btnAddExisiting.Size = new System.Drawing.Size(121, 23);
            this.btnAddExisiting.TabIndex = 21;
            this.btnAddExisiting.Text = "Add to Group";
            this.btnAddExisiting.UseVisualStyleBackColor = true;
            this.btnAddExisiting.Click += new System.EventHandler(this.btnAddExisiting_Click);
            // 
            // Add_Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 547);
            this.Controls.Add(this.gbExisting);
            this.Controls.Add(this.tbGroup);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Add_Group";
            this.Text = "Add Group";
            this.TopMost = true;
            this.tbGroup.ResumeLayout(false);
            this.tbGroup.PerformLayout();
            this.gbExisting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox tbGroup;
        private System.Windows.Forms.ComboBox cbxGroupStatus;
        private System.Windows.Forms.ListBox lbxMembers;
        private System.Windows.Forms.Button btnRemoveMember;
        private System.Windows.Forms.Label lbGroupName;
        private System.Windows.Forms.TextBox tbGroupName;
        private System.Windows.Forms.GroupBox gbExisting;
        private System.Windows.Forms.ListBox lbxExisting;
        private System.Windows.Forms.Button btnAddExisiting;
        private System.Windows.Forms.Button btnAddNewObserver;
    }
}