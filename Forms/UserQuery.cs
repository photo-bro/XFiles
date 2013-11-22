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
        View_Manager m_VM = View_Manager.Instance;
        UserQueryHandler m_UQH = UserQueryHandler.Instance;

        public UserQuery()
        {
            InitializeComponent();
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
        { this.Close(); }

        /// <summary>
        /// Query DB and create new view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        { m_VM.CreateNewView(m_xFacade.QueryToBindingSource(m_UQH.GetQuery)); }

        private void btnAddFind_Click(object sender, EventArgs e)
        {
            AddEntity aeForm = new AddEntity();
            aeForm.Show();

        }

        private void btnAddIn_Click(object sender, EventArgs e)
        {
            AddTable atForm = new AddTable();
            atForm.Show();
        }

        private void btnConditions_Click(object sender, EventArgs e)
        {

            AddCondition acForm = new AddCondition();
            acForm.Show();
        }

        private void UserQuery_MouseClick(object sender, MouseEventArgs e)
        {updateGUI();}



    }
}
