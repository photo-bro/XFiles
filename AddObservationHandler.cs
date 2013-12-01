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

        XFiles_Facade m_xFacade = XFiles_Facade.Instance;

        string[] m_sDelim = { "\r\n" };

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

        public string[] getWeather = {"Sunny", "Partly Cloudy", "Cloudy", "Overcast", "Raining"};

        public string[] getCredentials = { "Student", "Professor", "Staff", "Visitor", "Other" };

        public string[] getAddresses()
        {
            // get all locations from server
            string sAddresses = m_xFacade.QueryToString("SELECT AddressName FROM Address_T;");
            return sAddresses.Split(m_sDelim, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }

        public string[] getLocations()
        {
            // get all locations from server
            string sLocations = m_xFacade.QueryToString("SELECT OfficialName FROM Location_T;");
            return sLocations.Split(m_sDelim, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }

        public string[] getObservers()
        {
            string sObservers = m_xFacade.QueryToString("SELECT FirstName, LastName FROM Observer_T;");
            return sObservers.Split(m_sDelim, StringSplitOptions.RemoveEmptyEntries).ToArray();

        }

        public string[] getAnimals()
        {
            // get all animals from server
            string sAnimals = m_xFacade.QueryToString("SELECT CommonName FROM Animal_T;");
            return sAnimals.Split(m_sDelim, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }

        public string[] getGroups()
        {
            // get all groups from server
            string sGroups = m_xFacade.QueryToString("SELECT GroupName FROM Group_T;");
            return sGroups.Split(m_sDelim, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }

        public string getAddressID(string AddressName)
        {
            return m_xFacade.QueryToString("SELECT AddressID FROM Address_T WHERE AddressName = \"" + AddressName + "\";");
        }

        public string getObserverID(string FirstName, string LastName)
        {
            return m_xFacade.QueryToString("SELECT ObserverID FROM Observer_T WHERE FirstName = \"" + FirstName + "\" AND LastName = \"" + LastName + "\";");
        }

        public string getGroupID(string GroupName)
        {
            return m_xFacade.QueryToString("SELECT GroupID FROM Group_T WHERE GroupName = \"" + GroupName + "\";");
        }

        public string getLocationID(string LocationName)
        {
            return m_xFacade.QueryToString("SELECT LocationID FROM Location_T WHERE OfficialName = \"" + LocationName + "\";");
        }

        public string getAnimalID(string AnimalName)
        {
            return m_xFacade.QueryToString("SELECT AnimalID FROM Animal_T WHERE CommonName = \"" + AnimalName + "\";");
        }

        public string GetInsertQuery
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                // INSERT INTO table (*, table)
                sb.Append("INSERT INTO Observation_T(LocationID, AnimalID, GroupID, " +
                    "Locality, Latitude, Longitude, DateAndTime, Weather, AirTemperature, " +
                    "Number, Color, Characteristics, Comments) VALUES\r\n");
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

        public void InsertLocation(string AddressID, string OfficialName)
        {
            string s = string.Format("INSERT INTO Location_T (AddressID, OfficialName) VALUE (\"{0}\", \"{1}\");",
                AddressID, OfficialName);
            m_xFacade.Command(s);
        }

        public void InsertAnimal(string CommonName, string Genus, string Species, string Characteristics)
        {
            string s = string.Format("INSERT INTO Animal_T (CommonName, Genus, Species, Characteristics) VALUE (\"{0}\", \"{1}\", \"{2}\", \"{3}\");",
            CommonName, Genus, Species, Characteristics);

            m_xFacade.Command(s);
        }

        public void InsertGroup(string GroupName, string Active)
        {
            string s = string.Format("INSERT INTO Group_T (GroupName, Active) VALUE (\"{0}\", {1});",
             GroupName, Active);

            m_xFacade.Command(s);
        }

        public void InsertObserver(string AddressID, string FirstName, string LastName, string Credentials, string PhoneNumber_1,
            string PhoneNumber_2, string EmailAddress)
        {
            string s = string.Format("INSERT INTO Observer_T (AddressID, FirstName, LastName, Credentials, PhoneNumber_1, PhoneNumber_2, EmailAddress)" +
            "VALUE (\"{0}\", \"{1}\", \"{2}\", \"{3}\", \"{4}\", \"{5}\", \"{6}\");", AddressID, FirstName, LastName, Credentials, PhoneNumber_1, PhoneNumber_2, EmailAddress);

            m_xFacade.Command(s);
        }

        public void InsertAddress(string AddressName, string State, string StreetName, string BuildingNumber, string Zipcode)
        {
            string s = string.Format("INSERT INTO Address_T (AddressName, State, StreetName, BuildingNumber, Zipcode) VALUE (\"{0}\", \"{1}\", \"{2}\", \"{3}\", \"{4}\");",
            AddressName, State, StreetName, BuildingNumber, Zipcode);

            m_xFacade.Command(s);
        }

        public void InsertObserverList(string GroupID, string ObserverID)
        {
            string s = string.Format("INSERT INTO ObserverList_T(GroupID, ObserverID) VALUE (\"{0}\", \"{1}\")",
                GroupID, ObserverID);
            m_xFacade.Command(s);
        }

    } // AddObservationHandler
} // namespace XFiles
