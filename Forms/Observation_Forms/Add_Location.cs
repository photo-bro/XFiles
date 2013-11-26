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
    public partial class Add_Location : Form
    {
        public Add_Location()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Closes Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        { this.Close(); }

        private void btnAdd_Click(object sender, EventArgs e)
        {

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
    }
}
