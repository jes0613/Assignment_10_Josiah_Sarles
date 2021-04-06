using Assignment_10_Josiah_Sarles.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_10_Josiah_Sarles.Components
{
    public class TeamViewComponent : ViewComponent
    {
        private BowlingLeagueContext _context;
        public TeamViewComponent(BowlingLeagueContext con)
        {
            _context = con;
        }

        //Selects the teams to be displayed in the Team View Component
        public IViewComponentResult Invoke()
        {
   
            return View(_context.Teams
                .Distinct()
                .OrderBy(x => x)
                );
        }


    }
}
