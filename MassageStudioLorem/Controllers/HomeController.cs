﻿namespace MassageStudioLorem.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult Privacy() => this.View();

        public IActionResult Error() => this.View();
    }
}