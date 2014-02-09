using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;           // datatable
using System.Windows.Forms;  // dgv

namespace XFiles.Misc
{
    class Conversion
    {
        /// <summary>
        /// Converts datagridview to datatable. Null is returned if dgv has nor
        /// rows or columns
        /// </summary>
        /// <param name="dgv"></param>
        /// <returns></returns>
        public static DataTable DGVToDatatable(DataGridView dgv)
        {
            // DGV to DataTable
            // Credit: 
            // http://stackoverflow.com/questions/6295161/how-to-build-a-datatable-from-a-datagridview
            if (dgv.ColumnCount == 0) return null;
            DataTable dtSource = new DataTable();
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                //if (IgnoreHideColumns & !col.Visible) continue;
                if (col.Name == string.Empty) continue;
                dtSource.Columns.Add(col.Name, col.ValueType);
                dtSource.Columns[col.Name].Caption = col.HeaderText;
            } // foreach column
            if (dtSource.Columns.Count == 0) return null;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow drNewRow = dtSource.NewRow();
                foreach (DataColumn col in dtSource.Columns)
                {
                    if (row.Cells[col.ColumnName].Value == null) continue;
                    drNewRow[col.ColumnName] = row.Cells[col.ColumnName].Value;
                } // foreach column
                dtSource.Rows.Add(drNewRow);
            } // foreach row

            return dtSource;
        }

        /// <summary>
        /// Saves the contents of a datatable as a formatted text file to path/name
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="path"></param>
        /// <param name="name"></param>
        public static string DataTableToString(DataTable dt)
        {
            if (dt == null) return null; // check if datatable null

            StringBuilder sb = new StringBuilder();

            // Credit:
            // Wooh! Double imbedded lambda expressions!
            // http://www.codeproject.com/Tips/261752/Convert-DataTable-to-String-by-Extension-Method
            // column heading first
            dt.Columns.Cast<DataColumn>().ToList().ForEach(col => sb.AppendFormat("{0}, ", col.ColumnName));
            // seperate heading from data
            sb.Append(Environment.NewLine + Environment.NewLine);
            // row data
            dt.Rows.Cast<DataRow>().ToList().ForEach(dataRow =>
            {
                // column values
                dt.Columns.Cast<DataColumn>().ToList().ForEach(column =>
                {
                    sb.AppendFormat("{0}, ", dataRow[column]);
                });
                sb.Append(Environment.NewLine);
            });
            return sb.ToString();
        } // DataTableToString


    }
}
