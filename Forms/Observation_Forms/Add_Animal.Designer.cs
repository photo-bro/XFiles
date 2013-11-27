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
            this.tbSpecies = new System.Windows.Forms.TextBox();
            this.lbSpecies = new System.Windows.Forms.Label();
            this.tbCharacteristics = new System.Windows.Forms.TextBox();
            this.lbCharacteristics = new System.Windows.Forms.Label();
            this.tbGenus = new System.Windows.Forms.TextBox();
            this.lbGenus = new System.Windows.Forms.Label();
            this.tbCommonName = new System.Windows.Forms.TextBox();
            this.lbCommonName = new System.Windows.Forms.Label();
            this.gbAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(287, 239);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Animal";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(12, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.tbSpecies);
            this.gbAdd.Controls.Add(this.lbSpecies);
            this.gbAdd.Controls.Add(this.tbCharacteristics);
            this.gbAdd.Controls.Add(this.lbCharacteristics);
            this.gbAdd.Controls.Add(this.tbGenus);
            this.gbAdd.Controls.Add(this.lbGenus);
            this.gbAdd.Controls.Add(this.tbCommonName);
            this.gbAdd.Controls.Add(this.lbCommonName);
            this.gbAdd.Location = new System.Drawing.Point(12, 12);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(350, 216);
            this.gbAdd.TabIndex = 2;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Add Animal";
            // 
            // tbSpecies
            // 
            this.tbSpecies.Location = new System.Drawing.Point(155, 76);
            this.tbSpecies.Name = "tbSpecies";
            this.tbSpecies.Size = new System.Drawing.Size(189, 20);
            this.tbSpecies.TabIndex = 7;
            // 
            // lbSpecies
            // 
            this.lbSpecies.AutoSize = true;
            this.lbSpecies.Location = new System.Drawing.Point(6, 79);
            this.lbSpecies.Name = "lbSpecies";
            this.lbSpecies.Size = new System.Drawing.Size(48, 13);
            this.lbSpecies.TabIndex = 6;
            this.lbSpecies.Text = "Species:";
            // 
            // tbCharacteristics
            // 
            this.tbCharacteristics.Location = new System.Drawing.Point(155, 102);
            this.tbCharacteristics.Multiline = true;
            this.tbCharacteristics.Name = "tbCharacteristics";
            this.tbCharacteristics.Size = new System.Drawing.Size(189, 91);
            this.tbCharacteristics.TabIndex = 5;
            // 
            // lbCharacteristics
            // 
            this.lbCharacteristics.AutoSize = true;
            this.lbCharacteristics.Location = new System.Drawing.Point(6, 105);
            this.lbCharacteristics.Name = "lbCharacteristics";
            this.lbCharacteristics.Size = new System.Drawing.Size(79, 13);
            this.lbCharacteristics.TabIndex = 4;
            this.lbCharacteristics.Text = "Characteristics:";
            // 
            // tbGenus
            // 
            this.tbGenus.Location = new System.Drawing.Point(155, 50);
            this.tbGenus.Name = "tbGenus";
            this.tbGenus.Size = new System.Drawing.Size(189, 20);
            this.tbGenus.TabIndex = 3;
            // 
            // lbGenus
            // 
            this.lbGenus.AutoSize = true;
            this.lbGenus.Location = new System.Drawing.Point(6, 53);
            this.lbGenus.Name = "lbGenus";
            this.lbGenus.Size = new System.Drawing.Size(41, 13);
            this.lbGenus.TabIndex = 2;
            this.lbGenus.Text = "Genus:";
            // 
            // tbCommonName
            // 
            this.tbCommonName.Location = new System.Drawing.Point(155, 24);
            this.tbCommonName.Name = "tbCommonName";
            this.tbCommonName.Size = new System.Drawing.Size(189, 20);
            this.tbCommonName.TabIndex = 1;
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
            // Add_Animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 274);
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
        private System.Windows.Forms.TextBox tbCharacteristics;
        private System.Windows.Forms.Label lbCharacteristics;
        private System.Windows.Forms.TextBox tbGenus;
        private System.Windows.Forms.Label lbGenus;
        private System.Windows.Forms.TextBox tbCommonName;
        private System.Windows.Forms.Label lbCommonName;
        private System.Windows.Forms.TextBox tbSpecies;
        private System.Windows.Forms.Label lbSpecies;
    }
}