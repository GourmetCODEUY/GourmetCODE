namespace proyecto.Presentacion
{
    partial class FormConsultaCliente
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
            dgvSuPedido = new DataGridView();
            label1 = new Label();
            btnConsultarPedidos = new Button();
            txtNumCliente = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSuPedido).BeginInit();
            SuspendLayout();
            // 
            // dgvSuPedido
            // 
            dgvSuPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuPedido.Location = new Point(108, 35);
            dgvSuPedido.Name = "dgvSuPedido";
            dgvSuPedido.ReadOnly = true;
            dgvSuPedido.RowTemplate.Height = 25;
            dgvSuPedido.Size = new Size(735, 254);
            dgvSuPedido.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(406, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 23);
            label1.TabIndex = 2;
            label1.Text = "Sus Pedidos";
            // 
            // btnConsultarPedidos
            // 
            btnConsultarPedidos.BackColor = Color.SkyBlue;
            btnConsultarPedidos.Location = new Point(504, 321);
            btnConsultarPedidos.Name = "btnConsultarPedidos";
            btnConsultarPedidos.Size = new Size(118, 23);
            btnConsultarPedidos.TabIndex = 3;
            btnConsultarPedidos.Text = "Consultar Pedidos";
            btnConsultarPedidos.UseVisualStyleBackColor = false;
            btnConsultarPedidos.Click += btnConsultarPedidos_Click;
            // 
            // txtNumCliente
            // 
            txtNumCliente.Location = new Point(338, 321);
            txtNumCliente.Name = "txtNumCliente";
            txtNumCliente.Size = new Size(100, 23);
            txtNumCliente.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(338, 299);
            label2.Name = "label2";
            label2.Size = new Size(120, 19);
            label2.TabIndex = 5;
            label2.Text = "Numero de cliente";
            // 
            // FormConsultaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 125, 125);
            ClientSize = new Size(924, 595);
            Controls.Add(label2);
            Controls.Add(txtNumCliente);
            Controls.Add(btnConsultarPedidos);
            Controls.Add(label1);
            Controls.Add(dgvSuPedido);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormConsultaCliente";
            Text = "FormCunsultaCliente";
            ((System.ComponentModel.ISupportInitialize)dgvSuPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSuPedido;
        private Label label1;
        private Button btnConsultarPedidos;
        private TextBox txtNumCliente;
        private Label label2;
    }
}