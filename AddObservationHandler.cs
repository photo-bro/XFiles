using System;
using System.Collections.Generic;
using System.Collections; // Hashtable
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
       

        // Use Hashtable to store fields from the AddObservationForm.
        private Hashtable m_ht = new Hashtable();

        public void addFieldToObservation(string field, string value)
        {
            if (!m_ht.ContainsKey(field))
                m_ht.Add(field, value);
            else
            {
                // already entry, so overwrite
                m_ht.Remove(field);
                m_ht.Add(field, value);
            }
        }

        public string htGet(string key)
        {
            try
            { return (string)m_ht[key]; }
            catch (Exception e)
            { return ""; }
        }

        public string GetInsertQuery
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                // INSERT INTO table (*, table)
                sb.Append("INSERT INTO Observation_T(LocationID, AnimalID, GroupID, " +
                    "Locality, Latitude, Longitude, DateAndTime, Weather, AirTemperature, " +
                    "Number, Color, Characteristics, Comments) VALUES");
                sb.Append("(");

                // get fields
                sb.AppendFormat("\"{0}\", \"{1}\", \"{2}\", \"{3}\", \"{4}\", \"{5}\", \"{6}\", \"{7}\", \"{8}\", \"{9}\", \"{10}\", \"{11}\", \"{12}\"",
                htGet("LocationID"),
                htGet("AnimalID"),
                htGet("GroupID"),
                htGet("Locality"),
                htGet("Latitude"),
                htGet("Longitude"),
                htGet("DateAndTime"),
                htGet("Weather"),
                htGet("AirTemperature"),
                htGet("Number"),
                htGet("Color"),
                htGet("Characteristics"),
                htGet("Comments"));

                sb.Append(");");
                return sb.ToString();
            } // get
        } // GetQuery




    } // AddObservationHandler
} // namespace XFiles
