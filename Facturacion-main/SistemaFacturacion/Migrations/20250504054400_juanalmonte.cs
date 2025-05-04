using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaFacturacion.Migrations
{
    /// <inheritdoc />
    public partial class juanalmonte : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Reservas_ReservaId",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "ReservaId",
                table: "Pedidos",
                newName: "Reservaid");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_ReservaId",
                table: "Pedidos",
                newName: "IX_Pedidos_Reservaid");

            migrationBuilder.AddColumn<bool>(
                name: "estatusReserva",
                table: "Pedidos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Reservas_Reservaid",
                table: "Pedidos",
                column: "Reservaid",
                principalTable: "Reservas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Reservas_Reservaid",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "estatusReserva",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "Reservaid",
                table: "Pedidos",
                newName: "ReservaId");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_Reservaid",
                table: "Pedidos",
                newName: "IX_Pedidos_ReservaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Reservas_ReservaId",
                table: "Pedidos",
                column: "ReservaId",
                principalTable: "Reservas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
