using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XFiles
{
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

        // Store fields and tables used for query
        private List<string> m_lsFields = new List<string>();
        private List<string> m_lsTables = new List<string>();
        private List<string> m_lsConditions = new List<string>();
        private List<string> m_lsJoinConditions = new List<string>();

        // Conditions
        public string[] Conditionals = { "=", "!=", "<", ">", "<=", ">=" };
        public string[] JoinConditionals = { "  ", "AND", "OR", "XOR" };

        public void Reset()
        {
            m_lsFields.Clear();
            m_lsTables.Clear();
            m_lsConditions.Clear();
            m_lsJoinConditions.Clear();
        }

        public void AddFields(string[] fields)
        {
            m_lsFields.Clear();
            m_lsFields.AddRange(fields);
        }

        public void AddTables(string[] tables)
        {
            m_lsTables.Clear();
            m_lsTables.AddRange(tables);
        }

        public void AddCondition(string condition)
        { m_lsConditions.Add(condition); }

        public List<string> getFields
        { get { return m_lsFields; } }

        public List<string> getTables
        { get { return m_lsTables; } }

        public List<string> getConditions
        { get { return m_lsConditions; } }

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
                }

                // Determine which tables to be queried
                sb.Append("FROM ");
                for (int i = 0; i < m_lsTables.Count; ++i)
                {
                    if (i == m_lsTables.Count - 1)
                        sb.AppendFormat("{0} ", m_lsTables[i]);
                    else
                        sb.AppendFormat("{0} NATURAL JOIN  ", m_lsTables[i]);
                }

                // Determine condition(s) to query on
                sb.Append("WHERE ");
                for (int i = 0; i < m_lsConditions.Count; ++i)
                {
                    //if (i == m_lsConditions.Count - 1)
                        sb.AppendFormat("{0} ", m_lsConditions[i]);
                    //else
                    //    sb.AppendFormat("{0} ", m_lsConditions[i]);
                }

                sb.Append(";");

                return sb.ToString();
            }
        }

    } // UserQueryHandler
} // namespace XFiles
