using Microsoft.EntityFrameworkCore.Migrations;

namespace HateApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Scenarios",
                columns: table => new
                {
                    ScenarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Prereq = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scenarios", x => x.ScenarioId);
                });

            migrationBuilder.CreateTable(
                name: "Specials",
                columns: table => new
                {
                    SpecialId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    SpecialTypeId = table.Column<int>(nullable: false),
                    ScenarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specials", x => x.SpecialId);
                    table.ForeignKey(
                        name: "FK_Specials_Scenarios_ScenarioId",
                        column: x => x.ScenarioId,
                        principalTable: "Scenarios",
                        principalColumn: "ScenarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpecialTypes",
                columns: table => new
                {
                    SpecialTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SpecialRef = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialTypes", x => x.SpecialTypeId);
                    table.ForeignKey(
                        name: "FK_SpecialTypes_Specials_SpecialTypeId",
                        column: x => x.SpecialTypeId,
                        principalTable: "Specials",
                        principalColumn: "SpecialId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Scenarios",
                columns: new[] { "ScenarioId", "Description", "Name", "Prereq" },
                values: new object[] { 1, "Blah blah blah", "TestScenario1", "Must have X, Y, and Z" });

            migrationBuilder.InsertData(
                table: "Scenarios",
                columns: new[] { "ScenarioId", "Description", "Name", "Prereq" },
                values: new object[] { 2, "asdfasfdsf", "TestScenario2", "adsfasfd" });

            migrationBuilder.InsertData(
                table: "Specials",
                columns: new[] { "SpecialId", "Name", "ScenarioId", "SpecialTypeId" },
                values: new object[] { 1, "Special1", 1, 1 });

            migrationBuilder.InsertData(
                table: "Specials",
                columns: new[] { "SpecialId", "Name", "ScenarioId", "SpecialTypeId" },
                values: new object[] { 2, "Special2", 1, 2 });

            migrationBuilder.InsertData(
                table: "SpecialTypes",
                columns: new[] { "SpecialTypeId", "Name", "SpecialRef" },
                values: new object[] { 1, "Special Actions", 1 });

            migrationBuilder.InsertData(
                table: "SpecialTypes",
                columns: new[] { "SpecialTypeId", "Name", "SpecialRef" },
                values: new object[] { 2, "Special Rules", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Specials_ScenarioId",
                table: "Specials",
                column: "ScenarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpecialTypes");

            migrationBuilder.DropTable(
                name: "Specials");

            migrationBuilder.DropTable(
                name: "Scenarios");
        }
    }
}
