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

        /// <summary>
        /// Populate form values
        /// </summary>
        public AddTable()
        {
            InitializeComponent();

            // Populate checklistbox possible animals (fields) from DB
            chlbxTables.Items.AddRange(m_UQH.getTablesFromDB());

            // check items already included in query
            for (int i = 0; i < chlbxTables.Items.Count; ++i)
                if (m_UQH.getTables.Contains(chlbxTables.Items[i]))
                    chlbxTables.SetItemChecked(i, true);

        } // AddTable()

        /// <summary>
        /// Returns checked items as formatted string
        /// </summary>
        public string SelectedItems
        {
            get
            {
                string s = "";
                foreach (var v in chlbxTables.CheckedItems)
                    s += v.ToString() + " ";
                return s;
            } // get
        } // SelectedItems

        /// <summary>
        /// Add selected tables to handler class. Closes form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            // Add items to handler
            List<string> lsTables = new List<string>(); ;

            foreach (var table in chlbxTables.CheckedItems)
                lsTables.Add(table.ToString());
            m_UQH.AddTables(lsTables.ToArray());

            this.Close();
        } // btnOK

        /// <summary>
        /// Close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close(); }
    } // AddTable
} // namespace XFiles.Forms.Search_Forms
