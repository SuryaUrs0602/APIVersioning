using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeaderBasedAPIVersioning.Controllers
{
    [Route("api/student")]
    [ApiController]
    [ApiVersion("2.0")]
    public class StudentS2Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("THis is student s2");
        }
    }
}
