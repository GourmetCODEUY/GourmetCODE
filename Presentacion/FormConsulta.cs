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
    public partial class FormConsulta : Form
    {
        private Panel panel11Reference;
        private FormMenu formMenu;
        public FormConsulta(Panel panel11, FormMenu formMenu)
        {
            InitializeComponent();
            panel11Reference = panel11;
            this.formMenu = formMenu;
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FormConsultaPedidos formConsultaPedidos = new FormConsultaPedidos();

            // Configurar el formulario secundario para que no tenga borde de formulario propio
            formConsultaPedidos.FormBorderStyle = FormBorderStyle.None;

            // Establecer el formulario secundario como hijo del panel11
            formConsultaPedidos.TopLevel = false;
            panel11Reference.Controls.Clear(); // Limpia el panel si ya hay controles en él
            panel11Reference.Controls.Add(formConsultaPedidos);

            // Mostrar el formulario dentro del panel11
            formConsultaPedidos.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FormConsultaProductos formConsultaProductos = new FormConsultaProductos();

            // Configurar el formulario secundario para que no tenga borde de formulario propio
            formConsultaProductos.FormBorderStyle = FormBorderStyle.None;

            // Establecer el formulario secundario como hijo del panel11
            formConsultaProductos.TopLevel = false;
            panel11Reference.Controls.Clear(); // Limpia el panel si ya hay controles en él
            panel11Reference.Controls.Add(formConsultaProductos);

            // Mostrar el formulario dentro del panel11
            formConsultaProductos.Show();
        }

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            FormConsultaProduccion formConsultaProduccion = new FormConsultaProduccion();

            // Configurar el formulario secundario para que no tenga borde de formulario propio
            formConsultaProduccion.FormBorderStyle = FormBorderStyle.None;

            // Establecer el formulario secundario como hijo del panel11
            formConsultaProduccion.TopLevel = false;
            panel11Reference.Controls.Clear(); // Limpia el panel si ya hay controles en él
            panel11Reference.Controls.Add(formConsultaProduccion);

            // Mostrar el formulario dentro del panel11
            formConsultaProduccion.Show();
        }
    }
}
