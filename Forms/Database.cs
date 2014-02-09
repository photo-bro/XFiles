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
using XFiles.Import_Export;

namespace XFiles
{
    public partial class Database : Form
    {
        private XFiles_Facade m_xFacade = XFiles_Facade.Instance;
        private Query_Manager m_VM = Query_Manager.Instance;

       /// <summary>
       /// Default constructor
       /// </summary>
        public Database()
        {
            InitializeComponent();

            // Prep DGV's
            dgvView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            updateGUI();
        } // Database

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
            dgvView1.DataSource = m_VM[0].DataSource;
            dgvView1.AutoResizeColumns();
            dgvView2.DataSource = m_VM[1].DataSource;
            dgvView2.AutoResizeColumns();
            dgvView3.DataSource = m_VM[2].DataSource;
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
        /// Simple test for DGV integration with MySQL_Connect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(m_xFacade.QueryToString("SELECT * FROM test"));
            m_VM.CreateNewView("SELECT * FROM test;", m_xFacade.QueryToBindingSource("SELECT * FROM test;"));
            updateGUI();
        } // testToolStripMenuItem

        /// <summary>
        /// Show CustomQuery form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomQuery cq = new CustomQuery();
            cq.Show();
        } // customSearchToolStripMenuItem_Click

        /* ***********************************************
         * Refresh functions for different event types
         * *********************************************** */
        private void Refresh(object sender, EventArgs e)
        { updateGUI(); }
        private void Refresh(object sender, MouseEventArgs e)
        { updateGUI(); }

        /// <summary>
        /// Show Login form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_xFacade.DisconnectDatabase();
            Login lgForm = new Login();
            lgForm.Show();
        } // loginToolStripMenuItem_Click

        /// <summary>
        /// Show Search form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserQuery uq = new UserQuery();
            uq.Show();
        } // searchToolStripMenuItem_Click

        /// <summary>
        /// Button Search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {searchToolStripMenuItem.PerformClick();}

        /// <summary>
        /// Show current view in ResultWindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openViewInNewWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query q;
             // Get current view
            if (tabControlMain.SelectedTab == tabOne)
                q = m_VM[0];
            else if (tabControlMain.SelectedTab == tabTwo)
                q = m_VM[1];
            else if (tabControlMain.SelectedTab == tabThree)
                q = m_VM[2];
            else return;

            ResultWindow rw = new ResultWindow(q);
            try { rw.Show(); }
            catch (Exception ee)
            { MessageBox.Show("Query loading... Please try again"); }
        } // openViewInNewWindowToolStripMenuItem_Click

        /// <summary>
        /// Show AddObservationWindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddObservation_Click(object sender, EventArgs e)
        { AddObservationWindow(); }

        /// <summary>
        /// Show AddObservationWindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addObservationToolStripMenuItem_Click(object sender, EventArgs e)
        { AddObservationWindow(); }

        /// <summary>
        /// Show AddObservationWindow
        /// </summary>
        private void AddObservationWindow()
        {
            AddObservation ao = new AddObservation();
            ao.Show();
        } // AddObservationWindow

        /// <summary>
        /// Button Modify
        /// Show ModifyWindow form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModify_Click(object sender, EventArgs e)
        {
            ModifyWindow mw = new ModifyWindow();
            mw.Show();
        } // btnModify_Click

        /// <summary>
        /// About menuitem
        /// Show About form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.Show();
        }

        /// <summary>
        /// Prompts user for file path and name and saves active view as a text file 
        /// at that location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textFiletxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Call open file prompt
            SaveFileDialog sfdPrompt = new SaveFileDialog();
            sfdPrompt.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            sfdPrompt.ShowDialog();

            DataGridView dgv = getActiveDGV();

            // Check if view is empty
            if (dgv.Columns.Count < 1)
            {
                ErrorHandler.Error(ErrorHandler.XFILES_ERROR.VIEW_EMPTY, "Cannot save an empty table");
                Status.SetStatus(Status.STATUS_TYPE.COMMAND_UNSUCCESSFUL, "Cannot save an empty table");
                return;
            } // columns < 1

            DataTable dtSource = XFiles.Misc.Conversion.DGVToDatatable(dgv);

            // save file
            string s = Misc.Conversion.DataTableToString(dtSource);
            m_xFacade.CreateFile(s
                , Path.GetDirectoryName(sfdPrompt.FileName)
                , Path.GetFileName(sfdPrompt.FileName));

            updateGUI();
        }

        /// <summary>
        /// Prompts user for file path and name and saves active view as a CSV 
        /// at that location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cSVFilecsvToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // prompt user for path and name
            // Call open file prompt
            SaveFileDialog sfdPrompt = new SaveFileDialog();
            sfdPrompt.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            sfdPrompt.ShowDialog();

            // Save file
            CSV.Instance.ExportFromDGV(Path.GetDirectoryName(sfdPrompt.FileName)
                , Path.GetFileNameWithoutExtension(sfdPrompt.FileName)
                , getActiveDGV());

            updateGUI();
        }

        /// <summary>
        /// Returns the active DataGridView
        /// </summary>
        /// <returns></returns>
        private DataGridView getActiveDGV()
        {
            // Get current view
            if (tabControlMain.SelectedTab == tabOne)
                return dgvView1;
            else if (tabControlMain.SelectedTab == tabTwo)
                return dgvView2;
            else if (tabControlMain.SelectedTab == tabThree)
                return dgvView3;
            else return null;
        }

    } // Database Form
} // namespace XFiles
