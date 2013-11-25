namespace XFiles.Forms
{
    partial class AddObservation
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
            this.btnAddObserv = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbSQ_String = new System.Windows.Forms.GroupBox();
            this.tbSQL_String = new System.Windows.Forms.TextBox();
            this.gbObserParam = new System.Windows.Forms.GroupBox();
            this.gbSQ_String.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddObserv
            // 
            this.btnAddObserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddObserv.Location = new System.Drawing.Point(510, 567);
            this.btnAddObserv.Name = "btnAddObserv";
            this.btnAddObserv.Size = new System.Drawing.Size(102, 23);
            this.btnAddObserv.TabIndex = 0;
            this.btnAddObserv.Text = "Add Observation";
            this.btnAddObserv.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(12, 567);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // gbSQ_String
            // 
            this.gbSQ_String.Controls.Add(this.tbSQL_String);
            this.gbSQ_String.Location = new System.Drawing.Point(12, 406);
            this.gbSQ_String.Name = "gbSQ_String";
            this.gbSQ_String.Size = new System.Drawing.Size(600, 147);
            this.gbSQ_String.TabIndex = 4;
            this.gbSQ_String.TabStop = false;
            this.gbSQ_String.Text = "SQL String";
            // 
            // tbSQL_String
            // 
            this.tbSQL_String.BackColor = System.Drawing.Color.White;
            this.tbSQL_String.Location = new System.Drawing.Point(6, 19);
            this.tbSQL_String.Multiline = true;
            this.tbSQL_String.Name = "tbSQL_String";
            this.tbSQL_String.ReadOnly = true;
            this.tbSQL_String.Size = new System.Drawing.Size(588, 122);
            this.tbSQL_String.TabIndex = 0;
            // 
            // gbObserParam
            // 
            this.gbObserParam.Location = new System.Drawing.Point(18, 12);
            this.gbObserParam.Name = "gbObserParam";
            this.gbObserParam.Size = new System.Drawing.Size(588, 388);
            this.gbObserParam.TabIndex = 5;
            this.gbObserParam.TabStop = false;
            this.gbObserParam.Text = "Observation Parameters";
            // 
            // AddObservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 602);
            this.Controls.Add(this.gbObserParam);
            this.Controls.Add(this.gbSQ_String);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddObserv);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 640);
            this.MinimumSize = new System.Drawing.Size(640, 640);
            this.Name = "AddObservation";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Add Observation";
            this.TopMost = true;
            this.gbSQ_String.ResumeLayout(false);
            this.gbSQ_String.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddObserv;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbSQ_String;
        private System.Windows.Forms.TextBox tbSQL_String;
        private System.Windows.Forms.GroupBox gbObserParam;
    }
}