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

        public Add_Group()
        {
            InitializeComponent();
            // Populate combobox
        }

        private void cbxAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxAddress.SelectedItem.ToString() == "New Address")
            {
                Add_Address aa = new Add_Address();
                var result = aa.ShowDialog();
                RefreshFromServer(); // make sure box is repopulated with new enitity
                cbxAddress.SelectedValue = result;
                return;
            }
        }
            
        /// <summary>
        /// Refresh contents of components from server
        /// </summary>
        private void RefreshFromServer()
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // get AddressID from AddressName
            string AddressID = m_AOH.getAddressID(cbxAddress.SelectedItem.ToString());
            string ObserverID = m_AOH.getObserverID(tbFirstName.Text, tbLastName.Text);
            m_AOH.InsertGroup(ObserverID, tbGroupName.Text, cbxGroupStatus.ToString());
            this.Close();
        }
    }
}
