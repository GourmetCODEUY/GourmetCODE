using MySql.Data.MySqlClient;
using proyecto.Persistencia;

namespace proyecto.Logica
{
    internal class NuevoPedidoManager
    {
        public List<string> ObtenerZonas()
        {
            try
            {
                // En una aplicación real, puedes obtener las zonas desde la capa de persistencia
                List<string> zonas = new List<string>
                {

                };
                return zonas;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las zonas.", ex);
            }
        }

        public bool GuardarPedido(string descPedido, string calleCliente, string puertaCliente, string zonaCliente, string barrioCliente)
        {
            try
            {
                NuevoPedido persistencia = new NuevoPedido();
                bool resultado = persistencia.GuardarPedido(descPedido, calleCliente, puertaCliente,zonaCliente, barrioCliente);

                // Aquí puedes agregar lógica adicional si es necesario
                // Por ejemplo, actualizar la interfaz de usuario o realizar otras operaciones relacionadas con el pedido.

                return resultado;
            }
            catch (MySqlException mySqlEx)
            {
                // Agregar detalles específicos del error de MySQL
                string mensajeError = "Error al guardar el pedido en la base de datos. Detalles: " + mySqlEx.Message;
                throw new Exception(mensajeError, mySqlEx);
            }
        }
    }
}