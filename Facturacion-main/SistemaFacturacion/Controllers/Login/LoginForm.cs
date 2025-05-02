using SistemaFacturacion.Models.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion.Controllers.Login
{
    public partial class LoginForm : Form
    {
        
            private readonly EmpleadoRepository _repository;
        public LoginForm(EmpleadoRepository repository)
        {
            _repository = repository;
            InitializeComponent();
        }

        
       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textUsername.Text.Trim();
                string password = textPassword.Text.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Por favor, ingrese el nombre de usuario y la contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Authenticate the user
                var empleado = _repository.Autenticar(username, password);

                if (empleado == null)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // If authentication is successful, close the form with DialogResult.OK
              
                this.Tag = empleado; // Pass the authenticated employee to the main form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
