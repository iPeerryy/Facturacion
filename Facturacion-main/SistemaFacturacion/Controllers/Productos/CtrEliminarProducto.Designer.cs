namespace SistemaFacturacion.Controllers.Productos
{
    partial class CtrEliminarProducto
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
            DGVListarProducto = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            btnListar = new Button();
            btnEliminar = new Button();
            txtID = new TextBox();
            lblEliminar = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVListarProducto).BeginInit();
            SuspendLayout();
            // 
            // DGVListarProducto
            // 
            DGVListarProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVListarProducto.Columns.AddRange(new DataGridViewColumn[] { id, nombre, precio });
            DGVListarProducto.Location = new Point(84, 95);
            DGVListarProducto.Name = "DGVListarProducto";
            DGVListarProducto.Size = new Size(744, 575);
            DGVListarProducto.TabIndex = 21;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            // 
            // precio
            // 
            precio.HeaderText = "PRECIO";
            precio.Name = "precio";
            // 
            // btnListar
            // 
            btnListar.Location = new Point(898, 381);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(153, 101);
            btnListar.TabIndex = 20;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(898, 244);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(153, 101);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(922, 187);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 18;
            // 
            // lblEliminar
            // 
            lblEliminar.AutoSize = true;
            lblEliminar.Location = new Point(955, 150);
            lblEliminar.Name = "lblEliminar";
            lblEliminar.Size = new Size(18, 15);
            lblEliminar.TabIndex = 19;
            lblEliminar.Text = "ID";
            // 
            // CtrEliminarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DGVListarProducto);
            Controls.Add(btnListar);
            Controls.Add(btnEliminar);
            Controls.Add(txtID);
            Controls.Add(lblEliminar);
            Name = "CtrEliminarProducto";
            Size = new Size(1134, 765);
            ((System.ComponentModel.ISupportInitialize)DGVListarProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGVListarProducto;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn precio;
        private Button btnListar;
        private Button btnEliminar;
        private TextBox txtID;
        private Label lblEliminar;
    }
}
