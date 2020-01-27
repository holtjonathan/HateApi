using Microsoft.EntityFrameworkCore.Migrations;

namespace HateApi.Migrations
{
    public partial class addedseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rewards",
                columns: new[] { "RewardId", "Description", "HateReward", "Name", "ResourceReward", "RewardType", "UnitUpgrade" },
                values: new object[,]
                {
                    { 1, "Do PILLAGE action on 5 huts", 0, "Pillaged", 3, "Attacker", null },
                    { 2, "Allow less than 5 PILLAGE actions", 0, "Hold the line", 4, "Defender", null },
                    { 3, "Do something else unrelated to the others", 4, "Something else", 0, "Both", "SomeCoolActionName" }
                });

            migrationBuilder.InsertData(
                table: "Scenarios",
                columns: new[] { "ScenarioId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Go pillage a bunch of stuff!!", "Pillage the Village" },
                    { 2, "Some other scenario description!!", "Some other scenario name" }
                });

            migrationBuilder.InsertData(
                table: "Specials",
                columns: new[] { "SpecialId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Make sure to be sitting down while playing.", "Special Chair" },
                    { 2, "Play with your eyes closed.", "Special Action" }
                });

            migrationBuilder.InsertData(
                table: "ScenarioRewardAssignments",
                columns: new[] { "RewardId", "ScenarioId", "ScenarioRewardAssignmentId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "ScenarioSpecialAssignments",
                columns: new[] { "SpecialId", "ScenarioId", "ScenarioSpecialAssignmentId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ScenarioRewardAssignments",
                keyColumns: new[] { "RewardId", "ScenarioId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ScenarioRewardAssignments",
                keyColumns: new[] { "RewardId", "ScenarioId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ScenarioRewardAssignments",
                keyColumns: new[] { "RewardId", "ScenarioId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ScenarioSpecialAssignments",
                keyColumns: new[] { "SpecialId", "ScenarioId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ScenarioSpecialAssignments",
                keyColumns: new[] { "SpecialId", "ScenarioId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "ScenarioId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rewards",
                keyColumn: "RewardId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rewards",
                keyColumn: "RewardId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rewards",
                keyColumn: "RewardId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "ScenarioId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Specials",
                keyColumn: "SpecialId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Specials",
                keyColumn: "SpecialId",
                keyValue: 2);
        }
    }
}
