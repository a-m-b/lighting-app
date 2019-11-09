using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LightingApp.Models;
using LightingApp.Services;

namespace LightingApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILightingService lightingService;

        public HomeController(ILightingService lightingService)
        {
            this.lightingService = lightingService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(LightingViewModel lighting)
        {
            if (ModelState.IsValid)
            {
                lightingService.AddRecord(lighting);
                return Redirect("/Home/Complete");
            }

            return View(lighting);
        }

        public IActionResult Complete()
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
