using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XFiles
{
    class XFiles_Facade
    {
        // static instance of class
        private static XFiles_Facade c_xfInstance;

        // static lock object
        private static object c_xfLock;

        // Singleton class instances
        private FileManager m_FM = FileManager.Instance;



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
        /// Open and parse file into active database
        /// </summary>
        /// <param name="path"></param>
        public void OpenDataBaseInputFile(string path)
        {
        }




    } // XFiles_Facade
} // namespace XFiles
