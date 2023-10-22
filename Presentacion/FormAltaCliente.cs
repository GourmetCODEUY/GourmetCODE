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
        private Dictionary<string, List<string>> departamentosZonas = new Dictionary<string, List<string>>();

        public FormAltaCliente()
        {
            InitializeComponent();
            gbClienteComun.Visible = false;
            gbClienteEmpresa.Visible = false;
            clienteManager = new ClienteManager();
            //APLICAR LIMITES A LOS CAMPOS DE TEXTO EMPRESA:
            txtCalleEmpresa.MaxLength = 20;
            txtContraseñaEmpresa.MaxLength = 20;
            txtNombreEmpresa.MaxLength = 20;
            txtRut.MaxLength = 12;
            txtTelefonoEmpresa.MaxLength = 9;
            txtBarrioEmpresa.MaxLength = 20;

            // Configura la relación entre departamentos y zonas
            ConfigurarDepartamentosYZonas();
        }
        private void ConfigurarDepartamentosYZonas()
        {
            // Define las zonas para cada departamento
            departamentosZonas.Add("Artigas", new List<string> { "Zona1", "Zona2" });
            departamentosZonas.Add("Canelones", new List<string> { "Zona3", "Zona4" });
            departamentosZonas.Add("Cerro Largo", new List<string> { "Zona5", "Zona6" });
            departamentosZonas.Add("Colonia", new List<string> { "Zona7", "Zona8" });
            departamentosZonas.Add("Durazno", new List<string> { "Zona9", "Zona10" });
            departamentosZonas.Add("Flores", new List<string> { "Zona11", "Zona12" });
            departamentosZonas.Add("Florida", new List<string> { "Zona13", "Zona14" });
            departamentosZonas.Add("Lavalleja", new List<string> { "Zona15", "Zona16" });
            departamentosZonas.Add("Maldonado", new List<string> { "Zona17", "Zona18" });
            departamentosZonas.Add("Montevideo", new List<string> { "Zona19", "Zona20", "Zona21", "Zona22", "Zona23", "Zona24", "Zona25" });
            departamentosZonas.Add("Paysandú", new List<string> { "Zona26", "Zona27" });
            departamentosZonas.Add("Río Negro", new List<string> { "Zona28", "Zona29" });
            departamentosZonas.Add("Rivera", new List<string> { "Zona30", "Zona31" });
            departamentosZonas.Add("Rocha", new List<string> { "Zona32", "Zona33" });
            departamentosZonas.Add("Salto", new List<string> { "Zona34", "Zona35" });
            departamentosZonas.Add("San José", new List<string> { "Zona36", "Zona37" });
            departamentosZonas.Add("Soriano", new List<string> { "Zona38", "Zona39" });
            departamentosZonas.Add("Tacuarembó", new List<string> { "Zona40", "Zona41" });
            departamentosZonas.Add("Treinta y Tres", new List<string> { "Zona42", "Zona43" });

            // Llena el combo de departamentos con los nombres de los departamentos
            cmbDepartamentosEmpresa.Items.AddRange(departamentosZonas.Keys.ToArray());
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
                string puertaComun = txtPuertaComun.Text;
                string usuarioComun = txtUsuarioComun.Text;
                string contraseñaComun = txtContraseñaComun.Text;
                string telefonoComun = txtTelefonoComun.Text;
                // Llamar al método para insertar un cliente común
                clienteManager.InsertarClienteComun(ciClienteComun, primerNombre, primerApellido, segundoNombre, segundoApellido, calleComun, puertaComun, usuarioComun, telefonoComun, contraseñaComun);
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

                // Llamar al método para insertar un cliente de empresa
                clienteManager.InsertarClienteEmpresa(rut, nomEmpresa, usuarioLoginEmpresa, contraseñaLoginEmpresa, telefonoEmpresa, calleEmpresa, puertaEmpresa, departamentoEmpresa, zonaEmpresa);

                // Limpiar los TextBox después de una inserción exitosa
                cbCondicionEmpresa.SelectedIndex = -1;
                txtRut.Text = "";
                txtNombreEmpresa.Text = "";
                txtUsuarioEmpresa.Text = "";
                txtContraseñaEmpresa.Text = "";
                txtTelefonoEmpresa.Text = "";
                txtCalleEmpresa.Text = "";
                txtPuertaEmpresa.Text = "";
                cmbDepartamentosEmpresa.SelectedIndex = -1;
                cmbZonasEmpresa.Items.Clear();

                MessageBox.Show("Cliente de empresa creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtContraseñaEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es un número ni una tecla de control.
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, suprime el carácter ingresado.
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

        private void cmbDepartamentosEmpresa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Cuando el usuario selecciona un departamento, llena el combo de zonas con las zonas correspondientes
            string selectedDepartamento = cmbDepartamentosEmpresa.SelectedItem as string;

            if (departamentosZonas.ContainsKey(selectedDepartamento))
            {
                cmbZonasEmpresa.Items.Clear();
                cmbZonasEmpresa.Items.AddRange(departamentosZonas[selectedDepartamento].ToArray());
            }
            else
            {
                cmbZonasEmpresa.Items.Clear();
            }
        }
        private string ObtenerNombreArchivoImagen(string zona)
        {
            Dictionary<string, string> zonasImagenes = new Dictionary<string, string>
        {
             { "Zona1", "imagen1.jpg" },
            { "Zona2", "imagen2.jpg" },
            { "Zona3", "imagen3.jpg" },
            { "Zona4", "imagen4.jpg" },
            { "Zona5", "imagen5.jpg" },
            { "Zona6", "imagen6.jpg" },
            { "Zona7", "imagen7.jpg" },
            { "Zona8", "imagen8.jpg" },
            { "Zona9", "imagen9.jpg" },
            { "Zona10", "imagen10.jpg" },
            { "Zona11", "imagen11.jpg" },
            { "Zona12", "imagen12.jpg" },
            { "Zona13", "imagen13.jpg" },
            { "Zona14", "imagen14.jpg" },
            { "Zona15", "imagen15.jpg" },
            { "Zona16", "imagen16.jpg" },
            { "Zona17", "imagen17.jpg" },
            { "Zona18", "imagen18.jpg" },
            { "Zona19", "imagen19.jpg" },
            { "Zona20", "imagen20.jpg" },
            { "Zona21", "imagen21.jpg" },
            { "Zona22", "imagen22.jpg" },
            { "Zona23", "imagen23.jpg" },
            { "Zona24", "imagen24.jpg" },
            { "Zona25", "imagen25.jpg" },
            { "Zona26", "imagen26.jpg" },
            { "Zona27", "imagen27.jpg" },
            { "Zona28", "imagen28.jpg" },
            { "Zona29", "imagen29.jpg" },
            { "Zona30", "imagen30.jpg" },
            { "Zona31", "imagen31.jpg" },
            { "Zona32", "imagen32.jpg" },
            { "Zona33", "imagen33.jpg" },
            { "Zona34", "imagen34.jpg" },
            { "Zona35", "imagen35.jpg" },
            { "Zona36", "imagen36.jpg" },
            { "Zona37", "imagen37.jpg" },
            { "Zona38", "imagen38.jpg" },
            { "Zona39", "imagen39.jpg" },
            { "Zona40", "imagen40.jpg" },
            { "Zona41", "imagen41.jpg" },
            { "Zona42", "imagen42.jpg" },
            { "Zona43", "imagen43.jpg" }
        };

            if (zonasImagenes.ContainsKey(zona))
            {
                return zonasImagenes[zona];
            }

            return null;
        }

        private void cmbZonasEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string zonaSeleccionada = cmbZonasEmpresa.SelectedItem as string;
            string nombreArchivoImagen = ObtenerNombreArchivoImagen(zonaSeleccionada);

            if (nombreArchivoImagen != null)
            {
                pcbZona.Image = (Image)Properties.Resources.ResourceManager.GetObject(nombreArchivoImagen);
            }
        }
    }
}
