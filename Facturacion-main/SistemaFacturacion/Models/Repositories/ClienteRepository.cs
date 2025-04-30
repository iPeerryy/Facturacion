using SistemaFacturacion.Models.Context;
using SistemaFacturacion.Models.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using static SistemaFacturacion.Models.Entities.Cliente;
using static SistemaFacturacion.Models.Entities.Producto;

namespace Facturacion.Models.Repositories
{
    public class ClienteRepository 
    {
        private readonly CafeteriaContext _context;

        public ClienteRepository(CafeteriaContext context)
        {
            _context = context;
        }

        public void AgregarCliente(Cliente cliente)
        {
            using (var context = new CafeteriaContext())
            {
                _context.Clientes.Add(cliente);
                _context.SaveChanges();
            }

            
        }

        public void ActualizarCliente(Cliente cliente)
        {
            var clienteExistente = _context.Clientes.FirstOrDefault(c => c.cedula == cliente.cedula);
            if (clienteExistente == null)
                throw new Exception("Cliente no encontrado.");

            clienteExistente.nombre = cliente.nombre;
            clienteExistente.esFrecuente = cliente.esFrecuente;

            _context.Clientes.Update(clienteExistente);
            _context.SaveChanges();
        }

        public void EliminarCliente(string cedula)
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.cedula == cedula);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Cliente no encontrado.");
            }
        }

        public Cliente ObtenerCliente(string cedula)
        {
            return _context.Clientes.FirstOrDefault(c => c.cedula == cedula);
        }

        public List<Cliente> ObtenerTodos()
        {
            return _context.Clientes.ToList();
        }
    }
}
