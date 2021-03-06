﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms; // dgv

namespace XFiles.Import_Export
{
    interface IImport<T>
    {
        DataTable ImportAsDatatable(string path, string name);
        string ImportAsString(string path, string name);
        ObservationRecord[] ImportAsObservationRecord(string path, string name);
    }

    interface IExport<T>
    {
        void ExportFromQuery(string path, string name, Query query);
        void ExportFromObservationRecord(string path, string name, ObservationRecord[] records);
        void ExportFromString(string path, string name, string records);
        void ExportFromRaw(string path, string name, object[] raw);
        void ExportFromDGV(string path, string name, DataGridView dgv);
    }
}
