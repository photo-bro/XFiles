using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XFiles
{
    /// <summary>
    /// Class maintaining the current status the the program.
    /// To be used in conjunction with the lower status bar in the
    /// main window form
    /// </summary>
    class Status
    {
        private static STATUS_TYPE c_ActiveStatus;

        private static string c_sStatusLog;

        private static int c_iLogCount = 0;

        /// <summary>
        /// Enumeration of possible program statuses
        /// </summary>
        public enum STATUS_TYPE
        {
            NONE = 0,
            COMMAND_SUCCESSFUL = 1,
            COMMAND_UNSUCCESSFUL = 2,
            CONNECTION_SUCCESSFUL = 3


        } // STATUS_TYPE

        /// <summary>
        /// Set active status for program
        /// </summary>
        /// <param name="status"></param>
        /// <param name="comment"></param>
        public static void SetStatus(STATUS_TYPE status, string comment)
        {
            c_ActiveStatus = status;
            AddToLog(status, comment);
        } // SetStatus

        /// <summary>
        /// Add a status entry to log
        /// </summary>
        /// <param name="entry"></param>
        private static void AddToLog(STATUS_TYPE status, string comment)
        {
            c_sStatusLog += System.DateTime.Now.ToString() + "\r\n";
            c_sStatusLog += "Entry #" + c_iLogCount++ + ":  " + status.ToString() + "\r\n";
            c_sStatusLog += comment + "\r\n";
        } // AddToLog

        /// <summary>
        /// Return the current status log
        /// </summary>
        public static string StatusLog
        { get { return c_sStatusLog; } }

        /// <summary>
        /// Return the current program STATUS_TYPE
        /// </summary>
        public static STATUS_TYPE ActiveStatus
        { get { return c_ActiveStatus; } }
        
        /// <summary>
        /// Return the current program status as a formatted string
        /// </summary>
        /// <returns></returns>
        public static string CurrentStatus()
        { return "Status: " + c_ActiveStatus.ToString(); }

        /// <summary>
        /// Return the current status in string form
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        { return "Status: " + c_ActiveStatus.ToString();}

    } // Status
} // namespace XFiles
