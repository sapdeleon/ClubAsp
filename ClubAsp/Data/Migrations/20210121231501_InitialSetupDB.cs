using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubAsp.Data.Migrations
{
    public partial class InitialSetupDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GreenBean",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BinNo = table.Column<int>(type: "int", nullable: false),
                    GreenClass = table.Column<int>(type: "int", nullable: false),
                    LotNumber = table.Column<int>(type: "int", nullable: false),
                    BinLevel = table.Column<decimal>(type: "decimal(6,1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GreenBean", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    BlendNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    BlendDescription = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    PackWeight = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    DeclaredWeight = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ColorRange = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GreenBean");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
