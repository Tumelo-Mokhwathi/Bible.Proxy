using Microsoft.EntityFrameworkCore.Migrations;

namespace Bible.Proxy.Migrations
{
    public partial class Bible : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AmericanStandardVersion",
                columns: table => new
                {
                    VerseId = table.Column<string>(nullable: false),
                    Scriptures = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmericanStandardVersion", x => x.VerseId);
                });

            migrationBuilder.CreateTable(
                name: "EnglishStandardVersion",
                columns: table => new
                {
                    VerseId = table.Column<string>(nullable: false),
                    Scriptures = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnglishStandardVersion", x => x.VerseId);
                });

            migrationBuilder.CreateTable(
                name: "KingJamesVersion",
                columns: table => new
                {
                    VerseId = table.Column<string>(nullable: false),
                    Scripture = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KingJamesVersion", x => x.VerseId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmericanStandardVersion");

            migrationBuilder.DropTable(
                name: "EnglishStandardVersion");

            migrationBuilder.DropTable(
                name: "KingJamesVersion");
        }
    }
}
