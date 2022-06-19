using Microsoft.AspNetCore.Mvc;

namespace City_Bus_Management_Project.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult Dashboard()
        {
            return View();
        }

        public ViewResult Add()
        {
            return View();
        }

    }
}
