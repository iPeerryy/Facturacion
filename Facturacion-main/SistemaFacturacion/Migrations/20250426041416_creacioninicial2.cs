using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaFacturacion.Migrations
{
    /// <inheritdoc />
    public partial class creacioninicial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_clienteid",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Clientes_clienteid",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_clienteid",
                table: "Reservas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empleados",
                table: "Empleados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "clienteid",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "id",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "id",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "clienteid",
                table: "Pedidos",
                newName: "productoid");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_clienteid",
                table: "Pedidos",
                newName: "IX_Pedidos_productoid");

            migrationBuilder.AddColumn<string>(
                name: "clientecedula",
                table: "Reservas",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Hora",
                table: "Pedidos",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<string>(
                name: "clientecedula",
                table: "Pedidos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "empleadocedula",
                table: "Pedidos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cedula",
                table: "Empleados",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "cedula",
                table: "Clientes",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empleados",
                table: "Empleados",
                column: "cedula");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "cedula");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_clientecedula",
                table: "Reservas",
                column: "clientecedula");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_clientecedula",
                table: "Pedidos",
                column: "clientecedula");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_empleadocedula",
                table: "Pedidos",
                column: "empleadocedula");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clientes_clientecedula",
                table: "Pedidos",
                column: "clientecedula",
                principalTable: "Clientes",
                principalColumn: "cedula");

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
                name: "FK_Reservas_Clientes_clientecedula",
                table: "Reservas",
                column: "clientecedula",
                principalTable: "Clientes",
                principalColumn: "cedula");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_clientecedula",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Empleados_empleadocedula",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Productos_productoid",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Clientes_clientecedula",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_clientecedula",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_clientecedula",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_empleadocedula",
                table: "Pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empleados",
                table: "Empleados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "clientecedula",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "Hora",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "clientecedula",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "empleadocedula",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "productoid",
                table: "Pedidos",
                newName: "clienteid");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_productoid",
                table: "Pedidos",
                newName: "IX_Pedidos_clienteid");

            migrationBuilder.AddColumn<int>(
                name: "clienteid",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "cedula",
                table: "Empleados",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "Empleados",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "cedula",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empleados",
                table: "Empleados",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_clienteid",
                table: "Reservas",
                column: "clienteid");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clientes_clienteid",
                table: "Pedidos",
                column: "clienteid",
                principalTable: "Clientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Clientes_clienteid",
                table: "Reservas",
                column: "clienteid",
                principalTable: "Clientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
