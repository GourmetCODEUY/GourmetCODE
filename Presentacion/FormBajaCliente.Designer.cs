namespace proyecto.Presentacion
{
    partial class FormBajaCliente
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
            dgvClientes = new DataGridView();
            label1 = new Label();
            btnBorrarClientes = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(75, 32);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.Size = new Size(745, 250);
            dgvClientes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(416, 6);
            label1.Name = "label1";
            label1.Size = new Size(78, 23);
            label1.TabIndex = 2;
            label1.Text = "Clientes";
            // 
            // btnBorrarClientes
            // 
            btnBorrarClientes.BackColor = Color.SkyBlue;
            btnBorrarClientes.Location = new Point(381, 288);
            btnBorrarClientes.Name = "btnBorrarClientes";
            btnBorrarClientes.Size = new Size(130, 23);
            btnBorrarClientes.TabIndex = 3;
            btnBorrarClientes.Text = "Borrar Seleccionado";
            btnBorrarClientes.UseVisualStyleBackColor = false;
            btnBorrarClientes.Click += btnBorrarClientes_Click;
            // 
            // FormBajaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 125, 125);
            ClientSize = new Size(908, 556);
            Controls.Add(btnBorrarClientes);
            Controls.Add(label1);
            Controls.Add(dgvClientes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBajaCliente";
            Text = "FormBajaCliente";
            Load += FormBajaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private Label label1;
        private Button btnBorrarClientes;
    }
}