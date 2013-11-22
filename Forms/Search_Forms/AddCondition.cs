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
    public partial class AddCondition : Form
    {
        UserQueryHandler m_UQH = UserQueryHandler.Instance;
        XFiles_Facade m_xFacade = XFiles_Facade.Instance;

        public AddCondition()
        {
            InitializeComponent();
            
            // Populate fields
            // Field select
            cbxField.Items.AddRange(Fields().ToArray());
            // Condition select
            cbxCondition.Items.AddRange(m_UQH.Conditionals);
            cbxJoinCond.Items.AddRange(m_UQH.JoinConditionals);

            // Disable join condition if no other conditions
            if (m_UQH.getConditions.Count < 1) cbxJoinCond.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Add condition to handler
            if (cbxJoinCond.Enabled)
                m_UQH.AddCondition(cbxJoinCond.SelectedItem.ToString() + " " +
                    cbxField.SelectedItem.ToString()
                    + " " + cbxCondition.SelectedItem.ToString()
                    + " " + tbValue.Text);
            else

                m_UQH.AddCondition(cbxField.SelectedItem.ToString()
                    + " " + cbxCondition.SelectedItem.ToString() + " " +
                    tbValue.Text);
            this.Close();
        } // btnOK

        private void btnCancel_Click(object sender, EventArgs e)
        { this.Close(); }

        /// <summary>
        /// Returns a string list of all fields in tables handler
        /// </summary>
        /// <returns></returns>
        private List<string> Fields()
        {
            List<string> lsFields = new List<string>();
            string[] sDelim = { " ", "\r\n" };
            foreach (string s in m_UQH.getTables)
            {
                string items =
                    m_xFacade.QueryToString("SELECT `COLUMN_NAME` FROM `INFORMATION_SCHEMA`.`COLUMNS` WHERE `TABLE_SCHEMA`='xfiles' AND `TABLE_NAME`='test';");
                lsFields.AddRange(items.Split(sDelim, StringSplitOptions.RemoveEmptyEntries).ToArray());
            }
            return lsFields;
        } // Fields
    } // namespace XFiles.Forms.Search_Forms
}
