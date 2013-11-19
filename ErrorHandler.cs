using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XFiles
{
    /// <summary>
    /// Tracks, maintains, and handles exceptions and errors within the
    /// program.
    /// </summary>
    class ErrorHandler
    {
        private static XFILES_ERROR c_CurrentError;

        private static string c_sErrorLog;
        private static int c_iErrorCount = 0;

        private static bool c_bDisplayWindow = true;

        /// <summary>
        /// Enumeration of possible errors
        /// </summary>
        public enum XFILES_ERROR
        {
            NONE = 0,
            UNKNOWN_ERROR = 1,
            MySQL_CONNECTION_ERROR = 2,
            MySQL_CONNECTION_INVALID_CREDENTIALS = 3,
            MySQL_CONNECTION_ALREADY_OPEN = 4,
            MySQL_CONNECTION_NOT_OPEN = 5
        } // enum XFILES_ERROR

        /// <summary>
        /// Set active program error
        /// </summary>
        /// <param name="error"></param>
        /// <param name="comment"></param>
        public static void Error(XFILES_ERROR error, string comment)
        {
            c_CurrentError = error;
            AddToLog(error, comment);
            // prompt user of error
            if (c_bDisplayWindow) ErrorPrompt(error, comment);
        } // Error

        /// <summary>
        /// Add a error entry to log
        /// </summary>
        /// <param name="entry"></param>
        private static void AddToLog(XFILES_ERROR error, string comment)
        {
            c_sErrorLog += System.DateTime.Now.ToString() + "\r\n";
            c_sErrorLog += "Error #" + c_iErrorCount++ + ":  " + error.ToString() + "\r\n";
            c_sErrorLog += comment + "\r\n";
        } // AddToLog

        /// <summary>
        /// Display message box containing error and comment
        /// </summary>
        /// <param name="error"></param>
        /// <param name="comment"></param>
        private static void ErrorPrompt(XFILES_ERROR error, string comment)
        {
            string sError = "Error - " + error.ToString() + "\r\n" + comment;
            System.Windows.Forms.MessageBox.Show(sError, error.ToString());
        } // ErrorPrompt

        /// <summary>
        /// Get/set boolean determining if errors prompt a messagebox
        /// </summary>
        public static bool DisplayErrorPrompt
        {
            get { return c_bDisplayWindow; }
            set { c_bDisplayWindow = value; }
        } // DisplayErrorPrompt

        /// <summary>
        /// Return the current error log
        /// </summary>
        public static string ErrorLog
        { get { return c_sErrorLog; } }

        /// <summary>
        /// Returns the current XFILES_ERROR
        /// </summary>
        public static XFILES_ERROR CurrentError
        { get { return c_CurrentError; } }




    } // ErrorHandler
} // namespace XFiles
