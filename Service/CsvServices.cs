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

            List<Student> data = new List<Student>();
            string path = "C:\\Users\\Garul\\Documents\\code\\projet_collin\\notre_projet\\Service\\data.csv";
            string[] lines = System.IO.File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] columns = line.Split('\n');
                foreach (string column in columns)
                {

                    string[] info = column.Split(";");
                    String i = column;
                    if (info[0] == "id")
                    {

                    }
                    else
                    {
                        data.Add(new Student() { id = int.Parse(info[0]), name = info[1], mail = info[2] });
                    }

                }
            }
            return data;
        }
    }
}
