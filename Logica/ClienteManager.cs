using proyecto.Persistencia;
using System;
using System.Data;
using System.Linq;
using System.Security.Policy;

namespace proyecto.Logica
{
    public class ClienteManager
    {
        private readonly ClienteRepository clienteRepository;
        private int idDepartamento;
        public ClienteManager()
        {
            clienteRepository = new ClienteRepository();
        }
        
        public List<string> ObtenerDepartamentosDesdeBD()
        {
            try
            {
                return clienteRepository.ObtenerDepartamentosDesdeBD();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener departamentos desde la base de datos: " + ex.Message);
            }
        }
        public List<string> ObtenerZonasPorDepartamentoDesdeBD(string departamento)
        {
            try
            {
                return clienteRepository.ObtenerZonasPorDepartamentoDesdeBD(departamento);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener zonas desde la base de datos: " + ex.Message);
            }
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

        public void InsertarClienteEmpresa(int ID_Sucursal, string rut, string nomEmpresa, string usuarioLoginEmpresa, string contraseñaLoginEmpresa, string telefonoEmpresa, string calleEmpresa, string puertaEmpresa, string zonaEmpresa, string departamentoEmpresa, string condicionClinica)
        {
            int idDepartamento = clienteRepository.ObtenerIDDepartamentoPorNombre(departamentoEmpresa);

            if (idDepartamento < 0)
            {
                MessageBox.Show("El departamento no se encuentra en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

                ClienteEmpresa nuevoClienteEmpresa = new ClienteEmpresa
                {
                    Rut = rut,
                    Nombre_Empresa = nomEmpresa,
                    UsuarioEmpresa = usuarioLoginEmpresa,
                    ContraseñaEmpresa = contraseñaLoginEmpresa,
                    Telefono_Empresa = telefonoEmpresa,
                    Calle_Empresa = calleEmpresa,
                    Puerta_Empresa = puertaEmpresa,
                    Departamento = departamentoEmpresa,
                    Zona_Empresa = zonaEmpresa,
                    Condicion_Clinica = condicionClinica,
                    ID_Sucursal = idDepartamento
                };

                clienteRepository.InsertarClienteEmpresa(nuevoClienteEmpresa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex + MessageBoxButtons.OK + MessageBoxIcon.Error);

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
