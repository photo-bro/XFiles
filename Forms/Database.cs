using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; // path, directory
using XFiles.Forms; // project forms

namespace XFiles
{
    public partial class Database : Form
    {
        private XFiles_Facade m_xFacade = XFiles_Facade.Instance;
        private View_Manager m_VM = View_Manager.Instance;

       
        public Database()
        {
            InitializeComponent();

            // Prep DGV's
            dgvView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            updateGUI();
        }

        /// <summary>
        /// Refreshes all elements of the form to most current values
        /// </summary>
        private void updateGUI()
        {
            // status strip labels
            StatusLabel.Text = Status.CurrentStatus();
            ConnectionStatus.Text = (m_xFacade.DBConnected) ? "Database connected" : "Database not connected";
            ErrorStatus.Text = "Last Error: " + ErrorHandler.CurrentError.ToString();
            // status strip colors
            ConnectionStatus.ForeColor = (m_xFacade.DBConnected) ? Color.Green : Color.Red;
            ErrorStatus.ForeColor = (ErrorHandler.CurrentError < (ErrorHandler.XFILES_ERROR) 1) ? Color.Green : Color.Red;

            // views
            dgvView1.DataSource = m_VM[0];
            dgvView1.AutoResizeColumns();
            dgvView2.DataSource = m_VM[1];
            dgvView2.AutoResizeColumns();
            dgvView3.DataSource = m_VM[2];
            dgvView3.AutoResizeColumns();
        
        } // updateGUI


        /// <summary>
        /// Closes form instance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {this.Close();}

        /// <summary>
        /// Connect to BNR database
        /// NOTE: Current server is cs-vh1 under XFiles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            m_xFacade.ConnectToDatabase();
            updateGUI();
        } // btnConnect_Click

        /// <summary>
        /// Connect to BNR database
        /// NOTE: Current server is cs-vh1 under XFiles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        { btnConnect.PerformClick(); }

        /// <summary>
        /// Simple test for DGV integration with MySQL_Connect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_VM.CreateNewView(m_xFacade.Query("SELECT * FROM test;"));
            updateGUI();
        } // testToolStripMenuItem

        private void exportViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Call open file prompt
            SaveFileDialog sfdPrompt = new SaveFileDialog();
            sfdPrompt.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            sfdPrompt.ShowDialog();

            DataGridView dgv;
            // Get current view
            if (tabControlMain.SelectedTab == tabOne)
                dgv = dgvView1;
            else if (tabControlMain.SelectedTab == tabTwo)
                dgv = dgvView2;
            else if (tabControlMain.SelectedTab == tabThree)
                dgv = dgvView3;
            else return;

            // Check if view is empty
            if (dgv.Columns.Count < 1)
            {
                ErrorHandler.Error(ErrorHandler.XFILES_ERROR.VIEW_EMPTY, "Cannot save an empty table");
                Status.SetStatus(Status.STATUS_TYPE.COMMAND_UNSUCCESSFUL, "Cannot save an empty table");
                return;
            } // columns < 1

            // DGV to DataTable
            // Credit: 
            // http://stackoverflow.com/questions/6295161/how-to-build-a-datatable-from-a-datagridview
            if (dgv.ColumnCount == 0) return;
            DataTable dtSource = new DataTable();
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                //if (IgnoreHideColumns & !col.Visible) continue;
                if (col.Name == string.Empty) continue;
                dtSource.Columns.Add(col.Name, col.ValueType);
                dtSource.Columns[col.Name].Caption = col.HeaderText;
            } // foreach column
            if (dtSource.Columns.Count == 0) return ;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow drNewRow = dtSource.NewRow();
                foreach (DataColumn col in dtSource.Columns)
                {
                    if (row.Cells[col.ColumnName].Value == null) continue;
                    drNewRow[col.ColumnName] = row.Cells[col.ColumnName].Value;
                } // foreach column
                dtSource.Rows.Add(drNewRow);
            } // foreach row


            // save file
            m_xFacade.ExportDataTableToFile(dtSource, Path.GetDirectoryName(sfdPrompt.FileName),
                Path.GetFileName(sfdPrompt.FileName));

            updateGUI();
        }

        private void customSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomQuery cq = new CustomQuery();
            cq.Show();
        }

        private void Refresh(object sender, EventArgs e)
        { updateGUI(); }


    } // Database Form
} // namespace XFiles
