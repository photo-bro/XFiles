using System;
using System.Collections.Generic;
using System.Collections; // Hashtable
using System.Linq;
using System.Text;

namespace XFiles
{
    /// <summary>
    /// Handler class for AddObservation and child forms
    /// </summary>
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

        /// <summary>
        /// Reset class variables
        /// </summary>
        public void Reset()
        { m_ht.Clear();}

        /// <summary>
        /// Add value and field name to internal structure
        /// </summary>
        /// <param name="field"></param>
        /// <param name="value"></param>
        public void addFieldToObservation(string field, string value)
        {
            if (!m_ht.ContainsKey(field))
                m_ht.Add(field, value);
            else
            {
                // already entry, so overwrite
                m_ht.Remove(field);
                m_ht.Add(field, value);
            } // else
        } // addFieldToObservation

        /// <summary>
        /// Returns value as string referenced by key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string htGet(string key)
        {
            try
            { return (string)m_ht[key]; }
            catch (Exception e)
            { return ""; }
        } // htGet

        /// <summary>
        /// Weather enumerator as string array
        /// </summary>
        public string[] getWeather = {"Sunny", "Partly Cloudy", "Cloudy", "Overcast", "Raining"};

        /// <summary>
        /// Credential enumerator as string array
        /// </summary>
        public string[] getCredentials = { "Student", "Professor", "Staff", "Visitor", "Other" };

        /// <summary>
        /// Returns string array of all addresses in active database
        /// </summary>
        /// <returns></returns>
        public string[] getAddresses()
        {
            // get all locations from server
            string sAddresses = m_xFacade.QueryToString("SELECT AddressName FROM Address_T;");
            return sAddresses.Split(m_sDelim, StringSplitOptions.RemoveEmptyEntries).ToArray();
        } // getAddresses

        /// <summary>
        /// Returns string array of all locations in active database
        /// </summary>
        /// <returns></returns>
        public string[] getLocations()
        {
            // get all locations from server
            string sLocations = m_xFacade.QueryToString("SELECT OfficialName FROM Location_T;");
            return sLocations.Split(m_sDelim, StringSplitOptions.RemoveEmptyEntries).ToArray();
        } // getLocations

        /// <summary>
        /// Returns string array of all observers in active database
        /// </summary>
        /// <returns></returns>
        public string[] getObservers()
        {
            string sObservers = m_xFacade.QueryToString("SELECT FirstName, LastName FROM Observer_T;");
            return sObservers.Split(m_sDelim, StringSplitOptions.RemoveEmptyEntries).ToArray();
        } // getObservers

        /// <summary>
        /// Returns string array of all animals in active database
        /// </summary>
        /// <returns></returns>
        public string[] getAnimals()
        {
            // get all animals from server
            string sAnimals = m_xFacade.QueryToString("SELECT CommonName FROM Animal_T;");
            return sAnimals.Split(m_sDelim, StringSplitOptions.RemoveEmptyEntries).ToArray();
        } // getAnimals

        /// <summary>
        /// Returns string array of all groups in active database
        /// </summary>
        /// <returns></returns>
        public string[] getGroups()
        {
            // get all groups from server
            string sGroups = m_xFacade.QueryToString("SELECT GroupName FROM Group_T;");
            return sGroups.Split(m_sDelim, StringSplitOptions.RemoveEmptyEntries).ToArray();
        } // getGroups

        /// <summary>
        /// Returns AddressID referenced by AddressName
        /// </summary>
        /// <param name="AddressName"></param>
        /// <returns></returns>
        public string getAddressID(string AddressName)
        {return m_xFacade.QueryToString("SELECT AddressID FROM Address_T WHERE AddressName = \"" + AddressName + "\";");}

        /// <summary>
        /// Returns ObserverID referenced by FirstName LastName
        /// </summary>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <returns></returns>
        public string getObserverID(string FirstName, string LastName)
        {return m_xFacade.QueryToString("SELECT ObserverID FROM Observer_T WHERE FirstName = \"" + FirstName + "\" AND LastName = \"" + LastName + "\";");}

        /// <summary>
        /// Returns GroupID referenced by GroupName
        /// </summary>
        /// <param name="GroupName"></param>
        /// <returns></returns>
        public string getGroupID(string GroupName)
        {return m_xFacade.QueryToString("SELECT GroupID FROM Group_T WHERE GroupName = \"" + GroupName + "\";");}

