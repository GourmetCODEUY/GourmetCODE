using proyecto.Logica;
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
    public partial class FormUsuarios : Form
    {
        private bool isLabelGreen = false;
        private readonly GestionarUsuarios gestionarUsuarios;
        private DataTable dtUsuarios; // Variable para almacenar los datos del DataGridView

        public FormUsuarios()
        {
            InitializeComponent();
            txtMUsuarioLogin.Visible = false;
            txtMcontraseñaLogin.Visible = false;
            lblMcontraseña.Visible = false;
            lblMUsuario.Visible = false;
            ConfigurarEventos();
            gestionarUsuarios = new GestionarUsuarios();
            txtContraseñaLogin.PasswordChar = '*';
            try
            {
                ActualizarDgvUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar gestorUsuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarEventos()
        {
            // Validación de entrada del campo de "Usuario"
            txtUsuarioLogin.KeyPress += (sender, e) =>
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; // Bloquea cualquier carácter que no sea letra o control.
                }
            };

            // Manejar la visibilidad de la contraseña al hacer clic en el PictureBox
            pctBoxVer.Click += (sender, e) =>
            {
                if (txtContraseñaLogin.PasswordChar == '*')
                {
                    txtContraseñaLogin.PasswordChar = '\0'; // Mostrar la contraseña (sin asteriscos)
                }
                else
                {
                    txtContraseñaLogin.PasswordChar = '*'; // Ocultar la contraseña (con asteriscos)
                }
            };

            // Suscribirse al evento CellEndEdit para actualizar el DataTable
            dgvUsuarios.CellEndEdit += dgvUsuarios_CellEndEdit;
        }

        private void dgvUsuarios_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Obtiene la fila y la celda editada
            DataGridViewRow editedRow = dgvUsuarios.Rows[e.RowIndex];
            DataGridViewCell editedCell = editedRow.Cells[e.ColumnIndex];

            // Actualiza el valor en el DataTable subyacente
            dtUsuarios.Rows[editedRow.Index][editedCell.ColumnIndex] = editedCell.Value;
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string usuarioLogin = txtUsuarioLogin.Text;
                string contraseñaLogin = txtContraseñaLogin.Text;
                int rol = Convert.ToInt32(cmbRol.SelectedValue);

                gestionarUsuarios.InsertarUsuario(usuarioLogin, contraseñaLogin, rol);

                MessageBox.Show("Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtUsuarioLogin.Clear();
                txtContraseñaLogin.Clear();

                // Desactiva la actualización automática del DataGridView
                dgvUsuarios.SuspendLayout();

                // Llama a la función para cargar datos en el DataGridView
                ActualizarDgvUsuarios();

                // Permite que la interfaz de usuario se actualice
                Application.DoEvents();

                // Activa la actualización automática del DataGridView
                dgvUsuarios.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            var roles = new[]
            {
                new { Id = 1, Nombre = "Informatico" },
                new { Id = 2, Nombre = "Gerente" },
                new { Id = 3, Nombre = "Administracion" },
                new { Id = 4, Nombre = "Cocina" },
                new { Id = 5, Nombre = "Transporte" },
                new { Id = 6, Nombre = "Publico" }
            };

            cmbRol.DataSource = roles;
            cmbRol.ValueMember = "Id";
            cmbRol.DisplayMember = "Nombre";

            // Agrega columnas al DataGridView
            dgvUsuarios.Columns.Add("Usuario_Login", "Usuario");
            dgvUsuarios.Columns.Add("Rol", "Rol");

            // Asegura que la configuración de las columnas esté completa antes de cargar los datos
            dgvUsuarios.Refresh();

            // Llama a la función para cargar datos en el DataGridView
            ActualizarDgvUsuarios();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                string usuarioLogin = dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString();

                try
                {
                    gestionarUsuarios.EliminarUsuario(usuarioLogin);
                    MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Desactiva la actualización automática del DataGridView
                    dgvUsuarios.SuspendLayout();

                    // Llama a la función para cargar datos en el DataGridView
                    ActualizarDgvUsuarios();

                    // Permite que la interfaz de usuario se actualice
                    Application.DoEvents();

                    // Activa la actualización automática del DataGridView
                    dgvUsuarios.ResumeLayout();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un usuario para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ActualizarDgvUsuarios()
        {
            try
            {
                dgvUsuarios.Rows.Clear();
                dtUsuarios = gestionarUsuarios.ObtenerUsuarios();

                foreach (DataRow row in dtUsuarios.Rows)
                {
                    dgvUsuarios.Rows.Add(row["Usuario_Login"], row["Rol"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la lista de usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pctBoxVer_Click(object sender, EventArgs e)
        {
            if (isLabelGreen)
            {
                lblContraseña.ForeColor = Color.Red; // Cambia a rojo
            }
            else
            {
                lblContraseña.ForeColor = Color.GreenYellow; // Cambia a verde
            }

            // Cambia el estado para la próxima vez
            isLabelGreen = !isLabelGreen;
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvUsuarios.SelectedRows[0];

                // Verifica si la fila seleccionada contiene datos válidos antes de continuar
                if (selectedRow.Cells[0].Value != null && selectedRow.Cells[1].Value != null)
                {
                    string usuarioLogin = selectedRow.Cells["Usuario_Login"].Value.ToString();

                    // Asegúrate de que el valor seleccionado del ComboBox sea una cadena válida
                    if (cmbRol.SelectedValue != null && int.TryParse(cmbRol.SelectedValue.ToString(), out int nuevoRol))
                    {
                        try
                        {
                            string nuevoUsuarioLogin = txtMUsuarioLogin.Text;
                            string nuevaContraseñaLogin = txtMcontraseñaLogin.Text;

                            // Llama al método para actualizar el nombre de usuario y contraseña
                            gestionarUsuarios.ModificarUsuario(usuarioLogin, nuevoUsuarioLogin, nuevaContraseñaLogin, nuevoRol);

                            MessageBox.Show("Usuario modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Actualiza los datos en el DataTable y el DataGridView
                            ActualizarDgvUsuarios();

                            // Limpia los campos de texto después de la modificación
                            txtMUsuarioLogin.Clear();
                            txtMcontraseñaLogin.Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al modificar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecciona un rol válido para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un usuario válido para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvUsuarios.SelectedRows[0];

                // Verifica si la fila seleccionada contiene datos válidos antes de habilitar los controles
                if (selectedRow.Cells[0].Value != null && selectedRow.Cells[1].Value != null)
                {
                    txtMUsuarioLogin.Visible = true;
                    txtMcontraseñaLogin.Visible = true;
                    lblMcontraseña.Visible = true;
                    lblMUsuario.Visible = true;
                }
                else
                {
                    // Si la fila seleccionada no contiene datos válidos, deshabilita los controles
                    txtMUsuarioLogin.Visible = false;
                    txtMcontraseñaLogin.Visible = false;
                    lblMcontraseña.Visible = false;
                    lblMUsuario.Visible = false;
                }
            }
            else
            {
                // Si no hay filas seleccionadas, deshabilita los controles
                txtMUsuarioLogin.Visible = false;
                txtMcontraseñaLogin.Visible = false;
                lblMcontraseña.Visible = false;
                lblMUsuario.Visible = false;
            }
        }
    }
}