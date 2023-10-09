using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace proyecto.Persistencia
{
    internal class NuevoPedido
    {
        private readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["conexionSQL"].ConnectionString;

        public bool GuardarPedido(string descPedido, string calleCliente, string puertaCliente, string zonaCliente, string barrioCliente)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    using (MySqlTransaction transaction = conexion.BeginTransaction()) // Comienza una transacción
                    {
                        try
                        {
                            // Insertar en la tabla "pedido" y obtener el ID_Pedido recién insertado
                            string consultaPedido = "INSERT INTO pedido (Desc_Pedido, Calle_Cliente, Puerta_Cliente, Zona_Cliente, Barrio_Cliente) " +
                                                    "VALUES (@DescPedido, @CalleCliente, @PuertaCliente, @ZonaCliente, @BarrioCliente); " +
                                                    "SELECT LAST_INSERT_ID();";
                            MySqlCommand cmdPedido = new MySqlCommand(consultaPedido, conexion, transaction);
                            cmdPedido.Parameters.AddWithValue("@DescPedido", descPedido);
                            cmdPedido.Parameters.AddWithValue("@CalleCliente", calleCliente);
                            cmdPedido.Parameters.AddWithValue("@PuertaCliente", puertaCliente);
                            cmdPedido.Parameters.AddWithValue("@ZonaCliente", zonaCliente);
                            cmdPedido.Parameters.AddWithValue("@BarrioCliente", barrioCliente);
                            long idPedido = Convert.ToInt64(cmdPedido.ExecuteScalar());

                            // Insertar en la tabla "estado_pedido" con estado "Solicitado" y el ID_Pedido obtenido
                            string consultaEstadoPedido = "INSERT INTO estado_pedido (ID_Pedido, Estado_Pedido) " +
                                                          "VALUES (@ID_Pedido, 'Solicitado')";
                            MySqlCommand cmdEstadoPedido = new MySqlCommand(consultaEstadoPedido, conexion, transaction);
                            cmdEstadoPedido.Parameters.AddWithValue("@ID_Pedido", idPedido);
                            cmdEstadoPedido.ExecuteNonQuery();

                            // Confirmar la transacción
                            transaction.Commit();

                            return true;
                        }
                        catch (Exception ex)
                        {
                            // En caso de error, hacer un rollback de la transacción para deshacer cualquier cambio
                            transaction.Rollback();
                            throw new Exception("Error al guardar el pedido en la base de datos.", ex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar el pedido en la base de datos.", ex);
            }
        }
    }
}
