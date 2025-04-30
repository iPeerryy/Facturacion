using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaFacturacion.Models.Entities
{
    public class Reserva
    {
        [Key]
        public int id { get; set; }

        public DateTime fecha { get; set; }
        public TimeSpan hora { get; set; }
        public double total { get; set; }

        public string ClienteId { get; set; } 
        public Cliente cliente { get; set; }  
        public bool estado { get; set; } = true;
    }



    namespace SistemaFacturacion.Models.Interfaces
    {
        public interface IReserva<T>
        {
            void HacerReserva(T reserva);
            void EliminarReserva(int id);
            T ObtenerReserva(int id);
            List<T> ObtenerTodas();
        }
    }
}
