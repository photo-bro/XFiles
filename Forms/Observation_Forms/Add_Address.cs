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

        public Add_Address()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            m_AOH.InsertAddress(tbName.Text, tbState.Text, tbStreetName.Text, tbBuildingNo.Text, tbZipcode.Text);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        { this.Close(); }
    }
}
