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
        public int PageSize = 5;

        public HomeController(ILogger<HomeController> logger, BowlingLeagueContext con)
        {
            _logger = logger;
            _context = con;
        }

        public IActionResult Index(long? teamId, int pageNum = 1)
        {
            ViewBag.SelectedTeam = teamId;
            return View(new BowlingListViewModel
            {

                bowlers = _context.Bowlers
                    .Where(b => b.TeamId == teamId || teamId == null)
                    .OrderBy(b => b.BowlerId)
                    .Skip((pageNum - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = PageSize,
                    TotalNumItems = teamId == null ? _context.Bowlers.Count() :
                        _context.Bowlers.Where(x => x.TeamId == teamId).Count()
                },
                CurrentTeam = _context.Teams
                    .FromSqlInterpolated($"SELECT * FROM Teams Where TeamId = {teamId}")
            });
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
