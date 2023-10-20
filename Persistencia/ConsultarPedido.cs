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
        public string Barrio_Cliente { get; set; }
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
                    try
                    {
                        string consulta = "SELECT pedido.ID_Pedido, pedido.Desc_Pedido, cliente.Calle_Cliente, cliente.Puerta_Cliente, cliente.Zona_cliente, cliente.Barrio_Cliente, realiza.Fecha_Pedido, contiene_pedido.ID_Comida\r\nFROM pedido\r\nINNER JOIN realiza ON pedido.ID_Pedido = realiza.ID_Pedido\r\nINNER JOIN contiene_pedido ON pedido.ID_Pedido = contiene_pedido.ID_Pedido\r\nINNER JOIN cliente ON realiza.Num_Cliente = cliente.Num_Cliente\r\nLIMIT 0, 25;\r\n";
                        MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Pedido pedido = new Pedido
                            {
                                ID_Pedido = Convert.ToInt32(reader["ID_Pedido"]),
                                Desc_Pedido = reader["Desc_Pedido"].ToString(),
                                Calle_Cliente = reader["Calle_Cliente"].ToString(),
                                Puerta_Cliente = reader["Puerta_Cliente"].ToString(),
                                Zona_Cliente = reader["Zona_cliente"].ToString(),
                            };
                            pedidoList.Add(pedido);
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
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los datos de pedidos desde la base de datos.", ex);
            }
            return pedidoList;
        }
    }
}
