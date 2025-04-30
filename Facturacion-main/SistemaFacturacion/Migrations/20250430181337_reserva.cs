using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaFacturacion.Migrations
{
    /// <inheritdoc />
    public partial class reserva : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "hora",
                table: "Reservas");

            migrationBuilder.RenameColumn(
                name: "total",
                table: "Reservas",
                newName: "precio");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Reservas",
                newName: "nombre");

            migrationBuilder.AddColumn<int>(
                name: "reservaid",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_reservaid",
                table: "Pedidos",
                column: "reservaid");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Reservas_reservaid",
                table: "Pedidos",
                column: "reservaid",
                principalTable: "Reservas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Reservas_reservaid",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_reservaid",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "reservaid",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "precio",
                table: "Reservas",
                newName: "total");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Reservas",
                newName: "ClienteId");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "hora",
                table: "Reservas",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }
    }
}
