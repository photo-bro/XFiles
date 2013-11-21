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

        public void AddField(string field)
        { m_lsFields.Add(field); }

        public void AddTable(string table)
        { m_lsTables.Add(table); }

        public List<string> getFields
        { get { return m_lsFields; } }

        public List<string> getTables
        { get { return m_lsTables; } }



    } // UserQueryHandler
} // namespace XFiles
