using Facturacion.Models.Repositories;
using SistemaFacturacion.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion.Controllers.Productos
{
    public partial class CtrAgregarProducto : UserControl
    {
        private readonly ProductoRepository _repository;
        public CtrAgregarProducto(ProductoRepository repository)
        {
            _repository = repository;
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Producto nuevoProducto = new Producto
                {
                    nombre = textNombre.Text,
                    descripcion = textDescripcion.Text,
                    precio = double.Parse(textPrecio.Text),
                    cantidad = int.Parse(textCantidad.Text),

                };
                if (nuevoProducto.cantidad > 0)
                {
                    nuevoProducto.estado = true;
                }
                else
                {
                    nuevoProducto.estado = false;
                }
                if (nuevoProducto != null)
                {
                    _repository.AgregarProducto(nuevoProducto);

                    MessageBox.Show("Producto agregado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textCantidad.Clear();
                    textDescripcion.Clear();
                    textNombre.Clear();
                    textPrecio.Clear();

                }
                else
                {
                    MessageBox.Show("Error al agregar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void agregarProductoPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
