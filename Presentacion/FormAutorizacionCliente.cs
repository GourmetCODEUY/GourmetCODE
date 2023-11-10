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
    public partial class FormAutorizacionCliente : Form
    {
        private ClienteManager clienteManager;

        public FormAutorizacionCliente()
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

           
            // Configurar la edición de columnas
            ConfigurarEdicionColumnas();
        }

        

        private void FormAutorizacionCliente_Load(object sender, EventArgs e)
        {
            CargarClientes();
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
        private void ConfigurarEdicionColumnas()
        {
            // Deshabilitar la edición para todas las columnas
            foreach (DataGridViewColumn columna in dgvClientes.Columns)
            {
                columna.ReadOnly = true;
            }

            // Habilitar la edición solo para la columna "Autorizacion"
            dgvClientes.Columns["Autorizacion"].ReadOnly = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Obtener los cambios del DataGridView
            List<Cliente> clientesModificados = new List<Cliente>();
            // Verifica si la columna "Num_Cliente" existe
            if (dgvClientes.Columns["Num_Cliente"] == null)
            {
                MessageBox.Show("La columna 'Num_Cliente' no existe en el DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica si la columna "Autorizacion" existe
            if (dgvClientes.Columns["Autorizacion"] == null)
            {
                MessageBox.Show("La columna 'Autorizacion' no existe en el DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (DataGridViewRow row in dgvClientes.Rows)
            {
                // Verificar si la celda "Num_Cliente" no es nula antes de intentar acceder al valor
                if (row.Cells["Num_Cliente"] != null && row.Cells["Num_Cliente"].Value != null)
                {
                    string numCliente = row.Cells["Num_Cliente"].Value.ToString();
                    string autorizacion = row.Cells["Autorizacion"].Value.ToString();

                    // Validar que el valor sea "0" o "1"
                    if (EsValorValidoAutorizacion(autorizacion))
                    {
                        clientesModificados.Add(new Cliente
                        {
                            Num_Cliente = numCliente,
                            Autorizacion = autorizacion
                        });
                    }
                    else
                    {
                        MessageBox.Show("La columna 'Autorizacion' solo puede contener valores '0' o '1'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Detener la actualización si hay un valor incorrecto
                    }
                }
            }

            // Aplicar modificaciones
            try
            {
                clienteManager.ActualizarAutorizaciones(clientesModificados);
                MessageBox.Show("Modificaciones aplicadas correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aplicar modificaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool EsValorValidoAutorizacion(string valor)
        {
            // Verificar que el valor sea "0" o "1"
            return valor == "0" || valor == "1";
        }

    }
}
