using Microsoft.AspNetCore.Mvc;

namespace api_versioning_Demo.Controllers
{
    [Route("api/employee")]
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/{v:apiVersion}/employee")]
    public class EmployeeV2Controller : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult("employees from v2 controller");
        }
    }
}
