using Microsoft.EntityFrameworkCore.Migrations;



#nullable disable

namespace SistemaFacturacion.Migrations
{
    /// <inheritdoc />
    public partial class junsito : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Empleados_empleadocedula",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Productos_productoid",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Reservas_reservaid",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_productoid",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "productoid",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "reservaid",
                table: "Pedidos",
                newName: "ReservaId");

            migrationBuilder.RenameColumn(
                name: "empleadocedula",
                table: "Pedidos",
                newName: "EmpleadoCedula");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_reservaid",
                table: "Pedidos",
                newName: "IX_Pedidos_ReservaId");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_empleadocedula",
                table: "Pedidos",
                newName: "IX_Pedidos_EmpleadoCedula");

            migrationBuilder.AlterColumn<string>(
                name: "EmpleadoCedula",
                table: "Pedidos",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ProductosPedidos",
                columns: table => new
                {
                    PedidoId = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductosPedidos", x => new { x.PedidoId, x.ProductoId });
                    table.ForeignKey(
                        name: "FK_ProductosPedidos_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductosPedidos_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductosPedidos_ProductoId",
                table: "ProductosPedidos",
                column: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Empleados_EmpleadoCedula",
                table: "Pedidos",
                column: "EmpleadoCedula",
                principalTable: "Empleados",
                principalColumn: "cedula",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Reservas_ReservaId",
                table: "Pedidos",
                column: "ReservaId",
                principalTable: "Reservas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Empleados_EmpleadoCedula",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Reservas_ReservaId",
                table: "Pedidos");

            migrationBuilder.DropTable(
                name: "ProductosPedidos");

            migrationBuilder.RenameColumn(
                name: "ReservaId",
                table: "Pedidos",
                newName: "reservaid");

            migrationBuilder.RenameColumn(
                name: "EmpleadoCedula",
                table: "Pedidos",
                newName: "empleadocedula");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_ReservaId",
                table: "Pedidos",
                newName: "IX_Pedidos_reservaid");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_EmpleadoCedula",
                table: "Pedidos",
                newName: "IX_Pedidos_empleadocedula");

            migrationBuilder.AlterColumn<string>(
                name: "empleadocedula",
                table: "Pedidos",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
                name: "FK_Pedidos_Empleados_empleadocedula",
                table: "Pedidos",
                column: "empleadocedula",
                principalTable: "Empleados",
                principalColumn: "cedula");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Productos_productoid",
                table: "Pedidos",
                column: "productoid",
                principalTable: "Productos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Reservas_reservaid",
                table: "Pedidos",
                column: "reservaid",
                principalTable: "Reservas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
