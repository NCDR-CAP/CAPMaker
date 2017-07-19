using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPMaker
{
    class CsvHelperExtension
    {
        public static DataTable ReadFromCSV(string path, bool hasTitle = false)
        {
            DataTable dt = new DataTable();

            using (TextReader reader = File.OpenText(path))
            {

                var csv = new CsvHelper.CsvReader(reader);

                csv.ReadHeader();

                var headers = csv.FieldHeaders;

                foreach (var header in headers)
                    dt.Columns.Add(header);

                while (csv.Read())
                {
                    var row = dt.NewRow();
                    foreach (DataColumn column in dt.Columns)
                    {
                        row[column.ColumnName] = csv.GetField(column.ColumnName);
                    }

                    dt.Rows.Add(row);
                }

            }

            return dt;
        }
    }
}
