using proyecto.Logica;
using Proyecto.Persistencia;
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

    public partial class FormConsultaProductos : Form
    {
        private readonly ConsultaProducto consultaProducto;
        public FormConsultaProductos()
        {
            InitializeComponent();
            consultaProducto = new ConsultaProducto();
        }

        private void btnConsultaProducto_Click(object sender, EventArgs e)
        {
            try
            {
                List<Producto> productosHabilitados = consultaProducto.ConsultarProductosHabilitados();
                dgvConsultaProducto.DataSource = null;
                dgvConsultaProducto.Rows.Clear();
                dgvConsultaProducto.Columns.Clear();
                dgvConsultaProducto.DataSource = productosHabilitados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar los productos habilitados: " + ex.Message);
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                // Itera a través de las filas del DataGridView para obtener los cambios en "Habilitado"
                foreach (DataGridViewRow row in dgvConsultaProducto.Rows)
                {
                    bool nuevoValor = Convert.ToBoolean(row.Cells["Habilitado"].Value);
                    int numMenu = Convert.ToInt32(row.Cells["Num_Menu"].Value);

                    // Actualiza el estado en la base de datos
                    consultaProducto.ActualizarEstadoProducto(numMenu, nuevoValor);
                }

                // Itera a través de las filas del DataGridView para obtener los cambios en "Habilitado"
                foreach (DataGridViewRow row in dgvConsultaProductoDeshabilitado.Rows)
                {
                    bool nuevoValor = Convert.ToBoolean(row.Cells["Habilitado"].Value);
                    int numMenu = Convert.ToInt32(row.Cells["Num_Menu"].Value);

                    // Actualiza el estado en la base de datos
                    consultaProducto.ActualizarEstadoProducto(numMenu, nuevoValor);
                }

                MessageBox.Show("Cambios guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpia y actualiza ambos DataGridViews
                dgvConsultaProducto.DataSource = null;
                dgvConsultaProducto.Rows.Clear();
                dgvConsultaProducto.Columns.Clear();
                dgvConsultaProductoDeshabilitado.DataSource = null;
                dgvConsultaProductoDeshabilitado.Rows.Clear();
                dgvConsultaProductoDeshabilitado.Columns.Clear();

                btnConsultaProducto.PerformClick(); // Simula un clic en el botón "Consultar" de dgvConsultaProducto
                btnConsultarProductoDeshabilitado.PerformClick(); // Simula un clic en el botón "Consultar" de dgvConsultaProductoDeshabilitado
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarDataGridView()
        {
            try
            {
                // Vuelve a consultar los datos de la base de datos
                List<Producto> productos = consultaProducto.ConsultarProductos(); // Consulta solo los productos habilitados
                dgvConsultaProducto.DataSource = null;
                dgvConsultaProducto.Rows.Clear();
                dgvConsultaProducto.Columns.Clear();
                dgvConsultaProducto.DataSource = productos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los DataGridView: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultarProductoDeshabilitado_Click(object sender, EventArgs e)
        {
            try
            {
                List<Producto> productosDeshabilitados = consultaProducto.ConsultarProductosDeshabilitados();
                dgvConsultaProductoDeshabilitado.DataSource = null;
                dgvConsultaProductoDeshabilitado.Rows.Clear();
                dgvConsultaProductoDeshabilitado.Columns.Clear();
                dgvConsultaProductoDeshabilitado.DataSource = productosDeshabilitados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar los productos deshabilitados: " + ex.Message);
            }
        }

        private void FormConsultaProductos_Load(object sender, EventArgs e)
        {
            btnConsultaProducto.PerformClick();
            btnConsultarProductoDeshabilitado.PerformClick();
        }
    }
}
