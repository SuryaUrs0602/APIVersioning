using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace URLBasedAPIVersioning.Controllers
{
    [Route("api/{v:apiVersion}/student")]
    [ApiController]
    [ApiVersion("1.0")]
    public class Students1Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("This is student1 Controller");
        }
    }
}
