using CsvHelper;
using CsvHelper.Configuration;
using Designer.Models;
using System.Globalization;
using System.Text;

namespace Designer.Services
{
    public class CSVService : ICSVService
    {
        public IEnumerable<T> ReadCSV<T>(Stream file)
        {
            var reader = new StreamReader(file);

            //csv.Configuration.Delimiter = ";";
            //csv.Configuration.HasExcelSeparator = true;
            var config = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                Delimiter = ";",
                Encoding = Encoding.UTF8
            };
            var csv = new CsvReader(reader, config);

            var records = csv.GetRecords<T>();
            return records;
        }
        public void WriteCSV<T>(List<User> records)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";",
                Encoding = Encoding.UTF8
            };

            using (var writer = new StreamWriter("C:\\Users\\Etudiant\\Documents\\user.csv"))
            using (var csv = new CsvWriter(writer, config))
            {
                csv.WriteField("ID");
                csv.WriteField("NomPrenom");
                csv.WriteField("Email");
                csv.NextRecord();
                var id = 1;
                foreach (User record in records)
                {
                    csv.WriteField(id++);
                    csv.WriteField(record.Nom + " " + record.Prenom);
                    csv.WriteField(record.Email);
                    csv.NextRecord();
                }
            }
        }
    }
}
