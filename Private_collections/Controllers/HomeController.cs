using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Private_collections.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Private_collections.Controllers
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
            ThemeCollections theme;
            List<ThemeCollections> collections = new List<ThemeCollections>();
            for(int i = 0; i <= 6; i++)
            {
                theme = new ThemeCollections() { Id=i, Description="My collection "+i, Name= "Theme # " + i };
                collections.Add(theme);
            }
            return View(collections);
        }

        public IActionResult Privacy()
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
