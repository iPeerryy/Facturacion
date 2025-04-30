using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturacion.Models.Repositories;
using SistemaFacturacion.Models.Entities;

namespace SistemaFacturacion.Controllers.Productos
{
    public partial class CtrEliminarProducto : UserControl
    {
        private readonly ProductoRepository _repository;
        public CtrEliminarProducto(ProductoRepository repository)
        {
            _repository = repository;
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = new Producto();

                producto.id = Convert.ToInt32(txtID.Text);



                _repository.EliminarProducto(producto.id);
                MessageBox.Show("Producto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListar_Click_1(object sender, EventArgs e)
        {
            _repository.ListarProductos(DGVListarProducto);
        }
    }
}
