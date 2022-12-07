using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.Common;

namespace Service
{
    public class CsvServices
    {
        public List<String> getCSVData()
        {
            List<String> rows = new List<String>();
            List<String> cols = new List<String>();
            List<List<String>> data= new List<List<String>>();

            string path = "C:\\Users\\Garul\\Documents\\code\\projet_collin\\notre_projet\\Service\\data.csv";
            string[] lines = System.IO.File.ReadAllLines(path);
            foreach (string line in lines)
            {
                rows.Add(line);
                string[] columns = line.Split(',');
                foreach (string column in columns)
                {
                    cols.Add(column);
                }
            }

            data.Add(rows);
            data.Add(cols);
            return cols;
        }
    }
}
