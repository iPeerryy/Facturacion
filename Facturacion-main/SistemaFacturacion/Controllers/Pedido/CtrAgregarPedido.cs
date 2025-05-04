using Facturacion.Models.Repositories;
using SistemaFacturacion.Models.Entities;
using SistemaFacturacion.Models.Repositories;

namespace SistemaFacturacion.Controllers.Pedido
{
    public partial class CtrAgregarPedido : UserControl
    {
        private readonly PedidoRepository _pedidoRepository;
        private readonly ProductoRepository _productoRepository;
        private readonly EmpleadoRepository _empleadoRepository;
        private readonly ReservaRepository _reservaRepository;

        private List<ProductoPedido> carrito = new();
        private PedidoRepository p_repository;
        private ProductoRepository repository;
        private EmpleadoRepository e_repository;
        private ReservaRepository r_repository;
        private readonly Empleado _empleadoActual;
        public CtrAgregarPedido(PedidoRepository pedidoRepo, ProductoRepository productoRepo, EmpleadoRepository empleadoRepo, ReservaRepository reservaRepo, Empleado empleadoActual)
        {
            _pedidoRepository = pedidoRepo;
            _productoRepository = productoRepo;
            _empleadoRepository = empleadoRepo;
            _reservaRepository = reservaRepo;
            InitializeComponent();
            _empleadoActual = empleadoActual;
        }

        

        private void btnAgregarAlCarrito_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Producto agregado al carrito." + _empleadoActual.cedula);
            var producto = (Producto)comboBoxProducto.SelectedItem;
            int cantidad = (int)numericUpDownCantidad.Value;

            carrito.Add(new ProductoPedido
            {
                ProductoId = producto.id,
                Producto = producto,
                Cantidad = cantidad
            });

            MostrarCarrito();
        }
        private void MostrarCarrito()
        {
            dataGridViewCarrito.Rows.Clear();
            foreach (var pp in carrito)
            {
                dataGridViewCarrito.Rows.Add(pp.Producto.nombre, pp.Cantidad);
            }
        }

        private void btnGuardarPedido_Click(object sender, EventArgs e)
        {
            
           
            var pedido = new SistemaFacturacion.Models.Entities.Pedido
            {
                
                Fecha = DateTime.Now,
                Hora = DateTime.Now.TimeOfDay,
                Total = carrito.Sum(p => p.Producto.precio * p.Cantidad),
                Productos = carrito,
                Empleado = _empleadoActual,
                EmpleadoCedula = _empleadoActual.cedula,
                estatusReserva = checkBoxReserva.Checked,
            };

            foreach (var productoPedido in carrito)
            {
                var producto = _productoRepository.ObtenerPorId(productoPedido.ProductoId);
                if (producto.cantidad >= productoPedido.Cantidad)
                {
                    producto.cantidad -= productoPedido.Cantidad;
                    _productoRepository.ActualizarProducto(producto);
                }
                else
                {
                    MessageBox.Show($"No hay suficiente stock para el producto: {producto.nombre}");
                    return;
                }
            }

            if (_pedidoRepository == null)
            {
                MessageBox.Show("El repositorio de pedidos no está inicializado.");
                return;
            }
            _pedidoRepository.AgregarPedido(pedido);
            MessageBox.Show("Pedido guardado con éxito.");
            carrito.Clear();
            MostrarCarrito();
        }

        private void CargarProductos_Click(object sender, EventArgs e)
        {
            var productos = _productoRepository.ObtenerTodos();

            if (productos != null && productos.Any())
            {
                comboBoxProducto.DataSource = productos;
                comboBoxProducto.DisplayMember = "nombre";
                comboBoxProducto.ValueMember = "id";


                dataGridViewCarrito.Columns.Clear();
                dataGridViewCarrito.Columns.Add("NombreProducto", "Producto");
                dataGridViewCarrito.Columns.Add("Cantidad", "Cantidad");
            }
            else
            {
                MessageBox.Show("No se encontraron productos.");
            }
        }

        public void CargarProductos()
        {
            var productos = _productoRepository.ObtenerTodos();

            if (productos != null && productos.Any())
            {
                comboBoxProducto.DataSource = productos;
                comboBoxProducto.DisplayMember = "nombre";
                comboBoxProducto.ValueMember = "id";


                dataGridViewCarrito.Columns.Clear();
                dataGridViewCarrito.Columns.Add("NombreProducto", "Producto");
                dataGridViewCarrito.Columns.Add("Cantidad", "Cantidad");
            }
            else
            {
                MessageBox.Show("No se encontraron productos.");
            }
        }

        

        

        private void CtrAgregarPedido_Load(object sender, EventArgs e)
        {

        }
    }
}

