using Microsoft.EntityFrameworkCore.Migrations;

namespace NestEcommerceWebSiteHomework.Migrations
{
    public partial class HomePageUpdatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewPrice",
                table: "TopSellings");

            migrationBuilder.DropColumn(
                name: "OldPrice",
                table: "TopSellings");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "TopSellings");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "TopSellingImages");

            migrationBuilder.AddColumn<double>(
                name: "NewPrice",
                table: "TopSellingImages",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "OldPrice",
                table: "TopSellingImages",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "TopSellingImages",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewPrice",
                table: "TopSellingImages");

            migrationBuilder.DropColumn(
                name: "OldPrice",
                table: "TopSellingImages");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "TopSellingImages");

            migrationBuilder.AddColumn<double>(
                name: "NewPrice",
                table: "TopSellings",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "OldPrice",
                table: "TopSellings",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "TopSellings",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "TopSellingImages",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);
        }
    }
}
