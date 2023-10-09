using MySqlX.XDevAPI.Relational;
using Proyecto.Persistencia;
using System;
using System.Data;

namespace proyecto.Logica
{
    public class GestionarUsuarios
    {
        private readonly UsuarioRepository usuarioRepository;

        public GestionarUsuarios()
        {
            usuarioRepository = new UsuarioRepository();
        }

        public void InsertarUsuario(string usuarioLogin, string contraseñaLogin, int rol)
        {
            try
            {
                // Verificar si el nombre de usuario y la contraseña cumplen con los criterios
                if (string.IsNullOrWhiteSpace(usuarioLogin))
                {
                    throw new Exception("El nombre de usuario no puede estar vacío.");
                }

                if (contraseñaLogin.Length < 8)
                {
                    throw new Exception("La contraseña debe tener al menos 8 caracteres.");
                }

                Usuario nuevoUsuario = new Usuario
                {
                    Usuario_Login = usuarioLogin,
                    Contraseña_Login = contraseñaLogin,
                    Rol = rol
                };

                usuarioRepository.InsertarUsuario(nuevoUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el usuario: " + ex.Message);
            }
        }

        public void EliminarUsuario(string usuarioLogin)
        {
            try
            {
                usuarioRepository.EliminarUsuario(usuarioLogin);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el usuario: " + ex.Message);
            }
        }

        public DataTable ObtenerUsuarios()
        {
            try
            {
                return usuarioRepository.ObtenerUsuarios();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de usuarios: " + ex.Message);
            }
        }

        public void ModificarUsuario(string usuarioLogin, string nuevoUsuarioLogin, string nuevaContraseñaLogin, int nuevoRol)
        {
            try
            {
                // Verificar si el nombre de usuario y la contraseña cumplen con los criterios
                if (string.IsNullOrWhiteSpace(nuevoUsuarioLogin))
                {
                    throw new Exception("El nombre de usuario no puede estar vacío.");
                }

                if (string.IsNullOrWhiteSpace(nuevaContraseñaLogin))
                {
                    throw new Exception("La contraseña no puede estar vacía.");
                }

                if (nuevaContraseñaLogin.Length < 8)
                {
                    throw new Exception("La contraseña debe tener al menos 8 caracteres.");
                }
                // Llama al método de persistencia para modificar el usuario
                usuarioRepository.ModificarUsuario(usuarioLogin, nuevoUsuarioLogin, nuevaContraseñaLogin, nuevoRol);

                // Puedes agregar lógica adicional aquí si es necesario
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el usuario: " + ex.Message);
            }
        }
    }
}
