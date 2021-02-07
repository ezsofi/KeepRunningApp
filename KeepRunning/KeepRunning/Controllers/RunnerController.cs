using Microsoft.AspNetCore.Mvc;

namespace KeepRunning.Controllers
{
    [Route("")]
    public class RunnerController : Controller
    {
        [HttpGet("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
