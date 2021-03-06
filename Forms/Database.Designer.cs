﻿namespace XFiles
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
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.openViewInNewWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVFilecsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textFiletxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVFilecsvToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.arcGISShapefileshpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dbActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addObservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popularSearchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ErrorStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAddObservation = new System.Windows.Forms.Button();
            this.allObservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabOne);
            this.tabControlMain.Controls.Add(this.tabTwo);
            this.tabControlMain.Controls.Add(this.tabThree);
            this.tabControlMain.Location = new System.Drawing.Point(12, 27);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(760, 479);
            this.tabControlMain.TabIndex = 5;
            this.tabControlMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Refresh);
            // 
            // tabOne
            // 
            this.tabOne.BackColor = System.Drawing.Color.White;
            this.tabOne.Controls.Add(this.dgvView1);
            this.tabOne.Location = new System.Drawing.Point(4, 22);
            this.tabOne.Name = "tabOne";
            this.tabOne.Padding = new System.Windows.Forms.Padding(3);
            this.tabOne.Size = new System.Drawing.Size(752, 453);
            this.tabOne.TabIndex = 0;
            this.tabOne.Text = "View 1";
            // 
            // dgvView1
            // 
            this.dgvView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvView1.BackgroundColor = System.Drawing.Color.White;
            this.dgvView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView1.Location = new System.Drawing.Point(6, 6);
            this.dgvView1.Name = "dgvView1";
            this.dgvView1.ReadOnly = true;
            this.dgvView1.Size = new System.Drawing.Size(740, 443);
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
            this.dgvView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvView2.BackgroundColor = System.Drawing.Color.White;
            this.dgvView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView2.Location = new System.Drawing.Point(6, 6);
            this.dgvView2.Name = "dgvView2";
            this.dgvView2.ReadOnly = true;
            this.dgvView2.Size = new System.Drawing.Size(740, 443);
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
            this.dgvView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvView3.BackgroundColor = System.Drawing.Color.White;
            this.dgvView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView3.Location = new System.Drawing.Point(6, 6);
            this.dgvView3.Name = "dgvView3";
            this.dgvView3.ReadOnly = true;
            this.dgvView3.Size = new System.Drawing.Size(740, 443);
            this.dgvView3.TabIndex = 1;
            this.dgvView3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Refresh);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dbActionsToolStripMenuItem,
            this.popularSearchesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 23);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripSeparator3,
            this.openViewInNewWindowToolStripMenuItem,
            this.toolStripSeparator1,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(256, 6);
            // 
            // openViewInNewWindowToolStripMenuItem
            // 
            this.openViewInNewWindowToolStripMenuItem.Name = "openViewInNewWindowToolStripMenuItem";
            this.openViewInNewWindowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.openViewInNewWindowToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.openViewInNewWindowToolStripMenuItem.Text = "Open View in New Window";
            this.openViewInNewWindowToolStripMenuItem.Click += new System.EventHandler(this.openViewInNewWindowToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(256, 6);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVFilecsvToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // cSVFilecsvToolStripMenuItem
            // 
            this.cSVFilecsvToolStripMenuItem.Name = "cSVFilecsvToolStripMenuItem";
            this.cSVFilecsvToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.cSVFilecsvToolStripMenuItem.Text = "CSV File (.csv)";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textFiletxtToolStripMenuItem,
            this.cSVFilecsvToolStripMenuItem1,
            this.arcGISShapefileshpToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // textFiletxtToolStripMenuItem
            // 
            this.textFiletxtToolStripMenuItem.Name = "textFiletxtToolStripMenuItem";
            this.textFiletxtToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.textFiletxtToolStripMenuItem.Text = "Text File (.txt)";
            this.textFiletxtToolStripMenuItem.Click += new System.EventHandler(this.textFiletxtToolStripMenuItem_Click);
            // 
            // cSVFilecsvToolStripMenuItem1
            // 
            this.cSVFilecsvToolStripMenuItem1.Name = "cSVFilecsvToolStripMenuItem1";
            this.cSVFilecsvToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.cSVFilecsvToolStripMenuItem1.Text = "CSV File (.csv)";
            this.cSVFilecsvToolStripMenuItem1.Click += new System.EventHandler(this.cSVFilecsvToolStripMenuItem1_Click);
            // 
            // arcGISShapefileshpToolStripMenuItem
            // 
            this.arcGISShapefileshpToolStripMenuItem.Name = "arcGISShapefileshpToolStripMenuItem";
            this.arcGISShapefileshpToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.arcGISShapefileshpToolStripMenuItem.Text = "ArcGIS Shapefile (.shp)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(256, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // dbActionsToolStripMenuItem
            // 
            this.dbActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.addObservationToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.customSearchToolStripMenuItem,
            this.testToolStripMenuItem});
            this.dbActionsToolStripMenuItem.Name = "dbActionsToolStripMenuItem";
            this.dbActionsToolStripMenuItem.Size = new System.Drawing.Size(110, 19);
            this.dbActionsToolStripMenuItem.Text = "Database Actions";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // addObservationToolStripMenuItem
            // 
            this.addObservationToolStripMenuItem.Name = "addObservationToolStripMenuItem";
            this.addObservationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addObservationToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.addObservationToolStripMenuItem.Text = "Add Observation";
            this.addObservationToolStripMenuItem.Click += new System.EventHandler(this.addObservationToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // customSearchToolStripMenuItem
            // 
            this.customSearchToolStripMenuItem.Name = "customSearchToolStripMenuItem";
            this.customSearchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.customSearchToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.customSearchToolStripMenuItem.Text = "Custom Search";
            this.customSearchToolStripMenuItem.Click += new System.EventHandler(this.customSearchToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.testToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // popularSearchesToolStripMenuItem
            // 
            this.popularSearchesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastSearchToolStripMenuItem,
            this.toolStripSeparator4,
            this.allObservationsToolStripMenuItem});
            this.popularSearchesToolStripMenuItem.Name = "popularSearchesToolStripMenuItem";
            this.popularSearchesToolStripMenuItem.Size = new System.Drawing.Size(54, 19);
            this.popularSearchesToolStripMenuItem.Text = "Search";
            // 
            // lastSearchToolStripMenuItem
            // 
            this.lastSearchToolStripMenuItem.Name = "lastSearchToolStripMenuItem";
            this.lastSearchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Space)));
            this.lastSearchToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.lastSearchToolStripMenuItem.Text = "Last Search";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(227, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMenuToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
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
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.Location = new System.Drawing.Point(122, 512);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.Text = "Search";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Location = new System.Drawing.Point(203, 512);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.ConnectionStatus,
            this.ErrorStatus});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 542);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 20);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(82, 15);
            this.StatusLabel.Text = "Current Status";
            // 
            // ConnectionStatus
            // 
            this.ConnectionStatus.Name = "ConnectionStatus";
            this.ConnectionStatus.Size = new System.Drawing.Size(104, 15);
            this.ConnectionStatus.Text = "Connection Status";
            // 
            // ErrorStatus
            // 
            this.ErrorStatus.Name = "ErrorStatus";
            this.ErrorStatus.Size = new System.Drawing.Size(56, 15);
            this.ErrorStatus.Text = "Last Error";
            // 
            // btnAddObservation
            // 
            this.btnAddObservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddObservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddObservation.Location = new System.Drawing.Point(12, 512);
            this.btnAddObservation.Name = "btnAddObservation";
            this.btnAddObservation.Size = new System.Drawing.Size(104, 23);
            this.btnAddObservation.TabIndex = 0;
            this.btnAddObservation.Text = "Add Observation";
            this.btnAddObservation.UseVisualStyleBackColor = true;
            this.btnAddObservation.Click += new System.EventHandler(this.btnAddObservation_Click);
            // 
            // allObservationsToolStripMenuItem
            // 
            this.allObservationsToolStripMenuItem.Name = "allObservationsToolStripMenuItem";
            this.allObservationsToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.allObservationsToolStripMenuItem.Text = "All Observations";
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnAddObservation);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Database";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolStripMenuItem dbActionsToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel ConnectionStatus;
        private System.Windows.Forms.ToolStripStatusLabel ErrorStatus;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customSearchToolStripMenuItem;
        private System.Windows.Forms.Button btnAddObservation;
        private System.Windows.Forms.ToolStripMenuItem addObservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openViewInNewWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVFilecsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textFiletxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVFilecsvToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem arcGISShapefileshpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem popularSearchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem allObservationsToolStripMenuItem;
    }
}

