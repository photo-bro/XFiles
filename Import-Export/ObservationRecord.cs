using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace XFiles.Import_Export
{

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
         *  - Observer ID's (if exists skip), loop until @ is found (denotes last obID)
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

    /// <summary>
    /// Class containging the attributes for the fields of a proper
    /// XFiles file format
    /// 
    /// 
    /// </summary>
    public class ObservationRecord
    {
        public ObservationRecord() { /* TODO */ }

        public ObservationRecord(DataTable records) { /* TODO */ }

        public ObservationRecord(Query query) { /* TODO */}

		public ObservationRecord(object[] records){ /* TODO */ }

        public override string ToString()
        {
            return base.ToString();
        }

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

    }


}
