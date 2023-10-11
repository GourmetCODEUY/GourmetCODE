using proyecto.Persistencia;
using System;
using System.Data;

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

        public void InsertarClienteEmpresa(string rut, string nomEmpresa, string usuarioLoginEmpresa, string contraseñaLoginEmpresa, string telefonoEmpresa, string calleEmpresa, string puertaEmpresa)
        {
            try
            {
                ClienteEmpresa nuevoClienteEmpresa = new ClienteEmpresa
                {                   
                    Rut = rut,
                    Nom_Empresa = nomEmpresa,
                    UsuarioEmpresa = usuarioLoginEmpresa,
                    ContraseñaEmpresa = contraseñaLoginEmpresa,
                    Telefono_Empresa = telefonoEmpresa,
                    Calle_Empresa = calleEmpresa,
                    Puerta_Empresa = puertaEmpresa
                };

                clienteRepository.InsertarClienteEmpresa(nuevoClienteEmpresa);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el cliente de empresa: " + ex.Message);
            }
        }
    }
}