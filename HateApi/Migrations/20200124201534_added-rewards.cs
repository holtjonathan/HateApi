using Microsoft.EntityFrameworkCore.Migrations;

namespace HateApi.Migrations
{
    public partial class addedrewards : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AttackerRewardId",
                table: "Scenarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DefenderRewardId",
                table: "Scenarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Scenarios",
                columns: new[] { "ScenarioId", "AttackerRewardId", "DefenderRewardId", "Description", "Name", "Prereq" },
                values: new object[] { 3, 0, 0, "We have to fight our way throught the mountain", "We are trapped!", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "ScenarioId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "AttackerRewardId",
                table: "Scenarios");

            migrationBuilder.DropColumn(
                name: "DefenderRewardId",
                table: "Scenarios");
        }
    }
}
