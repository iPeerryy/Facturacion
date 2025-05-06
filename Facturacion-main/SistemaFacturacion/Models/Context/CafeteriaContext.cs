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

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductoPedido>()
                .HasKey(pp => new { pp.PedidoId, pp.ProductoId });

            modelBuilder.Entity<ProductoPedido>()
                .HasOne(pp => pp.Pedido)
                .WithMany(p => p.Productos)
                .HasForeignKey(pp => pp.PedidoId);

            modelBuilder.Entity<ProductoPedido>()
                .HasOne(pp => pp.Producto)
                .WithMany(p => p.Pedidos)
                .HasForeignKey(pp => pp.ProductoId);

            modelBuilder.Entity<Empleado>().HasData(
                new Empleado { nombre = "Adrian Sarcos", cedula = "4021356164", cargo = "Vendedor", salario = 30000 },
                new Empleado { nombre = "Valeria Suarez", cedula = "402654423", cargo = "Vendedor", salario = 30000 }
                );

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
