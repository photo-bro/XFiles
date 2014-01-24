using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data; // datatable
using FileHelpers;      // CSV import/export


namespace XFiles.Import_Export
{
    public class CSV : IImport<CSV> , IExport<CSV>
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

        FileHelperEngine m_fhe = new FileHelperEngine(typeof(ObservationRecord));

        public DataTable ImportAsDatatable(string path, string name)
        {
            string fullpath = path + "//" + name + ".csv";
            return m_fhe.ReadFileAsDT(fullpath);
        }

        public ObservationRecord[] ImportAsObservationRecord(string path, string name)
        {
            string fullpath = path + "//" + name + ".csv";
            return m_fhe.ReadFile(fullpath) as ObservationRecord[];
        }

        public string ImportAsString(string path, string name)
        {
            throw new NotImplementedException();
        }

        public void ExportFromObservationRecord(string path, string name, ObservationRecord[] records)
        {
            string fullpath = path + "//" + name + ".csv";
            m_fhe.WriteFile(fullpath, records);
        }

        public void ExportFromString(string path, string name, string records)
        {
            string fullpath = path + "//" + name + ".csv";
            m_fhe.WriteFile(fullpath, records.Split(Environment.NewLine.ToArray()));
        }

        public void ExportFromRaw(string path, string name, object[] raw)
        {
            throw new NotImplementedException();
        }

    }
}
