using Microsoft.AspNetCore.Mvc;

namespace api_versioning_Demo.Controllers
{
    [Route("api/employee")]
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/{v:apiVersion}/employee")]
    public class EmployeeV1Controller : Controller
    {

        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult("employees from v1 controller");
        }

    }
}
