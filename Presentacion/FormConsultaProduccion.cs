using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Persistencia; // Usa el espacio de nombres correcto

namespace proyecto.Presentacion
{
    public partial class FormConsultaProduccion : Form
    {
        private readonly ConsultarProduccionRepository consultarProduccionManager;
        public FormConsultaProduccion()
        {
            InitializeComponent();
            consultarProduccionManager = new ConsultarProduccionRepository();
        }
        private void btnConsultaProduccion_Click(object sender, EventArgs e)
        {
            try
            {
                List<Produccion> produccion = consultarProduccionManager.ObtenerProduccion();

                // Limpia el contenido actual del DataGridView
                dgvConsultaProduccion.DataSource = null;
                dgvConsultaProduccion.Rows.Clear();
                dgvConsultaProduccion.Columns.Clear();

                // Vuelve a cargar los datos en el DataGridView
                dgvConsultaProduccion.DataSource = produccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar la producción: " + ex.Message);
            }
        }
    }
}
