namespace SistemaFacturacion.Controllers.Productos
{
    partial class CtrAbastecerProducto
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
            AbasterProductoPanel = new Panel();
            ActualizarBtn = new Button();
            label4 = new Label();
            textCantidad = new TextBox();
            label1 = new Label();
            textId = new TextBox();
            AbasterProductoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AbasterProductoPanel
            // 
            AbasterProductoPanel.Controls.Add(ActualizarBtn);
            AbasterProductoPanel.Controls.Add(label4);
            AbasterProductoPanel.Controls.Add(textCantidad);
            AbasterProductoPanel.Controls.Add(label1);
            AbasterProductoPanel.Controls.Add(textId);
            AbasterProductoPanel.Dock = DockStyle.Fill;
            AbasterProductoPanel.Location = new Point(0, 0);
            AbasterProductoPanel.Name = "AbasterProductoPanel";
            AbasterProductoPanel.Size = new Size(1130, 651);
            AbasterProductoPanel.TabIndex = 0;
            AbasterProductoPanel.Paint += Abaster_Paint;
            // 
            // ActualizarBtn
            // 
            ActualizarBtn.Location = new Point(330, 328);
            ActualizarBtn.Name = "ActualizarBtn";
            ActualizarBtn.Size = new Size(285, 114);
            ActualizarBtn.TabIndex = 8;
            ActualizarBtn.Text = "Actualizar";
            ActualizarBtn.UseVisualStyleBackColor = true;
            ActualizarBtn.Click += ActualizarBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(520, 134);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 7;
            label4.Text = "Cantidad";
            // 
            // textCantidad
            // 
            textCantidad.Location = new Point(489, 161);
            textCantidad.Name = "textCantidad";
            textCantidad.Size = new Size(100, 23);
            textCantidad.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(373, 134);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 1;
            label1.Text = "Id";
            // 
            // textId
            // 
            textId.Location = new Point(340, 161);
            textId.Name = "textId";
            textId.Size = new Size(100, 23);
            textId.TabIndex = 0;
            // 
            // CtrAbastecerProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AbasterProductoPanel);
            Name = "CtrAbastecerProducto";
            Size = new Size(1130, 651);
            AbasterProductoPanel.ResumeLayout(false);
            AbasterProductoPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel AbasterProductoPanel;
        private Label label1;
        private TextBox textId;
        private Button ActualizarBtn;
        private Label label4;
        private TextBox textCantidad;
    }
}
