﻿using City_Bus_Management_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace City_Bus_Management_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult BookTicket()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult BusDetails()
        {
            return View();
        }

        public IActionResult RouteDetails()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}