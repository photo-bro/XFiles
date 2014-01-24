using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using XFiles.Forms; // Login

namespace XFiles
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login lgForm = new Login();
            Application.Run(lgForm);

            if (lgForm.DialogResult == DialogResult.OK)
                Application.Run(new Database());
        } // Main
    } // PRogram
} // namespace XFiles
