﻿namespace XFiles.Forms.Search_Forms
{
    partial class AddTable
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
            this.gbBox = new System.Windows.Forms.GroupBox();
            this.chlbxTables = new System.Windows.Forms.CheckedListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.gbBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBox
            // 
            this.gbBox.Controls.Add(this.chlbxTables);
            this.gbBox.Location = new System.Drawing.Point(6, 12);
            this.gbBox.Name = "gbBox";
            this.gbBox.Size = new System.Drawing.Size(261, 209);
            this.gbBox.TabIndex = 8;
            this.gbBox.TabStop = false;
            this.gbBox.Text = "Add Table";
            // 
            // chlbxTables
            // 
            this.chlbxTables.FormattingEnabled = true;
            this.chlbxTables.Location = new System.Drawing.Point(8, 24);
            this.chlbxTables.Name = "chlbxTables";
            this.chlbxTables.Size = new System.Drawing.Size(244, 169);
            this.chlbxTables.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(6, 237);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(192, 237);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // AddTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(274, 272);
            this.Controls.Add(this.gbBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(290, 306);
            this.MinimumSize = new System.Drawing.Size(290, 306);
            this.Name = "AddTable";
            this.Text = "Add Table";
            this.TopMost = true;
            this.gbBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBox;
        private System.Windows.Forms.CheckedListBox chlbxTables;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}