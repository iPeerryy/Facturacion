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

namespace SistemaFacturacion.Controllers.Clientes
{
    public partial class CtrAgregarCliente : UserControl
    {
        private readonly ClienteRepository C_repository;
        public CtrAgregarCliente(ClienteRepository repository)
        {
            C_repository = repository;
            InitializeComponent();
        }

        private void CtrAgregarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = new Cliente
                {
                    cedula = textCedula.Text.Trim(),
                    nombre = textNombre.Text.Trim(),
                };

                C_repository.AgregarCliente(cliente);

                MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textCedula.Clear();
                textNombre.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar cliente:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
