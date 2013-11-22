using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XFiles.Forms.Search_Forms
{
    public partial class AddTable : Form
    {
        UserQueryHandler m_UQH = UserQueryHandler.Instance;
        XFiles_Facade m_xFacade = XFiles_Facade.Instance;

        string[] m_sItems;

        public AddTable()
        {
            InitializeComponent();

            // Populate checklistbox possible animals (fields) from DB
            // Query DB to get all fields,
            string sFields = m_xFacade.QueryToString("SHOW TABLES IN xfiles");
            string[] sDelim = { " ", "\r\n" };
            // Split string into individual items
            m_sItems = sFields.Split(sDelim, StringSplitOptions.RemoveEmptyEntries);
            chlbxTables.Items.AddRange(m_sItems.ToArray());
        }

        /// <summary>
        /// Add selected tables to handler class. Closes form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {

            // Add items to handler
            foreach (var table in chlbxTables.CheckedItems)
                m_UQH.AddTable(table.ToString());
            this.Close();
        } // btnOK

        private void btnCancel_Click(object sender, EventArgs e)
        { this.Close(); }
    } // AddTable
} // namespace XFiles.Forms.Search_Forms
