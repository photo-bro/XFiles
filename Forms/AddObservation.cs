using System;
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
        Query_Manager m_QM = Query_Manager.Instance;

        /// <summary>
        /// Default constructor
        /// </summary>
        public AddObservation()
        {
            m_AOH.Reset();
            InitializeComponent();
            RefreshFromServer();
            // Weather Combobox
            cbxWeather.Items.AddRange(m_AOH.getWeather);
        }

        /// <summary>
        /// Update form components
        /// </summary>
        private void updateGUI()
        {tbSQL_String.Text = m_AOH.GetInsertQuery;}

        /// <summary>
        /// Closes form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            } // if "Add Location"
        } // cbxLocation_SelectedValueChanged

        /// <summary>
        /// Refresh combobox items from server
        /// </summary>
        private void RefreshFromServer()
        {
            // Location Combobox
            cbxLocation.Items.Clear();
            cbxLocation.Items.AddRange(m_AOH.getLocations());
            cbxLocation.Items.Add("Add Location");

            // Animal Combobox
            cbxAnimal.Items.Clear();
            cbxAnimal.Items.AddRange(m_AOH.getAnimals());
            cbxAnimal.Items.Add("Add Animal");

            // Group Combobox
            cbxGroup.Items.Clear();
            cbxGroup.Items.AddRange(m_AOH.getGroups());
            cbxGroup.Items.Add("Create New Group");
        } // RefreshFromServer

        /// <summary>
        /// Show Add_Animal form when "Add Animal" is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxAnimal_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxAnimal.SelectedItem.ToString() == "Add Animal")
            {
                Add_Animal aa = new Add_Animal();
                var result = aa.ShowDialog();
                RefreshFromServer(); // make sure box is repopulated with new enitity
                cbxLocation.SelectedValue = result;
                return;
            } // Add Animal
        } // cbxAnimal_SelectedValueChanged

        /// <summary>
        /// Show Add_Group form when "Create New Group" is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxGroup_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxGroup.SelectedItem.ToString() == "Create New Group")
            {
                Add_Group ag = new Add_Group();
                var result = ag.ShowDialog(); // wait for form to close before refresh
                RefreshFromServer(); // make sure box is repopulated with new enitity
                return;
            } // Create New Group
        } // cbxGroup_SelectedValueChanged


        // ***********************************************
        //           Component Change    S T U F F
        // ***********************************************
       
        /* *****************************************************
         * The following functions update their values to the handler
         * class and update the interface elements, namely the MySql
         * string.
         *  **************************************************** */

        private void cbxWeather_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_AOH.addFieldToObservation("Weather", cbxWeather.SelectedItem.ToString());
            updateGUI();
        } // cbxWeather_SelectedIndexChanged

        private void tbLatitude_TextChanged(object sender, EventArgs e)
        {
            m_AOH.addFieldToObservation("Latitude", tbLatitude.Text);
            updateGUI();
        } // tbLatitude_TextChanged

        private void tbLongitude_TextChanged(object sender, EventArgs e)
        {
            m_AOH.addFieldToObservation("Longitude", tbLongitude.Text);
            updateGUI();
        } // tbLongitude_TextChanged

        private void tbLocale_TextChanged(object sender, EventArgs e)
        {
            m_AOH.addFieldToObservation("Locality", tbLocale.Text);
            updateGUI();
        } // tbLocale_TextChanged

        private void tbObservCount_TextChanged(object sender, EventArgs e)
        {
            m_AOH.addFieldToObservation("Number", tbObservCount.Text);
            updateGUI();
        } // tbObservCount_TextChanged

        private void tbColor_TextChanged(object sender, EventArgs e)
        {
            m_AOH.addFieldToObservation("Color", tbColor.Text);
            updateGUI();
        } // tbColor_TextChanged

        private void tbTemperature_TextChanged(object sender, EventArgs e)
        {
            m_AOH.addFieldToObservation("AirTemperature", tbTemperature.Text);
            updateGUI();
        } // tbTemperature_TextChanged

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            m_AOH.addFieldToObservation("DateAndTime", dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm:ss"));
            updateGUI();
        } // dateTimePicker1_ValueChanged

        private void tbCharacteristics_TextChanged(object sender, EventArgs e)
        {
            m_AOH.addFieldToObservation("Characteristics", tbCharacteristics.Text);
            updateGUI();
        } // tbCharacteristics_TextChanged

        private void tbComments_TextChanged(object sender, EventArgs e)
        {
            m_AOH.addFieldToObservation("Comments", tbComments.Text);
            updateGUI();
        } // tbComments_TextChanged

        private void cbxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLocation.SelectedItem != null)
            {
                string s = m_AOH.getLocationID(cbxLocation.SelectedItem.ToString());
                s = s.Replace("\r\n", ""); // remove newline
                m_AOH.addFieldToObservation("LocationID", s);
            }
            updateGUI();
        } // cbxLocation_SelectedIndexChanged

        private void cbxAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxAnimal.SelectedItem != null)
            {
                string s = m_AOH.getAnimalID(cbxAnimal.SelectedItem.ToString());
                s = s.Replace("\r\n", ""); // remove newline
                m_AOH.addFieldToObservation("AnimalID", s);
            }
            updateGUI();
        } // cbxAnimal_SelectedIndexChanged

        private void cbxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxGroup.SelectedItem != null)
            {
                string s = m_AOH.getGroupID(cbxGroup.SelectedItem.ToString());
                s = s.Replace("\r\n", ""); // remove newline
                m_AOH.addFieldToObservation("GroupID", s);
            }
            updateGUI();
        } // cbxGroup_SelectedIndexChanged

        /// <summary>
        /// Insert observation into DB based upon form attributes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddObserv_Click(object sender, EventArgs e)
        {
            m_xFacade.Command(m_AOH.GetInsertQuery);
            this.Close();
        } // btnAddObserv_Click

    } // AddObservation
} // namespace XFiles.Forms
