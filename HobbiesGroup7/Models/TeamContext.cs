using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HobbiesGroup7.Models
{
    public class TeamContext : DbContext
    {
        public TeamContext(DbContextOptions options): base(options) { }

        public DbSet<TeamMember> Team { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TeamMember>().HasData(new TeamMember
            {
                TeamMemberId = 1,
                Name = "Dev Agrawal",
                Bio = "I am a 4th year IT student and an aspiring software developer/architect.",
                HobbyTitle = "Music",
                HobbyDescription = "I like playing rock and metal music on guitar, keyboard and drums."
            });
        }
    }
}
