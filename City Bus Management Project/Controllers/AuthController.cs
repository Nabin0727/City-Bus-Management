using Microsoft.AspNetCore.Mvc;
using City_Bus_Management_Project.Models;

namespace City_Bus_Management_Project.Controllers
{
    public class AuthController : Controller
    {
        private DatabaseContext _context;

        public AuthController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Signup()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Signup(Signup su)
        {
            if (ModelState.IsValid)
            {
                var s = new Signup()
                {
                    driverId = su.driverId,
                    Name = su.Name,
                    Email = su.Email,
                    Bno = su.Bno,
                    Password = su.Password

                };
                _context.Signups.Add(su); //insert
                _context.SaveChanges();
                TempData["msg"] = "Signup Sucessfull Login to Continue!";
                return View();

            }

            else
            {
                TempData["error"] = "Field are empty";
                return View();
            }
        }

    }
}