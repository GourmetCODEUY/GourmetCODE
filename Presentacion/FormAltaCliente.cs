using proyecto.Logica;

namespace proyecto.Presentacion
{
    public partial class FormAltaCliente : Form
    {
        private ClienteManager clienteManager;
        private Dictionary<string, List<string>> departamentosZonas = new Dictionary<string, List<string>>();

        public FormAltaCliente()
        {
            InitializeComponent();
            gbClienteComun.Visible = false;
            gbClienteEmpresa.Visible = false;
            clienteManager = new ClienteManager();


            CargarDepartamentosDesdeBD();


            //APLICAR LIMITES A LOS CAMPOS DE TEXTO EMPRESA:
            txtCalleEmpresa.MaxLength = 20;
            txtContraseñaEmpresa.MaxLength = 20;
            txtNombreEmpresa.MaxLength = 20;
            txtRut.MaxLength = 12;
            txtTelefonoEmpresa.MaxLength = 9;

            //PONEMOS TODOS LOS PICTURE BOX EN NO VISIBLE
            pcbZona1.Visible = false;
            pcbZona2.Visible = false;
            pcbZona3.Visible = false;
            pcbZona4.Visible = false;
            pcbZona5.Visible = false;
            pcbZona6.Visible = false;
            pcbZona7.Visible = false;
            pcbZona8.Visible = false;
            pcbZona9.Visible = false;
            pcbZona10.Visible = false;
            pcbZona11.Visible = false;
            pcbZona12.Visible = false;
            pcbZona13.Visible = false;
            pcbZona14.Visible = false;
            pcbZona15.Visible = false;
            pcbZona16.Visible = false;
            pcbZona17.Visible = false;
            pcbZona18.Visible = false;
            pcbZona19.Visible = false;
            pcbZona20.Visible = false;
            pcbZona21.Visible = false;
            pcbZona22.Visible = false;
            pcbZona23.Visible = false;
            pcbZona24.Visible = false;
            pcbZona25.Visible = false;
            pcbZona26.Visible = false;
            pcbZona27.Visible = false;
            pcbZona28.Visible = false;
            pcbZona29.Visible = false;
            pcbZona30.Visible = false;
            pcbZona31.Visible = false;
            pcbZona32.Visible = false;
            pcbZona33.Visible = false;
            pcbZona34.Visible = false;
            pcbZona35.Visible = false;
            pcbZona36.Visible = false;
            pcbZona37.Visible = false;
            pcbZona38.Visible = false;
            pcbZona39.Visible = false;
            pcbZona40.Visible = false;
            pcbZona41.Visible = false;
            pcbZona42.Visible = false;
            pcbZona43.Visible = false;

            // Asociar el evento de selección para el ComboBox de departamentos de Cliente Comun
            cmbDepartamentoComun.SelectedIndexChanged += cmbDepartamentoComun_SelectedIndexChanged;

            // Asociar el evento de selección para el ComboBox de zonas de Cliente Comun
            cmbZonaComun.SelectedIndexChanged += cmbZonaComun_SelectedIndexChanged;

            // Asociar el evento de selección para el ComboBox de departamentos
            cmbDepartamentosEmpresa.SelectedIndexChanged += cmbDepartamentosEmpresa_SelectedIndexChanged;

            // Asociar el evento de selección para el ComboBox de zonas
            cmbZonasEmpresa.SelectedIndexChanged += cmbZonasEmpresa_SelectedIndexChanged;
        }
        private void CargarDepartamentosDesdeBD()
        {
            try
            {
                // Llama al método del clienteManager para obtener los departamentos desde la base de datos
                List<string> departamentos = clienteManager.ObtenerDepartamentosDesdeBD();

                // Limpia cualquier elemento existente en el ComboBox de Cliente Comun
                cmbDepartamentoComun.Items.Clear();

                // Agrega los departamentos al ComboBox de Cliente Comun
                cmbDepartamentoComun.Items.AddRange(departamentos.ToArray());

                // Limpia cualquier elemento existente en el ComboBox
                cmbDepartamentosEmpresa.Items.Clear();

                // Agrega los departamentos al ComboBox
                cmbDepartamentosEmpresa.Items.AddRange(departamentos.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar departamentos desde la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                // Código para insertar cliente común
                string ciClienteComun = txtDocumento.Text;
                string primerNombre = txtPrimerNombre.Text;
                string segundoNombre = txtSegundoNombre.Text;
                string primerApellido = txtPrimerApellido.Text;
                string segundoApellido = txtSegundoApellido.Text;
                string calleComun = txtCalleComun.Text;
                string zonaComun = cmbZonaComun.SelectedItem as string;
                string puertaComun = txtPuertaComun.Text;
                string usuarioComun = txtUsuarioComun.Text;
                string contraseñaComun = txtContraseñaComun.Text;
                string telefonoComun = txtTelefonoComun.Text;
                string Condicion_Clinica_Comun = cbCondicionComun.SelectedItem as string;
                string Departamento_Comun = cmbDepartamentoComun.SelectedItem as string;
                int ID_SucursalComun = 0;
                // Llamar al método para insertar un cliente común
                clienteManager.InsertarClienteComun(Departamento_Comun, ID_SucursalComun, ciClienteComun, primerNombre, primerApellido, segundoNombre, segundoApellido, calleComun, puertaComun, zonaComun, usuarioComun, telefonoComun, contraseñaComun, Condicion_Clinica_Comun);

                txtDocumento.Text = "";
                txtPrimerNombre.Text = "";
                txtSegundoNombre.Text = "";
                txtPrimerApellido.Text = "";
                txtSegundoApellido.Text = "";
                txtCalleComun.Text = "";
                txtPuertaComun.Text = "";
                txtUsuarioComun.Text = "";
                txtContraseñaComun.Text = "";
                txtTelefonoComun.Text = "";
                cbCondicionComun.SelectedIndex = 0;
                cmbDepartamentoComun.SelectedIndex = 0;
                cmbZonaComun.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el cliente común: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string departamentoEmpresa = cmbDepartamentosEmpresa.SelectedItem as string;
                string zonaEmpresa = cmbZonasEmpresa.SelectedItem as string;
                string condicionClinica = CondicionClinica.SelectedItem as string; // Obtener el valor seleccionado del ComboBox
                int ID_Sucursal = 0;
                // Llama al método para insertar un cliente de empresa
                clienteManager.InsertarClienteEmpresa(ID_Sucursal, rut, nomEmpresa, usuarioLoginEmpresa, contraseñaLoginEmpresa, telefonoEmpresa, calleEmpresa, puertaEmpresa, zonaEmpresa, departamentoEmpresa, condicionClinica);

                // Limpiar los TextBox después de una inserción exitosa
                CondicionClinica.SelectedIndex = 0;
                txtRut.Text = "";
                txtNombreEmpresa.Text = "";
                txtUsuarioEmpresa.Text = "";
                txtContraseñaEmpresa.Text = "";
                txtTelefonoEmpresa.Text = "";
                txtCalleEmpresa.Text = "";
                txtPuertaEmpresa.Text = "";
                cmbDepartamentosEmpresa.SelectedIndex = 0;
                cmbZonasEmpresa.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el cliente de empresa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtNombreEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es una letra o una tecla de control.
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es una letra ni una tecla de control, suprime el carácter ingresado.
                e.Handled = true;
            }
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es un número ni una tecla de control.
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, suprime el carácter ingresado.
                e.Handled = true;
            }
        }

