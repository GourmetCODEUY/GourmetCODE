using proyecto.Logica;

namespace proyecto.Presentacion
{
    public partial class FormNuevoPedido : Form
    {
        private NuevoPedidoManager manager;
        public FormNuevoPedido()
        {
            InitializeComponent();
            manager = new NuevoPedidoManager();
        }
        private void FormNuevoPedido_Load(object sender, EventArgs e)
        {
            lblBarrio.Enabled = false;
            cmbBarrios.Enabled = false;

            //Cargar zonas en el comboBox
            CargarZonas();
        }

        private void CargarZonas()
        {
            try
            {
                List<string> zonas = manager.ObtenerZonas();

                cmbZonas.Items.AddRange(zonas.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las zonas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbZonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBarrios.Enabled = true;
            lblBarrio.Enabled = true;

            string zonaSeleccionada = cmbZonas.SelectedItem.ToString();
            cmbBarrios.Items.Clear();

            // Cargar los barrios al ComboBox según la zona seleccionada
            CargarBarrios(zonaSeleccionada);
        }
        private void CargarBarrios(string zonaSeleccionada)
        {
            try
            {
                List<string> barrios = manager.ObtenerBarrios(zonaSeleccionada);

                cmbBarrios.Items.Clear();
                cmbBarrios.Items.AddRange(barrios.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los barrios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string zonaSeleccionada = cmbZonas.SelectedItem.ToString();
            string barrioSeleccionado = cmbBarrios.SelectedItem.ToString();
            string descPedido = txtDescPedido.Text;
            string calleCliente = txtCalleCliente.Text;
            string puertaCliente = txtPuerta.Text;
            try
            {
                // Guardar el pedido en la base de datos a través de la capa de lógica
                bool resultado = manager.GuardarPedido(descPedido, calleCliente, puertaCliente, zonaSeleccionada, barrioSeleccionado);

                if (resultado)
                {
                    MessageBox.Show("Pedido guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar el pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el pedido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            cmbZonas.SelectedIndex = -1;
            cmbBarrios.SelectedIndex = -1;
            txtCalleCliente.Clear();
            txtPuerta.Clear();
        }
        private void txtPuerta_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número o la tecla Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Bloquear la tecla presionada
                e.Handled = true;
            }
        }
    }
}
