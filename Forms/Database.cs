using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data; // datatable

namespace XFiles
{
    public partial class Database : Form
    {
        private XFiles_Facade m_xFacade = XFiles_Facade.Instance;
        private List<DataGridView> m_lsDGV = new List<DataGridView>(3);


        public Database()
        {
            InitializeComponent();

            // initialize dgv's
            for (int i = 0; i < 3; ++i)
                m_lsDGV.Add(new DataGridView());

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
            
            // views
            dgvView1 = m_lsDGV[0];
            //dgvView2 = m_lsDGV[1];
            //dgvView2 = m_lsDGV[2];
        
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

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
             dgvView1.DataSource = m_xFacade.Query("SELECT * FROM test;");
            
            dgvView1.Update();

            m_lsDGV[0].AutoResizeColumns();
            m_lsDGV[0].AutoResizeRows();
            dgvView1.Refresh();
            //updateGUI();
        }


    } // Database Form
} // namespace XFiles
