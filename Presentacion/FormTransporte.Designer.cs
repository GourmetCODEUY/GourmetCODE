namespace proyecto.Presentacion
{
    partial class FormTransporte
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
            btnConsultaZonas = new Button();
            SuspendLayout();
            // 
            // btnConsultaZonas
            // 
            btnConsultaZonas.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            btnConsultaZonas.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnConsultaZonas.FlatStyle = FlatStyle.Flat;
            btnConsultaZonas.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultaZonas.ForeColor = Color.White;
            btnConsultaZonas.ImageAlign = ContentAlignment.MiddleRight;
            btnConsultaZonas.Location = new Point(338, 238);
            btnConsultaZonas.Name = "btnConsultaZonas";
            btnConsultaZonas.Size = new Size(233, 51);
            btnConsultaZonas.TabIndex = 7;
            btnConsultaZonas.Text = "Consultar Zonas";
            btnConsultaZonas.UseVisualStyleBackColor = true;
            btnConsultaZonas.Click += btnConsultaZonas_Click;
            // 
            // FormTransporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(908, 556);
            Controls.Add(btnConsultaZonas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTransporte";
            Text = "FormTransporte";
            ResumeLayout(false);
        }

        #endregion

        public Button btnConsultaZonas;
    }
}