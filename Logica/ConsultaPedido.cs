using MySql.Data.MySqlClient;
using Proyecto.Persistencia;

namespace Proyecto.Logica
{
    internal class ConsultaPedidoManager
    {
        private readonly ConsultarPedido consultarPedido;
        public ConsultaPedidoManager()
        {
            consultarPedido = new ConsultarPedido();

        }

        public List<Pedido> ConsultarPedidos()
        {
            try
            {
                return consultarPedido.ObtenerPedidos();
            }
            catch (MySqlException mySqlEx)
            {
                // Agregar detalles específicos del error de MySQL
                string mensajeError = mySqlEx.Message;
                throw new Exception(mensajeError, mySqlEx);
            }
        }

        public List<Pedido> ConsultarPedidosPorClienteDesdeFormulario(string numeroClienteFormulario)
        {
            try
            {
                // Llama al método de la capa de persistencia
                return consultarPedido.ObtenerPedidosPorCliente(Convert.ToInt32(numeroClienteFormulario));
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al consultar los pedidos por cliente: {ex.Message}", ex);
            }
        }
    }
}
