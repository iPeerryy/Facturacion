using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Models.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public double Total { get; set; }
        public Reserva reserva { get; set; }
        public Empleado empleado { get; set; }
        public Producto producto { get; set; }
        public List<ProductoPedido> productos { get; set; } = new List<ProductoPedido>();

    }
}
