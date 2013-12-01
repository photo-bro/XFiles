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
    public partial class AddEntity : Form
    {
        UserQueryHandler m_UQH = UserQueryHandler.Instance;
        XFiles_Facade m_xFacade = XFiles_Facade.Instance;

        string[] m_sItems;

        public AddEntity()
        {
            InitializeComponent();

            // Populate checklistbox possible animals (fields) from DB
            chlbxFields.Items.AddRange(m_UQH.getEntities());

            // check items already included in query
            for(int i = 0; i<chlbxFields.Items.Count; ++i)
                if (m_UQH.getFields.Contains(chlbxFields.Items[i]))
                    chlbxFields.SetItemChecked(i, true);
                    
        } // AddEntity constructor

        /// <summary>
        /// Returns checked items as formatted string
        /// </summary>
        public string SelectedItems
        {
            get
            {
                string s = "";
                foreach (var v in chlbxFields.CheckedItems)
                    s += v.ToString() + " ";
                return s;
            } // get
        } // SelectedItems

        /// <summary>
        /// Add selected fields to handler class. Closes form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            // Add items to handler
            List<string> lsFields = new List<string>();;
            foreach (var field in chlbxFields.CheckedItems)
                lsFields.Add(field.ToString());
            m_UQH.AddFields(lsFields.ToArray());

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
    } // AddEntity
} // namespace XFiles.Forms.Search_Forms
