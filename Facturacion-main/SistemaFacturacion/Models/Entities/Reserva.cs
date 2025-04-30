using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaFacturacion.Models.Entities
{
    public class Reserva
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
        public DateTime fecha { get; set; }
        public double precio { get; set; }
        public bool estado { get; set; } = true;


        public interface IReserva<T>
        {
            void HacerReserva(T reserva);
            void EliminarReserva(int id);
           
            
        }
    }
    
}
