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
    public partial class Add_Observer : Form
    {
        AddObservationHandler m_AOH = AddObservationHandler.Instance;

        public Add_Observer()
        {
            InitializeComponent();

            // Credential Combobox
            cbxCredentials.Items.AddRange(m_AOH.getCredentials);

            RefreshFromServer();
        }

        private void RefreshFromServer()
        {
            // Address Combobox
            cbxAddress.Items.Clear();
            cbxAddress.Items.AddRange(m_AOH.getAddresses());
            cbxAddress.Items.Add("Add Address");
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

        private void btnAddObserver_Click(object sender, EventArgs e)
        {
            string AddressID = m_AOH.getAddressID(cbxAddress.SelectedItem.ToString());
            m_AOH.InsertObserver(AddressID, tbFirstName.Text, tbLastName.Text, cbxCredentials.SelectedItem.ToString(), 
                tbPhone1.Text, tbPhone2.Text, tbEmail.Text);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        { this.Close(); }
    }
}
