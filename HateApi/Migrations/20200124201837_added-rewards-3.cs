using Microsoft.EntityFrameworkCore.Migrations;

namespace HateApi.Migrations
{
    public partial class addedrewards3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rewards",
                columns: new[] { "RewardId", "Description" },
                values: new object[] { 1, "You get blah!" });

            migrationBuilder.InsertData(
                table: "Rewards",
                columns: new[] { "RewardId", "Description" },
                values: new object[] { 2, "You get some other blah!" });

            migrationBuilder.UpdateData(
                table: "Scenarios",
                keyColumn: "ScenarioId",
                keyValue: 3,
                columns: new[] { "AttackerRewardId", "DefenderRewardId" },
                values: new object[] { 1, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rewards",
                keyColumn: "RewardId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rewards",
                keyColumn: "RewardId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Scenarios",
                keyColumn: "ScenarioId",
                keyValue: 3,
                columns: new[] { "AttackerRewardId", "DefenderRewardId" },
                values: new object[] { 0, 0 });
        }
    }
}
