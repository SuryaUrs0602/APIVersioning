using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace URLBasedAPIVersioning.Controllers
{
    [Route("api/{v:apiVersion}/student")]
    [ApiController]
    [ApiVersion("2.0")]
    public class Students2Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("This is student2 controller");
        }
    }
}
