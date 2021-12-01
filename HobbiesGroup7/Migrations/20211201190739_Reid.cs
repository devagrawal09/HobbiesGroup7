using Microsoft.EntityFrameworkCore.Migrations;

namespace HobbiesGroup7.Migrations
{
    public partial class Reid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamMemberId", "Bio", "HobbyDescription", "HobbyTitle", "Name" },
                values: new object[] { 2, "I am a third year student studying IT with a specialization in Software Development", "I like playing competitive shooters such as Halo, Overwatch, and Valorant.", "Video Games", "Reid Sweeney" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamMemberId",
                keyValue: 2);
        }
    }
}
