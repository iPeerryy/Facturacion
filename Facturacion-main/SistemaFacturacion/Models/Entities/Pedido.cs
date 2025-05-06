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
        public string EmpleadoCedula { get; set; }
        public bool estatusReserva { get; set; }
        public Empleado Empleado { get; set; }
        public List<ProductoPedido> Productos { get; set; } = new();

        public interface IPedido<T>
        {
            void AgregarPedido(T pedido);
            
            List<T> ObtenerTodos();
            void EliminarPedido(int id);
            void ActualizarPedido(T pedido);
            void ResetContext();
        }
    }
}