        private void txtPuertaEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es un número ni una tecla de control.
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, suprime el carácter ingresado.
                e.Handled = true;
            }
        }

        private void txtUsuarioEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es una letra o una tecla de control.
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es una letra ni una tecla de control, suprime el carácter ingresado.
                e.Handled = true;
            }
        }


        private void txtTelefonoEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es un número ni una tecla de control.
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, suprime el carácter ingresado.
                e.Handled = true;
            }
        }

        private void cmbDepartamentosEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDepartamento = cmbDepartamentosEmpresa.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedDepartamento))
            {
                // Realizar la consulta a la base de datos para obtener las zonas del departamento seleccionado
                List<string> zonas = clienteManager.ObtenerZonasPorDepartamentoDesdeBD(selectedDepartamento);

                // Limpia cualquier elemento existente en el ComboBox de Cliente Empresa
                cmbZonasEmpresa.Items.Clear();

                // Agrega las zonas al ComboBox de Cliente Empresa
                cmbZonasEmpresa.Items.AddRange(zonas.ToArray());
            }
        }

        private void cmbZonasEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Asegúrate de que el nombre de tus PictureBox siga el patrón "pcbZonaX"
            string selectedZona = cmbZonasEmpresa.SelectedItem.ToString();
            int zonaNumber;

            // Extrae el número de la opción seleccionada
            if (int.TryParse(selectedZona.Replace("Zona", ""), out zonaNumber))
            {
                // Oculta todos los PictureBox
                foreach (Control control in this.Controls)
                {
                    if (control is PictureBox)
                    {
                        control.Visible = false;
                    }
                }

                // Muestra el PictureBox correspondiente a la opción seleccionada
                Control pictureBoxToShow = this.Controls.Find("pcbZona" + zonaNumber, true).FirstOrDefault();
                if (pictureBoxToShow is PictureBox)
                {
                    pictureBoxToShow.Visible = true;
                }
            }
        }

        private void txtContraseñaEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es un número ni una tecla de control.
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, suprime el carácter ingresado.
                e.Handled = true;
            }
        }

        private void cmbDepartamentoComun_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDepartamento = cmbDepartamentoComun.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedDepartamento))
            {
                // Realizar la consulta a la base de datos para obtener las zonas del departamento seleccionado
                List<string> zonas = clienteManager.ObtenerZonasPorDepartamentoDesdeBD(selectedDepartamento);

                // Limpia cualquier elemento existente en el ComboBox de Cliente Comun
                cmbZonaComun.Items.Clear();

                // Agrega las zonas al ComboBox de Cliente Comun
                cmbZonaComun.Items.AddRange(zonas.ToArray());
            }
        }

        private void cmbZonaComun_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Asegúrate de que el nombre de tus PictureBox siga el patrón "pcbZonaX"
            string selectedZona = cmbZonaComun.SelectedItem.ToString();
            int zonaNumber;

            // Extrae el número de la opción seleccionada
            if (int.TryParse(selectedZona.Replace("Zona", ""), out zonaNumber))
            {
                // Oculta todos los PictureBox
                foreach (Control control in this.Controls)
                {
                    if (control is PictureBox)
                    {
                        control.Visible = false;
                    }
                }

                // Muestra el PictureBox correspondiente a la opción seleccionada
                Control pictureBoxToShow = this.Controls.Find("pcbZona" + zonaNumber, true).FirstOrDefault();
                if (pictureBoxToShow is PictureBox)
                {
                    pictureBoxToShow.Visible = true;
                }
            }
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir números y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            // Limitar la longitud a 8 dígitos
            if (txtDocumento.Text.Length >= 8 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtTelefonoComun_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir números y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            // Limitar la longitud a 9 dígitos
            if (txtTelefonoComun.Text.Length >= 9 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtPrimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir letras y la tecla de retroceso
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            // Limitar la longitud a 20 caracteres
            if (txtPrimerNombre.Text.Length >= 20 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtSegundoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir letras y la tecla de retroceso
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            // Limitar la longitud a 20 caracteres
            if (txtSegundoNombre.Text.Length >= 20 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtUsuarioComun_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir letras y la tecla de retroceso
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            // Limitar la longitud a 20 caracteres
            if (txtUsuarioComun.Text.Length >= 20 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtPrimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir letras y la tecla de retroceso
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            // Limitar la longitud a 20 caracteres
            if (txtPrimerApellido.Text.Length >= 20 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtSegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir letras y la tecla de retroceso
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            // Limitar la longitud a 20 caracteres
            if (txtSegundoApellido.Text.Length >= 20 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
