using Microsoft.EntityFrameworkCore;

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
            builder.Entity<TeamMember>().HasData(new TeamMember
            {
                TeamMemberId = 2,
                Name = "Reid Sweeney",
                Bio = "I am a third year student studying IT with a specialization in Software Development",
                HobbyTitle = "Video Games",
                HobbyDescription = "I like playing competitive shooters such as Halo, Overwatch, and Valorant."
            });
            builder.Entity<TeamMember>().HasData(new TeamMember
            {
                TeamMemberId = 3,
                Name = "Blake Warner",
                Bio = "I am a fourth year student on the software track, aspiring to be an app contractor or UI/UX Specialist",
                HobbyTitle = "Video Games and sports",
                HobbyDescription = "My favorite video game is Apex Legends. I watch European soccer whenever it is on and I am huge fan of Arsenal. I do not think I have missed a game in 6 years lol."
            });
            builder.Entity<TeamMember>().HasData(new TeamMember
            {
                TeamMemberId = 4,
                Name = "Ben Romig",
                Bio = "I am a 4th year IT student studying Software Development.",
                HobbyTitle = "Music",
                HobbyDescription = "I love playing, writing, and listening to music. I play a lot of instruments and love sharing my passion with others. "
            });
            builder.Entity<TeamMember>().HasData(new TeamMember
            {
                TeamMemberId = 5,
                Name = "Jacob Gormly",
                Bio = "Need to fill out!",
                HobbyTitle = "Need to fill out!",
                HobbyDescription = "Need to fill out!"
            });
        }
    }
}
