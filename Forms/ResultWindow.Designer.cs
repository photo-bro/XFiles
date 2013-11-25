namespace XFiles.Forms
{
    partial class ResultWindow
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
            this.btnClose = new System.Windows.Forms.Button();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tbSQL = new System.Windows.Forms.TextBox();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(697, 527);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbResult
            // 
            this.gbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResult.Controls.Add(this.dgv);
            this.gbResult.Location = new System.Drawing.Point(7, 5);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(765, 516);
            this.gbResult.TabIndex = 1;
            this.gbResult.TabStop = false;
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 13);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(753, 497);
            this.dgv.TabIndex = 1;
            // 
            // tbSQL
            // 
            this.tbSQL.BackColor = System.Drawing.Color.White;
            this.tbSQL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSQL.Location = new System.Drawing.Point(13, 527);
            this.tbSQL.Multiline = true;
            this.tbSQL.Name = "tbSQL";
            this.tbSQL.ReadOnly = true;
            this.tbSQL.Size = new System.Drawing.Size(678, 23);
            this.tbSQL.TabIndex = 2;
            this.tbSQL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbSQL_MouseClick);
            // 
            // ResultWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tbSQL);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.btnClose);
            this.Name = "ResultWindow";
            this.Text = "Result";
            this.gbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox tbSQL;
    }
}