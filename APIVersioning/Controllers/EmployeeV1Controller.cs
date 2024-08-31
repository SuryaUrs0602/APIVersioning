using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIVersioning.Controllers
{
    [Route("api/employee")]
    [ApiController]
    [ApiVersion("1.0", Deprecated = true)]
    public class EmployeeV1Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("This is Employee V1 controller");
        }

        //https://localhost:7160/api/employee?api-version=1.0
    }
}
