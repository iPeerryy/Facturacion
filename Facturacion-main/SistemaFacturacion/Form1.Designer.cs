namespace SistemaFacturacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnAgregarReserva = new Button();
            btnEliminar = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            label2 = new Label();
            panelReemplazable = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(206, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(917, 58);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 19);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 0;
            label1.Text = "Seleccione";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAgregarReserva);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(206, 609);
            panel2.TabIndex = 1;
            // 
            // btnAgregarReserva
            // 
            btnAgregarReserva.Dock = DockStyle.Top;
            btnAgregarReserva.Location = new Point(0, 264);
            btnAgregarReserva.Name = "btnAgregarReserva";
            btnAgregarReserva.Size = new Size(206, 55);
            btnAgregarReserva.TabIndex = 7;
            btnAgregarReserva.Text = "Agregar Reserva";
            btnAgregarReserva.UseVisualStyleBackColor = true;
            btnAgregarReserva.Click += btnAgregarReserva_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Dock = DockStyle.Top;
            btnEliminar.Location = new Point(0, 209);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(206, 55);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar Producto";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.Location = new Point(0, 154);
            button3.Name = "button3";
            button3.Size = new Size(206, 55);
            button3.TabIndex = 4;
            button3.Text = "Actualizar Producto";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(0, 99);
            button2.Name = "button2";
            button2.Size = new Size(206, 55);
            button2.TabIndex = 3;
            button2.Text = "Abastecer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 44);
            button1.Name = "button1";
            button1.Size = new Size(206, 55);
            button1.TabIndex = 2;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(206, 44);
            panel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 12);
            label2.Name = "label2";
            label2.Size = new Size(101, 23);
            label2.TabIndex = 0;
            label2.Text = "Productos";
            label2.Click += label2_Click;
            // 
            // panelReemplazable
            // 
            panelReemplazable.Dock = DockStyle.Fill;
            panelReemplazable.Location = new Point(206, 58);
            panelReemplazable.Name = "panelReemplazable";
            panelReemplazable.Size = new Size(917, 551);
            panelReemplazable.TabIndex = 2;
            panelReemplazable.Paint += panelReemplazable_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 609);
            Controls.Add(panelReemplazable);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Cafetería ";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Button button1;
        private Panel panelReemplazable;
        private Button button2;
        private Button button3;
        private Button btnEliminar;
        private Button btnAgregarReserva;
    }
}
