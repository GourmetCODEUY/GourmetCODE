using proyecto.Persistencia;

namespace TuProyecto.Logica
{
    public class verificarUsuario
    {
        public static bool VerificarCredenciales(string usuario, string contrasena, out int rol)
        {
            rol = 0; // Inicializa el rol en 0 por defecto

            Usuario usuarioPersistencia = new Usuario();
            int resultadoPersistencia = usuarioPersistencia.VerificarCredenciales(usuario, contrasena);

            if (resultadoPersistencia > 0)
            {
                rol = resultadoPersistencia;
                return true;
            }

            return false;
        }
    }
}