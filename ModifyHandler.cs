using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms; // BindingSource

namespace XFiles
{
    /// <summary>
    /// Handler class for all actions of the ModifyWindow form
    /// </summary>
    class ModifyHandler
    {
        // ***********************************************
        //       S I N G L E T O N    S T U F F
        // ***********************************************
        // static instance
        private static ModifyHandler c_mhInstance;
        // lock object
        private static object c_mhLock = new object();
        // default constructor
        private ModifyHandler() { }
        /// <summary>
        /// Returns singelton instance of class
        /// </summary>
        public static ModifyHandler Instance
        {
            get
            {
                lock (c_mhLock)
                {
                    if (c_mhInstance == null) c_mhInstance = new ModifyHandler();
                    return c_mhInstance;
                } // lock
            } // get
        } // Instance

        // ***********************************************
        //           H A N D L E R    S T U F F
        // ***********************************************

        XFiles_Facade m_xFacade = XFiles_Facade.Instance;
        
        /// <summary>
        /// Returns string array of all tablenames in database
        /// </summary>
        /// <returns></returns>
        public string[] getTables()
        {
            // Query DB to get all fields,
            string s = m_xFacade.QueryToString("SHOW TABLES IN " + FileManager.Instance.DatabaseName + ";");
            string[] sDelim = { " ", "\r\n" };
            // Split string into individual items
            return s.Split(sDelim, StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// Returns BindingSource with total contents of tablename
        /// </summary>
        /// <param name="tablename"></param>
        /// <returns></returns>
        public BindingSource GetBindingSource(string tablename)
        {return m_xFacade.QueryToBindingSource("SELECT * FROM " + tablename + ";");}

        /// <summary>
        /// Returns a string containing the proper MySql modify query
        /// </summary>
        /// <param name="table">Name of table to modify</param>
        /// <param name="id">Primary key of table</param>
        /// <param name="rows">Rows modified (primary key of row modified)</param>
        /// <param name="columns">Columns modified, column[row][columns#] = columnname</param>
        /// <param name="values">Values modified, value[row][values#] = valuemodified</param>
        /// <returns>MySQL modify string</returns>
        public string GetModifyQuery(string table, string id, List<string> rows, List<List<string>> columns, 
            List<List<string>> values)
        {
            StringBuilder sb = new StringBuilder();

            int rowcount = 0;
            // Update each column in each row. Start by going through row by row
            foreach (var row in rows)
            {
                int colcount = 0;
                // Now go column by column
                foreach (var column in columns[rowcount])
                {
                    // Header for MySql statement
                    sb.AppendFormat("UPDATE {0} SET ", table);
                    // Obtain the column name and value to change
                    sb.AppendFormat("{0} = \"{1}\" ", columns[rowcount][colcount], values[rowcount][colcount]);
                    // Determine which row to update upon
                    sb.AppendFormat("WHERE {0} = \"{1}\";\r\n", id, rows[rowcount]);
                    ++colcount; // Increment to go to next column
                } // columns
                ++rowcount; // Increment to go to next row
            } // rows

            return sb.ToString();
        } // GetModifyQuery

        /// <summary>
        /// Returns primary key name from tablename
        /// </summary>
        /// <param name="tablename"></param>
        /// <returns></returns>
        public string getTableIDFromName(string tablename)
        { return tablename.Replace("_t", "ID");}

    } // ModifyHandler
} // namespace XFiles