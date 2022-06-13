using Microsoft.AspNetCore.Mvc;

namespace City_Bus_Management_Project.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult Signup()
        {
            return View();
        }
        public ViewResult Login()
        {
            return View();
            
        }
    }
}
