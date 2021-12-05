using HobbiesGroup7.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;

namespace HobbiesGroup7.Controllers
{
    public class HomeController : Controller
    {
        private readonly TeamContext _teamContext;

        public HomeController(TeamContext teamContext)
        {
            _teamContext = teamContext;
        }

        public IActionResult Index()
        {
            IEnumerable<TeamMember> team = _teamContext.Team;
            return View(team);
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
