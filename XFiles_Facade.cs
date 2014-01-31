using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient; // MySqlDataReader
using System.Windows.Forms; // BindingSource (for fetching from db)
using System.Data; // DataTable


namespace XFiles
{
    /// <summary>
    /// Facade for basic MySql connectivity and program functions
    /// </summary>
    class XFiles_Facade
    {
        // static instance of class
        private static XFiles_Facade c_xfInstance;

        // static lock object
        private static object c_xfLock = new object();

        // Singleton class instances
        private FileManager m_FM = FileManager.Instance;
        private Connect_MySQL m_SQL = Connect_MySQL.LogIn();

        // Track if DB is connected
        private bool m_bDBConnected = false;
        /// <summary>
        /// Returns true if database is connected, false if not.
        /// </summary>
        public bool DBConnected
        { get { return m_bDBConnected; } }


        /// <summary>
        /// default constructor
        /// </summary>
        private XFiles_Facade() { }

        /// <summary>
        /// Return static instance of class
        /// </summary>
        public static XFiles_Facade Instance
        {
            get
            {
                lock (c_xfLock)
                {
                    if (c_xfInstance == null)
                        c_xfInstance = new XFiles_Facade();
                    return c_xfInstance;
                } // lock
            } // get
        } // Instance

        /// <summary>
        /// Connect to BNR database
        /// </summary>
        public void ConnectToDatabase()
        {
            m_bDBConnected = m_SQL.openConnection();
            if (m_bDBConnected) Status.SetStatus(Status.STATUS_TYPE.CONNECTION_SUCCESSFUL,
                "Successfully connected to database");
        } // ConnectToDataBase

        /// <summary>
        /// Disconnect from BNR database
        /// </summary>
        public void DisconnectDatabase()
        {
            m_SQL.closeConnection();
            m_bDBConnected = false;

        } // DisconnectDatabase

        /// <summary>
        /// Open and parse file into active database
        /// </summary>
        /// <param name="path"></param>
        public void OpenDataBaseInputFile(string path)
        {/* not implemented */ }

        /// <summary>
        /// Sends MySql string command to active database
        /// </summary>
        /// <param name="command"></param>
        public void Command(string command)
        {
            try
            {
                m_SQL.sendCommand(command);
                Status.SetStatus(Status.STATUS_TYPE.COMMAND_SUCCESSFUL, "Command sent and processed correctly");
            } // try
            catch (MySqlException e)
            {
                ErrorHandler.Error(ErrorHandler.XFILES_ERROR.UNKNOWN_ERROR, e.ToString());
                Status.SetStatus(Status.STATUS_TYPE.COMMAND_UNSUCCESSFUL, "Command send or process error");
            } // catch
        } // Command

        /// <summary>
        /// Return a BindingSource object containing the data selected by the query
        /// </summary>
        /// <param name="tablename"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        public BindingSource QueryToBindingSource(string query)
        { return m_SQL.QueryToBindingSource(query);}


        /// <summary>
        /// Query database and return result as formatted string
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public string QueryToString(string query)
        { return m_SQL.QueryToString(query); }

        /// <summary>
        /// Saves the contents of a datatable as a formatted text file to path/name
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="path"></param>
        /// <param name="name"></param>
        public void ExportDataTableToFile(DataTable dt, string path, string name)
        {
            if (dt == null)
            {
                ErrorHandler.Error(ErrorHandler.XFILES_ERROR.VIEW_EMPTY, "Cannot save an empty table");
                Status.SetStatus(Status.STATUS_TYPE.COMMAND_UNSUCCESSFUL, "Cannot save an empty table");
                return;
            } // check if datatable null

            StringBuilder sb = new StringBuilder();

            // Credit:
            // Wooh! Double imbedded lambda expressions!
            // http://www.codeproject.com/Tips/261752/Convert-DataTable-to-String-by-Extension-Method
            // column heading first
            dt.Columns.Cast<DataColumn>().ToList().ForEach(col => sb.AppendFormat("{0}, ", col.ColumnName));
            sb.Append(Environment.NewLine + Environment.NewLine);
            dt.Rows.Cast<DataRow>().ToList().ForEach(dataRow =>
            {
                // column values
                dt.Columns.Cast<DataColumn>().ToList().ForEach(column =>
                {
                    sb.AppendFormat("{0}, ", dataRow[column]);
                });
                sb.Append(Environment.NewLine);
            });

            m_FM.CreateFile(sb.ToString(), path, name);        
        } // ExportDataTableToFile

    } // XFiles_Facade
} // namespace XFiles
