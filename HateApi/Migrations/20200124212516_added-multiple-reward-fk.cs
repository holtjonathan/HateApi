using Microsoft.EntityFrameworkCore.Migrations;

namespace HateApi.Migrations
{
    public partial class addedmultiplerewardfk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Scenarios",
                keyColumn: "ScenarioId",
                keyValue: 3,
                columns: new[] { "AttackerRewardId", "DefenderRewardId" },
                values: new object[] { 0, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Scenarios_AttackerRewardId",
                table: "Scenarios",
                column: "AttackerRewardId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Scenarios_DefenderRewardId",
                table: "Scenarios",
                column: "DefenderRewardId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Scenarios_Rewards_AttackerRewardId",
                table: "Scenarios",
                column: "AttackerRewardId",
                principalTable: "Rewards",
                principalColumn: "RewardId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Scenarios_Rewards_DefenderRewardId",
                table: "Scenarios",
                column: "DefenderRewardId",
                principalTable: "Rewards",
                principalColumn: "RewardId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Scenarios_Rewards_AttackerRewardId",
                table: "Scenarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Scenarios_Rewards_DefenderRewardId",
                table: "Scenarios");

            migrationBuilder.DropIndex(
                name: "IX_Scenarios_AttackerRewardId",
                table: "Scenarios");

            migrationBuilder.DropIndex(
                name: "IX_Scenarios_DefenderRewardId",
                table: "Scenarios");

            migrationBuilder.UpdateData(
                table: "Scenarios",
                keyColumn: "ScenarioId",
                keyValue: 3,
                columns: new[] { "AttackerRewardId", "DefenderRewardId" },
                values: new object[] { 1, 2 });
        }
    }
}
