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

		Filer m_filer = new Filer ();

        public DataTable ImportAsDatatable(string path, string name)
        {
			throw new NotImplementedException ();
        }

        public ObservationRecord[] ImportAsObservationRecord(string path, string name)
        {
			string sFile = m_filer.FileToString (path + "//" + name);

			// list of observations to be filled
			List<ObservationRecord> lsObservations = new List<ObservationRecord> ();
			// splt file string by line and iterate through
			sFile.Split (Environment.NewLine.ToArray ()).ToList ().ForEach (line => {
				// split each line into words and cast as object array
				// then create new ObservationRecord from each object array
				lsObservations.Add(new ObservationRecord(line.Split(new char[]{' ', ','}) as object[]));
			});

			return lsObservations.ToArray ();
        }

        public string ImportAsString(string path, string name)
        {
			return m_filer.FileToString (path + "//" + name);
        }

        public void ExportFromObservationRecord(string path, string name, ObservationRecord[] records)
        {
			string sOut;

			// ObservationRecord.ToString should have each represented record separated by comma
			records.ToList ().ForEach (record => {
				sOut+= record.ToString();
				sOut += Environment.NewLine;
			});
			// write file out
			m_filer.CreateFile (sOut, path, name + ".csv");
		 }

        public void ExportFromString (string path, string name, string records)
		{
			string sOut;
			List<string> lsLines = new List<string> (records.Split (Environment.NewLine.ToArray ()));

			lsLines.ForEach (line => { 
				line.Split (new char[]{ ' ' }).ToList ().ForEach (word => {
					sOut += word + ", "; // add each entry separated by comma
				});
				sOut += Environment.NewLine; // new line after each row
			});

			// write file out
			m_filer.CreateFile (sOut, path, name + ".csv");
		}

        public void ExportFromRaw(string path, string name, object[] raw)
        {
            throw new NotImplementedException();
        }

    }
}
