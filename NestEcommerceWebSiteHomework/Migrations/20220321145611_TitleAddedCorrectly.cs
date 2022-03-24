using Microsoft.EntityFrameworkCore.Migrations;

namespace NestEcommerceWebSiteHomework.Migrations
{
    public partial class TitleAddedCorrectly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "TopSellingImages");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "TopSellings",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "TopSellings");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "TopSellingImages",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);
        }
    }
}
