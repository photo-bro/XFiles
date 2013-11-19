using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms; // BindingSource (for fetching from db)
using System.Data; // DataTable


namespace XFiles
{
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
        /// Open and parse file into active database
        /// </summary>
        /// <param name="path"></param>
        public void OpenDataBaseInputFile(string path)
        {
        }

        /// <summary>
        /// Return a DataGridView object containing the data selected by the query
        /// </summary>
        /// <param name="tablename"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        public BindingSource Query(string query )
        { return m_SQL.QueryToBindingSource(query);}

        public void ExportDataTableToFile(DataTable dt, string path, string name)
        {
            if (dt == null)
            {
                ErrorHandler.Error(ErrorHandler.XFILES_ERROR.VIEW_EMPTY, "Cannot save an empty table");
                Status.SetStatus(Status.STATUS_TYPE.COMMAND_UNSUCCESSFUL, "Cannot save an empty table");
                return;
            }

            StringBuilder sb = new StringBuilder();

            // Credit:
            // http://www.codeproject.com/Tips/261752/Convert-DataTable-to-String-by-Extension-Method
            dt.Rows.Cast<DataRow>().ToList().ForEach(dataRow =>
            {
                dt.Columns.Cast<DataColumn>().ToList().ForEach(column =>
                {
                    sb.AppendFormat("{0}:{1} ", column.ColumnName, dataRow[column]);
                });
                sb.Append(Environment.NewLine);
            });

            m_FM.CreateFile(sb.ToString(), path, name);        
        } // ExportDataTableToFile

    } // XFiles_Facade
} // namespace XFiles
