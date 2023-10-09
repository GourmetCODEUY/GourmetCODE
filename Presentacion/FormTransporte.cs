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
    public partial class FormTransporte : Form
    {

        private Panel panel11Reference;
        private FormMenu formMenu;
        public FormTransporte(Panel panel11, FormMenu formMenu)
        {
            InitializeComponent();
            panel11Reference = panel11;
            this.formMenu = formMenu;
        }

        private void btnConsultaZonas_Click(object sender, EventArgs e)
        {
            FormZonas formzonas = new FormZonas();

            // Configurar el formulario secundario para que no tenga borde de formulario propio
            formzonas.FormBorderStyle = FormBorderStyle.None;

            // Establecer el formulario secundario como hijo del panel11
            formzonas.TopLevel = false;
            panel11Reference.Controls.Clear(); // Limpia el panel si ya hay controles en él
            panel11Reference.Controls.Add(formzonas);

            // Mostrar el formulario dentro del panel11
            formzonas.Show();
        }
    }
}
