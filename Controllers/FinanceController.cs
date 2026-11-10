using Microsoft.AspNetCore.Mvc;

namespace Smart_Assistant.Controllers
{
    public class FinanceController : Controller
    {
        // هذه الدالة تستجيب للرابط /Finance أو /Finance/Index
        public IActionResult Index()
        {
            return View();
        }
    }
}