using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WordFun.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Story",
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
                    Noun8 = table.Column<string>(type: "TEXT", nullable: true),
                    Verb = table.Column<string>(type: "TEXT", nullable: true),
                    Adjective = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Story", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Story");
        }
    }
}
