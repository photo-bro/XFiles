﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XFiles.Forms
{
    public partial class Login : Form 
    {

        XFiles_Facade m_xFacade = XFiles_Facade.Instance;
        FileManager m_FM = FileManager.Instance;

        // Default constructor
        public Login()
        {
            InitializeComponent();

            // disable red 'x'
            this.ControlBox = false;

            // Remove before production build
            tbServer.Text = "cs-vh1"; //"sql3.freemysqlhosting.net";
            tbDataBase.Text = "xfiles";//"sql323644";
            tbUID.Text = "josh";//"sql323644";
            tbPassword.Text = "mudpie";//"uP8%bG6%";
        }

        /// <summary>
        /// Quit program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            Application.Exit(); 
        }

        /// <summary>
        /// Login to server based upon entered credentials
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Interface "backdoor" login
            // Can't alter data or even access db
            if (tbUID.Text == "GOD")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            } 

            m_FM.SetDatabaseCredentials(tbServer.Text, tbDataBase.Text, tbUID.Text,
                tbPassword.Text);
            m_xFacade.ConnectToDatabase();
            if (m_xFacade.DBConnected)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        } // btnLogin

    } // Login
} // Namespace XFiles.Forms
