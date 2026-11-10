using Microsoft.AspNetCore.Mvc;

namespace Smart_Assistant.Controllers
{
    public class AccountController : Controller
    {
        // عرض واجهة تسجيل الدخول
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        // واجهة إنشاء حساب جديد (مستقلة تماماً)
        public IActionResult Register()
        {
            return View();
        }

        // واجهة استعادة كلمة المرور (نسيت كلمة المرور)
        public IActionResult ForgotPassword()
        {
            return View();
        }



        // استقبال بيانات تسجيل الدخول وتوجيه المستخدم للداشبورد
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            // تحقق مؤقت (يمكنك إدخال أي إيميل وباسورد أو اترك التحقق مفتوحاً مؤقتاً للتجربة)
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                // الانتقال إلى لوحة التحكم بنجاح
                return RedirectToAction("Dashboard", "Home");
            }

            // في حال كانت الحقول فارغة
            ViewBag.Error = "يرجى إدخال البريد الإلكتروني وكلمة المرور!";
            return View();
        }
    }
}