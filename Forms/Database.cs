using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XFiles
{
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();

            updateGUI();
        }

        /// <summary>
        /// Refreshes all elements of the form to most current values
        /// </summary>
        private void updateGUI()
        {
            // status label
            StatusLabel.Text = Status.CurrentStatus();

        } // updateGUI


        /// <summary>
        /// Closes form instance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {this.Close();}


    } // Database Form
} // namespace XFiles
