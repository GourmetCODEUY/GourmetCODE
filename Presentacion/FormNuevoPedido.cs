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

            // Asocia el evento cmbDepartamentos_SelectedIndexChanged al ComboBox de departamentos
            cmbDepartamentos.SelectedIndexChanged += cmbDepartamentos_SelectedIndexChanged;
        }
        private void FormNuevoPedido_Load(object sender, EventArgs e)
        {
            lblBarrio.Enabled = false;
            cmbBarrios.Enabled = false;

            //Cargar zonas en el comboBox
            CargarZonas();

            List<string> departamentos = new List<string>
            {
                "Artigas",
                "Canelones",
                "Cerro Largo",
                "Colonia",
                "Durazno",
                "Flores",
                "Florida",
                "Lavalleja",
                "Maldonado",
                "Montevideo",
                "Paysandú",
                "Río Negro",
                "Rivera",
                "Rocha",
                "Salto",
                "San José",
                "Soriano",
                "Tacuarembó",
                "Treinta y Tres"
            };

            cmbDepartamentos.DataSource = departamentos;
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

            if (cmbZonas.SelectedItem != null)
            {
                string zonaSeleccionada = cmbZonas.SelectedItem?.ToString() ?? string.Empty;

                if (zonaSeleccionada != null)
                {
                    cmbBarrios.Items.Clear();

                    // Cargar los barrios al ComboBox según la zona seleccionada
                }
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string zonaSeleccionada = cmbZonas.SelectedItem.ToString() ?? string.Empty;
            string barrioSeleccionado = cmbBarrios.SelectedItem.ToString() ?? string.Empty;
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

        private void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtiene el departamento seleccionado
            string departamentoSeleccionado = cmbDepartamentos.SelectedItem?.ToString();

            if (departamentoSeleccionado != null)
            {
                // Llama a la función para cargar las zonas según el departamento
                CargarZonasPorDepartamento(departamentoSeleccionado);
            }
        }

        private void CargarZonasPorDepartamento(string departamentoSeleccionado)
        {
            // Crea una estructura de datos que mapea departamentos a zonas
            var zonasPorDepartamento = new Dictionary<string, List<string>>
    {
        { "Montevideo", new List<string> { "Zona 1", "Zona 2", "Zona 3" } },
        { "Canelones", new List<string> { "Zona A", "Zona B", "Zona C" } },
        // Agrega otros departamentos y sus respectivas zonas
    };

            // Verifica si el departamento seleccionado está en el diccionario
            if (zonasPorDepartamento.ContainsKey(departamentoSeleccionado))
            {
                // Obtiene la lista de zonas correspondientes al departamento
                var zonas = zonasPorDepartamento[departamentoSeleccionado];

                // Limpia el ComboBox cmbZonas
                cmbZonas.Items.Clear();

                // Agrega las zonas al ComboBox cmbZonas
                cmbZonas.Items.AddRange(zonas.ToArray());
            }
            else
            {
                // Maneja el caso en el que no se encuentra el departamento
                MessageBox.Show("Departamento no encontrado en el diccionario de zonas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}