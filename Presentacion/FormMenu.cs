using System;
using System.Drawing;
using System.Windows.Forms;
using proyecto.Persistencia;

namespace proyecto.Presentacion
{
    public partial class FormMenu : Form
    {
        private FormClienteSubMenu formClienteSubMenu;
        private FormTransporte Formtransporte;
        private FormConsulta Formconsulta;
        bool sidebarExpand;
        bool panel11Expand;
        int panel11OriginalWidth;
        private int rolUsuario;

        public FormMenu(int rol)
        {
            InitializeComponent();
            formClienteSubMenu = new FormClienteSubMenu(panelFormularios, this);
            Formtransporte = new FormTransporte(panelFormularios, this);
            Formconsulta = new FormConsulta(panelFormularios, this);
            SetFlatStyleToAllButtons(this);
            rolUsuario = rol;

            // Botones deshabilitados
            btnConsulta.Enabled = false;
            btnUsuario.Enabled = false;
            btnPedidos.Enabled = false;
            btnSucursales.Enabled = false;
            btnTransporte.Enabled = false;
            btnClientes.Enabled = false;

            ActualizarBotonesSegunRol();
            // Guarda el ancho original del panel para usarlo en la animación
            panel11OriginalWidth = panelFormularios.Width;
        }

        private void sidebarTime_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTime.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTime.Stop();
                }
            }

            // Ajusta el tamaño y la posición del panel durante la animación
            if (panel11Expand)
            {
                panelFormularios.Width -= 10;
                if (panelFormularios.Width == panelFormularios.MinimumSize.Width)
                {
                    panel11Expand = false;
                }
            }
            else
            {
                panelFormularios.Width += 10;
                if (panelFormularios.Width == panel11OriginalWidth)
                {
                    panel11Expand = true;
                }
            }
            panelFormularios.Location = new Point(sidebar.Width, panelFormularios.Location.Y);
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            sidebarTime.Start();
        }

        private void SetFlatStyleToAllButtons(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is Button button)
                {
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.BackColor = Color.Transparent;
                }
                else if (ctrl.HasChildren)
                {
                    SetFlatStyleToAllButtons(ctrl);
                }
            }
        }

        public void ActualizarBotonesSegunRol()
        {
            // Habilitar botones según el rol
            switch (rolUsuario)
            {
                case 1://Informatico
                    btnUsuario.Enabled = true;
                    this.Text = "Menu - Informatico";
                    break;

                case 2://Gerente
                    btnConsulta.Enabled = true;
                    btnClientes.Enabled = true;
                    btnPedidos.Enabled = true;
                    this.Text = "Menu - Gerente";
                    break;

                case 3: //Administracion
                    btnPedidos.Enabled = true;
                    btnClientes.Enabled = true;
                    this.Text = "Menu - Administracion";
                    break;

                case 4://Cocina
                    btnPedidos.Enabled = false;
                    btnSucursales.Enabled = false;
                    this.Text = "Menu - Cocina";
                    break;

                case 5://Transporte
                    btnTransporte.Enabled = false;
                    this.Text = "Menu - Transporte";
                    break;

                case 6://Publico
                    btnClientes.Enabled = false;
                    this.Text = "Menu - Publico";
                    break;

                case 7://Cliente Empresa
                    btnPedidos.Enabled = true;
                    this.Text = "Menu - Cliente Comun";
                    break;

                case 8://Cliente Empresa
                    btnPedidos.Enabled = true;
                    this.Text = "Menu - Cliente Empresa";
                    break;

                default:
                    break;
            }
        }

        private void MostrarFormularioSecundario(Form formularioSecundario)
        {
            // Configurar el formulario secundario para que no tenga borde de formulario propio
            formularioSecundario.FormBorderStyle = FormBorderStyle.None;

            // Establecer el formulario secundario como hijo del panel
            formularioSecundario.TopLevel = false;
            panelFormularios.Controls.Clear(); // Limpia el panel si ya hay controles en él
            panelFormularios.Controls.Add(formularioSecundario);

            // Mostrar el formulario dentro del panel
            formularioSecundario.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            MostrarFormularioSecundario(formClienteSubMenu);

            // Comprueba el rol y ajusta la visibilidad de los botones "Registro" y "Alta"
            if (rolUsuario == 2) // Gerente
            {
                formClienteSubMenu.ActualizarVisibilidadBoton(true, false);
            }
            else if (rolUsuario == 3) // Administración
            {
                formClienteSubMenu.ActualizarVisibilidadBoton(false, true);
            }
            else
            {
                // En otros casos, oculta ambos botones
                formClienteSubMenu.ActualizarVisibilidadBoton(false, false);
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            MostrarFormularioSecundario(Formconsulta);
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FormPedidos formpedidos = new FormPedidos(panelFormularios, rolUsuario);
            MostrarFormularioSecundario(formpedidos);
        }

        private void btnTransporte_Click(object sender, EventArgs e)
        {
            MostrarFormularioSecundario(Formtransporte);
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            // Oculta el formulario actual (FormMenu)
            this.Hide();

            // Muestra el formulario de inicio de sesión (FormLogin)
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void CerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Oculta el formulario actual (FormMenu)
            this.Hide();

            // Muestra el formulario de inicio de sesión (FormLogin)
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FormUsuarios formUsuarios = new FormUsuarios();
            MostrarFormularioSecundario(formUsuarios);
        }
    }
}