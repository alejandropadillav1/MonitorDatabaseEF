using Microsoft.AspNetCore.Mvc;

namespace MonitorDatabaseEF.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class DatabaseController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult PosteoMensaje()
        {
            return Ok();
        }
    }
}
