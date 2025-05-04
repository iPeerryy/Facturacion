using System;
using System.Windows.Forms;
using Facturacion.Models.Repositories;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using SistemaFacturacion.Models.Entities;



namespace SistemaFacturacion.Controllers.Reserva
{
    public partial class CtrAgregarReserva : UserControl
    {
        private readonly ReservaRepository R_repository;
        

        public CtrAgregarReserva(ReservaRepository reservaRepo)
        {
            R_repository = reservaRepo;
           
            InitializeComponent();
        }
        private void CtrAgregarReserva_Load(object sender, EventArgs e)
        {

        }
        private void btnHacerReserva_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreCliente.Text == "")
                {
                    MessageBox.Show("Por favor, ingrese el nombre del cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var reserva = new SistemaFacturacion.Models.Entities.Reserva
               {
                   
                nombre = txtNombreCliente.Text,
                   fecha = dtpFecha.Value,
                   precio = 200, 
                   estado = true 
               };
                R_repository.HacerReserva(reserva);
                MessageBox.Show("Reserva registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la reserva:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


