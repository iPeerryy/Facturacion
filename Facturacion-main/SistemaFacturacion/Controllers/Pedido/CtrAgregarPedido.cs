using Facturacion.Models.Repositories;
using SistemaFacturacion.Models.Entities;
using SistemaFacturacion.Models.Repositories;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;

namespace SistemaFacturacion.Controllers.Pedido
{
    public partial class CtrAgregarPedido : UserControl
    {
        private readonly PedidoRepository _pedidoRepository;
        private readonly ProductoRepository _productoRepository;
        private readonly Empleado _empleadoActual;

        private List<ProductoPedido> carrito = new();
        
        public CtrAgregarPedido(PedidoRepository pedidoRepo, ProductoRepository productoRepo, Empleado empleadoActual)
        {
            _pedidoRepository = pedidoRepo;
            _productoRepository = productoRepo;

            InitializeComponent();
            _empleadoActual = empleadoActual;
        }

        

        private void btnAgregarAlCarrito_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Producto agregado al carrito." );
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
            MessageBox.Show("Voy a generar el PDF...");
            string pdfPath = GenerarPDF(pedido);

            if (!string.IsNullOrEmpty(pdfPath) && File.Exists(pdfPath))
            {

                AbrirPDF(pdfPath);
                MessageBox.Show("Pedido guardado con éxito.");
            }
            else
            {
                MessageBox.Show("Error: No se pudo generar el archivo PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _pedidoRepository.ResetContext();
            MessageBox.Show("ID del pedido: " + pedido.Id);
            carrito.Clear();
            MostrarCarrito();
        }
        private string GenerarPDF(SistemaFacturacion.Models.Entities.Pedido pedido)
        {
            // Ruta de escritorio y carpeta personalizada
            string folderPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "AgregarClientes",
                "Facturas"
            );

            try
            {
                
                // Crea la carpeta si no existe
                
                Directory.CreateDirectory(@"C:\Users\Daniel\Desktop\AgregarClientes\Facturas");
                // Nombre del archivo único
                string fileName = $"Factura_{DateTime.Now:yyyyMMddHHmmss}.pdf";
                string filePath = Path.Combine(folderPath, fileName);

                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    Document document = new Document(PageSize.A4, 25, 25, 30, 30);
                    PdfWriter writer = PdfWriter.GetInstance(document, fs);
                    document.Open();

                    document.Add(new Paragraph("Detalles del Pedido", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)));
                    document.Add(new Paragraph($"Fecha: {pedido.Fecha.ToShortDateString()}"));
                    document.Add(new Paragraph($"Hora: {pedido.Hora}"));
                    document.Add(new Paragraph($"Empleado: {pedido.Empleado.nombre}"));
                    document.Add(new Paragraph(" "));

                    PdfPTable table = new PdfPTable(3);
                    table.AddCell("Producto");
                    table.AddCell("Cantidad");
                    table.AddCell("Precio");

                    foreach (var productoPedido in pedido.Productos)
                    {
                        table.AddCell(productoPedido.Producto.nombre);
                        table.AddCell(productoPedido.Cantidad.ToString());
                        table.AddCell($"${productoPedido.Producto.precio * productoPedido.Cantidad}");
                    }

                    document.Add(table);
                    document.Add(new Paragraph(" "));
                    document.Add(new Paragraph($"Total: ${pedido.Total}", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)));
                    MessageBox.Show("PDF generado correctamente en: " + filePath);
                    document.Close();
                    writer.Close();
                }

                return filePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }
        private void AbrirPDF(string filePath)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

