using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.Persistencia
{
    public class ModificarClientesP
    {
        private readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["conexionSQL"].ConnectionString;

        public DataTable ObtenerClientesComunes()
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT Num_Cliente, Segundo_Nombre, CI_Cliente_Comun, Primer_Nombre, Primer_Apellido, Segundo_Apellido, Usuario_Login, Contraseña_Login FROM cliente_comun";
                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                    {
                        DataTable tablaClientesComunes = new DataTable();
                        adaptador.Fill(tablaClientesComunes);
                        return tablaClientesComunes;
                    }
                }
            }
        }

        public DataTable ObtenerClientesEmpresas()
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT Num_Cliente, Rut, Nombre_Empresa, Usuario_Login, Contraseña_Login FROM cliente_empresa";
                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                    {
                        DataTable tablaClientesEmpresas = new DataTable();
                        adaptador.Fill(tablaClientesEmpresas);
                        return tablaClientesEmpresas;
                    }
                }
            }
        }

        public void ActualizarClientesComunes(DataTable tablaClientesComunes)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();

                foreach (DataRow fila in tablaClientesComunes.Rows)
                {
                    using (MySqlCommand comando = new MySqlCommand(
                        "UPDATE cliente_comun " +
                        "SET Segundo_Nombre = @Segundo_Nombre, " +
                        "CI_Cliente_Comun = @CI_Cliente_Comun, " +
                        "Primer_Nombre = @Primer_Nombre, " +
                        "Primer_Apellido = @Primer_Apellido, " +
                        "Segundo_Apellido = @Segundo_Apellido, " +
                        "Usuario_Login = @Usuario_Login, " +
                        "Contraseña_Login = @Contraseña_Login " +
                        "WHERE Num_Cliente = @Num_Cliente", conexion))
                    {
                        comando.Parameters.AddWithValue("@Segundo_Nombre", fila["Segundo_Nombre"]);
                        comando.Parameters.AddWithValue("@CI_Cliente_Comun", fila["CI_Cliente_Comun"]);
                        comando.Parameters.AddWithValue("@Primer_Nombre", fila["Primer_Nombre"]);
                        comando.Parameters.AddWithValue("@Primer_Apellido", fila["Primer_Apellido"]);
                        comando.Parameters.AddWithValue("@Segundo_Apellido", fila["Segundo_Apellido"]);
                        comando.Parameters.AddWithValue("@Usuario_Login", fila["Usuario_Login"]);
                        comando.Parameters.AddWithValue("@Contraseña_Login", fila["Contraseña_Login"]);
                        comando.Parameters.AddWithValue("@Num_Cliente", fila["Num_Cliente"]);

                        comando.ExecuteNonQuery();
                    }
                }
            }
        }

        public void ActualizarClientesEmpresas(DataTable tablaClientesEmpresas)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();

                foreach (DataRow fila in tablaClientesEmpresas.Rows)
                {
                    using (MySqlCommand comando = new MySqlCommand(
                        "UPDATE cliente_empresa " +
                        "SET Rut = @Rut, " +
                        "Nombre_Empresa = @Nombre_Empresa, " +
                        "Usuario_Login = @Usuario_Login, " +
                        "Contraseña_Login = @Contraseña_Login " +
                        "WHERE Num_Cliente = @Num_Cliente", conexion))
                    {
                        comando.Parameters.AddWithValue("@Rut", fila["Rut"]);
                        comando.Parameters.AddWithValue("@Nombre_Empresa", fila["Nombre_Empresa"]);
                        comando.Parameters.AddWithValue("@Usuario_Login", fila["Usuario_Login"]);
                        comando.Parameters.AddWithValue("@Contraseña_Login", fila["Contraseña_Login"]);
                        comando.Parameters.AddWithValue("@Num_Cliente", fila["Num_Cliente"]);
                        comando.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}