﻿namespace XFiles.Forms
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
            this.tbComments = new System.Windows.Forms.TextBox();
            this.lbComments = new System.Windows.Forms.Label();
            this.tbCharacteristics = new System.Windows.Forms.TextBox();
            this.lbCharacteristics = new System.Windows.Forms.Label();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.lbColor = new System.Windows.Forms.Label();
            this.tbObservCount = new System.Windows.Forms.TextBox();
            this.lbObservCount = new System.Windows.Forms.Label();
            this.cbxWeather = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.cbxGroup = new System.Windows.Forms.ComboBox();
            this.cbxAnimal = new System.Windows.Forms.ComboBox();
            this.cbxLocation = new System.Windows.Forms.ComboBox();
            this.gbSQ_String.SuspendLayout();
            this.gbObserParam.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddObserv
            // 
            this.btnAddObserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddObserv.Location = new System.Drawing.Point(510, 496);
            this.btnAddObserv.Name = "btnAddObserv";
            this.btnAddObserv.Size = new System.Drawing.Size(102, 23);
            this.btnAddObserv.TabIndex = 0;
            this.btnAddObserv.Text = "Add Observation";
            this.btnAddObserv.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(12, 496);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbSQ_String
            // 
            this.gbSQ_String.Controls.Add(this.tbSQL_String);
            this.gbSQ_String.Location = new System.Drawing.Point(12, 334);
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
            this.gbObserParam.Controls.Add(this.tbComments);
            this.gbObserParam.Controls.Add(this.lbComments);
            this.gbObserParam.Controls.Add(this.tbCharacteristics);
            this.gbObserParam.Controls.Add(this.lbCharacteristics);
            this.gbObserParam.Controls.Add(this.tbColor);
            this.gbObserParam.Controls.Add(this.lbColor);
            this.gbObserParam.Controls.Add(this.tbObservCount);
            this.gbObserParam.Controls.Add(this.lbObservCount);
            this.gbObserParam.Controls.Add(this.cbxWeather);
            this.gbObserParam.Controls.Add(this.dateTimePicker1);
            this.gbObserParam.Controls.Add(this.lbDateTime);
            this.gbObserParam.Controls.Add(this.cbxGroup);
            this.gbObserParam.Controls.Add(this.cbxAnimal);
            this.gbObserParam.Controls.Add(this.cbxLocation);
            this.gbObserParam.Location = new System.Drawing.Point(18, 12);
            this.gbObserParam.Name = "gbObserParam";
            this.gbObserParam.Size = new System.Drawing.Size(588, 316);
            this.gbObserParam.TabIndex = 5;
            this.gbObserParam.TabStop = false;
            this.gbObserParam.Text = "Observation Parameters";
            // 
            // tbComments
            // 
            this.tbComments.Location = new System.Drawing.Point(301, 200);
            this.tbComments.Multiline = true;
            this.tbComments.Name = "tbComments";
            this.tbComments.Size = new System.Drawing.Size(264, 98);
            this.tbComments.TabIndex = 13;
            // 
            // lbComments
            // 
            this.lbComments.AutoSize = true;
            this.lbComments.Location = new System.Drawing.Point(298, 184);
            this.lbComments.Name = "lbComments";
            this.lbComments.Size = new System.Drawing.Size(59, 13);
            this.lbComments.TabIndex = 12;
            this.lbComments.Text = "Comments:";
            // 
            // tbCharacteristics
            // 
            this.tbCharacteristics.Location = new System.Drawing.Point(24, 200);
            this.tbCharacteristics.Multiline = true;
            this.tbCharacteristics.Name = "tbCharacteristics";
            this.tbCharacteristics.Size = new System.Drawing.Size(264, 98);
            this.tbCharacteristics.TabIndex = 11;
            // 
            // lbCharacteristics
            // 
            this.lbCharacteristics.AutoSize = true;
            this.lbCharacteristics.Location = new System.Drawing.Point(21, 184);
            this.lbCharacteristics.Name = "lbCharacteristics";
            this.lbCharacteristics.Size = new System.Drawing.Size(130, 13);
            this.lbCharacteristics.TabIndex = 10;
            this.lbCharacteristics.Text = "Identifying Characteristics:";
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(133, 151);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(100, 20);
            this.tbColor.TabIndex = 9;
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(21, 154);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(37, 13);
            this.lbColor.TabIndex = 8;
            this.lbColor.Text = "Color: ";
            // 
            // tbObservCount
            // 
            this.tbObservCount.Location = new System.Drawing.Point(133, 124);
            this.tbObservCount.Name = "tbObservCount";
            this.tbObservCount.Size = new System.Drawing.Size(100, 20);
            this.tbObservCount.TabIndex = 7;
            // 
            // lbObservCount
            // 
            this.lbObservCount.AutoSize = true;
            this.lbObservCount.Location = new System.Drawing.Point(21, 127);
            this.lbObservCount.Name = "lbObservCount";
            this.lbObservCount.Size = new System.Drawing.Size(98, 13);
            this.lbObservCount.TabIndex = 6;
            this.lbObservCount.Text = "Number of Animals:";
            // 
            // cbxWeather
            // 
            this.cbxWeather.FormattingEnabled = true;
            this.cbxWeather.Location = new System.Drawing.Point(24, 85);
            this.cbxWeather.Name = "cbxWeather";
            this.cbxWeather.Size = new System.Drawing.Size(149, 21);
            this.cbxWeather.TabIndex = 5;
            this.cbxWeather.Text = "Weather";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(365, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // lbDateTime
            // 
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Location = new System.Drawing.Point(276, 93);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(83, 13);
            this.lbDateTime.TabIndex = 3;
            this.lbDateTime.Text = "Date and Time: ";
            // 
            // cbxGroup
            // 
            this.cbxGroup.FormattingEnabled = true;
            this.cbxGroup.Items.AddRange(new object[] {
            "Create New Group"});
            this.cbxGroup.Location = new System.Drawing.Point(444, 38);
            this.cbxGroup.Name = "cbxGroup";
            this.cbxGroup.Size = new System.Drawing.Size(121, 21);
            this.cbxGroup.TabIndex = 2;
            this.cbxGroup.Text = "Observer Group";
            this.cbxGroup.SelectedValueChanged += new System.EventHandler(this.cbxGroup_SelectedValueChanged);
            // 
            // cbxAnimal
            // 
            this.cbxAnimal.FormattingEnabled = true;
            this.cbxAnimal.Items.AddRange(new object[] {
            "Add Animal"});
            this.cbxAnimal.Location = new System.Drawing.Point(229, 38);
            this.cbxAnimal.Name = "cbxAnimal";
            this.cbxAnimal.Size = new System.Drawing.Size(209, 21);
            this.cbxAnimal.TabIndex = 1;
            this.cbxAnimal.Text = "Animal";
            this.cbxAnimal.SelectedValueChanged += new System.EventHandler(this.cbxAnimal_SelectedValueChanged);
            // 
            // cbxLocation
            // 
            this.cbxLocation.FormattingEnabled = true;
            this.cbxLocation.Items.AddRange(new object[] {
            "Add Location"});
            this.cbxLocation.Location = new System.Drawing.Point(24, 38);
            this.cbxLocation.Name = "cbxLocation";
            this.cbxLocation.Size = new System.Drawing.Size(199, 21);
            this.cbxLocation.TabIndex = 0;
            this.cbxLocation.Text = "Location";
            this.cbxLocation.SelectedValueChanged += new System.EventHandler(this.cbxLocation_SelectedValueChanged);
            // 
            // AddObservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 532);
            this.Controls.Add(this.gbObserParam);
            this.Controls.Add(this.gbSQ_String);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddObserv);
            this.MaximizeBox = false;
            this.Name = "AddObservation";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Add Observation";
            this.TopMost = true;
            this.gbSQ_String.ResumeLayout(false);
            this.gbSQ_String.PerformLayout();
            this.gbObserParam.ResumeLayout(false);
            this.gbObserParam.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddObserv;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbSQ_String;
        private System.Windows.Forms.TextBox tbSQL_String;
        private System.Windows.Forms.GroupBox gbObserParam;
        private System.Windows.Forms.TextBox tbComments;
        private System.Windows.Forms.Label lbComments;
        private System.Windows.Forms.TextBox tbCharacteristics;
        private System.Windows.Forms.Label lbCharacteristics;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.TextBox tbObservCount;
        private System.Windows.Forms.Label lbObservCount;
        private System.Windows.Forms.ComboBox cbxWeather;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.ComboBox cbxGroup;
        private System.Windows.Forms.ComboBox cbxAnimal;
        private System.Windows.Forms.ComboBox cbxLocation;
    }
}