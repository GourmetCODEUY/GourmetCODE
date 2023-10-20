namespace proyecto.Presentacion
{
    partial class FormPedidos
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
            btnModificacionPedido = new Button();
            btnNuevoPedido = new Button();
            btnEliminarPedido = new Button();
            btnConsultaCliente = new Button();
            btnPedidos = new Button();
            SuspendLayout();
            // 
            // btnModificacionPedido
            // 
            btnModificacionPedido.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            btnModificacionPedido.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnModificacionPedido.FlatStyle = FlatStyle.Flat;
            btnModificacionPedido.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificacionPedido.ForeColor = Color.White;
            btnModificacionPedido.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificacionPedido.Location = new Point(89, 79);
            btnModificacionPedido.Name = "btnModificacionPedido";
            btnModificacionPedido.Size = new Size(233, 51);
            btnModificacionPedido.TabIndex = 7;
            btnModificacionPedido.Text = "Modificacion";
            btnModificacionPedido.UseVisualStyleBackColor = true;
            btnModificacionPedido.Click += btnModificacionPedido_Click;
            // 
            // btnNuevoPedido
            // 
            btnNuevoPedido.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            btnNuevoPedido.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnNuevoPedido.FlatStyle = FlatStyle.Flat;
            btnNuevoPedido.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoPedido.ForeColor = Color.White;
            btnNuevoPedido.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoPedido.Location = new Point(328, 79);
            btnNuevoPedido.Name = "btnNuevoPedido";
            btnNuevoPedido.Size = new Size(233, 51);
            btnNuevoPedido.TabIndex = 8;
            btnNuevoPedido.Text = "Nuevo";
            btnNuevoPedido.UseVisualStyleBackColor = true;
            btnNuevoPedido.Click += btnNuevoPedido_Click;
            // 
            // btnEliminarPedido
            // 
            btnEliminarPedido.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            btnEliminarPedido.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnEliminarPedido.FlatStyle = FlatStyle.Flat;
            btnEliminarPedido.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarPedido.ForeColor = Color.White;
            btnEliminarPedido.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarPedido.Location = new Point(567, 79);
            btnEliminarPedido.Name = "btnEliminarPedido";
            btnEliminarPedido.Size = new Size(233, 51);
            btnEliminarPedido.TabIndex = 9;
            btnEliminarPedido.Text = "Eliminar";
            btnEliminarPedido.UseVisualStyleBackColor = true;
            btnEliminarPedido.Click += btnEliminarPedido_Click;
            // 
            // btnConsultaCliente
            // 
            btnConsultaCliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            btnConsultaCliente.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnConsultaCliente.FlatStyle = FlatStyle.Flat;
            btnConsultaCliente.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultaCliente.ForeColor = Color.White;
            btnConsultaCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultaCliente.Location = new Point(89, 287);
            btnConsultaCliente.Name = "btnConsultaCliente";
            btnConsultaCliente.Size = new Size(233, 51);
            btnConsultaCliente.TabIndex = 10;
            btnConsultaCliente.Text = "Consultar pedidos";
            btnConsultaCliente.UseVisualStyleBackColor = true;
            btnConsultaCliente.Click += btnConsultaCliente_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            btnPedidos.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnPedidos.FlatStyle = FlatStyle.Flat;
            btnPedidos.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnPedidos.ForeColor = Color.White;
            btnPedidos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPedidos.Location = new Point(89, 136);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(233, 51);
            btnPedidos.TabIndex = 11;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // FormPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(66, 125, 125);
            ClientSize = new Size(908, 556);
            Controls.Add(btnPedidos);
            Controls.Add(btnConsultaCliente);
            Controls.Add(btnEliminarPedido);
            Controls.Add(btnNuevoPedido);
            Controls.Add(btnModificacionPedido);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPedidos";
            Text = "FormPedidos";
            Load += FormPedidos_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnModificacionPedido;
        private Button btnNuevoPedido;
        private Button btnEliminarPedido;
        private Button btnConsultaCliente;
        private Button btnPedidos;
    }
}