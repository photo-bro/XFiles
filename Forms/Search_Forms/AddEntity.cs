﻿using System;
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

        public AddEntity()
        {
            InitializeComponent();

            // Populate checklistbox items from db
           // m_xFacade.q


        }

        private void chlbxFields_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
