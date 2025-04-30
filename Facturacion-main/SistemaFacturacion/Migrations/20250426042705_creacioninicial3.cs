using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaFacturacion.Migrations
{
    /// <inheritdoc />
    public partial class creacioninicial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Productos_productoid",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_productoid",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "productoid",
                table: "Pedidos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "productoid",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_productoid",
                table: "Pedidos",
                column: "productoid");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Productos_productoid",
                table: "Pedidos",
                column: "productoid",
                principalTable: "Productos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
