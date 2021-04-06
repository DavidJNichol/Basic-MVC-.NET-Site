using AzureSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AzureSite.Controllers
{
    public class PlantsController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        IPlant oak;

        public PlantsController(ILogger<HomeController> logger)
        {
            _logger = logger;
            oak = new Oak();
        }

        public IActionResult Create()
        {
            return View(oak);
        }

        public string About()
        {
            return oak.About();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
