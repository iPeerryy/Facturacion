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
    public partial class CtrActualizarProducto : UserControl
    {
        private readonly ProductoRepository _repository;
        public CtrActualizarProducto(ProductoRepository repository)
        {
            InitializeComponent();
            _repository = repository;

        }
        private void CtrActualizarProducto_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CtrActualizarProducto_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<Producto> productos = _repository.ObtenerTodos();
 
                dataGridView1.DataSource = productos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                if (dataGridView1.CurrentRow != null)
                {
                    Producto productoEditado = (Producto)dataGridView1.CurrentRow.DataBoundItem;

                   
                    _repository.ActualizarProducto(productoEditado);

                    MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (dataGridView1.CurrentRow != null)
                {
                    Producto productoEditado = (Producto)dataGridView1.CurrentRow.DataBoundItem;

                    
                    _repository.ActualizarProducto(productoEditado);

                    MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Seleccione un producto para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
