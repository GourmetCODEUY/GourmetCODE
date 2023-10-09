using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace Proyecto.Persistencia
{
    public class Produccion
    {
        public int ID_Estado_Producto { get; set; }
        public string Estado_Producto { get; set; }
        public int ID_Comida { get; set; }
        public string Desc_Menu { get; set; }
    }
    public class ConsultarProduccionRepository
    {
        private readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["conexionSQL"].ConnectionString;

        public List<Produccion> ObtenerProduccion()
        {
            List<Produccion> produccionList = new List<Produccion>();
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "SELECT p.ID_Estado_Producto, p.Estado_Producto, p.ID_Comida, m.Desc_Menu " +
                                      "FROM estado_producto p " +
                                      "INNER JOIN menu m ON p.ID_Comida = m.Num_Menu ";
                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Produccion produccion = new Produccion
                        {
                            ID_Estado_Producto = Convert.ToInt32(reader["ID_Estado_Producto"]),
                            Estado_Producto = reader["Estado_Producto"].ToString(),
                            ID_Comida = Convert.ToInt32(reader["ID_Comida"]),
                            Desc_Menu = reader["Desc_Menu"].ToString()

                        };
                        produccionList.Add(produccion);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los datos de producción desde la base de datos.", ex);
            }
            return produccionList;
        }
    }
}