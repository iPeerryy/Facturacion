using SistemaFacturacion.Models.Entities;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using SistemaFacturacion.Models.Context;
using static SistemaFacturacion.Models.Entities.Reserva;
using static SistemaFacturacion.Models.Entities.Cliente;


namespace Facturacion.Models.Repositories
{
    public class ReservaRepository : IReserva<Reserva>
    {
        private readonly CafeteriaContext _context;

        public ReservaRepository(CafeteriaContext context)
        {
            _context = context;
        }

        public void HacerReserva(Reserva reserva)
        {
            using (var context = new CafeteriaContext())
            {
                _context.Reservas.Add(reserva);
                _context.SaveChanges();
            }
        }

        public void EliminarReserva(int id)
        {
            var reserva = _context.Reservas.FirstOrDefault(r => r.id == id);
            if (reserva != null)
            {
                _context.Reservas.Remove(reserva);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Reserva no encontrada.");
            }
        }
        public List<Reserva> ObtenerTodos()
        {
            return _context.Reservas.ToList();  
        }



    }
}
