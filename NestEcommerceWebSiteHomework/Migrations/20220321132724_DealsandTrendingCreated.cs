using Microsoft.EntityFrameworkCore.Migrations;

namespace NestEcommerceWebSiteHomework.Migrations
{
    public partial class DealsandTrendingCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SecNum = table.Column<int>(nullable: false),
                    MinNUm = table.Column<int>(nullable: false),
                    HourNum = table.Column<int>(nullable: false),
                    DayNum = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    Image = table.Column<string>(maxLength: 1000, nullable: true),
                    OldPrice = table.Column<int>(nullable: false),
                    NewPrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trendings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    Image1 = table.Column<string>(maxLength: 1000, nullable: true),
                    Image2 = table.Column<string>(maxLength: 1000, nullable: true),
                    NewPrice = table.Column<double>(nullable: false),
                    OldPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trendings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deals");

            migrationBuilder.DropTable(
                name: "Trendings");
        }
    }
}
