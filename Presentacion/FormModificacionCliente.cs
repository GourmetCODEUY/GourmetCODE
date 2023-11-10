using proyecto.Logica;
using proyecto.Persistencia;
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
    public partial class FormModificacionCliente : Form
    {
        private ClienteManager _clienteManager = new ClienteManager();
        private DataTable _tablaClientesComunes;
        private DataTable _tablaClientesEmpresas;
        public FormModificacionCliente()
        {
            InitializeComponent();
        }
        private void GuardarCambios()
        {
            try
            {
                DataTable tablaClientesComunes = _clienteManager.ObtenerClientesComunes();
                DataTable tablaClientesEmpresas = _clienteManager.ObtenerClientesEmpresas();

                // Realiza cambios en las tablas si es necesario
                _clienteManager.ActualizarClientesComunes(tablaClientesComunes);
                _clienteManager.ActualizarClientesEmpresas(tablaClientesEmpresas);

                MessageBox.Show("Cambios guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar cambios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void CargarClientesEmpresa()
        {
            try
            {
                // Llama al método en la capa lógica para obtener los clientes comunes
                DataTable clientesComunes = _clienteManager.ObtenerClientesComunes();

                // Asigna los datos al DataGridView dgvClientesComun
                dgvClientesComun.DataSource = clientesComunes;
            }
            catch (Exception ex)
            {
                // Maneja la excepción según tus requisitos
                MessageBox.Show($"Error al cargar clientes comunes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarClientesComunes()
        {
            try
            {
                // Llama al método en la capa lógica para obtener los clientes de empresas
                DataTable clientesEmpresas = _clienteManager.ObtenerClientesEmpresas();

                // Asigna los datos al DataGridView dgvClientesEmpresa
                dgvClientesEmpresa.DataSource = clientesEmpresas;
            }
            catch (Exception ex)
            {
                // Maneja la excepción según tus requisitos
                MessageBox.Show($"Error al cargar clientes de empresas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormModificacionCliente_Load(object sender, EventArgs e)
        {
            CargarClientesComunes();
            CargarClientesEmpresa();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GuardarCambios();
        }
    }
}
