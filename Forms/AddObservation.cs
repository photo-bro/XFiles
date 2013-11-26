﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XFiles.Forms.Observation_Forms;

namespace XFiles.Forms
{
    public partial class AddObservation : Form
    {
        XFiles_Facade m_xFacade = XFiles_Facade.Instance;
        AddObservationHandler m_AOH = AddObservationHandler.Instance;

        public AddObservation()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {this.Close();}

        /// <summary>
        /// Location ComboBox
        /// Determines which item is selected, performing the necessary action.
        /// If Add Location is selected Add_Location form is launched
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxLocation_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxLocation.SelectedItem.ToString() == "Add Location")
            {
                Add_Location al = new Add_Location();
                var result = al.ShowDialog();
                RefreshFromServer(); // make sure box is repopulated with new enitity
                cbxLocation.SelectedValue = result;
                return;
            }
        }

        private void RefreshFromServer()
        {
        }

        private void cbxAnimal_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxAnimal.SelectedItem.ToString() == "Add Animal")
            {
                Add_Animal aa = new Add_Animal();
                var result = aa.ShowDialog();
                RefreshFromServer(); // make sure box is repopulated with new enitity
                cbxLocation.SelectedValue = result;
                return;
            }
        }

        private void cbxGroup_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxGroup.SelectedItem.ToString() == "Create New Group")
            {
                Add_Group ag = new Add_Group();
                var result = ag.ShowDialog();
                RefreshFromServer(); // make sure box is repopulated with new enitity
                cbxLocation.SelectedValue = result;
                return;
            }
        }
    } // AddObservation
} // namespace XFiles.Forms
