namespace proyecto.Presentacion
{
    partial class FormMenu
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
            components = new System.ComponentModel.Container();
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            Menu = new PictureBox();
            panel5 = new Panel();
            btnTransporte = new Button();
            panel3 = new Panel();
            panel10 = new Panel();
            btnUsuario = new Button();
            panel4 = new Panel();
            btnPedidos = new Button();
            panel7 = new Panel();
            btnSucursales = new Button();
            panel9 = new Panel();
            btnClientes = new Button();
            btnConsulta = new Button();
            panel6 = new Panel();
            CerrarSesion = new LinkLabel();
            sidebarTime = new System.Windows.Forms.Timer(components);
            panelFormularios = new Panel();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Menu).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel10.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(0, 64, 64);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel7);
            sidebar.Controls.Add(panel9);
            sidebar.Controls.Add(btnConsulta);
            sidebar.Controls.Add(panel6);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(230, 620);
            sidebar.MinimumSize = new Size(66, 620);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(230, 620);
            sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Menu);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 103);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(55, 36);
            label1.Name = "label1";
            label1.Size = new Size(64, 30);
            label1.TabIndex = 2;
            label1.Text = " Menu";
            // 
            // Menu
            // 
            Menu.Cursor = Cursors.Hand;
            Menu.Image = Properties.Resources._3592857_burger_general_ham_list_menu_menu_icon_office_107735;
            Menu.Location = new Point(9, 30);
            Menu.Name = "Menu";
            Menu.Size = new Size(40, 36);
            Menu.SizeMode = PictureBoxSizeMode.StretchImage;
            Menu.TabIndex = 1;
            Menu.TabStop = false;
            Menu.Click += Menu_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnTransporte);
            panel5.Location = new Point(3, 112);
            panel5.Name = "panel5";
            panel5.Size = new Size(230, 51);
            panel5.TabIndex = 1;
            // 
            // btnTransporte
            // 
            btnTransporte.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnTransporte.FlatStyle = FlatStyle.Flat;
            btnTransporte.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnTransporte.ForeColor = Color.White;
            btnTransporte.Image = Properties.Resources.transporte;
            btnTransporte.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransporte.Location = new Point(-3, 0);
            btnTransporte.Name = "btnTransporte";
            btnTransporte.Size = new Size(233, 51);
            btnTransporte.TabIndex = 2;
            btnTransporte.Text = "            Transporte";
            btnTransporte.TextAlign = ContentAlignment.MiddleLeft;
            btnTransporte.UseVisualStyleBackColor = true;
            btnTransporte.Click += btnTransporte_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel10);
            panel3.Location = new Point(3, 169);
            panel3.Name = "panel3";
            panel3.Size = new Size(227, 54);
            panel3.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.Controls.Add(btnUsuario);
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(234, 51);
            panel10.TabIndex = 1;
            // 
            // btnUsuario
            // 
            btnUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            btnUsuario.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuario.ForeColor = Color.White;
            btnUsuario.Image = Properties.Resources._3592856_general_group_office_personal_relation_team_team_structure_107770;
            btnUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuario.Location = new Point(-3, 0);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(233, 51);
            btnUsuario.TabIndex = 2;
            btnUsuario.Text = "            Usuarios";
            btnUsuario.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnPedidos);
            panel4.Location = new Point(3, 229);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 51);
            panel4.TabIndex = 1;
            // 
            // btnPedidos
            // 
            btnPedidos.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnPedidos.FlatStyle = FlatStyle.Flat;
            btnPedidos.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnPedidos.ForeColor = Color.White;
            btnPedidos.Image = Properties.Resources._3592870_brochure_document_menu_note_office_page_papers_107750;
            btnPedidos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPedidos.Location = new Point(-3, 0);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(233, 51);
            btnPedidos.TabIndex = 2;
            btnPedidos.Text = "            Pedidos";
            btnPedidos.TextAlign = ContentAlignment.MiddleLeft;
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnSucursales);
            panel7.Location = new Point(3, 286);
            panel7.Name = "panel7";
            panel7.Size = new Size(234, 51);
            panel7.TabIndex = 1;
            // 
            // btnSucursales
            // 
            btnSucursales.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnSucursales.FlatStyle = FlatStyle.Flat;
            btnSucursales.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnSucursales.ForeColor = Color.White;
            btnSucursales.Image = Properties.Resources._3592835_general_hierachy_map_office_site_structure_107768;
            btnSucursales.ImageAlign = ContentAlignment.MiddleLeft;
            btnSucursales.Location = new Point(-3, 0);
            btnSucursales.Name = "btnSucursales";
            btnSucursales.Size = new Size(233, 51);
            btnSucursales.TabIndex = 2;
            btnSucursales.Text = "            Sucursales";
            btnSucursales.TextAlign = ContentAlignment.MiddleLeft;
            btnSucursales.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnClientes);
            panel9.Location = new Point(3, 343);
            panel9.Name = "panel9";
            panel9.Size = new Size(234, 51);
            panel9.TabIndex = 1;
            // 
            // btnClientes
            // 
            btnClientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            btnClientes.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnClientes.ForeColor = Color.White;
            btnClientes.Image = Properties.Resources._3592855_business_man_employee_general_human_member_office_tie_107745;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(1, 0);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(233, 51);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "            Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnConsulta
            // 
            btnConsulta.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            btnConsulta.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnConsulta.FlatStyle = FlatStyle.Flat;
            btnConsulta.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsulta.ForeColor = Color.White;
            btnConsulta.Image = Properties.Resources.lupa1;
            btnConsulta.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsulta.Location = new Point(3, 400);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(233, 51);
            btnConsulta.TabIndex = 3;
            btnConsulta.Text = "            Consultas";
            btnConsulta.TextAlign = ContentAlignment.MiddleLeft;
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(CerrarSesion);
            panel6.Location = new Point(3, 457);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 116);
            panel6.TabIndex = 0;
            // 
            // CerrarSesion
            // 
            CerrarSesion.AutoSize = true;
            CerrarSesion.LinkColor = Color.White;
            CerrarSesion.Location = new Point(0, 101);
            CerrarSesion.Name = "CerrarSesion";
            CerrarSesion.Size = new Size(76, 15);
            CerrarSesion.TabIndex = 0;
            CerrarSesion.TabStop = true;
            CerrarSesion.Text = "Cerrar Sesion";
            CerrarSesion.LinkClicked += CerrarSesion_LinkClicked;
            // 
            // sidebarTime
            // 
            sidebarTime.Interval = 10;
            sidebarTime.Tick += sidebarTime_Tick;
            // 
            // panelFormularios
            // 
            panelFormularios.BackColor = Color.FromArgb(66, 125, 125);
            panelFormularios.Location = new Point(229, 0);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(924, 595);
            panelFormularios.TabIndex = 1;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1155, 574);
            Controls.Add(panelFormularios);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Menu).EndInit();
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel1;
#pragma warning disable CS0169 // El campo 'FormMenu.panel2' nunca se usa
        private Panel panel2;
#pragma warning restore CS0169 // El campo 'FormMenu.panel2' nunca se usa
        private Button btnAlta;
        private Button btnBaja;
        private Panel panel3;
        private Panel panel4;
        private Button btnPedidos;
        private Panel panel5;
        private Button btnTransporte;
        private Panel panel7;
        private Button btnSucursales;
        private Panel panel8;
        private Button button6;
        private Panel panel9;
        private Button btnClientes;
        private PictureBox Menu;
        private Label label1;
        private System.Windows.Forms.Timer sidebarTime;
        private Panel panel10;
        private Button btnUsuario;
        public Panel panelFormularios;
        private Button btnConsulta;
        private Panel panel6;
        private LinkLabel CerrarSesion;
    }
}