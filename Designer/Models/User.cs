using CsvHelper.Configuration.Attributes;

namespace Designer.Models
{
    public class User
    {
        [Index(0)]
        public string? Nom { get; set; }
        [Index(1)]
        public string? Prenom { get; set; }
        [Index(2)]
        public string? Email { get; set; }
    }
}
