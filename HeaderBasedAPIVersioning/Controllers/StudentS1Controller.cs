using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeaderBasedAPIVersioning.Controllers
{
    [Route("api/student")]
    [ApiController]
    [ApiVersion("1.0")]
    public class StudentS1Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("This is Student s1");
        }
    }
}
