using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TermProjectV1.Models;

namespace TermProjectV1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private RecommendContext context { get; set; }

        public HomeController(ILogger<HomeController> logger, RecommendContext ctx)
        {
            _logger = logger;
            context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Recommend()
        {
            var recommends = context.Recommends.Include(a => a.Allergy).OrderBy(r => r.Name).ToList();
            return View(recommends);
        }

        public IActionResult Allergy()
        {
            var allergies = context.Allergies.OrderBy(r => r.AllergyId).ToList();
            return View(allergies);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
