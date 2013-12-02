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
    public partial class Add_Group : Form
    {
        AddObservationHandler m_AOH = AddObservationHandler.Instance;

        // Hold members to be in group
        List<string> m_lsObservers = new List<string>();

        /// <summary>
        /// Default constructor
        /// </summary>
        public Add_Group()
        {
            InitializeComponent();
            RefreshFromServer();
        } // Add_Group
            
        /// <summary>
        /// Refresh contents of components from server
        /// </summary>
        private void RefreshFromServer()
        {
            // lbxExisting observers
            lbxExisting.Items.Clear();
            lbxExisting.Items.AddRange(m_AOH.getObservers());

            // lbxMembers members
            lbxMembers.Items.Clear();
            lbxMembers.Items.AddRange(m_lsObservers.ToArray());
        } // RefreshFromServer

        /// <summary>
        /// Button Add
        /// Show Add_Observer form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNewObserver_Click(object sender, EventArgs e)
        {
            Add_Observer ao = new Add_Observer();
            DialogResult dr = ao.ShowDialog();
            RefreshFromServer();
        } // btnAddNewObserver_Click

        /// <summary>
        /// Button Add Existing
        /// Add selected item in lbxExisting to current group list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddExisiting_Click(object sender, EventArgs e)
        {
            // Split full name into first/last
            //string[] sName = lbxExisting.SelectedItem.ToString().Split(" ".ToCharArray());
            m_lsObservers.Add(lbxExisting.SelectedItem.ToString());//m_AOH.getObserverID(sName[0], sName[1]);
            RefreshFromServer();
        } // btnAddExisiting_Click

        /// <summary>
        /// Button Remove Member
        /// Removed selected item from current group list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            m_lsObservers.Remove(lbxMembers.SelectedItem.ToString());
            RefreshFromServer();
        } // btnRemoveMember_Click

        /// <summary>
        /// Button Add
        /// Insert new group based upon form attributes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Create group
         string sActive = (cbxGroupStatus.SelectedItem.ToString() == "Active") ?"TRUE":"FALSE";
         m_AOH.InsertGroup(tbGroupName.Text, sActive);
            // Create observerlist
         foreach (var item in lbxMembers.Items)
         {
             m_AOH.InsertObserverList(m_AOH.getGroupID(tbGroupName.Text),
                 m_AOH.getObserverID(item.ToString().Split(" ".ToCharArray())[0],
                 item.ToString().Split(" ".ToCharArray())[1]));
         } // foreach
         this.Close();
        } // btnAdd_Click
    } // Add_Group
} // namespace XFiles.Forms.Observation_Forms
