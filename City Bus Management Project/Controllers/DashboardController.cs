using Microsoft.AspNetCore.Mvc;
using City_Bus_Management_Project.Models;

namespace City_Bus_Management_Project.Controllers
{
    public class DashboardController : Controller
    {
        private DatabaseContext _context;
        public DashboardController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ViewResult Dashboard()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Add ad)
        {
            if(ModelState.IsValid)
            {
                var a = new Add()
                {
                    VName = ad.VName,
                    Vno = ad.Vno,
                    Did = ad.Did,
                    Rno = ad.Rno

                };
                _context.Adds.Add(ad); //insert
                _context.SaveChanges();
                TempData["msg"] = "Data inserted sucessfully";
                return RedirectToAction("Dashboard");

            }
            else
            {
                TempData["error"] = "Insertion failed!";
                return View();
            }
        }

    }
}
