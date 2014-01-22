using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data; // datatable
using FileHelpers;      // CSV import/export


namespace XFiles.Import_Export
{
    public class CSV
    {
        // Singleton stuff....




        FileHelperEngine m_fhe = new FileHelperEngine(typeof(ObservationRecord));

        public DataTable CSVToDataTable(string path, string name)
        {
            string fullpath = path + "//" + name + ".csv";
            return m_fhe.ReadFileAsDT(fullpath);
        }

        public ObservationRecord[] CSVToObservations(string path, string name)
        {
            string fullpath = path + "//" + name + ".csv";
            return m_fhe.ReadFile(fullpath) as ObservationRecord[];
        }

        public void ObservationsToCSV(ObservationRecord[] records, string path, string name)
        {
            string fullpath = path + "//" + name + ".csv";
            m_fhe.WriteFile(fullpath, records);
        }


    }
}
