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

        public AddCondition()
        {
            InitializeComponent();
            // Populate fields
            cbxField.Items.AddRange(m_UQH.getFields.ToArray());
        }

    }
}
