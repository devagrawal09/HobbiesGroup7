using Microsoft.EntityFrameworkCore.Migrations;

namespace HobbiesGroup7.Migrations
{
    public partial class Blake : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamMemberId", "Bio", "HobbyDescription", "HobbyTitle", "Name" },
                values: new object[] { 3, "I am a fourth year student on the software track, aspiring to be an app contractor or UI/UX Specialist", "My favorite video game is Apex Legends. I watch European soccer whenever it is on and I am huge fan of Arsenal. I do not think I have missed a game in 6 years lol.", "Video Games and sports", "Blake Warner" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamMemberId", "Bio", "HobbyDescription", "HobbyTitle", "Name" },
                values: new object[] { 4, "Need to fill out!", "Need to fill out!", "Need to fill out!", "Ben Romig" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamMemberId", "Bio", "HobbyDescription", "HobbyTitle", "Name" },
                values: new object[] { 5, "Need to fill out!", "Need to fill out!", "Need to fill out!", "Jacob Gormly" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamMemberId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamMemberId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamMemberId",
                keyValue: 5);
        }
    }
}
