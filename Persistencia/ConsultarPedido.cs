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
                    string consulta = "SELECT ID_Pedido, Desc_Pedido, Calle_Cliente, Puerta_Cliente, Zona_Cliente, Barrio_Cliente " +
                                      "FROM pedido " +
                                      "LIMIT 0, 25";
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
                            Zona_Cliente = reader["Zona_Cliente"].ToString(),
                            Barrio_Cliente = reader["Barrio_Cliente"].ToString()
                        };
                        pedidoList.Add(pedido);
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
