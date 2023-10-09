namespace proyecto.Presentacion
{
    partial class FormUsuarios
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
            cmbRol = new ComboBox();
            label1 = new Label();
            txtUsuarioLogin = new TextBox();
            label2 = new Label();
            txtContraseñaLogin = new TextBox();
            lblContraseña = new Label();
            btnGuardarUsuario = new Button();
            pctBoxVer = new PictureBox();
            dgvUsuarios = new DataGridView();
            btnEliminarUsuario = new Button();
            btnModificarUsuario = new Button();
            txtMUsuarioLogin = new TextBox();
            txtMcontraseñaLogin = new TextBox();
            lblMUsuario = new Label();
            lblMcontraseña = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pctBoxVer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Informatico", "Gerente", "Administracion", "Cocina", "Transporte", "Publico" });
            cmbRol.Location = new Point(495, 81);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(121, 23);
            cmbRol.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(495, 57);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 1;
            label1.Text = "Roles";
            // 
            // txtUsuarioLogin
            // 
            txtUsuarioLogin.Location = new Point(670, 81);
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            txtUsuarioLogin.Size = new Size(100, 23);
            txtUsuarioLogin.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(670, 57);
            label2.Name = "label2";
            label2.Size = new Size(64, 21);
            label2.TabIndex = 3;
            label2.Text = "Usuario";
            // 
            // txtContraseñaLogin
            // 
            txtContraseñaLogin.Location = new Point(670, 131);
            txtContraseñaLogin.Name = "txtContraseñaLogin";
            txtContraseñaLogin.Size = new Size(100, 23);
            txtContraseñaLogin.TabIndex = 4;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblContraseña.ForeColor = Color.Brown;
            lblContraseña.Location = new Point(670, 107);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(135, 21);
            lblContraseña.TabIndex = 5;
            lblContraseña.Text = "Contraseña_Login";
            // 
            // btnGuardarUsuario
            // 
            btnGuardarUsuario.Location = new Point(519, 131);
            btnGuardarUsuario.Name = "btnGuardarUsuario";
            btnGuardarUsuario.Size = new Size(97, 23);
            btnGuardarUsuario.TabIndex = 6;
            btnGuardarUsuario.Text = "Guardar Alta ";
            btnGuardarUsuario.UseVisualStyleBackColor = true;
            btnGuardarUsuario.Click += btnGuardarUsuario_Click;
            // 
            // pctBoxVer
            // 
            pctBoxVer.Image = Properties.Resources.esconder;
            pctBoxVer.Location = new Point(776, 130);
            pctBoxVer.Name = "pctBoxVer";
            pctBoxVer.Size = new Size(27, 23);
            pctBoxVer.SizeMode = PictureBoxSizeMode.StretchImage;
            pctBoxVer.TabIndex = 7;
            pctBoxVer.TabStop = false;
            pctBoxVer.Click += pctBoxVer_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(40, 20);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(239, 417);
            dgvUsuarios.TabIndex = 8;
            dgvUsuarios.CellEndEdit += dgvUsuarios_CellEndEdit;
            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Location = new Point(66, 443);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(188, 23);
            btnEliminarUsuario.TabIndex = 9;
            btnEliminarUsuario.Text = "Eliminar Usuario Seleccionado";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario.Location = new Point(559, 347);
            btnModificarUsuario.Name = "btnModificarUsuario";
            btnModificarUsuario.Size = new Size(141, 23);
            btnModificarUsuario.TabIndex = 10;
            btnModificarUsuario.Text = "Guardar Modificacion";
            btnModificarUsuario.UseVisualStyleBackColor = true;
            btnModificarUsuario.Click += btnModificarUsuario_Click;
            // 
            // txtMUsuarioLogin
            // 
            txtMUsuarioLogin.Location = new Point(495, 309);
            txtMUsuarioLogin.Name = "txtMUsuarioLogin";
            txtMUsuarioLogin.Size = new Size(117, 23);
            txtMUsuarioLogin.TabIndex = 11;
            // 
            // txtMcontraseñaLogin
            // 
            txtMcontraseñaLogin.Location = new Point(644, 309);
            txtMcontraseñaLogin.Name = "txtMcontraseñaLogin";
            txtMcontraseñaLogin.Size = new Size(135, 23);
            txtMcontraseñaLogin.TabIndex = 12;
            // 
            // lblMUsuario
            // 
            lblMUsuario.AutoSize = true;
            lblMUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMUsuario.ForeColor = Color.Transparent;
            lblMUsuario.Location = new Point(495, 285);
            lblMUsuario.Name = "lblMUsuario";
            lblMUsuario.Size = new Size(64, 21);
            lblMUsuario.TabIndex = 13;
            lblMUsuario.Text = "Usuario";
            // 
            // lblMcontraseña
            // 
            lblMcontraseña.AutoSize = true;
            lblMcontraseña.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMcontraseña.ForeColor = Color.Brown;
            lblMcontraseña.Location = new Point(644, 285);
            lblMcontraseña.Name = "lblMcontraseña";
            lblMcontraseña.Size = new Size(135, 21);
            lblMcontraseña.TabIndex = 14;
            lblMcontraseña.Text = "Contraseña_Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(519, 20);
            label3.Name = "label3";
            label3.Size = new Size(232, 27);
            label3.TabIndex = 15;
            label3.Text = "INSERTAR USUARIO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(519, 258);
            label4.Name = "label4";
            label4.Size = new Size(253, 27);
            label4.TabIndex = 16;
            label4.Text = "MODIFICAR USUARIO";
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(876, 478);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblMcontraseña);
            Controls.Add(lblMUsuario);
            Controls.Add(txtMcontraseñaLogin);
            Controls.Add(txtMUsuarioLogin);
            Controls.Add(btnModificarUsuario);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(dgvUsuarios);
            Controls.Add(pctBoxVer);
            Controls.Add(btnGuardarUsuario);
            Controls.Add(lblContraseña);
            Controls.Add(txtContraseñaLogin);
            Controls.Add(label2);
            Controls.Add(txtUsuarioLogin);
            Controls.Add(label1);
            Controls.Add(cmbRol);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormUsuarios";
            Text = "FormUsuarios";
            Load += FormUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)pctBoxVer).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbRol;
        private Label label1;
        private TextBox txtUsuarioLogin;
        private Label label2;
        private TextBox txtContraseñaLogin;
        private Label lblContraseña;
        private Button btnGuardarUsuario;
        private PictureBox pctBoxVer;
        private DataGridView dgvUsuarios;
        private Button btnEliminarUsuario;
        private Button btnModificarUsuario;
        private TextBox txtMUsuarioLogin;
        private TextBox txtMcontraseñaLogin;
        private Label lblMUsuario;
        private Label lblMcontraseña;
        private Label label3;
        private Label label4;
    }
}