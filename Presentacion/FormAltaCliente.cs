using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto.Logica;
using proyecto.Logica.CapaLogica;

namespace proyecto.Presentacion
{
    public partial class FormAltaCliente : Form
    {
        public FormAltaCliente()
        {
            InitializeComponent();
            gbClienteComun.Visible = false;
            gbClienteEmpresa.Visible = false;
        }

        private void rbClienteComun_CheckedChanged(object sender, EventArgs e)
        {
            gbClienteComun.Visible = true;
            gbClienteEmpresa.Visible = false;
        }

        private void rbClienteEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            gbClienteComun.Visible = false;
            gbClienteEmpresa.Visible = true;
        }

        private void btAceptarComun_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btAceptarEmpresa_Click(object sender, EventArgs e)
        {
            string nombre = txtRut.Text;

            ClienteManager clienteManager = new ClienteManager();
            clienteManager.CrearNuevoCliente(nombre);

            MessageBox.Show("Cliente creado exitosamente.");
        }

        private void FormAltaCliente_Click(object sender, EventArgs e)
        {

        }
    }
}