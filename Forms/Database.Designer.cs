namespace XFiles
{
    partial class Database
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabOne = new System.Windows.Forms.TabPage();
            this.dgvView1 = new System.Windows.Forms.DataGridView();
            this.tabTwo = new System.Windows.Forms.TabPage();
            this.dgvView2 = new System.Windows.Forms.DataGridView();
            this.tabThree = new System.Windows.Forms.TabPage();
            this.dgvView3 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportArcGISToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ErrorStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlMain.SuspendLayout();
            this.tabOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView1)).BeginInit();
            this.tabTwo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView2)).BeginInit();
            this.tabThree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabOne);
            this.tabControlMain.Controls.Add(this.tabTwo);
            this.tabControlMain.Controls.Add(this.tabThree);
            this.tabControlMain.Location = new System.Drawing.Point(12, 27);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(760, 479);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Refresh);
            // 
            // tabOne
            // 
            this.tabOne.Controls.Add(this.dgvView1);
            this.tabOne.Location = new System.Drawing.Point(4, 22);
            this.tabOne.Name = "tabOne";
            this.tabOne.Padding = new System.Windows.Forms.Padding(3);
            this.tabOne.Size = new System.Drawing.Size(752, 453);
            this.tabOne.TabIndex = 0;
            this.tabOne.Text = "View 1";
            this.tabOne.UseVisualStyleBackColor = true;
            // 
            // dgvView1
            // 
            this.dgvView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView1.Location = new System.Drawing.Point(6, 6);
            this.dgvView1.Name = "dgvView1";
            this.dgvView1.Size = new System.Drawing.Size(740, 440);
            this.dgvView1.TabIndex = 0;
            this.dgvView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Refresh);
            // 
            // tabTwo
            // 
            this.tabTwo.Controls.Add(this.dgvView2);
            this.tabTwo.Location = new System.Drawing.Point(4, 22);
            this.tabTwo.Name = "tabTwo";
            this.tabTwo.Padding = new System.Windows.Forms.Padding(3);
            this.tabTwo.Size = new System.Drawing.Size(752, 453);
            this.tabTwo.TabIndex = 1;
            this.tabTwo.Text = "View 2";
            this.tabTwo.UseVisualStyleBackColor = true;
            // 
            // dgvView2
            // 
            this.dgvView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView2.Location = new System.Drawing.Point(6, 6);
            this.dgvView2.Name = "dgvView2";
            this.dgvView2.Size = new System.Drawing.Size(740, 440);
            this.dgvView2.TabIndex = 1;
            this.dgvView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Refresh);
            // 
            // tabThree
            // 
            this.tabThree.Controls.Add(this.dgvView3);
            this.tabThree.Location = new System.Drawing.Point(4, 22);
            this.tabThree.Name = "tabThree";
            this.tabThree.Size = new System.Drawing.Size(752, 453);
            this.tabThree.TabIndex = 2;
            this.tabThree.Text = "View 3";
            this.tabThree.UseVisualStyleBackColor = true;
            // 
            // dgvView3
            // 
            this.dgvView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView3.Location = new System.Drawing.Point(6, 6);
            this.dgvView3.Name = "dgvView3";
            this.dgvView3.Size = new System.Drawing.Size(740, 440);
            this.dgvView3.TabIndex = 1;
            this.dgvView3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Refresh);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.commandsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exportArcGISToolStripMenuItem,
            this.exportViewToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputFileToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // inputFileToolStripMenuItem
            // 
            this.inputFileToolStripMenuItem.Name = "inputFileToolStripMenuItem";
            this.inputFileToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.inputFileToolStripMenuItem.Text = "Input File";
            // 
            // exportArcGISToolStripMenuItem
            // 
            this.exportArcGISToolStripMenuItem.Name = "exportArcGISToolStripMenuItem";
            this.exportArcGISToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.exportArcGISToolStripMenuItem.Text = "Export ArcGIS";
            // 
            // exportViewToolStripMenuItem
            // 
            this.exportViewToolStripMenuItem.Name = "exportViewToolStripMenuItem";
            this.exportViewToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.exportViewToolStripMenuItem.Text = "Export View";
            this.exportViewToolStripMenuItem.Click += new System.EventHandler(this.exportViewToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // commandsToolStripMenuItem
            // 
            this.commandsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.testToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.customSearchToolStripMenuItem});
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            this.commandsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.commandsToolStripMenuItem.Text = "Commands";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.modifyToolStripMenuItem.Text = "Modify";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // customSearchToolStripMenuItem
            // 
            this.customSearchToolStripMenuItem.Name = "customSearchToolStripMenuItem";
            this.customSearchToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.customSearchToolStripMenuItem.Text = "Custom Search";
            this.customSearchToolStripMenuItem.Click += new System.EventHandler(this.customSearchToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMenuToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpMenuToolStripMenuItem
            // 
            this.helpMenuToolStripMenuItem.Name = "helpMenuToolStripMenuItem";
            this.helpMenuToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.helpMenuToolStripMenuItem.Text = "Help Menu";
            // 
            // btnQuery
            // 
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.Location = new System.Drawing.Point(12, 512);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "Search";
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Location = new System.Drawing.Point(93, 512);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.ConnectionStatus,
            this.ErrorStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(82, 17);
            this.StatusLabel.Text = "Current Status";
            // 
            // ConnectionStatus
            // 
            this.ConnectionStatus.Name = "ConnectionStatus";
            this.ConnectionStatus.Size = new System.Drawing.Size(104, 17);
            this.ConnectionStatus.Text = "Connection Status";
            // 
            // ErrorStatus
            // 
            this.ErrorStatus.Name = "ErrorStatus";
            this.ErrorStatus.Size = new System.Drawing.Size(56, 17);
            this.ErrorStatus.Text = "Last Error";
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Database";
            this.ShowIcon = false;
            this.Text = "Database View";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Refresh);
            this.tabControlMain.ResumeLayout(false);
            this.tabOne.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView1)).EndInit();
            this.tabTwo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView2)).EndInit();
            this.tabThree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabOne;
        private System.Windows.Forms.TabPage tabTwo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvView1;
        private System.Windows.Forms.DataGridView dgvView2;
        private System.Windows.Forms.TabPage tabThree;
        private System.Windows.Forms.DataGridView dgvView3;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel ConnectionStatus;
        private System.Windows.Forms.ToolStripStatusLabel ErrorStatus;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportArcGISToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customSearchToolStripMenuItem;
    }
}

