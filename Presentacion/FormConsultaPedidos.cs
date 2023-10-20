using Proyecto.Logica;
using Proyecto.Persistencia;

namespace proyecto.Presentacion
{
    public partial class FormConsultaPedidos : Form
    {
        private readonly ConsultaPedidoManager consultaPedidoManager;

        public FormConsultaPedidos()
        {
            InitializeComponent();
            consultaPedidoManager = new ConsultaPedidoManager();
        }

        private void btnConsultarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                List<Pedido> pedidos = consultaPedidoManager.ConsultarPedidos();

                // Limpia el contenido actual del DataGridView
                dgvPedidos.DataSource = null;
                dgvPedidos.Rows.Clear();
                dgvPedidos.Columns.Clear();
                // Vuelve a cargar los datos en el DataGridView
                dgvPedidos.DataSource = pedidos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar los pedidos: " + ex.Message + ex);
            }
        }

        private void FormConsultaPedidos_Load(object sender, EventArgs e)
        {
            btnConsultarPedido.PerformClick();
        }
    }
}
