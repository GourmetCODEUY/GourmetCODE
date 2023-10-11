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
                    //Inserta el usuario en la tabla "usuario"
                    string consultaUsuario = "INSERT INTO usuario (Usuario_Login, Contraseña_Login) VALUES (@UsuarioLogin, @ContraseñaLogin)";
                    MySqlCommand cmdUsuario = new MySqlCommand(consultaUsuario, conexion);
                    cmdUsuario.Parameters.AddWithValue("@UsuarioLogin", usuario.Usuario_Login);
                    cmdUsuario.Parameters.AddWithValue("@ContraseñaLogin", usuario.Contraseña_Login);

                    cmdUsuario.ExecuteNonQuery();

                    // Luego, inserta una fila en la tabla "rol" con la misma clave "Usuario_Login"
                    string consultaRol = "INSERT INTO rol (Rol, Usuario_Login) VALUES (@Rol, @Usuario_Login)";
                    MySqlCommand cmdRol = new MySqlCommand(consultaRol, conexion);
                    cmdRol.Parameters.AddWithValue("@Rol", usuario.Rol);
                    cmdRol.Parameters.AddWithValue("@Usuario_Login", usuario.Usuario_Login);
                    cmdRol.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el usuario en la base de datos." + ex.Message, ex);
            }
        }

        public void EliminarUsuario(string usuarioLogin)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    // Eliminar de la tabla 'rol'
                    string consultaRol = "DELETE FROM rol WHERE Usuario_Login = @UsuarioLogin";
                    MySqlCommand cmdRol = new MySqlCommand(consultaRol, conexion);
                    cmdRol.Parameters.AddWithValue("@UsuarioLogin", usuarioLogin);
                    cmdRol.ExecuteNonQuery();

                    // Eliminar de la tabla 'usuario' después de eliminar los registros relacionados en 'rol'
                    string consultaUsuario = "DELETE FROM usuario WHERE Usuario_Login = @UsuarioLogin";
                    MySqlCommand cmdUsuario = new MySqlCommand(consultaUsuario, conexion);
                    cmdUsuario.Parameters.AddWithValue("@UsuarioLogin", usuarioLogin);
                    cmdUsuario.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Agregar información sobre la excepción real al mensaje de error
                throw new Exception("Error al eliminar el usuario de la base de datos. Detalles: " + ex.Message, ex);
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
                    string consulta = "SELECT u.Usuario_Login, r.Rol FROM usuario u " +
                               "INNER JOIN rol r ON u.Usuario_Login = r.Usuario_Login";
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
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();

                    using (MySqlTransaction transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            // Actualizar la tabla 'usuario' primero
                            string consultaActualizarUsuario = @"UPDATE usuario SET Usuario_Login = @NuevoUsuarioLogin, Contraseña_Login = @NuevaContraseñaLogin WHERE Usuario_Login = @UsuarioLogin;";

                            MySqlCommand cmdActualizarUsuario = new MySqlCommand(consultaActualizarUsuario, conexion, transaccion);
                            cmdActualizarUsuario.Parameters.AddWithValue("@NuevoUsuarioLogin", nuevoUsuarioLogin);
                            cmdActualizarUsuario.Parameters.AddWithValue("@NuevaContraseñaLogin", nuevaContraseñaLogin);
                            cmdActualizarUsuario.Parameters.AddWithValue("@UsuarioLogin", usuarioLogin);
                            cmdActualizarUsuario.ExecuteNonQuery();

                            // Confirmar la transacción
                            transaccion.Commit();
                        }
                        catch (Exception ex)
                        {
                            // Si ocurre un error, hacer un rollback de la transacción
                            transaccion.Rollback();
                            throw new Exception("Error al modificar el usuario en la base de datos. Detalles: " + ex.Message, ex);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al conectar a la base de datos. Detalles: " + ex.Message, ex);
                }
            }
        }
    }
}