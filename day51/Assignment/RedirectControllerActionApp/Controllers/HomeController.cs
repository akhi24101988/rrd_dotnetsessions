﻿using Microsoft.AspNetCore.Mvc;

namespace RedirectControllerActionApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Login", "Account");
        }
    }
}
