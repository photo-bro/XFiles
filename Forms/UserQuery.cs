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

        public UserQuery()
        {
            InitializeComponent();
            m_UQH.Reset();
        }


        public void updateGUI()
        {
            tbSQL_String.Text = m_UQH.GetQuery;
        }

        /// <summary>
        /// Close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            m_UQH.Reset();
            this.Close(); 
        }

        /// <summary>
        /// Query DB and create new view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        { m_VM.CreateNewView(m_UQH.GetQuery, m_xFacade.QueryToBindingSource(m_UQH.GetQuery)); }

        private void btnAddFind_Click(object sender, EventArgs e)
        {
            AddEntity aeForm = new AddEntity();
            if (aeForm.ShowDialog() == DialogResult.OK)
            {
                tbFind.Text = aeForm.SelectedItems;
                updateGUI();
            }
        }

        private void btnAddIn_Click(object sender, EventArgs e)
        {
            AddTable atForm = new AddTable();
            if (atForm.ShowDialog() == DialogResult.OK)
            {
                tbIn.Text = atForm.SelectedItems;
                updateGUI();
            }
        }

        private void btnConditions_Click(object sender, EventArgs e)
        {

            AddCondition acForm = new AddCondition();
            if (acForm.ShowDialog() == DialogResult.OK)
            {
                tbConditions.Text += acForm.SelectedItems + "\r\n";
                updateGUI();
            }
        }

        private void UserQuery_MouseClick(object sender, MouseEventArgs e)
        {updateGUI();}



    }
}
