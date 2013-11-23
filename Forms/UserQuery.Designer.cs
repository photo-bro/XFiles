namespace XFiles.Forms
{
    partial class UserQuery
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbSQ_String = new System.Windows.Forms.GroupBox();
            this.tbSQL_String = new System.Windows.Forms.TextBox();
            this.gbSeachComponents = new System.Windows.Forms.GroupBox();
            this.btnConditions = new System.Windows.Forms.Button();
            this.tbConditions = new System.Windows.Forms.TextBox();
            this.lbConditions = new System.Windows.Forms.Label();
            this.btnAddIn = new System.Windows.Forms.Button();
            this.tbIn = new System.Windows.Forms.TextBox();
            this.lbIn = new System.Windows.Forms.Label();
            this.btnAddFind = new System.Windows.Forms.Button();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.lbFind = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbSQ_String.SuspendLayout();
            this.gbSeachComponents.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(556, 405);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 25);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(12, 405);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbSQ_String
            // 
            this.gbSQ_String.Controls.Add(this.tbSQL_String);
            this.gbSQ_String.Location = new System.Drawing.Point(12, 231);
            this.gbSQ_String.Name = "gbSQ_String";
            this.gbSQ_String.Size = new System.Drawing.Size(600, 168);
            this.gbSQ_String.TabIndex = 3;
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
            this.tbSQL_String.Size = new System.Drawing.Size(588, 143);
            this.tbSQL_String.TabIndex = 0;
            this.tbSQL_String.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserQuery_MouseClick);
            // 
            // gbSeachComponents
            // 
            this.gbSeachComponents.Controls.Add(this.btnConditions);
            this.gbSeachComponents.Controls.Add(this.tbConditions);
            this.gbSeachComponents.Controls.Add(this.lbConditions);
            this.gbSeachComponents.Controls.Add(this.btnAddIn);
            this.gbSeachComponents.Controls.Add(this.tbIn);
            this.gbSeachComponents.Controls.Add(this.lbIn);
            this.gbSeachComponents.Controls.Add(this.btnAddFind);
            this.gbSeachComponents.Controls.Add(this.tbFind);
            this.gbSeachComponents.Controls.Add(this.lbFind);
            this.gbSeachComponents.Location = new System.Drawing.Point(12, 12);
            this.gbSeachComponents.Name = "gbSeachComponents";
            this.gbSeachComponents.Size = new System.Drawing.Size(600, 213);
            this.gbSeachComponents.TabIndex = 4;
            this.gbSeachComponents.TabStop = false;
            this.gbSeachComponents.Text = "Search Database";
            // 
            // btnConditions
            // 
            this.btnConditions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConditions.Location = new System.Drawing.Point(502, 154);
            this.btnConditions.Name = "btnConditions";
            this.btnConditions.Size = new System.Drawing.Size(75, 53);
            this.btnConditions.TabIndex = 8;
            this.btnConditions.Text = "Add Condition";
            this.btnConditions.UseVisualStyleBackColor = true;
            this.btnConditions.Click += new System.EventHandler(this.btnConditions_Click);
            // 
            // tbConditions
            // 
            this.tbConditions.Location = new System.Drawing.Point(111, 85);
            this.tbConditions.Multiline = true;
            this.tbConditions.Name = "tbConditions";
            this.tbConditions.Size = new System.Drawing.Size(374, 122);
            this.tbConditions.TabIndex = 7;
            // 
            // lbConditions
            // 
            this.lbConditions.AutoSize = true;
            this.lbConditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConditions.Location = new System.Drawing.Point(22, 84);
            this.lbConditions.Name = "lbConditions";
            this.lbConditions.Size = new System.Drawing.Size(83, 18);
            this.lbConditions.TabIndex = 6;
            this.lbConditions.Text = "Conditions:";
            // 
            // btnAddIn
            // 
            this.btnAddIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIn.Location = new System.Drawing.Point(502, 57);
            this.btnAddIn.Name = "btnAddIn";
            this.btnAddIn.Size = new System.Drawing.Size(75, 23);
            this.btnAddIn.TabIndex = 5;
            this.btnAddIn.Text = "Add Item";
            this.btnAddIn.UseVisualStyleBackColor = true;
            this.btnAddIn.Click += new System.EventHandler(this.btnAddIn_Click);
            // 
            // tbIn
            // 
            this.tbIn.Location = new System.Drawing.Point(77, 59);
            this.tbIn.Name = "tbIn";
            this.tbIn.Size = new System.Drawing.Size(408, 20);
            this.tbIn.TabIndex = 4;
            // 
            // lbIn
            // 
            this.lbIn.AutoSize = true;
            this.lbIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIn.Location = new System.Drawing.Point(22, 58);
            this.lbIn.Name = "lbIn";
            this.lbIn.Size = new System.Drawing.Size(23, 18);
            this.lbIn.TabIndex = 3;
            this.lbIn.Text = "In:";
            // 
            // btnAddFind
            // 
            this.btnAddFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFind.Location = new System.Drawing.Point(502, 31);
            this.btnAddFind.Name = "btnAddFind";
            this.btnAddFind.Size = new System.Drawing.Size(75, 23);
            this.btnAddFind.TabIndex = 2;
            this.btnAddFind.Text = "Add Item";
            this.btnAddFind.UseVisualStyleBackColor = true;
            this.btnAddFind.Click += new System.EventHandler(this.btnAddFind_Click);
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(77, 33);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(408, 20);
            this.tbFind.TabIndex = 1;
            // 
            // lbFind
            // 
            this.lbFind.AutoSize = true;
            this.lbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFind.Location = new System.Drawing.Point(22, 32);
            this.lbFind.Name = "lbFind";
            this.lbFind.Size = new System.Drawing.Size(40, 18);
            this.lbFind.TabIndex = 0;
            this.lbFind.Text = "Find:";
            // 
            // UserQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.gbSeachComponents);
            this.Controls.Add(this.gbSQ_String);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "UserQuery";
            this.Text = "Search Database";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserQuery_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbSQ_String.ResumeLayout(false);
            this.gbSQ_String.PerformLayout();
            this.gbSeachComponents.ResumeLayout(false);
            this.gbSeachComponents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbSeachComponents;
        private System.Windows.Forms.GroupBox gbSQ_String;
        private System.Windows.Forms.TextBox tbSQL_String;
        private System.Windows.Forms.Button btnConditions;
        private System.Windows.Forms.TextBox tbConditions;
        private System.Windows.Forms.Label lbConditions;
        private System.Windows.Forms.Button btnAddIn;
        private System.Windows.Forms.TextBox tbIn;
        private System.Windows.Forms.Label lbIn;
        private System.Windows.Forms.Button btnAddFind;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Label lbFind;

    }
}