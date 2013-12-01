using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XFiles
{
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
    }
}
