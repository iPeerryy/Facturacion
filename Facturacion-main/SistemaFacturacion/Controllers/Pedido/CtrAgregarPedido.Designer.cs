namespace SistemaFacturacion.Controllers.Pedido
{
    partial class CtrAgregarPedido
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            numericUpDownCantidad = new NumericUpDown();
            dataGridViewCarrito = new DataGridView();
            btnAgregarAlCarrito = new Button();
            btnGuardarPedido = new Button();
            comboBoxProducto = new ComboBox();
            checkBoxReserva = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrito).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownCantidad
            // 
            numericUpDownCantidad.Location = new Point(611, 136);
            numericUpDownCantidad.Name = "numericUpDownCantidad";
            numericUpDownCantidad.Size = new Size(120, 23);
            numericUpDownCantidad.TabIndex = 1;
            // 
            // dataGridViewCarrito
            // 
            dataGridViewCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCarrito.Location = new Point(19, 45);
            dataGridViewCarrito.Name = "dataGridViewCarrito";
            dataGridViewCarrito.Size = new Size(311, 440);
            dataGridViewCarrito.TabIndex = 2;
            // 
            // btnAgregarAlCarrito
            // 
            btnAgregarAlCarrito.Location = new Point(558, 291);
            btnAgregarAlCarrito.Name = "btnAgregarAlCarrito";
            btnAgregarAlCarrito.Size = new Size(131, 50);
            btnAgregarAlCarrito.TabIndex = 3;
            btnAgregarAlCarrito.Text = "AgregarAlCarrito";
            btnAgregarAlCarrito.UseVisualStyleBackColor = true;
            btnAgregarAlCarrito.Click += btnAgregarAlCarrito_Click;
            // 
            // btnGuardarPedido
            // 
            btnGuardarPedido.Location = new Point(392, 291);
            btnGuardarPedido.Name = "btnGuardarPedido";
            btnGuardarPedido.Size = new Size(142, 50);
            btnGuardarPedido.TabIndex = 4;
            btnGuardarPedido.Text = "GuardarPedido";
            btnGuardarPedido.UseVisualStyleBackColor = true;
            btnGuardarPedido.Click += btnGuardarPedido_Click;
            // 
            // comboBoxProducto
            // 
            comboBoxProducto.FormattingEnabled = true;
            comboBoxProducto.Location = new Point(360, 136);
            comboBoxProducto.Name = "comboBoxProducto";
            comboBoxProducto.Size = new Size(215, 23);
            comboBoxProducto.TabIndex = 7;
            // 
            // checkBoxReserva
            // 
            checkBoxReserva.AutoSize = true;
            checkBoxReserva.Location = new Point(499, 413);
            checkBoxReserva.Name = "checkBoxReserva";
            checkBoxReserva.Size = new Size(103, 19);
            checkBoxReserva.TabIndex = 10;
            checkBoxReserva.Text = "Reservó mesa?";
            checkBoxReserva.UseVisualStyleBackColor = true;
            // 
            // CtrAgregarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(checkBoxReserva);
            Controls.Add(comboBoxProducto);
            Controls.Add(btnGuardarPedido);
            Controls.Add(btnAgregarAlCarrito);
            Controls.Add(dataGridViewCarrito);
            Controls.Add(numericUpDownCantidad);
            Name = "CtrAgregarPedido";
            Size = new Size(917, 551);
            Load += CtrAgregarPedido_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown numericUpDownCantidad;
        private DataGridView dataGridViewCarrito;
        private Button btnAgregarAlCarrito;
        private Button btnGuardarPedido;
        private ComboBox comboBoxProducto;
        private CheckBox checkBoxReserva;
    }
}
