namespace proyecto.Presentacion
{
    partial class FormClienteSubMenu
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
            btnAlta = new Button();
            btnModificacion = new Button();
            btnBaja = new Button();
            btnRegistro = new Button();
            SuspendLayout();
            // 
            // btnAlta
            // 
            btnAlta.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            btnAlta.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnAlta.FlatStyle = FlatStyle.Flat;
            btnAlta.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlta.ForeColor = Color.White;
            btnAlta.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlta.Location = new Point(54, 235);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(233, 51);
            btnAlta.TabIndex = 3;
            btnAlta.Text = "Alta";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // btnModificacion
            // 
            btnModificacion.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            btnModificacion.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnModificacion.FlatStyle = FlatStyle.Flat;
            btnModificacion.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificacion.ForeColor = Color.White;
            btnModificacion.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificacion.Location = new Point(331, 235);
            btnModificacion.Name = "btnModificacion";
            btnModificacion.Size = new Size(233, 51);
            btnModificacion.TabIndex = 4;
            btnModificacion.Text = "Modificacion";
            btnModificacion.UseVisualStyleBackColor = true;
            btnModificacion.Click += btnModificacion_Click;
            // 
            // btnBaja
            // 
            btnBaja.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            btnBaja.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnBaja.FlatStyle = FlatStyle.Flat;
            btnBaja.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnBaja.ForeColor = Color.White;
            btnBaja.ImageAlign = ContentAlignment.MiddleLeft;
            btnBaja.Location = new Point(607, 235);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(233, 51);
            btnBaja.TabIndex = 5;
            btnBaja.Text = "Baja";
            btnBaja.UseVisualStyleBackColor = true;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnRegistro
            // 
            btnRegistro.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            btnRegistro.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistro.ForeColor = Color.White;
            btnRegistro.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistro.Location = new Point(54, 235);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(233, 51);
            btnRegistro.TabIndex = 6;
            btnRegistro.Text = "Registro";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // FormClienteSubMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 125, 125);
            ClientSize = new Size(908, 556);
            Controls.Add(btnRegistro);
            Controls.Add(btnBaja);
            Controls.Add(btnModificacion);
            Controls.Add(btnAlta);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormClienteSubMenu";
            Text = "FormClienteSubMenu";
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button3;
        private Button btnModificacion;
        private Button btnBaja;
        private PictureBox pictureBox1;
        public Button btnAlta;
        public Button btnRegistro;
    }
}