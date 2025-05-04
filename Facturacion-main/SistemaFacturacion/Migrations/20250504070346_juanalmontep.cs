using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaFacturacion.Migrations
{
    /// <inheritdoc />
    public partial class juanalmontep : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Reservas_Reservaid",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_Reservaid",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Reservaid",
                table: "Pedidos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Reservaid",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_Reservaid",
                table: "Pedidos",
                column: "Reservaid");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Reservas_Reservaid",
                table: "Pedidos",
                column: "Reservaid",
                principalTable: "Reservas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
