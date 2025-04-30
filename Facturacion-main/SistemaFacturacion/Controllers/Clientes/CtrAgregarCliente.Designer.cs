namespace SistemaFacturacion.Controllers.Clientes
{
    partial class CtrAgregarCliente
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
            btnAgregarCliente = new Button();
            textCedula = new TextBox();
            textNombre = new TextBox();
            lblCedula = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(387, 284);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(222, 67);
            btnAgregarCliente.TabIndex = 0;
            btnAgregarCliente.Text = "Agregar";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // textCedula
            // 
            textCedula.Location = new Point(319, 132);
            textCedula.Name = "textCedula";
            textCedula.Size = new Size(100, 23);
            textCedula.TabIndex = 1;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(588, 132);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(100, 23);
            textNombre.TabIndex = 2;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(346, 73);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(44, 15);
            lblCedula.TabIndex = 3;
            lblCedula.Text = "Cedula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(612, 73);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // CtrAgregarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(lblCedula);
            Controls.Add(textNombre);
            Controls.Add(textCedula);
            Controls.Add(btnAgregarCliente);
            Name = "CtrAgregarCliente";
            Size = new Size(1130, 651);
            Load += CtrAgregarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarCliente;
        private TextBox textCedula;
        private TextBox textNombre;
        private Label lblCedula;
        private Label label2;
    }
}
