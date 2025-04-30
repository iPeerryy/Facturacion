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
            modelBuilder.Entity<Reserva>()
            .HasOne(r => r.cliente)  // Una reserva tiene un cliente
            .WithMany()  // Un cliente puede tener muchas reservas
            .HasForeignKey(r => r.ClienteId)  // La clave foránea es ClienteId
            .OnDelete(DeleteBehavior.Restrict);  // Opcional: especificar comportamiento en caso de eliminación del cliente
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
