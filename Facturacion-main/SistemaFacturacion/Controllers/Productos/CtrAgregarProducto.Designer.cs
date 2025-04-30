namespace SistemaFacturacion.Controllers.Productos
{
    partial class CtrAgregarProducto
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            textNombre = new TextBox();
            textDescripcion = new TextBox();
            label2 = new Label();
            textCantidad = new TextBox();
            label3 = new Label();
            textPrecio = new TextBox();
            Precio = new Label();
            label4 = new Label();
            agregarProductoPanel = new Panel();
            agregarProductoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(271, 85);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // button1
            // 
            button1.Location = new Point(449, 395);
            button1.Name = "button1";
            button1.Size = new Size(153, 101);
            button1.TabIndex = 1;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(250, 103);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(100, 23);
            textNombre.TabIndex = 2;
            // 
            // textDescripcion
            // 
            textDescripcion.Location = new Point(403, 103);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(100, 23);
            textDescripcion.TabIndex = 4;
            textDescripcion.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 9;
            // 
            // textCantidad
            // 
            textCantidad.Location = new Point(703, 103);
            textCantidad.Name = "textCantidad";
            textCantidad.Size = new Size(100, 23);
            textCantidad.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(724, 85);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 7;
            label3.Text = "Cantidad";
            // 
            // textPrecio
            // 
            textPrecio.Location = new Point(550, 103);
            textPrecio.Name = "textPrecio";
            textPrecio.Size = new Size(100, 23);
            textPrecio.TabIndex = 6;
            // 
            // Precio
            // 
            Precio.AutoSize = true;
            Precio.Location = new Point(571, 85);
            Precio.Name = "Precio";
            Precio.Size = new Size(40, 15);
            Precio.TabIndex = 5;
            Precio.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(418, 85);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 10;
            label4.Text = "Descripcion";
            // 
            // agregarProductoPanel
            // 
            agregarProductoPanel.Controls.Add(button1);
            agregarProductoPanel.Controls.Add(label4);
            agregarProductoPanel.Controls.Add(textNombre);
            agregarProductoPanel.Controls.Add(textCantidad);
            agregarProductoPanel.Controls.Add(label1);
            agregarProductoPanel.Controls.Add(label3);
            agregarProductoPanel.Controls.Add(textDescripcion);
            agregarProductoPanel.Controls.Add(textPrecio);
            agregarProductoPanel.Controls.Add(Precio);
            agregarProductoPanel.Dock = DockStyle.Fill;
            agregarProductoPanel.Location = new Point(0, 0);
            agregarProductoPanel.Name = "agregarProductoPanel";
            agregarProductoPanel.Size = new Size(1134, 765);
            agregarProductoPanel.TabIndex = 11;
            agregarProductoPanel.Paint += agregarProductoPanel_Paint;
            // 
            // CtrAgregarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(agregarProductoPanel);
            Controls.Add(label2);
            Name = "CtrAgregarProducto";
            Size = new Size(1134, 765);
            agregarProductoPanel.ResumeLayout(false);
            agregarProductoPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textNombre;
        private TextBox textDescripcion;
        private Label label2;
        private TextBox textCantidad;
        private Label label3;
        private TextBox textPrecio;
        private Label Precio;
        private Label label4;
        private Panel agregarProductoPanel;
        private CheckBox checkBox1;
        private TextBox textId;
    }
}
