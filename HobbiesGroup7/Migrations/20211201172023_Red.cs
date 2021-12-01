using Microsoft.EntityFrameworkCore.Migrations;

namespace HobbiesGroup7.Migrations
{
    public partial class Red : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    TeamMemberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HobbyTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HobbyDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.TeamMemberId);
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamMemberId", "Bio", "HobbyDescription", "HobbyTitle", "Name" },
                values: new object[] { 1, "I am a 4th year IT student and an aspiring software developer/architect.", "I like playing rock and metal music on guitar, keyboard and drums.", "Music", "Dev Agrawal" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Team");
        }
    }
}
