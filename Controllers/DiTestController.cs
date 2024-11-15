using Microsoft.AspNetCore.Mvc;
using TestDI.Core;

namespace TestDI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DiTestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([ModelBinder] IService service)
        {
            return Ok(service.GetData());
        }
    }
}