using SistemaFacturacion.Models.Entities;
using SistemaFacturacion.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using SistemaFacturacion.Models.Context;
using SistemaFacturacion.Models.Entities.SistemaFacturacion.Models.Interfaces;

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
            _context.Reservas.Add(reserva);
            _context.SaveChanges();
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

        public Reserva ObtenerReserva(int id)
        {
            return _context.Reservas.Include(r => r.cliente).FirstOrDefault(r => r.id == id);
        }

        public List<Reserva> ObtenerTodas()
        {
            return _context.Reservas.Include(r => r.cliente).ToList();  // Aquí también puedes incluir al cliente si lo necesitas
        }
    }
}
