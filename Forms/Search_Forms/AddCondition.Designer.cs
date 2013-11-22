namespace XFiles.Forms.Search_Forms
{
    partial class AddCondition
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbBox = new System.Windows.Forms.GroupBox();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.lbCondition = new System.Windows.Forms.Label();
            this.lbValue = new System.Windows.Forms.Label();
            this.lbField = new System.Windows.Forms.Label();
            this.cbxCondition = new System.Windows.Forms.ComboBox();
            this.cbxField = new System.Windows.Forms.ComboBox();
            this.lbBool = new System.Windows.Forms.Label();
            this.cbxJoinCond = new System.Windows.Forms.ComboBox();
            this.gbBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(387, 142);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(12, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbBox
            // 
            this.gbBox.Controls.Add(this.lbBool);
            this.gbBox.Controls.Add(this.cbxJoinCond);
            this.gbBox.Controls.Add(this.tbValue);
            this.gbBox.Controls.Add(this.lbCondition);
            this.gbBox.Controls.Add(this.lbValue);
            this.gbBox.Controls.Add(this.lbField);
            this.gbBox.Controls.Add(this.cbxCondition);
            this.gbBox.Controls.Add(this.cbxField);
            this.gbBox.Location = new System.Drawing.Point(12, 12);
            this.gbBox.Name = "gbBox";
            this.gbBox.Size = new System.Drawing.Size(450, 124);
            this.gbBox.TabIndex = 2;
            this.gbBox.TabStop = false;
            this.gbBox.Text = "Add Condition";
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(294, 49);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(150, 20);
            this.tbValue.TabIndex = 6;
            // 
            // lbCondition
            // 
            this.lbCondition.AutoSize = true;
            this.lbCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCondition.Location = new System.Drawing.Point(182, 27);
            this.lbCondition.Name = "lbCondition";
            this.lbCondition.Size = new System.Drawing.Size(71, 18);
            this.lbCondition.TabIndex = 5;
            this.lbCondition.Text = "Condition";
            // 
            // lbValue
            // 
            this.lbValue.AutoSize = true;
            this.lbValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValue.Location = new System.Drawing.Point(291, 27);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(44, 18);
            this.lbValue.TabIndex = 4;
            this.lbValue.Text = "Value";
            // 
            // lbField
            // 
            this.lbField.AutoSize = true;
            this.lbField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbField.Location = new System.Drawing.Point(6, 27);
            this.lbField.Name = "lbField";
            this.lbField.Size = new System.Drawing.Size(39, 18);
            this.lbField.TabIndex = 3;
            this.lbField.Text = "Field";
            // 
            // cbxCondition
            // 
            this.cbxCondition.FormattingEnabled = true;
            this.cbxCondition.Location = new System.Drawing.Point(185, 48);
            this.cbxCondition.Name = "cbxCondition";
            this.cbxCondition.Size = new System.Drawing.Size(80, 21);
            this.cbxCondition.TabIndex = 1;
            // 
            // cbxField
            // 
            this.cbxField.FormattingEnabled = true;
            this.cbxField.Location = new System.Drawing.Point(6, 48);
            this.cbxField.Name = "cbxField";
            this.cbxField.Size = new System.Drawing.Size(150, 21);
            this.cbxField.TabIndex = 0;
            // 
            // lbBool
            // 
            this.lbBool.AutoSize = true;
            this.lbBool.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBool.Location = new System.Drawing.Point(125, 85);
            this.lbBool.Name = "lbBool";
            this.lbBool.Size = new System.Drawing.Size(103, 18);
            this.lbBool.TabIndex = 8;
            this.lbBool.Text = "Join Condition";
            // 
            // cbxJoinCond
            // 
            this.cbxJoinCond.FormattingEnabled = true;
            this.cbxJoinCond.Location = new System.Drawing.Point(234, 86);
            this.cbxJoinCond.Name = "cbxJoinCond";
            this.cbxJoinCond.Size = new System.Drawing.Size(74, 21);
            this.cbxJoinCond.TabIndex = 7;
            // 
            // AddCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 176);
            this.Controls.Add(this.gbBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 200);
            this.MinimumSize = new System.Drawing.Size(480, 200);
            this.Name = "AddCondition";
            this.Text = "Add Condition";
            this.gbBox.ResumeLayout(false);
            this.gbBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbBox;
        private System.Windows.Forms.ComboBox cbxCondition;
        private System.Windows.Forms.ComboBox cbxField;
        private System.Windows.Forms.Label lbCondition;
        private System.Windows.Forms.Label lbValue;
        private System.Windows.Forms.Label lbField;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label lbBool;
        private System.Windows.Forms.ComboBox cbxJoinCond;
    }
}