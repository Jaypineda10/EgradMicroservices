using Microsoft.AspNetCore.Mvc;

namespace Evaluation.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EvaluationController : ControllerBase
    {
        private static readonly List<string> _evaluations = new() { "Evaluación 1", "Evaluación 2" };

        [HttpGet]
        public IActionResult GetAll() => Ok(_evaluations);

        [HttpPost]
        public IActionResult Add([FromBody] string name)
        {
            _evaluations.Add(name);
            return Ok(new { message = "Evaluación agregada", total = _evaluations.Count });
        }
    }
}
