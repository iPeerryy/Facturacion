using Facturacion.Models.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SistemaFacturacion.Controllers.Login;
using SistemaFacturacion.Models.Context;
using SistemaFacturacion.Models.Repositories;

namespace SistemaFacturacion
{
    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        { 
        

           
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
            // Configure the database context
            var options = new DbContextOptionsBuilder<CafeteriaContext>()
                .UseSqlServer("Server=(localdb)\\localDB;Database=CafeteriaDB;Trusted_Connection=True;Integrated Security=True")
                .Options;
            var dbContext = new CafeteriaContext(options);

            // Create the employee repository
            var empleadoRepository = new EmpleadoRepository(dbContext);
            Application.Run(new Form1(empleadoRepository));
        }
    }
}