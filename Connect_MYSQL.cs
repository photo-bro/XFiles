using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms; // Feedback forms to user

namespace BNR
{

    /// <summary>
    /// Interface to MySQL server. Modified version of original by Jeremy Gilmand and Jessica Barrel
    /// </summary>
    class Connect_MySQL
    {
        private MySqlConnection connection;
        private string server, database, uid, password, connectionString;

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
            server = "";
            database = "jeremy.gilman";
            uid = "cs320";
            password = "cs320";
            connectionString = "SERVER=" + server +
                                    ";DATABASE=" + database +
                                    ";UID=" + uid +
                                    ";PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        } // Initialize

        /// <summary>
        /// Establish connection to database. True is returned if successful,
        /// else false has been returned.
        /// </summary>
        /// <returns></returns>
        public bool openConnection()
        {
            try
            {
                connection.Open();
                //MessageBox.Show("Connection to: " + database + " successful.");
                return true;
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

                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                } // switch exception
                return false;
            } // catch
        } // openConnection

        /// <summary>
        /// Close connection with database
        /// </summary>
        public void closeConnection()
        { connection.Close();} // closeConnection

        /// <summary>
        /// Send MySQL command to database
        /// </summary>
        /// <param name="sCommand"></param>
        public void sendCommand(string sCommand)
        {
            openConnection();

            MySqlCommand command = new MySqlCommand(sCommand, connection);

            command.ExecuteReader();

            closeConnection();

        } // sendCommand

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sCommand"></param>
        /// <returns></returns>
        public string GetColumns(string sCommand)
        {
            string answer = null;
            MySqlDataReader myReader = null;
            openConnection();

            MySqlCommand command = new MySqlCommand(sCommand, connection);

            myReader = command.ExecuteReader();
            int i = 0;
            while (myReader.Read())
                answer += myReader[i].ToString() + ",";

            closeConnection();
            return answer;
        }

        /// <summary>
        /// Query
        /// Pre: sCommand is a valid SQL command
        /// Post: the MySqlDataReader associated with the command has been returned
        /// </summary>
        /// <param name="sCommand"></param>
        public MySqlDataReader Query(string sCommand)
        {

            MySqlCommand command = new MySqlCommand(sCommand, connection);

            return command.ExecuteReader();
        }

        /// <summary>
        /// Returns MySQLCommand object connected to active database
        /// </summary>
        /// <returns></returns>
        public MySqlCommand CreateCommandCustom()
        {
            return connection.CreateCommand();
        }
    } // Connect_MySQL
} // namespace XFiles
