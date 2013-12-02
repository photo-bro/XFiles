using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XFiles.Forms
{
    public partial class AboutForm : Form
    {
        FileManager m_FM = FileManager.Instance;
        public AboutForm()
        {
            InitializeComponent();
            // Set description
            tbDescription.Text = m_FM.ProgramName + " " + m_FM.ProgramVersion + "\r\n" +
                "Josh Harmon & Kali McKee\r\n" + "CSCI 330 DBMS Fall 2013\r\n\r\n" +
                "XFiles is a simple animal observation database and interface for cataloging " +
                "various sightings of birds and creatures on the Principia College Campus" + 
                "\r\n\r\nFull commit history and code at: https://github.com/photo-bro/XFiles";
        } // AboutForm()
        
        /// <summary>
        /// Close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        { this.Close(); }
    } // AboutForm
} // namespace XFiles.Forms
