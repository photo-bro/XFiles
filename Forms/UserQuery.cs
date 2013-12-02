using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XFiles.Forms.Search_Forms; // Add forms

namespace XFiles.Forms
{
    public partial class UserQuery : Form
    {

        XFiles_Facade m_xFacade = XFiles_Facade.Instance;
        Query_Manager m_VM = Query_Manager.Instance;
        UserQueryHandler m_UQH = UserQueryHandler.Instance;

        /// <summary>
        /// Default constructor
        /// </summary>
        public UserQuery()
        {
            InitializeComponent();
            m_UQH.Reset();
        } // UserQuery

        /// <summary>
        /// Update components 
        /// </summary>
        public void updateGUI()
        {tbSQL_String.Text = m_UQH.GetQuery; }

        /// <summary>
        /// Close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        { this.Close(); }

        /// <summary>
        /// Query DB and create new view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        { m_VM.CreateNewView(m_UQH.GetQuery, m_xFacade.QueryToBindingSource(m_UQH.GetQuery)); }

        /// <summary>
        /// Button Add New Entity
        /// Show AddEntity Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddFind_Click(object sender, EventArgs e)
        {
            AddEntity aeForm = new AddEntity();
            if (aeForm.ShowDialog() == DialogResult.OK)
            {
                tbFind.Text = aeForm.SelectedItems;
                updateGUI();
            } // if OK
        } // btnAddFind_Click

        /// <summary>
        /// Button Add New Table
        /// Show AddTable form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddIn_Click(object sender, EventArgs e)
        {
            AddTable atForm = new AddTable();
            if (atForm.ShowDialog() == DialogResult.OK)
            {
                tbIn.Text = atForm.SelectedItems;
                updateGUI();
            } // if OK
        } // btnAddIn_Click

        /// <summary>
        /// Button Add Condition
        /// Show AddCondition form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConditions_Click(object sender, EventArgs e)
        {
            AddCondition acForm = new AddCondition();
            if (acForm.ShowDialog() == DialogResult.OK)
            {
                tbConditions.Text += acForm.SelectedItems + "\r\n";
                updateGUI();
            } // if OK
        } // btnConditions_Click

        /// <summary>
        /// Update components upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserQuery_MouseClick(object sender, MouseEventArgs e)
        {updateGUI();}
    } // UserQuery
} // namespace XFiles.Forms
