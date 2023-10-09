using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;

namespace Proyecto.Persistencia
{
    public class Usuario
    {
        public string Usuario_Login { get; set; }
        public string Contraseña_Login { get; set; }
        public int Rol { get; set; }
    }

    public class UsuarioRepository
    {
        private readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["conexionSQL"].ConnectionString;

        public void InsertarUsuario(Usuario usuario)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "INSERT INTO usuario (Usuario_Login, Contraseña_Login, Rol) " +
                                      "VALUES (@UsuarioLogin, @ContraseñaLogin, @Rol)";
                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@UsuarioLogin", usuario.Usuario_Login);
                    cmd.Parameters.AddWithValue("@ContraseñaLogin", usuario.Contraseña_Login);
                    cmd.Parameters.AddWithValue("@Rol", usuario.Rol);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el usuario en la base de datos.", ex);
            }
        }

        public void EliminarUsuario(string usuarioLogin)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "DELETE FROM usuario WHERE Usuario_Login = @UsuarioLogin";
                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@UsuarioLogin", usuarioLogin);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el usuario de la base de datos.", ex);
            }
        }

        public DataTable ObtenerUsuarios()
        {
            try
            {
                DataTable dt = new DataTable();
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "SELECT Usuario_Login, Rol FROM usuario";
                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de usuarios de la base de datos.", ex);
            }
        }

        public void ModificarUsuario(string usuarioLogin, string nuevoUsuarioLogin, string nuevaContraseñaLogin, int nuevoRol)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "UPDATE usuario SET Usuario_Login = @NuevoUsuarioLogin, Contraseña_Login = @NuevaContraseñaLogin, Rol = @NuevoRol WHERE Usuario_Login = @UsuarioLogin";
                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                    cmd.Parameters.AddWithValue("@NuevoUsuarioLogin", nuevoUsuarioLogin);
                    cmd.Parameters.AddWithValue("@NuevaContraseñaLogin", nuevaContraseñaLogin);
                    cmd.Parameters.AddWithValue("@NuevoRol", nuevoRol);
                    cmd.Parameters.AddWithValue("@UsuarioLogin", usuarioLogin);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el usuario en la base de datos.", ex);
            }
        }
    }
}
