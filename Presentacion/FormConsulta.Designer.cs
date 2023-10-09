namespace proyecto.Presentacion
{
    partial class FormConsulta
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnProducto = new Button();
            btnPedidos = new Button();
            btnProduccion = new Button();
            SuspendLayout();
            // 
            // btnProducto
            // 
            btnProducto.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            btnProducto.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnProducto.FlatStyle = FlatStyle.Flat;
            btnProducto.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnProducto.ForeColor = Color.White;
            btnProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducto.Location = new Point(54, 235);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(233, 51);
            btnProducto.TabIndex = 4;
            btnProducto.Text = "Producto";
            btnProducto.UseVisualStyleBackColor = true;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            btnPedidos.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnPedidos.FlatStyle = FlatStyle.Flat;
            btnPedidos.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnPedidos.ForeColor = Color.White;
            btnPedidos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPedidos.Location = new Point(331, 235);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(233, 51);
            btnPedidos.TabIndex = 5;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // btnProduccion
            // 
            btnProduccion.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            btnProduccion.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnProduccion.FlatStyle = FlatStyle.Flat;
            btnProduccion.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnProduccion.ForeColor = Color.White;
            btnProduccion.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduccion.Location = new Point(607, 235);
            btnProduccion.Name = "btnProduccion";
            btnProduccion.Size = new Size(233, 51);
            btnProduccion.TabIndex = 6;
            btnProduccion.Text = "Produccion";
            btnProduccion.UseVisualStyleBackColor = true;
            btnProduccion.Click += btnProduccion_Click;
            // 
            // FormConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(924, 595);
            Controls.Add(btnProduccion);
            Controls.Add(btnPedidos);
            Controls.Add(btnProducto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormConsulta";
            Text = "FormConsulta";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProducto;
        private Button btnPedidos;
        private Button btnProduccion;
    }
}