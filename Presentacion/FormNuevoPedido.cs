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

            List<Comida> comidas = new List<Comida>
            {
                new Comida { ID = 1, Nombre = "Hamburguesa de carne con puré de papas" },
                new Comida { ID = 2, Nombre = "Solomillo al jerez con boniatos escrachados" },
                new Comida { ID = 3, Nombre = "Suprema sinfonía con mix Pacabó" },
                new Comida { ID = 4, Nombre = "Risotto de hongos" },
                new Comida { ID = 5, Nombre = "Chop suey de pollo con arroz azafrán" },
                new Comida { ID = 6, Nombre = "Arrollado de pollo con ens. de zanahoria y cebolla" },
                new Comida { ID = 7, Nombre = "Bondiola criolla con papas a la crema" },
                new Comida { ID = 8, Nombre = "Suprema teriyaki con papas bravas" },
                new Comida { ID = 9, Nombre = "Cerdo agridulce con arroz" },
                new Comida { ID = 10, Nombre = "Muslo con salsa de tomate y albahaca con puré" },
                new Comida { ID = 11, Nombre = "Albóndigas con spaghettis" },
                new Comida { ID = 12, Nombre = "Arroz a la valenciana" },
                new Comida { ID = 13, Nombre = "Bondiola a la salsa naranja con puré" },
                new Comida { ID = 14, Nombre = "Cazuela de lentejas con arroz" },
                new Comida { ID = 15, Nombre = "Suprema a la portuguesa con boniatos escrachados" },
                new Comida { ID = 16, Nombre = "Strogonoff de pollo con arroz" },
                new Comida { ID = 17, Nombre = "Solomillo al jerez con zanahorias glaseadas" },
                new Comida { ID = 18, Nombre = "Suprema limón con Puré de calabaza" },
                new Comida { ID = 19, Nombre = "Mejillones a la marinera con arroz azafrán" },
                new Comida { ID = 20, Nombre = "Carré con ananá con puré mixto" }
            };

            // Configurar el DataGridView
            dgvComidas.AutoGenerateColumns = true; // Puedes configurar las columnas en el diseñador visual si prefieres.

            // Establecer la fuente de datos
            dgvComidas.DataSource = comidas;

            // Configurar la visibilidad de la columna ID
            dgvComidas.Columns["ID"].Visible = false;
        }
        public class Comida
        {
            public string Nombre { get; set; }
            public int ID { get; set; }
        }
        private void FormNuevoPedido_Load(object sender, EventArgs e)
        {
        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {

        }
    }
}