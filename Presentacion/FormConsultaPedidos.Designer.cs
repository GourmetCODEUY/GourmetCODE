namespace proyecto.Presentacion
{
    partial class FormConsultaPedidos
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
            dgvPedidos = new DataGridView();
            btnConsultarPedido = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // dgvPedidos
            // 
            dgvPedidos.BackgroundColor = Color.FromArgb(66, 125, 125);
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(127, 12);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowTemplate.Height = 25;
            dgvPedidos.Size = new Size(643, 296);
            dgvPedidos.TabIndex = 0;
            // 
            // btnConsultarPedido
            // 
            btnConsultarPedido.BackColor = Color.SkyBlue;
            btnConsultarPedido.Location = new Point(418, 314);
            btnConsultarPedido.Name = "btnConsultarPedido";
            btnConsultarPedido.Size = new Size(75, 23);
            btnConsultarPedido.TabIndex = 1;
            btnConsultarPedido.Text = "Pedido";
            btnConsultarPedido.UseVisualStyleBackColor = false;
            btnConsultarPedido.Click += btnConsultarPedido_Click;
            // 
            // FormConsultaPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 125, 125);
            ClientSize = new Size(908, 556);
            Controls.Add(btnConsultarPedido);
            Controls.Add(dgvPedidos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormConsultaPedidos";
            Text = "FormCosultaPedidos";
            Load += FormConsultaPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPedidos;
        private Button btnConsultarPedido;
    }
}