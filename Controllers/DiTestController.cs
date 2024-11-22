using Microsoft.AspNetCore.Mvc;
using TestDI.Core;
using TestDI.Notification;

namespace TestDI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DiTestController(NotificationService service) : ControllerBase
    {
        private readonly NotificationService service = service;

        [HttpGet("service/{serviceType}")]
        public IActionResult Get([ModelBinder] IService service)
        {
            return Ok(service.GetData());
        }

        [HttpGet("notify/{type}/{message}")]
        public IActionResult Get(string type, string message)
        {
            return Ok(service.SendNotification(type, message));
        }
    }
}