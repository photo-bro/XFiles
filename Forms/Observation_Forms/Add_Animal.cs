using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XFiles.Forms.Observation_Forms
{
    public partial class Add_Animal : Form
    {
        public Add_Animal()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        { this.Close(); }
    }
}
