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
            textPassword.UseSystemPasswordChar = true;

            this.AcceptButton = button1;
            this.FormClosing += LoginForm_FormClosing;
        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (this.DialogResult != DialogResult.OK)
            {
                Application.Exit();
            }
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

              
                var empleado = _repository.Autenticar(username, password);

                if (empleado == null)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
              


                this.Tag = empleado; 
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
