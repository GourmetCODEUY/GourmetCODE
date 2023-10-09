using MySqlX.XDevAPI.Relational;
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
    public partial class FormPedidos : Form
    {
        private int rolUsuario;
        private Panel panel11Reference;
        public FormPedidos(Panel panel11, int rol)
        {
            InitializeComponent();
            panel11Reference = panel11;
            rolUsuario = rol;
        }
        private void btnModificacionPedido_Click(object sender, EventArgs e)
        {
            FormModificacionPedido formModificacionPedido = new FormModificacionPedido();
            // Establecer el formulario secundario como hijo del panel11
            formModificacionPedido.TopLevel = false;
            panel11Reference.Controls.Clear(); // Limpia el panel si ya hay controles en él
            panel11Reference.Controls.Add(formModificacionPedido);
            formModificacionPedido.Show();
        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            FormNuevoPedido formNuevoPedido = new FormNuevoPedido();
            // Configurar el formulario secundario para que no tenga borde de formulario propio
            formNuevoPedido.FormBorderStyle = FormBorderStyle.None;

            // Establecer el formulario secundario como hijo del panel11
            formNuevoPedido.TopLevel = false;
            panel11Reference.Controls.Clear(); // Limpia el panel si ya hay controles en él
            panel11Reference.Controls.Add(formNuevoPedido);

            // Mostrar el formulario dentro del panel11
            formNuevoPedido.Show();
        }

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            FormEliminarPedido formEliminarPedido = new FormEliminarPedido();
            // Establecer el formulario secundario como hijo del panel11
            formEliminarPedido.TopLevel = false;
            panel11Reference.Controls.Clear(); // Limpia el panel si ya hay controles en él
            panel11Reference.Controls.Add(formEliminarPedido);
            formEliminarPedido.Show();
        }

        private void btnConsultaCliente_Click(object sender, EventArgs e)
        {
            FormConsultaCliente formCunsultaCliente = new FormConsultaCliente();
            formCunsultaCliente.TopLevel = false;
            panel11Reference.Controls.Clear(); // Limpia el panel si ya hay controles en él
            panel11Reference.Controls.Add(formCunsultaCliente);
            formCunsultaCliente.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FormConsultaPedidos formCosultaPedidos = new FormConsultaPedidos();
            formCosultaPedidos.TopLevel = false;
            panel11Reference.Controls.Clear(); // Limpia el panel si ya hay controles en él
            panel11Reference.Controls.Add(formCosultaPedidos);
            formCosultaPedidos.Show();
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            if (rolUsuario == 3)
            {
                btnConsultaCliente.Visible = false;
            }
            else
            {
                btnConsultaCliente.Visible = true;
            }
        }
    }
}
