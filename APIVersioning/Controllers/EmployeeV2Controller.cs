using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIVersioning.Controllers
{
    [Route("api/employee")]
    [ApiController]
    [ApiVersion("2.0")]
    public class EmployeeV2Controller : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok("This is EMployee V2 Controller");
        }



        //https://localhost:7160/api/employee?api-version=1.0
    }
}
