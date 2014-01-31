using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data; // datatable
using FileHelpers;      // CSV import/export


namespace XFiles.Import_Export
{
    public class CSV : IImport<CSV>, IExport<CSV>
    {
        // ***********************************************
        //       S I N G L E T O N    S T U F F
        // ***********************************************
        // static instance
        private static CSV c_CSVInstance;
        // lock object
        private static object c_CSVLock = new object();
        // default constructor
        private CSV() { }
        /// <summary>
        /// Returns singelton instance of class
        /// </summary>
        public static CSV Instance
        {
            get
            {
                lock (c_CSVLock)
                {
                    if (c_CSVInstance == null) c_CSVInstance = new CSV();
                    return c_CSVInstance;
                } // lock
            } // get
        } // Instance

        // ***********************************************
        //                C    S    V
        // ***********************************************

        // ***********************************************
        // IMPORT

        Filer m_filer = new Filer();

        public DataTable ImportAsDatatable(string path, string name)
        {
            throw new NotImplementedException();
        }

        public ObservationRecord[] ImportAsObservationRecord(string path, string name)
        {
            string sFile = m_filer.FileToString(path + "//" + name);

            // list of observations to be filled
            List<ObservationRecord> lsObservations = new List<ObservationRecord>();
            // split file string by line and iterate through
            sFile.Split(Environment.NewLine.ToArray()).ToList().ForEach(line =>
            {
                // split each line into words and cast as object array
                // then create new ObservationRecord from each object array
                lsObservations.Add(new ObservationRecord(line));
            });

            return lsObservations.ToArray();
        }

        public string ImportAsString(string path, string name)
        {
            return m_filer.FileToString(path + "//" + name);
        }

        // ***********************************************
        // EXPORT

        public void ExportFromQuery(string path, string name, Query query)
        {
        
        
        }

        public void ExportFromObservationRecord(string path, string name, ObservationRecord[] records)
        {
            string sOut = "";

            // ObservationRecord.ToString should have each represented record separated by comma
            records.ToList().ForEach(record =>
            {
                sOut += record.ToString();
                sOut += Environment.NewLine;
            });
            // write file out
            m_filer.CreateFile(sOut, path, name + ".csv");
        }

        public void ExportFromString(string path, string name, string records)
        {
            string sOut = "";

            // get lines from string
            List<string> lsLines = new List<string>(records.Split(Environment.NewLine.ToArray()));
            // iterate through each line (entry)
            lsLines.ForEach(line =>
            {   // split into words and deliminate by ','
                line.Split(new char[] { ' ' }).ToList().ForEach(word =>
                {
                    sOut += word + ", "; // add each entry separated by comma
                });
                sOut += Environment.NewLine; // new line after each row
            });

            // write file out
            m_filer.CreateFile(sOut, path, name + ".csv");
        }

        public void ExportFromRaw(string path, string name, object[] raw)
        {
            throw new NotImplementedException();
        }

    }
}
