using Microsoft.EntityFrameworkCore.Migrations;

namespace HobbiesGroup7.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamMemberId",
                keyValue: 5,
                columns: new[] { "Bio", "HobbyDescription", "HobbyTitle" },
                values: new object[] { "I am a third year student on the software development track. I am a software developer, ride operator, and gamer.", "I have been gaming for a long time. I started playing Halo CE about 12 years ago and have been gaming since.", "Video games and rollercoasters" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamMemberId",
                keyValue: 5,
                columns: new[] { "Bio", "HobbyDescription", "HobbyTitle" },
                values: new object[] { "Need to fill out!", "Need to fill out!", "Need to fill out!" });
        }
    }
}
