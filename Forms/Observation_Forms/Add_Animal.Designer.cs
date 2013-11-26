namespace XFiles.Forms.Observation_Forms
{
    partial class Add_Animal
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.lbCommonName = new System.Windows.Forms.Label();
            this.tbCommonName = new System.Windows.Forms.TextBox();
            this.tbScientificName = new System.Windows.Forms.TextBox();
            this.lbScientificName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbCharacteristics = new System.Windows.Forms.Label();
            this.gbAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(287, 341);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Animal";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(12, 341);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.textBox1);
            this.gbAdd.Controls.Add(this.lbCharacteristics);
            this.gbAdd.Controls.Add(this.tbScientificName);
            this.gbAdd.Controls.Add(this.lbScientificName);
            this.gbAdd.Controls.Add(this.tbCommonName);
            this.gbAdd.Controls.Add(this.lbCommonName);
            this.gbAdd.Location = new System.Drawing.Point(12, 12);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(350, 313);
            this.gbAdd.TabIndex = 2;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Add Animal";
            // 
            // lbCommonName
            // 
            this.lbCommonName.AutoSize = true;
            this.lbCommonName.Location = new System.Drawing.Point(6, 27);
            this.lbCommonName.Name = "lbCommonName";
            this.lbCommonName.Size = new System.Drawing.Size(82, 13);
            this.lbCommonName.TabIndex = 0;
            this.lbCommonName.Text = "Common Name:";
            // 
            // tbCommonName
            // 
            this.tbCommonName.Location = new System.Drawing.Point(155, 24);
            this.tbCommonName.Name = "tbCommonName";
            this.tbCommonName.Size = new System.Drawing.Size(189, 20);
            this.tbCommonName.TabIndex = 1;
            // 
            // tbScientificName
            // 
            this.tbScientificName.Location = new System.Drawing.Point(155, 50);
            this.tbScientificName.Name = "tbScientificName";
            this.tbScientificName.Size = new System.Drawing.Size(189, 20);
            this.tbScientificName.TabIndex = 3;
            // 
            // lbScientificName
            // 
            this.lbScientificName.AutoSize = true;
            this.lbScientificName.Location = new System.Drawing.Point(6, 53);
            this.lbScientificName.Name = "lbScientificName";
            this.lbScientificName.Size = new System.Drawing.Size(84, 13);
            this.lbScientificName.TabIndex = 2;
            this.lbScientificName.Text = "Scientific Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 76);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 91);
            this.textBox1.TabIndex = 5;
            // 
            // lbCharacteristics
            // 
            this.lbCharacteristics.AutoSize = true;
            this.lbCharacteristics.Location = new System.Drawing.Point(6, 79);
            this.lbCharacteristics.Name = "lbCharacteristics";
            this.lbCharacteristics.Size = new System.Drawing.Size(79, 13);
            this.lbCharacteristics.TabIndex = 4;
            this.lbCharacteristics.Text = "Characteristics:";
            // 
            // Add_Animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 376);
            this.Controls.Add(this.gbAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Add_Animal";
            this.Text = "Add Animal";
            this.TopMost = true;
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbCharacteristics;
        private System.Windows.Forms.TextBox tbScientificName;
        private System.Windows.Forms.Label lbScientificName;
        private System.Windows.Forms.TextBox tbCommonName;
        private System.Windows.Forms.Label lbCommonName;
    }
}