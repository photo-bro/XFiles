using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XFiles;

namespace XFiles.Forms
{
    public partial class ModifyWindow : Form
    {
        ModifyHandler m_MF = ModifyHandler.Instance;
        XFiles_Facade m_xFacade = XFiles_Facade.Instance;

        List<string> m_lsRows = new List<string>();
        List<List<string>> m_lslsColumns = new List<List<string>>();
        List<List<string>> m_lslsValues = new List<List<string>>();


        public ModifyWindow()
        {
            InitializeComponent();

            RefreshFromServer();
        }

        private void RefreshFromServer()
        {
            // Table combobox
            cbxTables.Items.Clear();
            cbxTables.Items.AddRange(m_MF.getTables());

            // Refresh DGV
            // Determine which binding source to get
            if (cbxTables.SelectedItem != null)
                dgv.DataSource = m_MF.GetBindingSource(cbxTables.SelectedItem.ToString());
        }

        private void updateGUI()
        {
            try
            {
                tbSQL.Text = m_MF.GetModifyQuery(
                    cbxTables.SelectedItem.ToString(),
                    m_MF.getTableIDFromName(cbxTables.SelectedItem.ToString()),
                    m_lsRows, m_lslsColumns, m_lslsValues);
            }
            catch (Exception e)
            {
                ErrorHandler.Error(ErrorHandler.XFILES_ERROR.UNKNOWN_ERROR,
                    e.ToString());
                tbSQL.Text = "";
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        { this.Close(); }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            updateGUI();
            m_xFacade.Command(tbSQL.Text);
            RefreshFromServer();
            
        }

        private void cbxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Determine which binding source to get
            dgv.DataSource = m_MF.GetBindingSource(cbxTables.SelectedItem.ToString());
        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Rows, get primary key value to uniqly idenify row
            // assumes primary key is first item of table
            if (!m_lsRows.Contains(dgv.CurrentCell.OwningRow.Cells[0].Value.ToString()))
                m_lsRows.Add(dgv.CurrentCell.OwningRow.Cells[0].Value.ToString());

            // Column names
            while (dgv.CurrentCell.OwningRow.Index + 1 > m_lslsColumns.Count)
                m_lslsColumns.Add(new List<string>());

            // place info in temp vars for readability
            int curIndex = dgv.CurrentCell.OwningRow.Index;
            string curColName = dgv.CurrentCell.OwningColumn.Name;
            var curValue = dgv.CurrentCell.Value;

            // Check if column exists, and replace if it does
            if (m_lslsColumns[curIndex].Contains(curColName))
                m_lslsColumns[curIndex].Remove(curColName);
            m_lslsColumns[curIndex].Add(curColName);

            // Cell values
            while (dgv.CurrentCell.OwningRow.Index + 1 > m_lslsValues.Count)
                m_lslsValues.Add(new List<string>());

            // Check if value exists, and replace if it does
            //if (m_lslsValues[curIndex].Contains(curValue.ToString()))
            //    m_lslsValues[curIndex].Remove(curValue.ToString());
            m_lslsValues[curIndex].Add(curValue.ToString());

            updateGUI();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        { updateGUI(); }

    } // ResultWindow
} // namespace XFiles.Forms
