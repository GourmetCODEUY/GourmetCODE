using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace Proyecto.Persistencia
{
    public class Pedido
    {
        public int ID_Pedido { get; set; }
        public string Desc_Pedido { get; set; }
        public string Calle_Cliente { get; set; }
        public string Puerta_Cliente { get; set; }
        public string Zona_Cliente { get; set; }
        public int ID_Comida { get; set; }
        public string Estado_Pedido { get; set; }
    }

    public class ConsultarPedido
    {
        private readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["conexionSQL"].ConnectionString;

        public List<Pedido> ObtenerPedidos()
        {
            List<Pedido> pedidoList = new List<Pedido>();

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta = "SELECT pedido.ID_Pedido, pedido.Desc_Pedido, cliente.Calle_Cliente, cliente.Puerta_Cliente, cliente.Zona_cliente, contiene_pedido.ID_Comida, estado_pedido.Estado_Pedido " +
                               "FROM pedido " +
                               "INNER JOIN realiza ON pedido.ID_Pedido = realiza.ID_Pedido " +
                               "INNER JOIN contiene_pedido ON pedido.ID_Pedido = contiene_pedido.ID_Pedido " +
                               "INNER JOIN cliente ON realiza.Num_Cliente = cliente.Num_Cliente " +
                               "LEFT JOIN pasa_pedido ON pedido.ID_Pedido = pasa_pedido.ID_Pedido " +
                               "LEFT JOIN estado_pedido ON pasa_pedido.ID_Estado_Pedido = estado_pedido.ID_Estado_Pedido";

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Pedido pedido = new Pedido
                                {
                                    ID_Pedido = reader.GetInt32("ID_Pedido"),
                                    Desc_Pedido = reader.GetString("Desc_Pedido"),
                                    Calle_Cliente = reader.GetString("Calle_Cliente"),
                                    Puerta_Cliente = reader.GetString("Puerta_Cliente"),
                                    Zona_Cliente = reader.GetString("Zona_cliente"),
                                    ID_Comida = reader.GetInt32("ID_Comida"),
                                    Estado_Pedido = reader.IsDBNull(reader.GetOrdinal("Estado_Pedido")) ? null : reader.GetString("Estado_Pedido")
                                };
                                pedidoList.Add(pedido);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los datos de pedidos desde la base de datos.", ex);
            }

            return pedidoList;
        }

        public List<Pedido> ObtenerPedidosPorCliente(int numeroCliente)
        {
            List<Pedido> pedidoList = new List<Pedido>();

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string consulta = "SELECT pedido.ID_Pedido, pedido.Desc_Pedido, cliente.Calle_Cliente, cliente.Puerta_Cliente, cliente.Zona_cliente, contiene_pedido.ID_Comida, estado_pedido.Estado_Pedido " +
                                "FROM pedido " +
                                "INNER JOIN realiza ON pedido.ID_Pedido = realiza.ID_Pedido " +
                                "INNER JOIN contiene_pedido ON pedido.ID_Pedido = contiene_pedido.ID_Pedido " +
                                "INNER JOIN cliente ON realiza.Num_Cliente = cliente.Num_Cliente " +
                                "LEFT JOIN pasa_pedido ON pedido.ID_Pedido = pasa_pedido.ID_Pedido " +
                                "LEFT JOIN estado_pedido ON pasa_pedido.ID_Estado_Pedido = estado_pedido.ID_Estado_Pedido " +
                                "WHERE cliente.Num_Cliente = @NumeroCliente"; // Agregar el filtro por cliente

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@NumeroCliente", numeroCliente);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Pedido pedido = new Pedido
                                {
                                    ID_Pedido = reader.GetInt32("ID_Pedido"),
                                    Desc_Pedido = reader.GetString("Desc_Pedido"),
                                    Calle_Cliente = reader.GetString("Calle_Cliente"),
                                    Puerta_Cliente = reader.GetString("Puerta_Cliente"),
                                    Zona_Cliente = reader.GetString("Zona_cliente"),
                                    ID_Comida = reader.GetInt32("ID_Comida"),
                                    Estado_Pedido = reader.IsDBNull(reader.GetOrdinal("Estado_Pedido")) ? null : reader.GetString("Estado_Pedido")
                                };
                                pedidoList.Add(pedido);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los datos de pedidos por cliente desde la base de datos.", ex);
            }

            return pedidoList;
        }
    }
}
