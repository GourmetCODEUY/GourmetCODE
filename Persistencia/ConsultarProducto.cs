using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Proyecto.Persistencia;
namespace Proyecto.Persistencia
{
    public class Producto
    {
        public int Num_Menu { get; set; }
        public string Desc_Menu { get; set; }
        public int Stock_Real { get; set; }
        public int Stock_Minimo { get; set; }
        public int Stock_Maximo { get; set; }
        public bool Habilitado { get; set; }
    }
    public class ConsultarProductoRepository
    {
        private readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["conexionSQL"].ConnectionString;

        public List<Producto> ObtenerProductos()
        {
            List<Producto> productosList = new List<Producto>();
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "SELECT Num_Menu, Desc_Menu, Stock_Real, Stock_Minimo, Stock_Maximo, Habilitado " +
                                      "FROM menu";
                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Producto producto = new Producto
                        {
                            Num_Menu = Convert.ToInt32(reader["Num_Menu"]),
                            Desc_Menu = reader["Desc_Menu"].ToString(),
                            Stock_Real = Convert.ToInt32(reader["Stock_Real"]),
                            Stock_Minimo = Convert.ToInt32(reader["Stock_Minimo"]),
                            Stock_Maximo = Convert.ToInt32(reader["Stock_Maximo"]),
                            Habilitado = Convert.ToBoolean(reader["Habilitado"])
                        };
                        productosList.Add(producto);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los productos desde la base de datos.", ex);
            }
            return productosList;
        }
        public void ActualizarEstadoProducto(int numMenu, bool nuevoEstado)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "UPDATE menu SET Habilitado = @NuevoEstado WHERE Num_Menu = @NumMenu";
                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@NuevoEstado", nuevoEstado);
                    cmd.Parameters.AddWithValue("@NumMenu", numMenu);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el estado en la base de datos.", ex);
            }
        }
    }
}
