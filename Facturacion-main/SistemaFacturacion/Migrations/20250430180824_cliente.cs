using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaFacturacion.Migrations
{
    /// <inheritdoc />
    public partial class cliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_clientecedula",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Clientes_ClienteId",
                table: "Reservas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_ClienteId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_clientecedula",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "clientecedula",
                table: "Pedidos");

            migrationBuilder.AlterColumn<string>(
                name: "ClienteId",
                table: "Reservas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ClienteId",
                table: "Reservas",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "clientecedula",
                table: "Pedidos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    cedula = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    esFrecuente = table.Column<bool>(type: "bit", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.cedula);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_ClienteId",
                table: "Reservas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_clientecedula",
                table: "Pedidos",
                column: "clientecedula");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clientes_clientecedula",
                table: "Pedidos",
                column: "clientecedula",
                principalTable: "Clientes",
                principalColumn: "cedula");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Clientes_ClienteId",
                table: "Reservas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "cedula",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
