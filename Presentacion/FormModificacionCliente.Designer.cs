namespace proyecto.Presentacion
{
    partial class FormModificacionCliente
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
            dgvClientesComun = new DataGridView();
            dgvClientesEmpresa = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btnAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientesComun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientesEmpresa).BeginInit();
            SuspendLayout();
            // 
            // dgvClientesComun
            // 
            dgvClientesComun.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientesComun.Location = new Point(12, 58);
            dgvClientesComun.Name = "dgvClientesComun";
            dgvClientesComun.RowTemplate.Height = 25;
            dgvClientesComun.Size = new Size(431, 377);
            dgvClientesComun.TabIndex = 0;
            dgvClientesComun.DataError += dgvClientesComun_DataError;
            // 
            // dgvClientesEmpresa
            // 
            dgvClientesEmpresa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientesEmpresa.Location = new Point(449, 58);
            dgvClientesEmpresa.Name = "dgvClientesEmpresa";
            dgvClientesEmpresa.RowTemplate.Height = 25;
            dgvClientesEmpresa.Size = new Size(447, 377);
            dgvClientesEmpresa.TabIndex = 1;
            dgvClientesEmpresa.DataError += dgvClientesEmpresa_DataError;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(112, 32);
            label1.Name = "label1";
            label1.Size = new Size(212, 23);
            label1.TabIndex = 2;
            label1.Text = "CLIENTES COMUNES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(560, 32);
            label2.Name = "label2";
            label2.Size = new Size(206, 23);
            label2.TabIndex = 3;
            label2.Text = "CLIENTES EMPRESA";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.SkyBlue;
            btnAceptar.Location = new Point(384, 441);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(115, 23);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar Cambios";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FormModificacionCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 125, 125);
            ClientSize = new Size(908, 556);
            Controls.Add(btnAceptar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvClientesEmpresa);
            Controls.Add(dgvClientesComun);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormModificacionCliente";
            Text = "FormModificacionCliente";
            Load += FormModificacionCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientesComun).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientesEmpresa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientesComun;
        private DataGridView dgvClientesEmpresa;
        private Label label1;
        private Label label2;
        private Button btnAceptar;
    }
}