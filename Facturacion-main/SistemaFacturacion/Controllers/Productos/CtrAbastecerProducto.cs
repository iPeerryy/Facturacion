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
    public partial class CtrAbastecerProducto : UserControl
    {
        private readonly ProductoRepository _repository;
        public CtrAbastecerProducto(ProductoRepository repository)
        {
            _repository = repository;
            InitializeComponent();
        }

        private void ActualizarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textId.Text);
                Producto producto = _repository.Obtener(id);
                if (producto != null)
                {
                    producto.cantidad += int.Parse(textCantidad.Text);
                    _repository.ActualizarProducto(producto);
                    MessageBox.Show("Producto abastecido correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textId.Clear();
                    textCantidad.Clear();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Abaster_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
