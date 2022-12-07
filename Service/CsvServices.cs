using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.Common;
using DataContract;

namespace Service
{
    public class CsvServices
    {
        public List<Student> getCSVData()
        {
            List<String> rows = new List<String>();
            List<String> cols = new List<String>();

            List<Student> data = new List<Student>();
            string path = "C:/Users/20210792/Source/Repos/ETL-DOTNET/Service/data.csv";
            string[] lines = System.IO.File.ReadAllLines(path);
            foreach (string line in lines)
            {
                rows.Add(line);
                string[] columns = line.Split('\n');
                foreach (string column in columns)
                {
                    cols.Add(column);
                    string[] info = column.Split(";");
                    if (info[0] == "id")
                    {
                        //first row
                    }
                    else
                    {
                        data.Add(new Student() { id = int.Parse(info[0]), name = info[1].ToString(), mail = info[2].ToString() });
                    }

                }
            }
            return data;
        }
    }
}