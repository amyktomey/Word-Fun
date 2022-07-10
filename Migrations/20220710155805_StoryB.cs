using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WordFun.Migrations
{
    public partial class StoryB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StoryB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Noun1 = table.Column<string>(type: "TEXT", nullable: true),
                    Noun2 = table.Column<string>(type: "TEXT", nullable: true),
                    Noun3 = table.Column<string>(type: "TEXT", nullable: true),
                    Noun4 = table.Column<string>(type: "TEXT", nullable: true),
                    Noun5 = table.Column<string>(type: "TEXT", nullable: true),
                    Noun6 = table.Column<string>(type: "TEXT", nullable: true),
                    Noun7 = table.Column<string>(type: "TEXT", nullable: true),
                    Adjective1 = table.Column<string>(type: "TEXT", nullable: true),
                    Adjective2 = table.Column<string>(type: "TEXT", nullable: true),
                    Adjective3 = table.Column<string>(type: "TEXT", nullable: true),
                    Verb1 = table.Column<string>(type: "TEXT", nullable: true),
                    Verb2 = table.Column<string>(type: "TEXT", nullable: true),
                    Verb3 = table.Column<string>(type: "TEXT", nullable: true),
                    Verb4 = table.Column<string>(type: "TEXT", nullable: true),
                    Verb5 = table.Column<string>(type: "TEXT", nullable: true),
                    Verb6 = table.Column<string>(type: "TEXT", nullable: true),
                    Interjection = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoryB", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoryB");
        }
    }
}
