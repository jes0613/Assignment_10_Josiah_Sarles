using Assignment_10_Josiah_Sarles.Models;
using Assignment_10_Josiah_Sarles.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_10_Josiah_Sarles.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BowlingLeagueContext _context;

        public HomeController(ILogger<HomeController> logger, BowlingLeagueContext con)
        {
            _logger = logger;
            _context = con;
        }

        public IActionResult Index(long? teamId)
        {
            return View(_context.Bowlers
                    .FromSqlInterpolated($"SELECT * FROM Bowlers Where TeamId = {teamId} OR {teamId} IS NULL")
                    .ToList());
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
