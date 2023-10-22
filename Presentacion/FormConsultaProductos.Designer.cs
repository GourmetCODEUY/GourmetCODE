namespace proyecto.Presentacion
{
    partial class FormConsultaProductos
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
            btnConsultaProducto = new Button();
            dgvConsultaProductoDeshabilitado = new DataGridView();
            label2 = new Label();
            dgvConsultaProducto = new DataGridView();
            btnGuardarCambios = new Button();
            btnConsultarProductoDeshabilitado = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaProductoDeshabilitado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaProducto).BeginInit();
            SuspendLayout();
            // 
            // btnConsultaProducto
            // 
            btnConsultaProducto.BackColor = Color.SkyBlue;
            btnConsultaProducto.Location = new Point(214, 31);
            btnConsultaProducto.Name = "btnConsultaProducto";
            btnConsultaProducto.Size = new Size(75, 23);
            btnConsultaProducto.TabIndex = 1;
            btnConsultaProducto.Text = "Consultar";
            btnConsultaProducto.UseVisualStyleBackColor = false;
            btnConsultaProducto.Click += btnConsultaProducto_Click;
            // 
            // dgvConsultaProductoDeshabilitado
            // 
            dgvConsultaProductoDeshabilitado.AllowUserToResizeColumns = false;
            dgvConsultaProductoDeshabilitado.AllowUserToResizeRows = false;
            dgvConsultaProductoDeshabilitado.BackgroundColor = Color.FromArgb(66, 125, 125);
            dgvConsultaProductoDeshabilitado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaProductoDeshabilitado.Location = new Point(466, 60);
            dgvConsultaProductoDeshabilitado.Name = "dgvConsultaProductoDeshabilitado";
            dgvConsultaProductoDeshabilitado.RowTemplate.Height = 25;
            dgvConsultaProductoDeshabilitado.Size = new Size(439, 225);
            dgvConsultaProductoDeshabilitado.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(579, 9);
            label2.Name = "label2";
            label2.Size = new Size(181, 19);
            label2.TabIndex = 5;
            label2.Text = "MENU DESHABILITADO";
            // 
            // dgvConsultaProducto
            // 
            dgvConsultaProducto.AllowUserToAddRows = false;
            dgvConsultaProducto.AllowUserToDeleteRows = false;
            dgvConsultaProducto.AllowUserToResizeColumns = false;
            dgvConsultaProducto.AllowUserToResizeRows = false;
            dgvConsultaProducto.BackgroundColor = Color.FromArgb(66, 125, 125);
            dgvConsultaProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaProducto.Location = new Point(12, 60);
            dgvConsultaProducto.Name = "dgvConsultaProducto";
            dgvConsultaProducto.RowTemplate.Height = 25;
            dgvConsultaProducto.Size = new Size(439, 225);
            dgvConsultaProducto.TabIndex = 6;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.BackColor = Color.SkyBlue;
            btnGuardarCambios.Location = new Point(401, 308);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(117, 23);
            btnGuardarCambios.TabIndex = 7;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.UseVisualStyleBackColor = false;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // btnConsultarProductoDeshabilitado
            // 
            btnConsultarProductoDeshabilitado.BackColor = Color.SkyBlue;
            btnConsultarProductoDeshabilitado.Location = new Point(630, 31);
            btnConsultarProductoDeshabilitado.Name = "btnConsultarProductoDeshabilitado";
            btnConsultarProductoDeshabilitado.Size = new Size(75, 23);
            btnConsultarProductoDeshabilitado.TabIndex = 8;
            btnConsultarProductoDeshabilitado.Text = "Consultar";
            btnConsultarProductoDeshabilitado.UseVisualStyleBackColor = false;
            btnConsultarProductoDeshabilitado.Click += btnConsultarProductoDeshabilitado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(177, 9);
            label1.Name = "label1";
            label1.Size = new Size(152, 19);
            label1.TabIndex = 9;
            label1.Text = "MENU HABILITADO";
            // 
            // FormConsultaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 125, 125);
            ClientSize = new Size(908, 556);
            Controls.Add(label1);
            Controls.Add(btnConsultarProductoDeshabilitado);
            Controls.Add(btnGuardarCambios);
            Controls.Add(dgvConsultaProducto);
            Controls.Add(label2);
            Controls.Add(dgvConsultaProductoDeshabilitado);
            Controls.Add(btnConsultaProducto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormConsultaProductos";
            Text = "FormConsultaProductos";
            Load += FormConsultaProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultaProductoDeshabilitado).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnConsultaProducto;
        private DataGridView dgvConsultaProductoDeshabilitado;
        private Label label2;
        private DataGridView dgvConsultaProducto;
        private Button btnGuardarCambios;
        private Button btnConsultarProductoDeshabilitado;
        private Label label1;
    }
}