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
    public partial class Add_Animal : Form
    {
        AddObservationHandler m_AOH = AddObservationHandler.Instance;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Add_Animal()
        {InitializeComponent(); }

        /// <summary>
        /// Close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        { this.Close(); }

        /// <summary>
        /// Button Add
        /// Insert new Animal based upon form attributes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            m_AOH.InsertAnimal(tbCommonName.Text, tbGenus.Text, tbSpecies.Text, tbCharacteristics.Text);
            this.Close();
        } // btnAdd_Click
    } // Add_Animal
} // namespace XFiles.Forms.Observation_Forms
