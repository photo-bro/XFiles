using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace XFiles.Import_Export
{
    public struct Location
    {
        Address address;
        string officialname;
    }

    public struct Animal
    {
        string commonname, genus, species, gender, characteristics;
    }

    public struct Address
    {
        string name, state, street;
        int buildingNo, zipcode;
    }

    public struct Group
    {
        string name;
        bool active;
        Observer[] observers;
    }

    public struct Observer
    {
        string firstname, lastname, gender, credentials, phone1, phone2, email;
        Address address;
    }

    public struct Observation
    {
        Location location;
        Animal animal;
        Group group;
        string locality, weather, color, characteristics, comment;
        double latitude, longitude, airtemp;
        int number;
    }


	/* Format: (AKA fully denormalized view of database)
         * 
         * NULL denoted by unicode # 0xD7 (multiplication "x")
         * 
         * Observation ID (if exists break)
         * Location ID (If exists skip to Animal ID)
         *  - Address ID (If exists skip to Official Name)
         *    - Name
         *    - State
         *    - Street
         *    - Building No.
         *    - Zip
         *  - Official Name
         * Animal ID (if exists skip to GroupID)
         *  - CommonName
         *  - Genus
         *  - Species
         *  - Gender
         *  - Characteristics
         * Group ID (if exists skip)
         *  - Group Name
         *  - Active
         *  - Observer ID's (if exists skip), loop until @ is found ('@' in email denotes last obID)
         *    - First
         *    - Last
         *    - Address ID (if exists skip)
         *      - Name
         *      - State
         *      - Street
         *      - Building No.
         *      - Zip 
         *    - Gender
         *    - Credentials
         *    - Phone 1
         *    - Phone 2
         *    - Email
         * Locality
         * Lat
         * Long
         * DateAndTime
         * Weather
         * Air Temp
         * Number
         * Color
         * Characteristics 
         * Comment
         * */

    public enum ImportTokenType
    {
        ITT_STRING,
        ITT_INT,
        ITT_FLOAT
    };

    public class ImportToken
    {
        public ImportTokenType Type;
        // hold value, type determines which cast
        public object Value;        

        public ImportToken(ImportTokenType type, object value) {
            Type = type;
            Value = value;
        }
    }

    public class ImportLexer
    {
        List<string> m_lsFile;
        List<ImportToken> m_lsTokens;

        // constructor
        public ImportLexer(string file)
        {
            m_lsFile = new List<string>(file.Split(new char[] { ',', '\n' }));
            m_lsTokens = new List<ImportToken>();
        }

        public List<ImportToken> Lex()
        {
            float fTemp;
            int iTemp;
            // loop through each item in file
            foreach (string s in m_lsFile)
            {
                // Float
                if (float.TryParse(s, out fTemp))
                    m_lsTokens.Add(new ImportToken(ImportTokenType.ITT_FLOAT, fTemp));

                // Int
                if (int.TryParse(s, out iTemp))
                    m_lsTokens.Add(new ImportToken(ImportTokenType.ITT_INT, iTemp));

                // Else must be string
                m_lsTokens.Add(new ImportToken(ImportTokenType.ITT_STRING, s));
            }

            return m_lsTokens;
        }
    }


    /// <summary>
    /// Class containging the attributes for the fields of a proper
    /// XFiles file format
    /// 
    /// 
    /// </summary>
    public class ObservationRecord
    {
        // Class values
        private List<ImportToken> m_lsTokens;

        // Observation values
        private int m_iObservationID;
        private Location m_Location;
        private Animal m_Animal;
        private Group m_Group;
        private string m_sLocality
            , m_sColor
            , m_sCharacteristics
            , m_sComment;
        private DateTime m_DateAndTime;
        private double m_fLatitude
            , m_fLongitude
            , m_fAirTemp;
        private int m_iNumber;

        // Constructors
        public ObservationRecord() { /* TODO */ }

        public ObservationRecord(DataTable records) { /* TODO */ }

        public ObservationRecord(Query query) { /* TODO */}

		public ObservationRecord(string record){


            ImportLexer il = new ImportLexer(record);
            m_lsTokens = il.Lex();

            Parse();


        
        
        }

        private void Parse()
        {
            int iPos = 0;
            ImportToken itCur = m_lsTokens[iPos];

            // Observation ID
            

            // check if null



        }

        private void parLocation() {
            int AddressID;
            string OfficialName;


        
        }

        private void parAnimal() { }

        private void parGroup() { }

        private void parObserver() { }

        private void parAddress() { }




        public override string ToString()
        {
            return base.ToString();
        }

    }


}
