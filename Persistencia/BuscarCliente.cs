using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace proyecto.Persistencia
{
    internal class BuscarCliente
    {
        private readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["conexionSQL"].ConnectionString;
        public List<Cliente> ObtenerTodosLosClientesDesdeBD()
        {
            List<Cliente> clientes = new List<Cliente>();

            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT Num_Cliente, Calle_Cliente, Puerta_Cliente, Zona_cliente, Autorizacion, Condicion_Clinica, Telefono FROM cliente";
                MySqlCommand cmd = new MySqlCommand(consulta, conexion);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente
                        {
                            Num_Cliente = reader["Num_Cliente"].ToString(),
                            Calle_Cliente = reader["Calle_Cliente"].ToString(),
                            Puerta_Cliente = reader["Puerta_Cliente"].ToString(),
                            Zona_Cliente = reader["Zona_cliente"].ToString(),
                            Autorizacion = reader["Autorizacion"].ToString(),
                            Condicion_Clinica = reader["Condicion_Clinica"].ToString(),
                            Telefono = reader["Telefono"].ToString()
                        };

                        clientes.Add(cliente);
                    }
                }
            }

            return clientes;
        }
        public void ActualizarAutorizaciones(List<Cliente> clientesModificados)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            try
            {
                conexion.Open();

                foreach (var cliente in clientesModificados)
                {
                    string consulta = "UPDATE cliente SET Autorizacion = @Autorizacion WHERE Num_Cliente = @NumCliente";
                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@Autorizacion", cliente.Autorizacion);
                    cmd.Parameters.AddWithValue("@NumCliente", cliente.Num_Cliente);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades
                throw new Exception("Error al actualizar las autorizaciones en la base de datos: " + ex.Message, ex);
            }
            finally
            {
                // Asegurarse de cerrar la conexión, incluso en caso de excepción
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}
