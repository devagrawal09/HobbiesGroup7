using HobbiesGroup7.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace HobbiesGroup7.Controllers
{
    public class TeamController : Controller
    {
        private readonly TeamContext _teamContext;

        public TeamController(TeamContext teamContext)
        {
            _teamContext = teamContext;
        }

        [HttpGet]
        [Route("Team/{memberId:int}")]
        public IActionResult Index(int memberId)
        {
            var member = _teamContext.Team.Find(memberId);
            return View(member);
        }

        public IActionResult Database()
        {
            var team = _teamContext.Team;
            return View(team);
        }
    }
}
