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

        private string m_sQueryString = "";
       
        public UserQuery()
        {
            InitializeComponent();
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
        { m_VM.CreateNewView(m_xFacade.Query(m_sQueryString)); }



    }
}
