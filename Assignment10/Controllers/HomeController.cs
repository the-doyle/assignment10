using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment10.Models;
using Microsoft.EntityFrameworkCore;
using Assignment10.Models.ViewModels;

namespace Assignment10.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private BowlingLeagueContext context { get; set; }

        public HomeController(ILogger<HomeController> logger, BowlingLeagueContext ctx)
        {
            _logger = logger;
            context = ctx;
        }

        public IActionResult Index(long? team, string teamname, int pageNum = 0)
        {
            int pageSize = 5;

            if (String.IsNullOrEmpty(teamname))
            {
                ViewBag.Team = "All Players";
            }
            else
            {
                ViewBag.Team = teamname;
            }

            return View(new IndexViewModel

            {
                Bowlers = context.Bowlers
                    //.FromSqlInterpolated($"SELECT * FROM Bowlers WHERE TeamID == {team} OR {team} IS NULL")
                    .Where(m => m.TeamId == team || team == null)
                    .OrderBy(m => m.BowlerFirstName)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize)
                    .ToList(),

                PageNumberingInfo = new PageNumberingInfo
                {
                    NumItemsPerPage = pageSize,
                    CurrentPage = pageNum,

                    //if no team has been selected, then get the full count. otherwise, only count the
                    //number from the team that has been selected. 
                    TotalNumItems = (team == null ? context.Bowlers.Count() :
                        context.Bowlers.Where(x => x.TeamId == team).Count())
                },

                Team = teamname
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
