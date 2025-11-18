using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CatalogController : ControllerBase
    {
        private static readonly List<string> _projects = new() { "Proyecto A", "Proyecto B" };

        [HttpGet]
        public IActionResult GetAll() => Ok(_projects);

        [HttpPost]
        public IActionResult Add([FromBody] string name)
        {
            _projects.Add(name);
            return Ok(new { message = "Proyecto agregado", total = _projects.Count });
        }
    }
}
