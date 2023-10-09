using System;
using MySql.Data.MySqlClient;
using System.Configuration;
using MySqlX.XDevAPI.Relational;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Reflection;

namespace proyecto.Persistencia
{
    public class Usuario
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["conexionSQL"].ConnectionString;

        public int VerificarCredenciales(string usuario, string contraseña)
        {
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                int rol = 0;
                conexion.Open();
                string sql = "SELECT r.Rol FROM rol r INNER JOIN usuario u ON r.Usuario_Login = u.Usuario_Login WHERE u.Usuario_Login = @usuario AND u.Contraseña_Login = @contraseña; ";
                MySqlCommand comandoSql = new MySqlCommand(sql, conexion);
                comandoSql.Parameters.AddWithValue("@usuario", usuario);
                comandoSql.Parameters.AddWithValue("@contraseña", contraseña);

                int count = Convert.ToInt32(comandoSql.ExecuteScalar());

                return count;
            }
        }
    }
}