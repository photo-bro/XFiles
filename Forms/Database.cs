﻿using System;
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
        private Query_Manager m_VM = Query_Manager.Instance;

       
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

        private void Refresh(object sender, MouseEventArgs e)
        { updateGUI(); }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_xFacade.DisconnectDatabase();
            Login lgForm = new Login();
            lgForm.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserQuery uq = new UserQuery();
            uq.Show();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {searchToolStripMenuItem.PerformClick();}

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
        }

        private void btnAddObservation_Click(object sender, EventArgs e)
        { AddObservationWindow(); }

        private void addObservationToolStripMenuItem_Click(object sender, EventArgs e)
        { AddObservationWindow(); }

        private void AddObservationWindow()
        {
            AddObservation ao = new AddObservation();
            ao.Show();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            ModifyWindow mw = new ModifyWindow();
            mw.Show();
        }


    } // Database Form
} // namespace XFiles
