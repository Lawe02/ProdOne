using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectOne.Migrations
{
    public partial class dsfsdf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Results",
                table: "Results");

            migrationBuilder.RenameTable(
                name: "Results",
                newName: "CalculationResults");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CalculationResults",
                table: "CalculationResults",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CalculationResults",
                table: "CalculationResults");

            migrationBuilder.RenameTable(
                name: "CalculationResults",
                newName: "Results");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Results",
                table: "Results",
                column: "Id");
        }
    }
}
