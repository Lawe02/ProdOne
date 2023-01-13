using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectOne.Migrations
{
    public partial class goingback : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Base",
                table: "Shapes");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Shapes");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Shapes");

            migrationBuilder.DropColumn(
                name: "Paralellogram_Base",
                table: "Shapes");

            migrationBuilder.DropColumn(
                name: "Paralellogram_Height",
                table: "Shapes");

            migrationBuilder.DropColumn(
                name: "ShortSide",
                table: "Shapes");

            migrationBuilder.DropColumn(
                name: "Side",
                table: "Shapes");

            migrationBuilder.DropColumn(
                name: "Triangel_Base",
                table: "Shapes");

            migrationBuilder.DropColumn(
                name: "Triangel_Height",
                table: "Shapes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Base",
                table: "Shapes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Shapes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "Shapes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Paralellogram_Base",
                table: "Shapes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Paralellogram_Height",
                table: "Shapes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShortSide",
                table: "Shapes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Side",
                table: "Shapes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Triangel_Base",
                table: "Shapes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Triangel_Height",
                table: "Shapes",
                type: "int",
                nullable: true);
        }
    }
}
