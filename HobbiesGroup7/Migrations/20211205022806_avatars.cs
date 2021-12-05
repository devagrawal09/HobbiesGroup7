using Microsoft.EntityFrameworkCore.Migrations;

namespace HobbiesGroup7.Migrations
{
    public partial class avatars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "Team",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamMemberId",
                keyValue: 1,
                column: "Avatar",
                value: "~/images/homeProPic1.jpg");

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamMemberId",
                keyValue: 2,
                column: "Avatar",
                value: "~/images/homeProPic2.jpg");

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamMemberId",
                keyValue: 3,
                column: "Avatar",
                value: "~/images/homeProPic3.jpg");

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamMemberId",
                keyValue: 4,
                columns: new[] { "Avatar", "Bio", "HobbyDescription", "HobbyTitle" },
                values: new object[] { "~/images/homeProPic4.jpg", "I am a 4th year IT student studying Software Development.", "I love playing, writing, and listening to music. I play a lot of instruments and love sharing my passion with others. ", "Music" });

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamMemberId",
                keyValue: 5,
                column: "Avatar",
                value: "~/images/blakesProPic.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "Team");

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamMemberId",
                keyValue: 4,
                columns: new[] { "Bio", "HobbyDescription", "HobbyTitle" },
                values: new object[] { "Need to fill out!", "Need to fill out!", "Need to fill out!" });
        }
    }
}
