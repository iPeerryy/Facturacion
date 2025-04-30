using Microsoft.EntityFrameworkCore;
using SistemaFacturacion.Models.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Models.Context
{
    public class CafeteriaContext : DbContext
    {
       
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<ProductoPedido> ProductosPedidos { get; set; } 


        public CafeteriaContext()
        {
        }

        public CafeteriaContext(DbContextOptions<CafeteriaContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<ProductoPedido>();
            modelBuilder.Ignore<Cliente>();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConexionCafeteria"].ConnectionString;
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        

    }
}
