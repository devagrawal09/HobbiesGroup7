// <auto-generated />
using HobbiesGroup7.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HobbiesGroup7.Migrations
{
    [DbContext(typeof(TeamContext))]
    [Migration("20211205163353_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("HobbiesGroup7.Models.TeamMember", b =>
                {
                    b.Property<int>("TeamMemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HobbyDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HobbyTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamMemberId");

                    b.ToTable("Team");

                    b.HasData(
                        new
                        {
                            TeamMemberId = 1,
                            Avatar = "/images/homeProPic1.jpg",
                            Bio = "I am a 4th year IT student and an aspiring software developer/architect.",
                            HobbyDescription = "I like playing rock and metal music on guitar, keyboard and drums.",
                            HobbyTitle = "Music",
                            Name = "Dev Agrawal"
                        },
                        new
                        {
                            TeamMemberId = 2,
                            Avatar = "/images/homeProPic2.jpg",
                            Bio = "I am a third year student studying IT with a specialization in Software Development",
                            HobbyDescription = "I like playing competitive shooters such as Halo, Overwatch, and Valorant.",
                            HobbyTitle = "Video Games",
                            Name = "Reid Sweeney"
                        },
                        new
                        {
                            TeamMemberId = 3,
                            Avatar = "/images/homeProPic3.jpg",
                            Bio = "I am a fourth year student on the software track, aspiring to be an app contractor or UI/UX Specialist",
                            HobbyDescription = "My favorite video game is Apex Legends. I watch European soccer whenever it is on and I am huge fan of Arsenal. I do not think I have missed a game in 6 years lol.",
                            HobbyTitle = "Video Games and sports",
                            Name = "Blake Warner"
                        },
                        new
                        {
                            TeamMemberId = 4,
                            Avatar = "/images/homeProPic4.jpg",
                            Bio = "I am a 4th year IT student studying Software Development.",
                            HobbyDescription = "I love playing, writing, and listening to music. I play a lot of instruments and love sharing my passion with others. ",
                            HobbyTitle = "Music",
                            Name = "Ben Romig"
                        },
                        new
                        {
                            TeamMemberId = 5,
                            Avatar = "/images/blakesProPic.jpg",
                            Bio = "I am a third year student on the software development track. I am a software developer, ride operator, and gamer.",
                            HobbyDescription = "I have been gaming for a long time. I started playing Halo CE about 12 years ago and have been gaming since.",
                            HobbyTitle = "Video games and rollercoasters",
                            Name = "Jacob Gormly"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
