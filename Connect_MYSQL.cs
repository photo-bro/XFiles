using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms; // DataGridView, Feedback forms to user
using System.Data; // dataset

namespace XFiles
{

    /// <summary>
    /// Interface to MySQL server. Modified version LOOSELY based on original by 
    /// Jeremy Gilmand and Jessica Barrel
    /// </summary>
    class Connect_MySQL
    {
        // MySQL connection object
        private MySqlConnection m_sqlConnection;
        // open connection bool
        private bool m_bIsOpen = false;

        // static instance of class
        private static Connect_MySQL c_sqlInstance;
        // static lock object
        private static Object c_sqlLock = typeof(Connect_MySQL);

        /// <summary>
        /// Return the singleton instance of class. Initializes connection to
        /// MySQL database
        /// </summary>
        /// <returns></returns>
        static public Connect_MySQL LogIn()
        {
            lock (c_sqlLock)
            {
                if (c_sqlInstance == null)
                    c_sqlInstance = new Connect_MySQL();
                return c_sqlInstance;
            }
        } // LogIn

        /// <summary>
        /// default constructor - establishes connection to database
        /// </summary>
        private Connect_MySQL()
        {
            Initialize();
        } // Connect_MySQL

        /// <summary>
        /// MySQL command to connect to database
        /// </summary>
        private void Initialize()
        {
           // m_sqlConnection = new MySqlConnection(FileManager.Instance.DatabaseConnectionString);
        } // Initialize

        /// <summary>
        /// Establish connection to database. True is returned if successful,
        /// else false has been returned.
        /// Found the source they used:
        /// http://solibnis.blogspot.com/2013/02/connecting-mysql-table-to-datagridview.html
        /// </summary>
        /// <returns></returns>
        public bool openConnection()
        {
            if (m_bIsOpen)
            {
                ErrorHandler.Error(ErrorHandler.XFILES_ERROR.MySQL_CONNECTION_ALREADY_OPEN,
                    "Database already connected");
                return m_bIsOpen;
            }
            // reset credentials
            m_sqlConnection = new MySqlConnection(FileManager.Instance.DatabaseConnectionString);
            try
            {
                m_sqlConnection.Open();
                //MessageBox.Show("Connection to: " + "XFiles" + " successful.");
                m_bIsOpen = true;
            } // try
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        ErrorHandler.Error(ErrorHandler.XFILES_ERROR.MySQL_CONNECTION_ERROR,
                            "Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        ErrorHandler.Error(ErrorHandler.XFILES_ERROR.MySQL_CONNECTION_INVALID_CREDENTIALS,
                           "Invalid username/password, please try again");
                        break;
                } // switch exception
                m_bIsOpen = false;
            } // catch
            return m_bIsOpen;
        } // openConnection

        /// <summary>
        /// Close connection with database
        /// </summary>
        public void closeConnection()
        {
            m_sqlConnection.Close();
            m_bIsOpen = false;
        } // closeConnection

        /// <summary>
        /// Send MySQL command to database
        /// </summary>
        /// <param name="sCommand"></param>
        public void sendCommand(string sCommand)
        {
            openConnection();

            MySqlCommand command = new MySqlCommand(sCommand, m_sqlConnection);

            command.ExecuteReader();

            closeConnection();

        } // sendCommand

        /// <summary>
        /// Query
        /// Pre: sCommand is a valid SQL command
        /// Post: the MySqlDataReader associated with the command has been returned
        /// </summary>
        /// <param name="sCommand"></param>
        public MySqlDataReader Query(string sCommand)
        {
            MySqlCommand command = new MySqlCommand(sCommand, m_sqlConnection);

            return command.ExecuteReader();
        } // Query

        /// <summary>
        /// Returns a BindingSource containing the contents of the query
        /// Josh Harmon
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public BindingSource QueryToBindingSource(string query)
        {
            if (!m_bIsOpen)
            {
                ErrorHandler.Error(ErrorHandler.XFILES_ERROR.MySQL_CONNECTION_NOT_OPEN,
                    "Database is not connected");
                return null;
            }

            // Some Credit:
            // http://solibnis.blogspot.com/2013/02/connecting-mysql-table-to-datagridview.html

            // DataTable intermediate between BindingSource and MySQL command
            DataTable dt = new DataTable();

            // get query from db
            MySqlDataAdapter da = new MySqlDataAdapter(query, m_sqlConnection);
            try
            {
                // fill dataset which can then fill BindingSource
                da.Fill(dt);

            } // try
            catch (MySqlException e)
            {
                ErrorHandler.Error(ErrorHandler.XFILES_ERROR.UNKNOWN_ERROR, e.ToString());
                return null;
            } // catch

            Status.SetStatus(Status.STATUS_TYPE.COMMAND_SUCCESSFUL, "Test successful");

            // Create and set binding source
            BindingSource bs = new BindingSource();
            // Pass DataTable into BindingSource
            bs.DataSource = dt;

            return bs;
        } // QueryToDGV

        /// <summary>
        /// Returns MySQLCommand object connected to active database
        /// </summary>
        /// <returns></returns>
        public MySqlCommand CreateCommandCustom()
        {
            return m_sqlConnection.CreateCommand();
        } // CreateCommandCustom
    } // Connect_MySQL
} // namespace XFiles
