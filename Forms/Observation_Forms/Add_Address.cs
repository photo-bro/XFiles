using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XFiles.Forms.Observation_Forms
{
    public partial class Add_Address : Form
    {
        AddObservationHandler m_AOH = AddObservationHandler.Instance;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Add_Address()
        {InitializeComponent();}

        /// <summary>
        /// Button Add
        /// Insert new Address based upon form attributes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            m_AOH.InsertAddress(tbName.Text, tbState.Text, tbStreetName.Text, tbBuildingNo.Text, tbZipcode.Text);
            this.Close();
        } // btnAdd_Click

        /// <summary>
        /// Close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        { this.Close(); }
    } // Add_Address
} // namespace XFiles.Forms.Observation_Forms
