using Microsoft.EntityFrameworkCore.Migrations;

namespace NestEcommerceWebSiteHomework.Migrations
{
    public partial class DealIntChangedTodoubleForPrices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "OldPrice",
                table: "Deals",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "NewPrice",
                table: "Deals",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OldPrice",
                table: "Deals",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "NewPrice",
                table: "Deals",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
