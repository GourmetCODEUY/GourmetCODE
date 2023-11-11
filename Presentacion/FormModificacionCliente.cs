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

        private void CargarClientesEmpresa()
        {
            try
            {
                _tablaClientesComunes = _clienteManager.ObtenerClientesComunes();
                dgvClientesComun.DataSource = _tablaClientesComunes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes comunes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarClientesComunes()
        {
            try
            {
                _tablaClientesEmpresas = _clienteManager.ObtenerClientesEmpresas();
                dgvClientesEmpresa.DataSource = _tablaClientesEmpresas;
            }
            catch (Exception ex)
            {
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
            try
            {
                // Guardar cambios en la base de datos
                _clienteManager.ActualizarClientesComunes(_tablaClientesComunes);
                _clienteManager.ActualizarClientesEmpresas(_tablaClientesEmpresas);

                MessageBox.Show("Cambios guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar cambios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClientesEmpresa_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error en los datos ingresados. Asegúrese de ingresar números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvClientesComun_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error en los datos ingresados. Asegúrese de ingresar números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }  
}

