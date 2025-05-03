using Facturacion.Models.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SistemaFacturacion.Controllers.Clientes;
using SistemaFacturacion.Controllers.Login;
using SistemaFacturacion.Controllers.Productos;
using SistemaFacturacion.Controllers.Reserva;
using SistemaFacturacion.Models.Context;
using SistemaFacturacion.Models.Entities;
using SistemaFacturacion.Models.Repositories;


namespace SistemaFacturacion
{
    public partial class Form1 : Form
    {
        private readonly CafeteriaContext _dbContext;
        private readonly ProductoRepository _repository;
        private readonly ReservaRepository R_repository;
        private readonly ClienteRepository repository;
        private readonly ClienteRepository C_repository;
        private readonly EmpleadoRepository E_repository;



        public Form1(EmpleadoRepository empleadorepository)
        {
            InitializeComponent();
            E_repository= empleadorepository;

            var loginForm = new LoginForm(E_repository);
            if (loginForm.ShowDialog() != DialogResult.OK)
            {
                
                Application.Exit();
                return;
            }
            var empleado = (Empleado)loginForm.Tag;

            MessageBox.Show($"Bienvenido, {empleado.nombre}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var options = new DbContextOptionsBuilder<CafeteriaContext>()
               .UseSqlServer("Server=(localdb)\\localDB;Database=CafeteriaDB;Trusted_Connection=True;Integrated Security=True")
               .Options;
            _dbContext = new CafeteriaContext(options);
            _repository = new ProductoRepository(_dbContext);
            repository = new ClienteRepository(_dbContext);
            C_repository = new ClienteRepository(_dbContext);
            R_repository = new ReservaRepository(_dbContext);
            E_repository = new EmpleadoRepository(_dbContext);

        }
      
        private void CargarControladorEnPanel(UserControl controlador)
        {
            controlador.Dock = DockStyle.Fill;
            panelReemplazable.Controls.Clear();
            panelReemplazable.Controls.Add(controlador);
            controlador.BringToFront();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CtrAgregarProducto ctrAgregarProducto = new CtrAgregarProducto(_repository);
            CargarControladorEnPanel(ctrAgregarProducto);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CtrAbastecerProducto ctrAbastecerProducto = new CtrAbastecerProducto(_repository);
            CargarControladorEnPanel(ctrAbastecerProducto);
        }

        private void panelReemplazable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CtrActualizarProducto ctrActualizarProducto = new CtrActualizarProducto(_repository);
            CargarControladorEnPanel(ctrActualizarProducto);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CtrEliminarProducto ctrEliminarProducto = new CtrEliminarProducto(_repository);
            CargarControladorEnPanel(ctrEliminarProducto);
        }

      

        private void btnAgregarReserva_Click(object sender, EventArgs e)
        {
            CtrAgregarReserva ctrAgregarReserva = new CtrAgregarReserva(R_repository);
            CargarControladorEnPanel(ctrAgregarReserva);
        }

        private void panelPrimario_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
