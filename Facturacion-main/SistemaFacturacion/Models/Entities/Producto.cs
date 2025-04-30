using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFacturacion.Models.Entities
{
    public class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public int cantidad { get; set; }
        public bool estado { get; set; } = false;

        public interface IProducto<T>
        {
            void AgregarProducto(T producto);
            void ActualizarProducto(T producto);
            void EliminarProducto(int id);
            T Obtener(int id);
            List<T> ObtenerTodos();
        }
    }
}
