using proyecto.Logica;
using proyecto.Persistencia;

namespace proyecto.Presentacion
{
    public partial class FormBajaCliente : Form
    {
        private ClienteManager clienteManager;

        public FormBajaCliente()
        {
            InitializeComponent();
            clienteManager = new ClienteManager();

            // Configurar las columnas del DataGridView
            dgvClientes.ColumnCount = 7; // Número de columnas

            dgvClientes.Columns[0].Name = "Num_Cliente";
            dgvClientes.Columns[1].Name = "Calle_Cliente";
            dgvClientes.Columns[2].Name = "Puerta_Cliente";
            dgvClientes.Columns[3].Name = "Zona_Cliente";
            dgvClientes.Columns[4].Name = "Autorizacion";
            dgvClientes.Columns[5].Name = "Condicion_Clinica";
            dgvClientes.Columns[6].Name = "Telefono";

            // Configurar la selección de filas completas
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Configurar la edición de columnas
            ConfigurarEdicionColumnas();
        }
        private void ConfigurarEdicionColumnas()
        {
            // Deshabilitar la edición para todas las columnas
            foreach (DataGridViewColumn columna in dgvClientes.Columns)
            {
                columna.ReadOnly = true;
            }
        }

        private void CargarClientes()
        {
            List<Cliente> clientes = clienteManager.ObtenerTodosLosClientes();

            dgvClientes.Rows.Clear();

            foreach (var cliente in clientes)
            {
                dgvClientes.Rows.Add(
                    cliente.Num_Cliente,
                    cliente.Calle_Cliente,
                    cliente.Puerta_Cliente,
                    cliente.Zona_Cliente,
                    cliente.Autorizacion,
                    cliente.Condicion_Clinica,
                    cliente.Telefono
                );
            }
        }

        private void FormBajaCliente_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void btnBorrarClientes_Click(object sender, EventArgs e)
        {
            // Obtener el número de cliente seleccionado (supongo que está en la primera columna)
            if (dgvClientes.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvClientes.SelectedCells[0].RowIndex;
                int numCliente = Convert.ToInt32(dgvClientes.Rows[selectedRowIndex].Cells["Num_Cliente"].Value);

                // Llamar al método para eliminar el cliente
                clienteManager.EliminarCliente(numCliente);

                // Recargar la lista de clientes después de la eliminación
                CargarClientes();
            }
        }
    }
}
