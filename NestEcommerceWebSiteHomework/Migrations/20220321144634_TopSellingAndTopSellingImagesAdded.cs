using Microsoft.EntityFrameworkCore.Migrations;

namespace NestEcommerceWebSiteHomework.Migrations
{
    public partial class TopSellingAndTopSellingImagesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TopSellings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    OldPrice = table.Column<double>(nullable: false),
                    NewPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopSellings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TopSellingImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    TopSellingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopSellingImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TopSellingImages_TopSellings_TopSellingId",
                        column: x => x.TopSellingId,
                        principalTable: "TopSellings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TopSellingImages_TopSellingId",
                table: "TopSellingImages",
                column: "TopSellingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TopSellingImages");

            migrationBuilder.DropTable(
                name: "TopSellings");
        }
    }
}
