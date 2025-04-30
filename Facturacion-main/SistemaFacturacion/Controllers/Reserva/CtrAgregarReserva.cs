using System;
using System.Windows.Forms;
using SistemaFacturacion.Models.Entities;
using SistemaFacturacion.Models.Entities.SistemaFacturacion.Models.Interfaces;
using SistemaFacturacion.Models.Interfaces;

namespace SistemaFacturacion.Controllers.Reserva
{
    public partial class CtrAgregarReserva : UserControl
    {
        private readonly IReserva<SistemaFacturacion.Models.Entities.Reserva> R_repository;
        private readonly ICliente<Cliente> C_repository;

        public CtrAgregarReserva(IReserva<SistemaFacturacion.Models.Entities.Reserva> reservaRepo, ICliente<Cliente> clienteRepo)
        {
            R_repository = reservaRepo;
            C_repository = clienteRepo;
            InitializeComponent();
        }
        private void CtrAgregarReserva_Load(object sender, EventArgs e)
        {

        }
        private void btnHacerReserva_Click(object sender, EventArgs e)
        {
            try
            {
                string cedula = txtCedulaCliente.Text;

                // Verifica el valor de la cédula que estás buscando
                MessageBox.Show($"Cédula ingresada: {cedula}");

                var clienteExistente = C_repository.ObtenerCliente(cedula);

                if (clienteExistente == null)
                {
                    MessageBox.Show("Cliente no encontrado. Verifique la cédula.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var reserva = new SistemaFacturacion.Models.Entities.Reserva
                {
                    fecha = dtpFecha.Value.Date,
                    hora = dtpHora.Value.TimeOfDay,
                    cliente = clienteExistente,
                    total = 0.0 // Si deseas calcular un total aquí o dejarlo en 0 por ahora
                };

                R_repository.HacerReserva(reserva);

                MessageBox.Show("Reserva registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCedulaCliente.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la reserva:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


