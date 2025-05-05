using Microsoft.EntityFrameworkCore;
using SistemaFacturacion.Models.Context;
using SistemaFacturacion.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Facturacion.Models.Repositories
{
    public class PedidoRepository
    {
        private readonly CafeteriaContext _context;

        public PedidoRepository(CafeteriaContext context)
        {
            _context = context;
        }

        public void AgregarPedido(Pedido pedido)
        {

            try
            {
                // Attach the existing Empleado entity
                if (pedido.Empleado != null)
                {
                    _context.Empleados.Attach(pedido.Empleado);
                }

                // Ensure each ProductoPedido is unique for this Pedido
                foreach (var productoPedido in pedido.Productos)
                {
                    if (productoPedido.Producto != null)
                    {
                        _context.Productos.Attach(productoPedido.Producto);
                    }

                    // Detach the ProductoPedido if it is already tracked
                    var existingEntry = _context.Entry(productoPedido);
                    if (existingEntry.State != EntityState.Detached)
                    {
                        existingEntry.State = EntityState.Detached;
                    }
                }

                _context.Pedidos.Add(pedido);
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new InvalidOperationException("Error adding the pedido to the database. Ensure the related entities already exist and primary keys are not duplicated.", ex);
            }

        }



        public List<Pedido> ObtenerTodos()
        {
            return _context.Pedidos
                .Include(p => p.Productos)
                    .ThenInclude(pp => pp.Producto)
                .Include(p => p.Empleado)
                .ToList();
        }
    }
}
