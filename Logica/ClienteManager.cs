using proyecto.Persistencia;
using System;
using System.Data;
using System.Linq;

namespace proyecto.Logica
{
    public class ClienteManager
    {
        private readonly ClienteRepository clienteRepository;

        public ClienteManager()
        {
            clienteRepository = new ClienteRepository();
        }

        public void InsertarClienteComun(string ciClienteComun, string primerNombre, string segundoNombre, string telefonoComun, string primerApellido, string segundoApellido, string calleComun, string puertaComun, string usuarioComun, string contraseñaComun)
        {
            try
            {
                ClienteComun nuevoClienteComun = new ClienteComun
                {
                    CI_Cliente_Comun = ciClienteComun,
                    Primer_Nombre = primerNombre,
                    Segundo_Nombre = segundoNombre,
                    Primer_Apellido = primerApellido,
                    Segundo_Apellido = segundoApellido,
                    Calle_Comun = calleComun,
                    Puerta_Comun = puertaComun,
                    Usuario_Comun = usuarioComun,
                    Contraseña_Comun = contraseñaComun,
                    Telefono_Comun = telefonoComun
                };

                clienteRepository.InsertarClienteComun(nuevoClienteComun);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el cliente común: " + ex.Message);
            }
        }

        public void InsertarClienteEmpresa(string rut, string nomEmpresa, string usuarioLoginEmpresa, string contraseñaLoginEmpresa, string telefonoEmpresa, string calleEmpresa, string puertaEmpresa, string departamento, string zona)
        {
            try
            {
                // Realizar validaciones aquí antes de insertar los datos en la base de datos.
                if (rut.Length > 12 || !EsNumero(rut))
                {
                    throw new Exception("El RUT debe ser numérico y no debe ser mayor a 12 caracteres.");
                }
                if (!EsTextoValido(nomEmpresa, 20))
                {
                    throw new Exception("El nombre de la empresa debe ser un texto de no más de 20 caracteres.");
                }
                if (!EsTextoValido(usuarioLoginEmpresa, 20))
                {
                    throw new Exception("El usuario de inicio de sesión debe ser un texto de no más de 20 caracteres.");
                }
                if (contraseñaLoginEmpresa.Length > 20)
                {
                    throw new Exception("La contraseña de inicio de sesión no debe ser mayor a 20 caracteres.");
                }

                // Validar otros campos aquí
                if (zona != "Zona1" && zona != "Zona2")
                {
                    throw new Exception("La zona seleccionada no es válida.");
                }

                ClienteEmpresa nuevoClienteEmpresa = new ClienteEmpresa
                {
                    Rut = rut,
                    Nombre_Empresa = nomEmpresa,
                    UsuarioEmpresa = usuarioLoginEmpresa,
                    ContraseñaEmpresa = contraseñaLoginEmpresa,
                    Telefono_Empresa = telefonoEmpresa,
                    Calle_Empresa = calleEmpresa,
                    Puerta_Empresa = puertaEmpresa,
                    Departamento = departamento,
                    Zona = zona
                };

                clienteRepository.InsertarClienteEmpresa(nuevoClienteEmpresa);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el cliente de empresa: " + ex.Message);
            }
        }

        private bool EsTextoValido(string texto, int maxLength)
        {
            return !string.IsNullOrEmpty(texto) && texto.Length <= maxLength && !texto.Any(char.IsDigit);
        }

        private bool EsNumero(string texto)
        {
            return long.TryParse(texto, out _);
        }
    }
}
