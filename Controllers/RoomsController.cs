﻿using Microsoft.AspNetCore.Mvc;

namespace HotelManagementSystem.Controllers
{
    public class RoomsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
