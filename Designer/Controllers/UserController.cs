using Designer.Services;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Designer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly ICSVService _csvService;

        public UserController(ICSVService csvService)
        {
            _csvService = csvService;
        }

        [HttpPost("read-users-csv")]
        public async Task<IActionResult> GetEmployeeCSV([FromForm] IFormFileCollection file)
        {
            var users = _csvService.ReadCSV<Models.User>(file[0].OpenReadStream());

            return Ok(users);
        }

        [HttpPost("write-user-csv")]
        public async Task<IActionResult> WriteEmployeeCSV([FromBody] List<Models.User> users)
        {
            _csvService.WriteCSV<Models.User>(users);

            return Ok();
        }

    }
}
