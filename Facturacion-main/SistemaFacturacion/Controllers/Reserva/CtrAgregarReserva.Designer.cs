namespace SistemaFacturacion.Controllers.Reserva
{
    partial class CtrAgregarReserva
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
            dtpFecha = new DateTimePicker();
            dtpHora = new DateTimePicker();
            txtCedulaCliente = new TextBox();
            btnHacerReserva = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(134, 92);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 0;
            // 
            // dtpHora
            // 
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(369, 92);
            dtpHora.Name = "dtpHora";
            dtpHora.Size = new Size(200, 23);
            dtpHora.TabIndex = 1;
            // 
            // txtCedulaCliente
            // 
            txtCedulaCliente.Location = new Point(618, 92);
            txtCedulaCliente.Name = "txtCedulaCliente";
            txtCedulaCliente.Size = new Size(100, 23);
            txtCedulaCliente.TabIndex = 2;
            // 
            // btnHacerReserva
            // 
            btnHacerReserva.Location = new Point(377, 305);
            btnHacerReserva.Name = "btnHacerReserva";
            btnHacerReserva.Size = new Size(192, 86);
            btnHacerReserva.TabIndex = 3;
            btnHacerReserva.Text = "Hacer Reserva";
            btnHacerReserva.UseVisualStyleBackColor = true;
            btnHacerReserva.Click += btnHacerReserva_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 60);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(440, 60);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 5;
            label2.Text = "Hora";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(642, 60);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 6;
            label3.Text = "Cédula";
            // 
            // CtrAgregarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnHacerReserva);
            Controls.Add(txtCedulaCliente);
            Controls.Add(dtpHora);
            Controls.Add(dtpFecha);
            Name = "CtrAgregarReserva";
            Size = new Size(1130, 651);
            Load += CtrAgregarReserva_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFecha;
        private DateTimePicker dtpHora;
        private TextBox txtCedulaCliente;
        private Button btnHacerReserva;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
