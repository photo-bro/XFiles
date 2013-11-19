using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms; // datagridview (for fetching from db)


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
        public DataGridView Query(string query )
        { return m_SQL.QueryToDGV(query);}



    } // XFiles_Facade
} // namespace XFiles
