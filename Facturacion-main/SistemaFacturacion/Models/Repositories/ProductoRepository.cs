using SistemaFacturacion.Models.Context;
using SistemaFacturacion.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SistemaFacturacion.Models.Entities.Producto;

namespace Facturacion.Models.Repositories
{
    public class ProductoRepository : IProducto<Producto>
    {
        private readonly CafeteriaContext _context;

        public ProductoRepository(CafeteriaContext context)
        {
            _context = context;
        }
        public List<Producto> ObtenerTodos()
        {
            return _context.Productos.ToList();
        }

        public Producto Obtener(int id)
        {
            return _context.Productos.FirstOrDefault(e => e.id == id);
        }
        public void AgregarProducto(Producto producto)
        {
            using (var context = new CafeteriaContext())
            {
                context.Productos.Add(producto);
                context.SaveChanges();
            }
        }
      
        public void ActualizarProducto(Producto producto)
        {
           
            
                _context.Productos.Update(producto);
                _context.SaveChanges();
            
        }
        public void EliminarProducto(int id)
        {
            using (var context = new CafeteriaContext())
            {
                var producto = context.Productos.Find(id);
                if (producto != null)
                {
                    context.Productos.Remove(producto);
                    context.SaveChanges();
                }
            }
        }

        public void ListarProductos(DataGridView dataGridView)
        {
            using (var context = new CafeteriaContext())
            {
                var productos = context.Productos.ToList();


                dataGridView.Rows.Clear();
                foreach (var producto in productos)
                {

                    dataGridView.Rows.Add(producto.id, producto.nombre, producto.precio);
                }
            }
        }
    }
}
