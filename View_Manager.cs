using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XFiles
{
    class View_Manager
    {
        private static View_Manager c_vmInstance;
        private static object c_vmLock = new object();

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




    }
}
