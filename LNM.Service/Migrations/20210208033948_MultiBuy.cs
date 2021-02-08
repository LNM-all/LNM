using Microsoft.EntityFrameworkCore.Migrations;

namespace LNM.Service.Migrations
{
    public partial class MultiBuy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MultiBuy");

            migrationBuilder.AddColumn<decimal>(
                name: "MultiBuyPrice",
                table: "Sku",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "MultiBuyQuantity",
                table: "Sku",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MultiBuyPrice",
                table: "Sku");

            migrationBuilder.DropColumn(
                name: "MultiBuyQuantity",
                table: "Sku");

            migrationBuilder.CreateTable(
                name: "MultiBuy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    SkuId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultiBuy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MultiBuy_Sku_SkuId",
                        column: x => x.SkuId,
                        principalTable: "Sku",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MultiBuy_SkuId",
                table: "MultiBuy",
                column: "SkuId",
                unique: true);
        }
    }
}
