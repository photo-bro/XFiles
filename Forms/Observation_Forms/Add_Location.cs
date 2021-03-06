﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XFiles.Forms.Observation_Forms
{
    public partial class Add_Location : Form
    {
        AddObservationHandler m_AOH = AddObservationHandler.Instance;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Add_Location()
        {
            InitializeComponent();
            cbxAddress.Items.AddRange(m_AOH.getAddresses());
        } // Add_Location

        /// <summary>
        /// Closes Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        { this.Close(); }

        /// <summary>
        /// Button Add
        /// Insert new Location based upon form attributes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // get AddressID from AddressName
            string AddressID = m_AOH.getAddressID(cbxAddress.SelectedItem.ToString());
            m_AOH.InsertLocation(AddressID, tbOfficialName.Text);
            m_AOH.addFieldToObservation("AddressName", AddressID);
            this.Close();
        } // btnAdd_Click

        /// <summary>
        /// Open Add_Address form if "New Address" is selected in combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxAddress.SelectedItem.ToString() == "New Address")
            {
                Add_Address aa = new Add_Address();
                var result = aa.ShowDialog();
                RefreshFromServer(); // make sure box is repopulated with new enitity
                cbxAddress.SelectedValue = result;
                return;
            } // if 
        } // cbxAddress changed

        /// <summary>
        /// Refresh contents of components from server
        /// </summary>
        private void RefreshFromServer()
        { cbxAddress.Items.AddRange(m_AOH.getAddresses()); }
    } // Add_Location
} // namespace XFiles.Observation_Forms
