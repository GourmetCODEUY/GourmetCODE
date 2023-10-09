namespace proyecto.Presentacion
{
    partial class FormAltaCliente
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
            rbClienteComun = new RadioButton();
            gbClienteComun = new GroupBox();
            txtContraseñaComun = new TextBox();
            txtUsuarioComun = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtDocumento = new TextBox();
            txtPrimerApellido = new TextBox();
            txtSegundoNombre = new TextBox();
            txtSegundoApellido = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label7 = new Label();
            txtPrimerNombre = new TextBox();
            btAceptarComun = new Button();
            gbClienteEmpresa = new GroupBox();
            txtContraseñaEmpresa = new TextBox();
            label6 = new Label();
            txtUsuarioEmpresa = new TextBox();
            txtRut = new TextBox();
            label5 = new Label();
            label17 = new Label();
            label18 = new Label();
            txtNombreEmpresa = new TextBox();
            btAceptarEmpresa = new Button();
            rbClienteEmpresa = new RadioButton();
            label3 = new Label();
            label4 = new Label();
            gbClienteComun.SuspendLayout();
            gbClienteEmpresa.SuspendLayout();
            SuspendLayout();
            // 
            // rbClienteComun
            // 
            rbClienteComun.AutoSize = true;
            rbClienteComun.Location = new Point(348, 104);
            rbClienteComun.Name = "rbClienteComun";
            rbClienteComun.Size = new Size(105, 19);
            rbClienteComun.TabIndex = 3;
            rbClienteComun.TabStop = true;
            rbClienteComun.Text = "Cliente Comun";
            rbClienteComun.UseVisualStyleBackColor = true;
            rbClienteComun.CheckedChanged += rbClienteComun_CheckedChanged;
            // 
            // gbClienteComun
            // 
            gbClienteComun.Controls.Add(txtContraseñaComun);
            gbClienteComun.Controls.Add(txtUsuarioComun);
            gbClienteComun.Controls.Add(label2);
            gbClienteComun.Controls.Add(label1);
            gbClienteComun.Controls.Add(txtDocumento);
            gbClienteComun.Controls.Add(txtPrimerApellido);
            gbClienteComun.Controls.Add(txtSegundoNombre);
            gbClienteComun.Controls.Add(txtSegundoApellido);
            gbClienteComun.Controls.Add(label14);
            gbClienteComun.Controls.Add(label13);
            gbClienteComun.Controls.Add(label12);
            gbClienteComun.Controls.Add(label11);
            gbClienteComun.Controls.Add(label7);
            gbClienteComun.Controls.Add(txtPrimerNombre);
            gbClienteComun.Controls.Add(btAceptarComun);
            gbClienteComun.Location = new Point(235, 158);
            gbClienteComun.Name = "gbClienteComun";
            gbClienteComun.Size = new Size(485, 168);
            gbClienteComun.TabIndex = 4;
            gbClienteComun.TabStop = false;
            // 
            // txtContraseñaComun
            // 
            txtContraseñaComun.Location = new Point(321, 46);
            txtContraseñaComun.Name = "txtContraseñaComun";
            txtContraseñaComun.Size = new Size(100, 23);
            txtContraseñaComun.TabIndex = 32;
            // 
            // txtUsuarioComun
            // 
            txtUsuarioComun.Location = new Point(321, 17);
            txtUsuarioComun.Name = "txtUsuarioComun";
            txtUsuarioComun.Size = new Size(100, 23);
            txtUsuarioComun.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(249, 48);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 30;
            label2.Text = "Contraseña_Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(249, 20);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 29;
            label1.Text = "Usuario";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(125, 16);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(100, 23);
            txtDocumento.TabIndex = 28;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(125, 106);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(100, 23);
            txtPrimerApellido.TabIndex = 27;
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Location = new Point(125, 74);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(100, 23);
            txtSegundoNombre.TabIndex = 26;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(125, 135);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(100, 23);
            txtSegundoApellido.TabIndex = 25;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.ForeColor = Color.White;
            label14.Location = new Point(6, 106);
            label14.Name = "label14";
            label14.Size = new Size(89, 15);
            label14.TabIndex = 24;
            label14.Text = "Primer Apellido";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.ForeColor = Color.White;
            label13.Location = new Point(6, 141);
            label13.Name = "label13";
            label13.Size = new Size(101, 15);
            label13.TabIndex = 23;
            label13.Text = "Segundo Apellido";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.ForeColor = Color.White;
            label12.Location = new Point(6, 77);
            label12.Name = "label12";
            label12.Size = new Size(101, 15);
            label12.TabIndex = 22;
            label12.Text = "Segundo Nombre";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.ForeColor = Color.White;
            label11.Location = new Point(6, 19);
            label11.Name = "label11";
            label11.Size = new Size(70, 15);
            label11.TabIndex = 21;
            label11.Text = "Documento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.White;
            label7.Location = new Point(6, 48);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 20;
            label7.Text = "Primer Nombre";
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(125, 45);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(100, 23);
            txtPrimerNombre.TabIndex = 18;
            // 
            // btAceptarComun
            // 
            btAceptarComun.Location = new Point(404, 137);
            btAceptarComun.Name = "btAceptarComun";
            btAceptarComun.Size = new Size(75, 23);
            btAceptarComun.TabIndex = 7;
            btAceptarComun.Text = "Aceptar";
            btAceptarComun.UseVisualStyleBackColor = true;
            btAceptarComun.Click += btAceptarComun_Click;
            // 
            // gbClienteEmpresa
            // 
            gbClienteEmpresa.Controls.Add(txtContraseñaEmpresa);
            gbClienteEmpresa.Controls.Add(label6);
            gbClienteEmpresa.Controls.Add(txtUsuarioEmpresa);
            gbClienteEmpresa.Controls.Add(txtRut);
            gbClienteEmpresa.Controls.Add(label5);
            gbClienteEmpresa.Controls.Add(label17);
            gbClienteEmpresa.Controls.Add(label18);
            gbClienteEmpresa.Controls.Add(txtNombreEmpresa);
            gbClienteEmpresa.Controls.Add(btAceptarEmpresa);
            gbClienteEmpresa.Location = new Point(235, 161);
            gbClienteEmpresa.Name = "gbClienteEmpresa";
            gbClienteEmpresa.Size = new Size(485, 165);
            gbClienteEmpresa.TabIndex = 5;
            gbClienteEmpresa.TabStop = false;
            // 
            // txtContraseñaEmpresa
            // 
            txtContraseñaEmpresa.Location = new Point(304, 53);
            txtContraseñaEmpresa.Name = "txtContraseñaEmpresa";
            txtContraseñaEmpresa.Size = new Size(100, 23);
            txtContraseñaEmpresa.TabIndex = 50;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.White;
            label6.Location = new Point(232, 56);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 49;
            label6.Text = "Contraseña_Login";
            // 
            // txtUsuarioEmpresa
            // 
            txtUsuarioEmpresa.Location = new Point(304, 16);
            txtUsuarioEmpresa.Name = "txtUsuarioEmpresa";
            txtUsuarioEmpresa.Size = new Size(100, 23);
            txtUsuarioEmpresa.TabIndex = 34;
            // 
            // txtRut
            // 
            txtRut.Location = new Point(126, 53);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(100, 23);
            txtRut.TabIndex = 48;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.White;
            label5.Location = new Point(232, 19);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 33;
            label5.Text = "Usuario";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.ForeColor = Color.White;
            label17.Location = new Point(7, 56);
            label17.Name = "label17";
            label17.Size = new Size(28, 15);
            label17.TabIndex = 41;
            label17.Text = "RUT";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.ForeColor = Color.White;
            label18.Location = new Point(7, 19);
            label18.Name = "label18";
            label18.Size = new Size(99, 15);
            label18.TabIndex = 40;
            label18.Text = "Nombre Empresa";
            // 
            // txtNombreEmpresa
            // 
            txtNombreEmpresa.Location = new Point(126, 16);
            txtNombreEmpresa.Name = "txtNombreEmpresa";
            txtNombreEmpresa.Size = new Size(100, 23);
            txtNombreEmpresa.TabIndex = 39;
            // 
            // btAceptarEmpresa
            // 
            btAceptarEmpresa.Location = new Point(404, 134);
            btAceptarEmpresa.Name = "btAceptarEmpresa";
            btAceptarEmpresa.Size = new Size(75, 23);
            btAceptarEmpresa.TabIndex = 6;
            btAceptarEmpresa.Text = "Aceptar";
            btAceptarEmpresa.UseVisualStyleBackColor = true;
            btAceptarEmpresa.Click += btAceptarEmpresa_Click;
            // 
            // rbClienteEmpresa
            // 
            rbClienteEmpresa.AutoSize = true;
            rbClienteEmpresa.Location = new Point(502, 104);
            rbClienteEmpresa.Name = "rbClienteEmpresa";
            rbClienteEmpresa.Size = new Size(110, 19);
            rbClienteEmpresa.TabIndex = 5;
            rbClienteEmpresa.TabStop = true;
            rbClienteEmpresa.Text = "Cliente Empresa";
            rbClienteEmpresa.UseVisualStyleBackColor = true;
            rbClienteEmpresa.CheckedChanged += rbClienteEmpresa_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(410, 14);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 8;
            label3.Text = "REGISTO DE CLIENTES";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(395, 55);
            label4.Name = "label4";
            label4.Size = new Size(153, 15);
            label4.TabIndex = 9;
            label4.Text = "SELECCIONE UNA OPCION:";
            // 
            // FormAltaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(924, 595);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(gbClienteEmpresa);
            Controls.Add(rbClienteEmpresa);
            Controls.Add(gbClienteComun);
            Controls.Add(rbClienteComun);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAltaCliente";
            Click += FormAltaCliente_Click;
            gbClienteComun.ResumeLayout(false);
            gbClienteComun.PerformLayout();
            gbClienteEmpresa.ResumeLayout(false);
            gbClienteEmpresa.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtDireccion;
        private RadioButton rbClienteComun;
        private GroupBox gbClienteComun;
        private TextBox txtDocumento;
        private RadioButton rbClienteEmpresa;
        private GroupBox gbClienteEmpresa;
        private TextBox txtRut;
        private Button btAceptarEmpresa;
        private Button btAceptarComun;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox cbDepartamentos;
        private Label label11;
        private Label label7;
        private TextBox txtPrimerNombre;
        private TextBox textBox3;
        private TextBox textBox8;
        private TextBox txtPrimerApellido;
        private TextBox txtSegundoNombre;
        private TextBox txtSegundoApellido;
        private Label label14;
        private Label label13;
        private Label label12;
        private TextBox textBox9;
        private Label label17;
        private Label label18;
        private TextBox txtNombreEmpresa;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox txtContraseñaComun;
        private TextBox txtUsuarioComun;
        private Label label2;
        private Label label1;
        private TextBox txtContraseñaEmpresa;
        private Label label6;
        private TextBox txtUsuarioEmpresa;
        private Label label5;
    }
}