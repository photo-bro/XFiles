using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XFiles
{
    class AddObservationHandler
    {
        // ***********************************************
        //       S I N G L E T O N    S T U F F
        // ***********************************************
        // static instance
        private static AddObservationHandler c_aohInstance;
        // lock object
        private static object c_aohLock = new object();
        // default constructor
        private AddObservationHandler() { }
        /// <summary>
        /// Returns singelton instance of class
        /// </summary>
        public static AddObservationHandler Instance
        {
            get
            {
                lock (c_aohLock)
                {
                    if (c_aohInstance == null) c_aohInstance = new AddObservationHandler();
                    return c_aohInstance;
                } // lock
            } // get
        } // Instance

        // ***********************************************
        //           H A N D L E R    S T U F F
        // ***********************************************

        // Observation:
        // Location(entity), DateTime, Weather, Wind, Temperature(f), Observer(entity)
        // Animal(entity), number, color, identifying characteristics, comment
        //
        // Location:
        // Lat/Long, Name, Locality (Science center, Eliestoun etc), address info (optional)
        //
        // Observer:
        // FirstName, LastName, Credentials (student, prof, staff, etc), age
        //
        // Animal:
        // Common Name, Scientific Name, phylum, class, order, family, genus, species, 
        // characteristics
        //  


        public string GetQuery
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                // INSERT INTO table (*, table)
                sb.Append("INSERT INTO ");
                // sb.Append("Observation_T VALUES"):

                sb.Append("(");
                //
                



                return sb.ToString();
            } // get
        } // GetQuery




    } // AddObservationHandler
} // namespace XFiles
