namespace proyecto.Presentacion
{
    partial class FormConsultaProduccion
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
            dgvConsultaProduccion = new DataGridView();
            ID_Estado_Producto = new DataGridViewTextBoxColumn();
            Estado_Producto = new DataGridViewTextBoxColumn();
            ID_Comida = new DataGridViewTextBoxColumn();
            Desc_Menu = new DataGridViewTextBoxColumn();
            btnConsultaProduccion = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaProduccion).BeginInit();
            SuspendLayout();
            // 
            // dgvConsultaProduccion
            // 
            dgvConsultaProduccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaProduccion.Columns.AddRange(new DataGridViewColumn[] { ID_Estado_Producto, Estado_Producto, ID_Comida, Desc_Menu });
            dgvConsultaProduccion.Location = new Point(218, 12);
            dgvConsultaProduccion.Name = "dgvConsultaProduccion";
            dgvConsultaProduccion.RowTemplate.Height = 25;
            dgvConsultaProduccion.Size = new Size(460, 260);
            dgvConsultaProduccion.TabIndex = 0;
            // 
            // ID_Estado_Producto
            // 
            ID_Estado_Producto.HeaderText = "ID del Estado de Producto";
            ID_Estado_Producto.Name = "ID_Estado_Producto";
            ID_Estado_Producto.Width = 120;
            // 
            // Estado_Producto
            // 
            Estado_Producto.HeaderText = "Estado de Producto";
            Estado_Producto.Name = "Estado_Producto";
            // 
            // ID_Comida
            // 
            ID_Comida.HeaderText = "ID de Comida";
            ID_Comida.Name = "ID_Comida";
            // 
            // Descripcion_Menu
            // 
            Desc_Menu.HeaderText = "Descripcion de Menu";
            Desc_Menu.Name = "Descripcion_Menu";
            // 
            // btnConsultaProduccion
            // 
            btnConsultaProduccion.Location = new Point(395, 278);
            btnConsultaProduccion.Name = "btnConsultaProduccion";
            btnConsultaProduccion.Size = new Size(75, 23);
            btnConsultaProduccion.TabIndex = 1;
            btnConsultaProduccion.Text = "Consultar";
            btnConsultaProduccion.UseVisualStyleBackColor = true;
            btnConsultaProduccion.Click += btnConsultaProduccion_Click;
            // 
            // FormConsultaProduccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(876, 478);
            Controls.Add(btnConsultaProduccion);
            Controls.Add(dgvConsultaProduccion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormConsultaProduccion";
            Text = "FormConsultaProduccion";
            ((System.ComponentModel.ISupportInitialize)dgvConsultaProduccion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvConsultaProduccion;
        private Button btnConsultaProduccion;
        private DataGridViewTextBoxColumn ID_Estado_Producto;
        private DataGridViewTextBoxColumn Estado_Producto;
        private DataGridViewTextBoxColumn ID_Comida;
        private DataGridViewTextBoxColumn Desc_Menu;
    }
}