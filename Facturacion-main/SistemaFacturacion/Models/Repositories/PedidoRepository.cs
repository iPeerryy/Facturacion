using Microsoft.EntityFrameworkCore;
using SistemaFacturacion.Models.Context;
using SistemaFacturacion.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using static SistemaFacturacion.Models.Entities.Pedido;

namespace Facturacion.Models.Repositories
{
    public class PedidoRepository : IPedido<Pedido>
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
                if (pedido.Empleado != null)
                {
                    _context.Empleados.Attach(pedido.Empleado);
                }
            

                foreach (var productoPedido in pedido.Productos)
                {


                    productoPedido.Producto = _context.Productos.Find(productoPedido.ProductoId);
                }

                // Eliminar duplicados en memoria
                pedido.Productos = pedido.Productos
                    .GroupBy(pp => pp.ProductoId)
                    .Select(g => g.First())
                    .ToList();

                // Guardar el pedido y obtener su ID
                _context.Pedidos.Add(pedido);
                _context.SaveChanges();

                // Agregar ProductoPedido solo si no existe
                foreach (var productoPedido in pedido.Productos)
                {
                    productoPedido.PedidoId = pedido.Id;

                    bool yaExiste = _context.ProductosPedidos
                        .Any(pp => pp.PedidoId == pedido.Id && pp.ProductoId == productoPedido.ProductoId);

                    if (!yaExiste)
                    {
                        _context.ProductosPedidos.Add(productoPedido);
                    }
                }

                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new InvalidOperationException("Error al agregar el pedido.", ex);
            }
        }
      
        public void EliminarPedido(int id)
        {
            var pedido = _context.Pedidos.Find(id);
            if (pedido != null)
            {
                _context.Pedidos.Remove(pedido);
                _context.SaveChanges();
            }
        }
        public void ActualizarPedido(Pedido pedido)
        {
            var existingPedido = _context.Pedidos.Find(pedido.Id);
            if (existingPedido != null)
            {
                _context.Entry(existingPedido).CurrentValues.SetValues(pedido);
                _context.SaveChanges();
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
        public void ResetContext()
        {
            _context.ChangeTracker.Clear();
        }

        //public void AgregarPedido(Pedido pedido)
        //{

        //    try
        //    {
        //        // Attach the existing Empleado entity
        //        if (pedido.Empleado != null)
        //        {
        //            _context.Empleados.Attach(pedido.Empleado);
        //        }

        //        // Ensure each ProductoPedido is unique for this Pedido
        //        foreach (var productoPedido in pedido.Productos)
        //        {
        //            if (productoPedido.Producto != null)
        //            {
        //                _context.Productos.Attach(productoPedido.Producto);
        //            }

        //            // Detach the ProductoPedido if it is already tracked
        //            var existingEntry = _context.Entry(productoPedido);
        //            if (existingEntry.State != EntityState.Detached)
        //            {
        //                existingEntry.State = EntityState.Detached;
        //            }

        //            // Ensure ProductoPedido has a unique key for this Pedido
        //            productoPedido.PedidoId = pedido.Id;
        //        }

        //        _context.Pedidos.Add(pedido);
        //        _context.SaveChanges();
        //    }
        //    catch (DbUpdateException ex)
        //    {
        //        throw new InvalidOperationException("Error adding the pedido to the database. Ensure the related entities already exist and primary keys are not duplicated.", ex);
        //    }
        //}



        //public List<Pedido> ObtenerTodos()
        //{
        //    return _context.Pedidos
        //        .Include(p => p.Productos)
        //            .ThenInclude(pp => pp.Producto)
        //        .Include(p => p.Empleado)
        //        .ToList();
        //}
        //public void ResetContext()
        //{
        //    _context.ChangeTracker.Clear();
        //}
    }
}
