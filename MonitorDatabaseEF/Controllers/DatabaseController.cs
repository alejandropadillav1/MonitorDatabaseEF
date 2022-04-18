using Microsoft.AspNetCore.Mvc;
using MonitorDatabaseEF.Infrastructure;

namespace MonitorDatabaseEF.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class DatabaseController : Controller
    {
        private readonly DatabaseDataContext _context;
        public DatabaseController(DatabaseDataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var estudiantes = _context.Estudiantes;
            return Ok(estudiantes);
        }
        [HttpPut]
        public IActionResult PosteoMensaje()
        {
            return Ok();
        }
    }
}
