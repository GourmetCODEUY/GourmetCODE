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
            txtDescPedido = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtCalleCliente = new TextBox();
            cmbZonas = new ComboBox();
            label3 = new Label();
            cmbBarrios = new ComboBox();
            lblBarrio = new Label();
            btnEnviar = new Button();
            txtPuerta = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cmbDepartamentos = new ComboBox();
            SuspendLayout();
            // 
            // txtDescPedido
            // 
            txtDescPedido.Location = new Point(12, 40);
            txtDescPedido.Name = "txtDescPedido";
            txtDescPedido.Size = new Size(150, 23);
            txtDescPedido.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(150, 19);
            label1.TabIndex = 3;
            label1.Text = "Descripcion del Pedido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(629, 18);
            label2.Name = "label2";
            label2.Size = new Size(108, 19);
            label2.TabIndex = 4;
            label2.Text = "Calle del Cliente";
            // 
            // txtCalleCliente
            // 
            txtCalleCliente.Location = new Point(629, 40);
            txtCalleCliente.Name = "txtCalleCliente";
            txtCalleCliente.Size = new Size(100, 23);
            txtCalleCliente.TabIndex = 5;
            // 
            // cmbZonas
            // 
            cmbZonas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbZonas.FormattingEnabled = true;
            cmbZonas.Location = new Point(335, 40);
            cmbZonas.Name = "cmbZonas";
            cmbZonas.Size = new Size(121, 23);
            cmbZonas.TabIndex = 6;
            cmbZonas.SelectedIndexChanged += cmbZonas_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(335, 18);
            label3.Name = "label3";
            label3.Size = new Size(40, 19);
            label3.TabIndex = 7;
            label3.Text = "Zona";
            // 
            // cmbBarrios
            // 
            cmbBarrios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBarrios.FormattingEnabled = true;
            cmbBarrios.Location = new Point(482, 40);
            cmbBarrios.Name = "cmbBarrios";
            cmbBarrios.Size = new Size(121, 23);
            cmbBarrios.TabIndex = 8;
            // 
            // lblBarrio
            // 
            lblBarrio.AutoSize = true;
            lblBarrio.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBarrio.ForeColor = SystemColors.ControlLightLight;
            lblBarrio.Location = new Point(482, 18);
            lblBarrio.Name = "lblBarrio";
            lblBarrio.Size = new Size(47, 19);
            lblBarrio.TabIndex = 9;
            lblBarrio.Text = "Barrio";
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.SkyBlue;
            btnEnviar.Location = new Point(400, 239);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 10;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtPuerta
            // 
            txtPuerta.Location = new Point(759, 40);
            txtPuerta.Name = "txtPuerta";
            txtPuerta.Size = new Size(100, 23);
            txtPuerta.TabIndex = 11;
            txtPuerta.KeyPress += txtPuerta_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(759, 18);
            label4.Name = "label4";
            label4.Size = new Size(116, 19);
            label4.TabIndex = 12;
            label4.Text = "Puerta del Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(191, 18);
            label5.Name = "label5";
            label5.Size = new Size(101, 19);
            label5.TabIndex = 14;
            label5.Text = "Departamentos";
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Location = new Point(191, 40);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(121, 23);
            cmbDepartamentos.TabIndex = 13;
            cmbDepartamentos.SelectedIndexChanged += cmbDepartamentos_SelectedIndexChanged;
            // 
            // FormNuevoPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 125, 125);
            ClientSize = new Size(908, 556);
            Controls.Add(label5);
            Controls.Add(cmbDepartamentos);
            Controls.Add(label4);
            Controls.Add(txtPuerta);
            Controls.Add(btnEnviar);
            Controls.Add(lblBarrio);
            Controls.Add(cmbBarrios);
            Controls.Add(label3);
            Controls.Add(cmbZonas);
            Controls.Add(txtCalleCliente);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescPedido);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormNuevoPedido";
            Text = "FormNuevoPedido";
            Load += FormNuevoPedido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtDescPedido;
        private Label label1;
        private Label label2;
        private TextBox txtCalleCliente;
        private ComboBox cmbZonas;
        private Label label3;
        private ComboBox cmbBarrios;
        private Label lblBarrio;
        private Button btnEnviar;
        private TextBox txtPuerta;
        private Label label4;
        private Label label5;
        private ComboBox cmbDepartamentos;
    }
}