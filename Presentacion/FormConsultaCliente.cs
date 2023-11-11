using proyecto.Persistencia;
using Proyecto.Logica;
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
    public partial class FormConsultaCliente : Form
    {
        private ConsultaPedidoManager consultarPedidoManager;
        public FormConsultaCliente()
        {
            InitializeComponent();
            consultarPedidoManager = new ConsultaPedidoManager();
            // Agregar estas líneas en algún lugar apropiado, como en el constructor del formulario
            dgvSuPedido.Columns.Add("ID_Pedido", "ID Pedido");
            dgvSuPedido.Columns.Add("Desc_Pedido", "Descripción Pedido");
            dgvSuPedido.Columns.Add("Calle_Cliente", "Calle Cliente");
            dgvSuPedido.Columns.Add("Puerta_Cliente", "Puerta Cliente");
            dgvSuPedido.Columns.Add("Zona_Cliente", "Zona Cliente");
            dgvSuPedido.Columns.Add("ID_Comida", "ID Comida");
            dgvSuPedido.Columns.Add("Estado_Pedido", "Estado Pedido");

        }

        private void btnConsultarPedidos_Click(object sender, EventArgs e)
        {
            try
            {
                string numeroClienteFormulario = txtNumCliente.Text;

                if (!string.IsNullOrEmpty(numeroClienteFormulario))
                {
                    List<Pedido> pedidos = consultarPedidoManager.ConsultarPedidosPorClienteDesdeFormulario(numeroClienteFormulario);

                    if (pedidos.Count > 0)
                    {
                        MostrarPedidosEnDataGridView(pedidos);
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron pedidos para el cliente especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Número de cliente no válido. Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar los pedidos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int ObtenerNumeroCliente()
        {
            // Implementa la lógica para obtener el número de cliente desde tu formulario.
            // Este es solo un ejemplo, debes adaptarlo según tu estructura.
            return Convert.ToInt32(txtNumCliente.Text);
        }
        private void MostrarPedidosEnDataGridView(List<Pedido> pedidos)
        {
            // Limpiar el DataGridView antes de mostrar nuevos datos
            dgvSuPedido.Rows.Clear();

            foreach (var pedido in pedidos)
            {
                // Agregar una nueva fila al DataGridView con la información del pedido
                dgvSuPedido.Rows.Add(
                    pedido.ID_Pedido,
                    pedido.Desc_Pedido,
                    pedido.Calle_Cliente,
                    pedido.Puerta_Cliente,
                    pedido.Zona_Cliente,
                    pedido.ID_Comida,
                    pedido.Estado_Pedido
                );
            }
        }
    }
}
