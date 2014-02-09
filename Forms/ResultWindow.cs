using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
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

        private void cSVFilecsvToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            // prompt user for path and name
            // Call open file prompt
            SaveFileDialog sfdPrompt = new SaveFileDialog();
            sfdPrompt.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            sfdPrompt.ShowDialog();

            // Save file
            XFiles.Import_Export.CSV.Instance.ExportFromDGV(
                Path.GetDirectoryName(sfdPrompt.FileName)
                , Path.GetFileNameWithoutExtension(sfdPrompt.FileName)
                , dgv);
        }

        private void textFiletxtToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            // prompt user for path and name
            // Call open file prompt
            SaveFileDialog sfdPrompt = new SaveFileDialog();
            sfdPrompt.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            sfdPrompt.ShowDialog();

            // Save file
            XFiles_Facade.Instance.CreateFile(
                Misc.Conversion.DataTableToString(XFiles.Misc.Conversion.DGVToDatatable(dgv))
                , Path.GetDirectoryName(sfdPrompt.FileName)
                , Path.GetFileNameWithoutExtension(sfdPrompt.FileName));
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        { this.Close(); }

    } // ResultWindow
} // namespace XFiles.Forms
