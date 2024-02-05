using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lanche.Migrations
{
    /// <inheritdoc />
    public partial class CarrinhoCompraItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarrinhoCompraItens",
                columns: table => new
                {
                    CarrinhoCompraItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanchesId = table.Column<int>(type: "int", nullable: true),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    CarrinhoCompraId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoCompraItens", x => x.CarrinhoCompraItemId);
                    table.ForeignKey(
                        name: "FK_CarrinhoCompraItens_Lanches_LanchesId",
                        column: x => x.LanchesId,
                        principalTable: "Lanches",
                        principalColumn: "LanchesId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoCompraItens_LanchesId",
                table: "CarrinhoCompraItens",
                column: "LanchesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarrinhoCompraItens");
        }
    }
}
