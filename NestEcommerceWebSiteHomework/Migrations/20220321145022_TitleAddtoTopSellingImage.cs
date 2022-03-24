using Microsoft.EntityFrameworkCore.Migrations;

namespace NestEcommerceWebSiteHomework.Migrations
{
    public partial class TitleAddtoTopSellingImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "TopSellingImages",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "TopSellingImages");
        }
    }
}
