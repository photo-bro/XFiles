using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms; // BindingSource

namespace XFiles
{
    /// <summary>
    /// A Query contains a BindingSource and its respective MySql string
    /// </summary>
    public struct Query
    {
        private BindingSource m_bsResult;
        private string m_sSQL_String;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="query"></param>
        /// <param name="result"></param>
        public Query(string query, BindingSource result)
        {
            m_sSQL_String = query;
            m_bsResult = result;
        } // Query

        /// <summary>
        /// Get/sets binding source
        /// </summary>
        public BindingSource DataSource
        {
            get { return m_bsResult; }
            set { m_bsResult = value; }
        } // Datasource

        /// <summary>
        /// Get/sets MySql string
        /// </summary>
        public string MySql_String
        {
            get { return m_sSQL_String; }
            set { m_sSQL_String = value; }
        } // MySql_String
    } // Query

    /// <summary>
    /// Manages Query objects throughout XFiles. Specifically in relation to views
    /// </summary>
    class Query_Manager
    {
        // static instance
        private static Query_Manager c_vmInstance;
        // static lock object
        private static object c_vmLock = new object();

        // Query's stored in order of "creation"
        LinkedList<Query> m_Querys = new LinkedList<Query>();

        // default constructor
        private Query_Manager() { }

        /// <summary>
        /// Return static instance of class
        /// </summary>
        public static Query_Manager Instance
        {
            get
            {
                lock (c_vmLock)
                {
                    if (c_vmInstance == null)
                        c_vmInstance = new Query_Manager();
                    return c_vmInstance;
                } // lock
            } // get
        } // Instance

        /// <summary>
        /// Create new view from BindingSource
        /// </summary>
        /// <param name="bs"></param>
        public void CreateNewView(string query, BindingSource result)
        { m_Querys.AddFirst(new Query(query, result));}

        /// <summary>
        /// Get Query at position i
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Query this[int i]
        {
            get
            {
                if (i < m_Querys.Count)
                {
                    return m_Querys.ElementAt(i);
                }
                else return new Query("", null);
            }
        } // this[i]

        /// <summary>
        /// Get MySql query string from Query at position i
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public string MySql_String(int position)
        {
            if (position < m_Querys.Count)
            {
                return m_Querys.ElementAt(position).MySql_String;
            }
            else return "";
        } // MySql_String

    } // View_Manager
} // namespace XFiles
