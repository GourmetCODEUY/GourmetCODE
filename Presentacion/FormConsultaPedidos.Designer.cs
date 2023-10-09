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
            ID_Pedido = new DataGridViewTextBoxColumn();
            Desc_Pedido = new DataGridViewTextBoxColumn();
            Calle_Cliente = new DataGridViewTextBoxColumn();
            Puerta_Cliente = new DataGridViewTextBoxColumn();
            Zona_Cliente = new DataGridViewTextBoxColumn();
            Barrio_Cliente = new DataGridViewTextBoxColumn();
            btnConsultarPedido = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // dgvPedidos
            // 
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Columns.AddRange(new DataGridViewColumn[] { ID_Pedido, Desc_Pedido, Calle_Cliente, Puerta_Cliente, Zona_Cliente, Barrio_Cliente });
            dgvPedidos.Location = new Point(140, 12);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowTemplate.Height = 25;
            dgvPedidos.Size = new Size(642, 296);
            dgvPedidos.TabIndex = 0;
            // 
            // ID_Pedido
            // 
            ID_Pedido.HeaderText = "Id del pedido";
            ID_Pedido.Name = "ID_Pedido";
            // 
            // Desc_Pedido
            // 
            Desc_Pedido.HeaderText = "Descripcion del pedido";
            Desc_Pedido.Name = "Desc_Pedido";
            // 
            // Calle_Cliente
            // 
            Calle_Cliente.HeaderText = "Calle del cliente";
            Calle_Cliente.Name = "Calle_Cliente";
            // 
            // Puerta_Cliente
            // 
            Puerta_Cliente.HeaderText = "Puerta del cliente";
            Puerta_Cliente.Name = "Puerta_Cliente";
            // 
            // Zona_Cliente
            // 
            Zona_Cliente.HeaderText = "Zona del cliente";
            Zona_Cliente.Name = "Zona_Cliente";
            // 
            // Barrio_Cliente
            // 
            Barrio_Cliente.HeaderText = "Barrio del cliente";
            Barrio_Cliente.Name = "Barrio_Cliente";
            // 
            // btnConsultarPedido
            // 
            btnConsultarPedido.Location = new Point(418, 314);
            btnConsultarPedido.Name = "btnConsultarPedido";
            btnConsultarPedido.Size = new Size(75, 23);
            btnConsultarPedido.TabIndex = 1;
            btnConsultarPedido.Text = "Pedido";
            btnConsultarPedido.UseVisualStyleBackColor = true;
            btnConsultarPedido.Click += btnConsultarPedido_Click;
            // 
            // FormConsultaPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
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
        private DataGridViewTextBoxColumn ID_Pedido;
        private DataGridViewTextBoxColumn Desc_Pedido;
        private DataGridViewTextBoxColumn Calle_Cliente;
        private DataGridViewTextBoxColumn Puerta_Cliente;
        private DataGridViewTextBoxColumn Zona_Cliente;
        private DataGridViewTextBoxColumn Barrio_Cliente;
    }
}