using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaFacturacion.Migrations
{
    /// <inheritdoc />
    public partial class initialcase2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Clientes_clientecedula",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_clientecedula",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "clientecedula",
                table: "Reservas");

            migrationBuilder.AddColumn<string>(
                name: "ClienteId",
                table: "Reservas",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_ClienteId",
                table: "Reservas",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Clientes_ClienteId",
                table: "Reservas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "cedula",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Clientes_ClienteId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_ClienteId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Reservas");

            migrationBuilder.AddColumn<string>(
                name: "clientecedula",
                table: "Reservas",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_clientecedula",
                table: "Reservas",
                column: "clientecedula");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Clientes_clientecedula",
                table: "Reservas",
                column: "clientecedula",
                principalTable: "Clientes",
                principalColumn: "cedula");
        }
    }
}
