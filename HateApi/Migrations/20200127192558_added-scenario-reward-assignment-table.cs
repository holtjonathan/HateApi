using Microsoft.EntityFrameworkCore.Migrations;

namespace HateApi.Migrations
{
    public partial class addedscenariorewardassignmenttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScenarioRewardAssignments",
                columns: table => new
                {
                    ScenarioId = table.Column<int>(nullable: false),
                    RewardId = table.Column<int>(nullable: false),
                    ScenarioRewardAssignmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScenarioRewardAssignments", x => new { x.RewardId, x.ScenarioId });
                    table.ForeignKey(
                        name: "FK_ScenarioRewardAssignments_Rewards_RewardId",
                        column: x => x.RewardId,
                        principalTable: "Rewards",
                        principalColumn: "RewardId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScenarioRewardAssignments_Scenarios_ScenarioId",
                        column: x => x.ScenarioId,
                        principalTable: "Scenarios",
                        principalColumn: "ScenarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScenarioRewardAssignments_ScenarioId",
                table: "ScenarioRewardAssignments",
                column: "ScenarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScenarioRewardAssignments");
        }
    }
}
