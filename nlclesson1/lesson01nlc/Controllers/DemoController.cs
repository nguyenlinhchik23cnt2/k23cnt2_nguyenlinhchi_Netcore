﻿using Microsoft.AspNetCore.Mvc;

namespace lesson01nlc.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
