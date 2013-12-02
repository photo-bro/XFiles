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
    public partial class ResultWindow : Form
    {
        public ResultWindow(Query q)
        {
            InitializeComponent();


            dgv.DataSource = q.DataSource;
             tbSQL.Text = q.MySql_String;
        }

        private void btnClose_Click(object sender, EventArgs e)
        { this.Close(); }

        private void tbSQL_MouseClick(object sender, MouseEventArgs e)
        {
            tbSQL.SelectionStart = 0;
            tbSQL.SelectionLength = tbSQL.Text.Length;
        }
    } // ResultWindow
} // namespace XFiles.Forms
