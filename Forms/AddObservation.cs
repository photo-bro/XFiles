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

        public AddObservation()
        {
            InitializeComponent();

            RefreshFromServer();

            // Weather Combobox
            cbxWeather.Items.AddRange(m_AOH.getWeather);

            //// Populate comboboxes
            //cbxLocation.Items.AddRange(m_AOH.getLocations());
            //// Populate combobox
            //cbxAnimal.Items.AddRange(m_AOH.getAnimals());
            //// Populate combobox
            //cbxGroup.Items.AddRange(m_AOH.getGroups());


        }

        private void updateGUI()
        {
            tbSQL_String.Text = m_AOH.GetInsertQuery;


        }

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
            }
        }

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
                var result = ag.ShowDialog(); // wait for form to close before refresh
                RefreshFromServer(); // make sure box is repopulated with new enitity
                return;
            }
        }


        // ***********************************************
        //           Component Change    S T U F F
        // ***********************************************
       

        private void cbxWeather_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_AOH.addFieldToObservation("Weather", cbxWeather.SelectedItem.ToString());
            updateGUI();
        }

        private void tbLatitude_TextChanged(object sender, EventArgs e)
        {
            m_AOH.addFieldToObservation("Latitude", tbLatitude.Text);
            updateGUI();
        }

        private void tbLongitude_TextChanged(object sender, EventArgs e)
        {
            m_AOH.addFieldToObservation("Longitude", tbLongitude.Text);
            updateGUI();
        }

        private void tbLocale_TextChanged(object sender, EventArgs e)
        {
            m_AOH.addFieldToObservation("Locality", tbLocale.Text);
            updateGUI();
        }

        private void tbObservCount_TextChanged(object sender, EventArgs e)
        {
            m_AOH.addFieldToObservation("Number", tbObservCount.Text);
            updateGUI();
        }

        private void tbColor_TextChanged(object sender, EventArgs e)
        {
            m_AOH.addFieldToObservation("Color", tbColor.Text);
            updateGUI();
        }

        private void tbTemperature_TextChanged(object sender, EventArgs e)
        {
            m_AOH.addFieldToObservation("AirTemperature", tbTemperature.Text);
            updateGUI();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            m_AOH.addFieldToObservation("DateAndTime", dateTimePicker1.Value.ToString());
            updateGUI();
        }

        private void tbCharacteristics_TextChanged(object sender, EventArgs e)
        {
            m_AOH.addFieldToObservation("Characteristics", tbCharacteristics.Text);
            updateGUI();
        }

        private void tbComments_TextChanged(object sender, EventArgs e)
        {
            m_AOH.addFieldToObservation("Comments", tbComments.Text);
            updateGUI();
        }

        private void cbxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_AOH.addFieldToObservation("LocationID", m_AOH.getLocationID(cbxLocation.SelectedItem.ToString()));
            updateGUI();
        }

        private void cbxAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_AOH.addFieldToObservation("AnimalID", m_AOH.getAnimalID(cbxAnimal.SelectedItem.ToString()));
            updateGUI();
        }

        private void cbxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_AOH.addFieldToObservation("GroupID", m_AOH.getGroupID(cbxGroup.SelectedItem.ToString()));
            updateGUI();
        }



    } // AddObservation
} // namespace XFiles.Forms
