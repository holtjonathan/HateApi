using Microsoft.EntityFrameworkCore.Migrations;

namespace HateApi.Migrations
{
    public partial class addedscenariospecialassignmenttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScenarioSpecialAssignments",
                columns: table => new
                {
                    ScenarioId = table.Column<int>(nullable: false),
                    SpecialId = table.Column<int>(nullable: false),
                    ScenarioSpecialAssignmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScenarioSpecialAssignments", x => new { x.SpecialId, x.ScenarioId });
                    table.ForeignKey(
                        name: "FK_ScenarioSpecialAssignments_Scenarios_ScenarioId",
                        column: x => x.ScenarioId,
                        principalTable: "Scenarios",
                        principalColumn: "ScenarioId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScenarioSpecialAssignments_Specials_SpecialId",
                        column: x => x.SpecialId,
                        principalTable: "Specials",
                        principalColumn: "SpecialId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScenarioSpecialAssignments_ScenarioId",
                table: "ScenarioSpecialAssignments",
                column: "ScenarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScenarioSpecialAssignments");
        }
    }
}
