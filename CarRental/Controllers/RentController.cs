﻿using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class RentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
