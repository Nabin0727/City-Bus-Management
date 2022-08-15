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

        public IActionResult Display()
        {
            var Signups = _context.Signups.ToList(); //select data from the database
            return View(Signups);
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
                return RedirectToAction("Login");

            }

            else
            {
                TempData["error"] = "Field are empty";
                return View();
            }
        }

        public IActionResult Remove(int id)
        {
            var su = _context.Signups.SingleOrDefault(s => s.Id == id); //select * from database ehre id = id
            _context.Signups.Remove(su);
            _context.SaveChanges();
            TempData["msg"] = "Sucesfuly Deleted!";
            return RedirectToAction("Display");


        }

        public IActionResult Edit(int id)
        {
            var su = _context.Signups.SingleOrDefault(s => s.Id == id);
            return View(su);
        }

        [HttpPost]
        public IActionResult Edit(Signup s)
        {
            if(ModelState.IsValid)
            {
                _context.Signups.Update(s);
                _context.SaveChanges();
                TempData["msg"] = "Sucessfully updated!!";
                return RedirectToAction("Display");
 
            }
            else
            {
                TempData["error"] = "Some error occured!!";
                return View();
            }
        }
    }

    

}