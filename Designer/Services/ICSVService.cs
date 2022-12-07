using Designer.Models;

namespace Designer.Services
{
    public interface ICSVService
    {
        public IEnumerable<T> ReadCSV<T>(Stream file);
        void WriteCSV<T>(List<User> records);

    }
}
