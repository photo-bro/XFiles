using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XFiles.Forms
{
    public partial class CustomQuery : Form
    {

        XFiles_Facade m_xFacade = XFiles_Facade.Instance;
        Query_Manager m_VM = Query_Manager.Instance;


        public CustomQuery()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {this.Close();}


        /// <summary>
        /// Query DB and create new view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        { m_VM.CreateNewView(tbCustQuery.Text, m_xFacade.QueryToBindingSource(tbCustQuery.Text)); }

    } // CustomQuery
} // namespace XFiles
