using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaFacturacion.Migrations
{
    /// <inheritdoc />
    public partial class creacioninicial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Personas_clienteid",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Personas_clienteid",
                table: "Reservas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personas",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "esFrecuente",
                table: "Personas");

            migrationBuilder.RenameTable(
                name: "Personas",
                newName: "Empleados");

            migrationBuilder.AlterColumn<int>(
                name: "salario",
                table: "Empleados",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cargo",
                table: "Empleados",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empleados",
                table: "Empleados",
                column: "id");

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    esFrecuente = table.Column<bool>(type: "bit", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cedula = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_clienteid",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Clientes_clienteid",
                table: "Reservas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empleados",
                table: "Empleados");

            migrationBuilder.RenameTable(
                name: "Empleados",
                newName: "Personas");

            migrationBuilder.AlterColumn<int>(
                name: "salario",
                table: "Personas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "cargo",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Personas",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "esFrecuente",
                table: "Personas",
                type: "bit",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personas",
                table: "Personas",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Personas_clienteid",
                table: "Pedidos",
                column: "clienteid",
                principalTable: "Personas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Personas_clienteid",
                table: "Reservas",
                column: "clienteid",
                principalTable: "Personas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
