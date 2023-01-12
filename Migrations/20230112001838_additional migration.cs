using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectOne.Migrations
{
    public partial class additionalmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Area",
                table: "Shapes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Circumference",
                table: "Shapes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Shapes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Form",
                table: "Shapes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "Shapes");

            migrationBuilder.DropColumn(
                name: "Circumference",
                table: "Shapes");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Shapes");

            migrationBuilder.DropColumn(
                name: "Form",
                table: "Shapes");
        }
    }
}
