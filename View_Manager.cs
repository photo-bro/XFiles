using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms; // BindingSource

namespace XFiles
{
    class View_Manager
    {
        // static instance
        private static View_Manager c_vmInstance;
        // static lock object
        private static object c_vmLock = new object();

        // Create 
        LinkedList<BindingSource> m_bsViews = new LinkedList<BindingSource>();


        // default constructor
        private View_Manager() { }

        /// <summary>
        /// Return static instance of class
        /// </summary>
        public static View_Manager Instance
        {
            get
            {
                lock (c_vmLock)
                {
                    if (c_vmInstance == null)
                        c_vmInstance = new View_Manager();
                    return c_vmInstance;
                } // lock
            } // get
        } // Instance


        /// <summary>
        /// Create new view from BindingSource
        /// </summary>
        /// <param name="bs"></param>
        public void CreateNewView(BindingSource bs)
        { m_bsViews.AddFirst(bs);}

        /// <summary>
        /// Return views
        /// </summary>
        /// <returns></returns>
        public LinkedList<BindingSource> GetViews()
        { return m_bsViews; }

        /// <summary>
        /// Get BindingSource at position i
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public BindingSource this[int i]
        {
            get
            {
                if (i < m_bsViews.Count)
                {
                    return m_bsViews.ElementAt(i);
                }
                else return null;
            }
        } // this[i]

    } // View_Manager
} // namespace XFiles
