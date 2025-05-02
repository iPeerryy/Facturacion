using Microsoft.EntityFrameworkCore.Migrations;



#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SistemaFacturacion.Migrations
{
    /// <inheritdoc />
    public partial class addinginformation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "cedula", "cargo", "nombre", "salario" },
                values: new object[,]
                {
                    { "4021356164", "Vendedor", "Adrian Sarcos", 30000 },
                    { "402654423", "Vendedor", "Valeria Suarez", 30000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "cedula",
                keyValue: "4021356164");

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "cedula",
                keyValue: "402654423");
        }
    }
}
