using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
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
                            string consultaPedido = "INSERT INTO pedido (Desc_Pedido) " +
                                "VALUES (@DescPedido);";
                            MySqlCommand cmdPedido = new MySqlCommand(consultaPedido, conexion, transaction);
                            cmdPedido.Parameters.AddWithValue("@DescPedido", descPedido);
                            cmdPedido.ExecuteNonQuery();

                            // Obtener el ID_Pedido recién insertado
                            string obtenerIdPedido = "SELECT LAST_INSERT_ID();";
                            MySqlCommand cmdObtenerIdPedido = new MySqlCommand(obtenerIdPedido, conexion, transaction);
                            long idPedido = Convert.ToInt64(cmdObtenerIdPedido.ExecuteScalar());

                            // Insertar en la tabla "cliente" para guardar los datos del cliente
                            string consultaCliente = "INSERT INTO cliente (Calle_Cliente, Puerta_Cliente, Zona_Cliente, Barrio_Cliente) " +
                                "VALUES (@CalleCliente, @PuertaCliente, @ZonaCliente, @BarrioCliente)";
                            MySqlCommand cmdCliente = new MySqlCommand(consultaCliente, conexion, transaction);
                            cmdCliente.Parameters.AddWithValue("@CalleCliente", calleCliente);
                            cmdCliente.Parameters.AddWithValue("@PuertaCliente", puertaCliente);
                            cmdCliente.Parameters.AddWithValue("@ZonaCliente", zonaCliente);
                            cmdCliente.Parameters.AddWithValue("@BarrioCliente", barrioCliente);
                            cmdCliente.ExecuteNonQuery();

                            // Insertar en la tabla "realiza" para relacionar el pedido con el cliente
                            string consultaRealiza = "INSERT INTO realiza (Fecha_Pedido, ID_Pedido, Num_Cliente) " +
                                "VALUES (NOW(), @ID_Pedido, LAST_INSERT_ID())";
                            MySqlCommand cmdRealiza = new MySqlCommand(consultaRealiza, conexion, transaction);
                            cmdRealiza.Parameters.AddWithValue("@ID_Pedido", idPedido);
                            cmdRealiza.ExecuteNonQuery();

                            // Confirmar la transacción
                            transaction.Commit();

                            return true;
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
            catch (MySqlException mySqlEx)
            {
                // Agregar detalles específicos del error de MySQL
                string mensajeError = "Error al guardar el pedido en la base de datos. Detalles: " + mySqlEx.Message;
                throw new Exception(mensajeError, mySqlEx);
            }
        }
    }
}
