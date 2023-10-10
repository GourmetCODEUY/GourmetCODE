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

namespace proyecto.Presentacion
{
    public partial class FormAltaCliente : Form
    {
        private ClienteManager clienteManager;
        public FormAltaCliente()
        {
            InitializeComponent();
            gbClienteComun.Visible = false;
            gbClienteEmpresa.Visible = false;
            clienteManager = new ClienteManager();
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
            try
            {

                string ciClienteComun = txtDocumento.Text;
                string primerNombre = txtPrimerNombre.Text;
                string segundoNombre = txtSegundoNombre.Text;
                string primerApellido = txtPrimerApellido.Text;
                string segundoApellido = txtSegundoApellido.Text;
                string calleComun = txtCalleComun.Text;
                string puertaComun = txtPuertaComun.Text;
                string usuarioComun = txtUsuarioComun.Text;
                string contraseñaComun = txtContraseñaComun.Text;
                string telefonoComun = txtTelefonoComun.Text;
                // Llamar al método para insertar un cliente comun
                clienteManager.InsertarClienteComun(ciClienteComun, primerNombre, primerApellido, segundoNombre, segundoApellido, calleComun, puertaComun, usuarioComun, telefonoComun, contraseñaComun);
            }
            catch (Exception ex)
            {

            }
        }

        private void btAceptarEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos del cliente de empresa desde los controles

                string rut = txtRut.Text;
                string nomEmpresa = txtNombreEmpresa.Text;
                string usuarioLoginEmpresa = txtUsuarioEmpresa.Text;
                string contraseñaLoginEmpresa = txtContraseñaEmpresa.Text;
                string telefonoEmpresa = txtTelefonoEmpresa.Text; 
                string calleEmpresa = txtCalleEmpresa.Text;
                string puertaEmpresa = txtPuertaEmpresa.Text;
                // Llamar al método para insertar un cliente de empresa
                clienteManager.InsertarClienteEmpresa(rut, nomEmpresa, usuarioLoginEmpresa, contraseñaLoginEmpresa, telefonoEmpresa, calleEmpresa, puertaEmpresa);

                MessageBox.Show("Cliente de empresa creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el cliente de empresa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAltaCliente_Click(object sender, EventArgs e)
        {

        }
    }
}