        /// <summary>
        /// Returns LocationID referenced by LocationName
        /// </summary>
        /// <param name="LocationName"></param>
        /// <returns></returns>
        public string getLocationID(string LocationName)
        {return m_xFacade.QueryToString("SELECT LocationID FROM Location_T WHERE OfficialName = \"" + LocationName + "\";");}

        /// <summary>
        /// Returns AnimalID referenced by AnimalName
        /// </summary>
        /// <param name="AnimalName"></param>
        /// <returns></returns>
        public string getAnimalID(string AnimalName)
        {return m_xFacade.QueryToString("SELECT AnimalID FROM Animal_T WHERE CommonName = \"" + AnimalName + "\";");}

        /// <summary>
        /// Returns formatted MySql query for inserting a new observation based upon entered form attributes
        /// </summary>
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

        /// <summary>
        /// Executes insert command to insert new Location 
        /// </summary>
        /// <param name="AddressID"></param>
        /// <param name="OfficialName"></param>
        public void InsertLocation(string AddressID, string OfficialName)
        {
            string s = string.Format("INSERT INTO Location_T (AddressID, OfficialName) VALUE (\"{0}\", \"{1}\");",
                AddressID, OfficialName);
            m_xFacade.Command(s);
        } // InsertLocation

        /// <summary>
        /// Executes insert command to insert new Animal 
        /// </summary>
        /// <param name="CommonName"></param>
        /// <param name="Genus"></param>
        /// <param name="Species"></param>
        /// <param name="Characteristics"></param>
        public void InsertAnimal(string CommonName, string Genus, string Species, string Characteristics)
        {
            string s = string.Format("INSERT INTO Animal_T (CommonName, Genus, Species, Characteristics) VALUE (\"{0}\", \"{1}\", \"{2}\", \"{3}\");",
            CommonName, Genus, Species, Characteristics);
            m_xFacade.Command(s);
        } // InsertAnimal

        /// <summary>
        /// Executes insert command to insert new Group
        /// </summary>
        /// <param name="GroupName"></param>
        /// <param name="Active"></param>
        public void InsertGroup(string GroupName, string Active)
        {
            string s = string.Format("INSERT INTO Group_T (GroupName, Active) VALUE (\"{0}\", {1});",
             GroupName, Active);
            m_xFacade.Command(s);
        } // InsertGroup

        /// <summary>
        /// Executes insert command to insert new Observer
        /// </summary>
        /// <param name="AddressID"></param>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="Gender"></param>
        /// <param name="Credentials"></param>
        /// <param name="PhoneNumber_1"></param>
        /// <param name="PhoneNumber_2"></param>
        /// <param name="EmailAddress"></param>
        public void InsertObserver(string AddressID, string FirstName, string LastName, string Gender, string Credentials, string PhoneNumber_1,
            string PhoneNumber_2, string EmailAddress)
        {
            string s = string.Format("INSERT INTO Observer_T (AddressID, FirstName, LastName, Gender, Credentials, PhoneNumber_1, PhoneNumber_2, EmailAddress)" +
            "VALUE (\"{0}\", \"{1}\", \"{2}\", \"{3}\", \"{4}\", \"{5}\", \"{6}\", \"{7}\");", AddressID, FirstName, LastName, Gender, Credentials, PhoneNumber_1, PhoneNumber_2, EmailAddress);
            m_xFacade.Command(s);
        } // InsertAddress

        /// <summary>
        /// Executes insert command to insert new Address
        /// </summary>
        /// <param name="AddressName"></param>
        /// <param name="State"></param>
        /// <param name="StreetName"></param>
        /// <param name="BuildingNumber"></param>
        /// <param name="Zipcode"></param>
        public void InsertAddress(string AddressName, string State, string StreetName, string BuildingNumber, string Zipcode)
        {
            string s = string.Format("INSERT INTO Address_T (AddressName, State, StreetName, BuildingNumber, Zipcode) VALUE (\"{0}\", \"{1}\", \"{2}\", \"{3}\", \"{4}\");",
            AddressName, State, StreetName, BuildingNumber, Zipcode);
            m_xFacade.Command(s);
        } // InsertAddress

        /// <summary>
        /// Executes insert command to insert new ObserverList
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="ObserverID"></param>
        public void InsertObserverList(string GroupID, string ObserverID)
        {
            string s = string.Format("INSERT INTO ObserverList_T(GroupID, ObserverID) VALUE (\"{0}\", \"{1}\")",
                GroupID, ObserverID);
            m_xFacade.Command(s);
        } // InsertObserverList

    } // AddObservationHandler
} // namespace XFiles
