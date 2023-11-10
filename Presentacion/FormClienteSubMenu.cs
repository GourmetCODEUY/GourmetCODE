using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace proyecto.Presentacion
{
    public partial class FormClienteSubMenu : Form
    {
        private Panel panel11Reference;
        private FormMenu formMenu;
        public FormClienteSubMenu(Panel panel11, FormMenu formMenu)
        {

            InitializeComponent();
            panel11Reference = panel11;
            this.formMenu = formMenu;
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            FormModificacionCliente formModificacionCliente = new FormModificacionCliente();

            // Configurar el formulario secundario para que no tenga borde de formulario propio
            formModificacionCliente.FormBorderStyle = FormBorderStyle.None;

            // Establecer el formulario secundario como hijo del panel11
            formModificacionCliente.TopLevel = false;
            panel11Reference.Controls.Clear(); // Limpia el panel si ya hay controles en él
            panel11Reference.Controls.Add(formModificacionCliente);

            // Mostrar el formulario dentro del panel11
            formModificacionCliente.Show();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            FormBajaCliente formBajaCliente = new FormBajaCliente();

            // Configurar el formulario secundario para que no tenga borde de formulario propio
            formBajaCliente.FormBorderStyle = FormBorderStyle.None;

            // Establecer el formulario secundario como hijo del panel11
            formBajaCliente.TopLevel = false;
            panel11Reference.Controls.Clear(); // Limpia el panel si ya hay controles en él
            panel11Reference.Controls.Add(formBajaCliente);

            // Mostrar el formulario dentro del panel11
            formBajaCliente.Show();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            FormAltaCliente formAltaCliente = new FormAltaCliente();

            // Configurar el formulario secundario para que no tenga borde de formulario propio
            formAltaCliente.FormBorderStyle = FormBorderStyle.None;

            // Establecer el formulario secundario como hijo del panel11
            formAltaCliente.TopLevel = false;
            panel11Reference.Controls.Clear(); // Limpia el panel si ya hay controles en él
            panel11Reference.Controls.Add(formAltaCliente);

            // Mostrar el formulario dentro del panel11
            formAltaCliente.Show();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FormAutorizacionCliente formAutorizacionCliente = new FormAutorizacionCliente();

            // Configurar el formulario secundario para que no tenga borde de formulario propio
            formAutorizacionCliente.FormBorderStyle = FormBorderStyle.None;

            // Establecer el formulario secundario como hijo del panel11
            formAutorizacionCliente.TopLevel = false;
            panel11Reference.Controls.Clear(); // Limpia el panel si ya hay controles en él
            panel11Reference.Controls.Add(formAutorizacionCliente);

            // Mostrar el formulario dentro del panel11
            formAutorizacionCliente.Show();

        }
        public void ActualizarVisibilidadBoton(bool btnRegistroVisible, bool btnAltaVisible)
        {
            btnRegistro.Visible = btnRegistroVisible;
            btnAlta.Visible = btnAltaVisible;
        }

        private void FormClienteSubMenu_Load(object sender, EventArgs e)
        {

        }
    }
}