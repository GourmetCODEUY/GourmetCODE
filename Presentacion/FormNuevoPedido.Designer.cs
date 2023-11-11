namespace proyecto.Presentacion
{
    partial class FormNuevoPedido
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
            btnEnviar = new Button();
            txtDescPedido = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dgvComidas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvComidas).BeginInit();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.SkyBlue;
            btnEnviar.Location = new Point(821, 521);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 10;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtDescPedido
            // 
            txtDescPedido.Location = new Point(143, 61);
            txtDescPedido.Name = "txtDescPedido";
            txtDescPedido.Size = new Size(100, 23);
            txtDescPedido.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(143, 43);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 12;
            label1.Text = "Descripcion del pedido";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 14;
            label2.Text = "Numero de cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(307, 44);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 16;
            label3.Text = "Comidas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(244, 23);
            label4.TabIndex = 17;
            label4.Text = "MENU PERSONALIZADO";
            // 
            // dgvComidas
            // 
            dgvComidas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvComidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComidas.Location = new Point(316, 68);
            dgvComidas.Name = "dgvComidas";
            dgvComidas.RowTemplate.Height = 25;
            dgvComidas.Size = new Size(240, 150);
            dgvComidas.TabIndex = 18;
            // 
            // FormNuevoPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 125, 125);
            ClientSize = new Size(908, 556);
            Controls.Add(dgvComidas);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(txtDescPedido);
            Controls.Add(btnEnviar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormNuevoPedido";
            Text = "FormNuevoPedido";
            Load += FormNuevoPedido_Load;
            ((System.ComponentModel.ISupportInitialize)dgvComidas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEnviar;
        private TextBox txtDescPedido;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvComidas;
    }
}