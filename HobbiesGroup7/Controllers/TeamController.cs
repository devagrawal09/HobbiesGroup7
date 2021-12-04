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
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        List<TeamMember> team = new List<TeamMember>();
        private readonly ILogger<TeamController> _logger;

        public TeamController(ILogger<TeamController> logger)
        {
            _logger = logger;
            con.ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=Team;Trusted_Connection=True;MultipleActiveResultSets=true";
        }
        private void FetchData (int? id)
        {
            if(team.Count > 0)
            {
                team.Clear();
            }
            
            try
            {
                con.Open();
                com.Connection = con;
                if (id != null)
                {
                    var idParamater = new SqlParameter("@id", id);
                    com.Parameters.Add(idParamater);
                    com.CommandText = "select * from Team where TeamMemberId = @id;";
                } else if (id == null)
                {
                    com.CommandText = "select * from Team";
                }
                
                dr = com.ExecuteReader();
                while(dr.Read())
                {
                    team.Add(new TeamMember()
                    {
                        TeamMemberId = (int)dr["TeamMemberId"],
                        Name = dr["Name"].ToString(),
                        Bio = dr["Bio"].ToString(),
                        HobbyTitle = dr["HobbyTitle"].ToString(),
                        HobbyDescription = dr["HobbyDescription"].ToString()
                    });
                }
                con.Close();
            } catch (Exception ex) {
                throw ex;
            }
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Ben()
        {
            FetchData(4);
            return View(team);
        }
        public IActionResult Database()
        {
            FetchData(null);
            return View(team);
        }
        public IActionResult Reid()
        {
            FetchData(2);
            return View(team);
        }
        public IActionResult Jacob()
        {
            FetchData(5);
            return View(team);
        }
        public IActionResult Dev()
        {
            FetchData(1);
            return View(team);
        }
        public IActionResult Blake()
        {
            FetchData(3);
            return View(team);
        }
    }
}
