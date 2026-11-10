using Microsoft.AspNetCore.Mvc;
using Smart_Assistant.Models;
using System.Diagnostics;


namespace Smart_Assistant.Controllers
{
    public class HomeController : Controller
    {
        // إعادة التوجيه إلى صفحة تسجيل الدخول عند فتح الموقع لأول مرة
        public IActionResult Index()
        {
            return RedirectToAction("Login", "Account");
        }



        // عرض واجهة لوحة التحكم الرئيسية (Dashboard)
        public IActionResult Dashboard()
        {
            return View();
        }


        public IActionResult Memory()
        {
            return View();
        }

        public IActionResult Health()
        {
            return View();
        }

        public IActionResult Entertainment()
        {
            return View("~/Views/Home/Entertainment.cshtml");
        }

        public IActionResult PersonalRecords()
        {
            return View("~/Views/Home/PersonalRecords.cshtml");
        }

        public IActionResult CustomSection(string id, string title)
        {
            ViewBag.SectionId = id;
            ViewBag.SectionTitle = title;
            return View("~/Views/Home/CustomSection.cshtml");
        }
    }
}




