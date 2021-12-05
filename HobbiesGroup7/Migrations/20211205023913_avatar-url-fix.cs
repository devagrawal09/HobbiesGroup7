using Microsoft.EntityFrameworkCore.Migrations;

namespace HobbiesGroup7.Migrations
{
    public partial class avatarurlfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamMemberId",
                keyValue: 1,
                column: "Avatar",
                value: "/images/homeProPic1.jpg");

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamMemberId",
                keyValue: 2,
                column: "Avatar",
                value: "/images/homeProPic2.jpg");

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamMemberId",
                keyValue: 3,
                column: "Avatar",
                value: "/images/homeProPic3.jpg");

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamMemberId",
                keyValue: 4,
                column: "Avatar",
                value: "/images/homeProPic4.jpg");

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamMemberId",
                keyValue: 5,
                column: "Avatar",
                value: "/images/blakesProPic.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                column: "Avatar",
                value: "~/images/homeProPic4.jpg");

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "TeamMemberId",
                keyValue: 5,
                column: "Avatar",
                value: "~/images/blakesProPic.jpg");
        }
    }
}
