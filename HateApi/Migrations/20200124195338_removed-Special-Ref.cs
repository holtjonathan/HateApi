using Microsoft.EntityFrameworkCore.Migrations;

namespace HateApi.Migrations
{
    public partial class removedSpecialRef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpecialRef",
                table: "SpecialTypes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SpecialRef",
                table: "SpecialTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "SpecialTypes",
                keyColumn: "SpecialTypeId",
                keyValue: 1,
                column: "SpecialRef",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SpecialTypes",
                keyColumn: "SpecialTypeId",
                keyValue: 2,
                column: "SpecialRef",
                value: 2);
        }
    }
}
