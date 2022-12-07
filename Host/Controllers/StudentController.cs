using DataContract;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace Host.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
      
        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "getStudents")]
        public IEnumerable<Student> Get()
        {
            var c = new CsvServices();
            return c.getCSVData();
        }
    }
}