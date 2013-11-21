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

        public Login()
        {
            InitializeComponent();

            // Remove before production build
            tbServer.Text = "cs-vh1";
            tbDataBase.Text = "xfiles";
            tbUID.Text = "josh";
            tbPassword.Text = "mudpie";
        }

        /// <summary>
        /// Quit program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e)
        { Application.Exit(); }

        /// <summary>
        /// Login to server based upon entered credentials
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            m_FM.SetDatabaseCredentials(tbServer.Text, tbDataBase.Text, tbUID.Text,
                tbPassword.Text);
            m_xFacade.ConnectToDatabase();
            if (m_xFacade.DBConnected)
            {
                //Database dbFormMain = new Database();
                //dbFormMain.
                this.Close();
            }
        } // btnLogin
    } // Login
} // Namespace XFiles.Forms
