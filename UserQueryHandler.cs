using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XFiles
{
    /// <summary>
    /// Handler class of all actions for the UserQuery and child forms
    /// </summary>
    class UserQueryHandler
    {
        // ***********************************************
        //       S I N G L E T O N    S T U F F
        // ***********************************************
        // static instance
        private static UserQueryHandler c_uqhInstance;
        // lock object
        private static object c_uqhLock = new object();
        // default constructor
        private UserQueryHandler() { }
        /// <summary>
        /// Returns singelton instance of class
        /// </summary>
        public static UserQueryHandler Instance
        {
            get
            {
                lock (c_uqhLock)
                {
                    if (c_uqhInstance == null) c_uqhInstance = new UserQueryHandler();
                    return c_uqhInstance;
                } // lock
            } // get
        } // Instance

        // ***********************************************
        //           H A N D L E R    S T U F F
        // ***********************************************

        XFiles_Facade m_xFacade = XFiles_Facade.Instance;

        // Store fields and tables used for query
        private List<string> m_lsFields = new List<string>();
        private List<string> m_lsTables = new List<string>();
        private List<string> m_lsConditions = new List<string>();
        private List<string> m_lsJoinConditions = new List<string>();

        // Conditions
        public string[] Conditionals = { "=", "!=", "<", ">", "<=", ">=" };
        public string[] JoinConditionals = { "  ", "AND", "OR", "XOR" };

        // Deliminator
        string[] m_sDelim = { ",", " ", "\r\n" };

        /// <summary>
        /// Resets class variables
        /// </summary>
        public void Reset()
        {
            m_lsFields.Clear();
            m_lsTables.Clear();
            m_lsConditions.Clear();
            m_lsJoinConditions.Clear();
        } // Reset

        /// <summary>
        /// Add selected fields for current query
        /// </summary>
        /// <param name="fields"></param>
        public void AddFields(string[] fields)
        {
            m_lsFields.Clear();
            m_lsFields.AddRange(fields);
        } // AddFields

        /// <summary>
        /// Add selected tables for current query
        /// </summary>
        /// <param name="tables"></param>
        public void AddTables(string[] tables)
        {
            m_lsTables.Clear();
            m_lsTables.AddRange(tables);
        } // AddTables

        /// <summary>
        /// Add selected condition for current query
        /// </summary>
        /// <param name="condition"></param>
        public void AddCondition(string condition)
        { m_lsConditions.Add(condition); }

        /// <summary>
        /// Returns previously selected fields
        /// </summary>
        public List<string> getFields
        { get { return m_lsFields; } }

        /// <summary>
        /// Returns previously selected tables
        /// </summary>
        public List<string> getTables
        { get { return m_lsTables; } }

        /// <summary>
        /// Returns previously selected conditions
        /// </summary>
        public List<string> getConditions
        { get { return m_lsConditions; } }

        /// <summary>
        /// Returns a formatted MySql query based upon selected fields, tables, and conditions
        /// </summary>
        public string GetQuery
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                // Determine which fields to select
                sb.Append("SELECT ");
                for (int i = 0; i < m_lsFields.Count; ++i)
                {
                    if (i == m_lsFields.Count - 1)
                        sb.AppendFormat("{0} ", m_lsFields[i]);
                    else
                        sb.AppendFormat("{0}, ", m_lsFields[i]);
                } // for fields selected

                // Determine which tables to be queried
                sb.Append("FROM ");
                for (int i = 0; i < m_lsTables.Count; ++i)
                {
                    if (i == m_lsTables.Count - 1)
                        sb.AppendFormat("{0} ", m_lsTables[i]);
                    else
                        sb.AppendFormat("{0} NATURAL JOIN  ", m_lsTables[i]);
                } // for tables selected

                // Determine condition(s) to query on
                if (m_lsConditions.Count > 0)
                {
                    sb.Append("WHERE ");
                    for (int i = 0; i < m_lsConditions.Count; ++i)
                    {
                        if (i == m_lsConditions.Count - 1)
                        sb.AppendFormat("{0} ", m_lsConditions[i]);
                        else
                            sb.AppendFormat("{0} ", m_lsConditions[i]);
                    }
                } // if (m_lsConditions.Count > 0)

                sb.Append(";");

                return sb.ToString();
            } // get
        } // GetQuery

        /// <summary>
        /// Return a sorted distinct string arry of all fields in current database
        /// </summary>
        /// <returns></returns>
        public string [] getEntities()
        {
            string sFields = m_xFacade.QueryToString("SELECT `COLUMN_NAME` FROM `INFORMATION_SCHEMA`.`COLUMNS` WHERE `TABLE_SCHEMA`='"
                + FileManager.Instance.DatabaseName + "';");
            // Split string into individual items
            List<string> ls = new List<string>(sFields.Split(m_sDelim, StringSplitOptions.RemoveEmptyEntries));
            ls.Sort();
            return ls.Distinct().ToArray();
        } // getEntities

        /// <summary>
        /// Return a string array of all tables in current database
        /// </summary>
        /// <returns></returns>
        public string[] getTablesFromDB()
        {
            string sFields = m_xFacade.QueryToString("SHOW TABLES IN " + FileManager.Instance.DatabaseName + ";");
            // Split string into individual items
            return sFields.Split(m_sDelim, StringSplitOptions.RemoveEmptyEntries);

        } // getTablesFromDB

    } // UserQueryHandler
} // namespace XFiles
