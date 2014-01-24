using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using FileHelpers;


namespace XFiles.Import_Export
{

    /// <summary>
    /// Class containging the attributes for the fields of a proper
    /// XFiles file format
    /// 
    /// 
    /// </summary>
    [DelimitedRecord(",")]
    public class ObservationRecord
    {
        public ObservationRecord() { }

        public ObservationRecord(DataTable records) { }

        public override string ToString()
        {
            return base.ToString();
        }


        /* Format:
         * Null denoted by unicode #0xD7 (multiplication "x")
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

    }


}
