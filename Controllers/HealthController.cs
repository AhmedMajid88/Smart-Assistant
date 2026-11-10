using Microsoft.AspNetCore.Mvc;

namespace Smart_Assistant.Controllers
{
    public class HealthController : Controller
    {
        [HttpGet]
        public IActionResult Health()
        {
            return View();
        }
    }
}