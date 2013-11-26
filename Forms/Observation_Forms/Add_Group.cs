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
        public Add_Group()
        {
            InitializeComponent();
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
