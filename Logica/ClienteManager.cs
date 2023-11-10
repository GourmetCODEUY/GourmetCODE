using proyecto.Persistencia;
using Proyecto.Persistencia;
using System;
using System.Data;
using System.Linq;
using System.Security.Policy;
using static proyecto.Persistencia.BuscarCliente;

namespace proyecto.Logica
{

    public class ClienteManager
    {
        private readonly ModificarClientesP _clientePersistencia = new ModificarClientesP();
        private BuscarCliente buscarCliente;
        private readonly ClienteRepository clienteRepository;
        private int idDepartamento;

        public ClienteManager()
        {
          
            buscarCliente = new BuscarCliente();
            clienteRepository = new ClienteRepository();
        }

        public void ActualizarClientesComunes(DataTable tablaClientesComunes)
        {
            try
            {
                _clientePersistencia.ActualizarClientesComunes(tablaClientesComunes);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar clientes comunes: {ex.Message}", ex);
            }
        }

        public void ActualizarClientesEmpresas(DataTable tablaClientesEmpresas)
        {
            try
            {
                _clientePersistencia.ActualizarClientesEmpresas(tablaClientesEmpresas);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar clientes de empresas: {ex.Message}", ex);
            }
        }
        public DataTable ObtenerClientesComunes()
        {
            try
            {
                // Llama al método en la capa de persistencia para obtener los clientes comunes
                return _clientePersistencia.ObtenerClientesComunes();
            }
            catch (Exception ex)
            {
                // Maneja la excepción según tus requisitos
                Console.WriteLine($"Error al obtener clientes comunes: {ex.Message}");
                return null;
            }
        }
        public DataTable ObtenerClientesEmpresas()
        {
            try
            {
                // Llama al método en la capa de persistencia para obtener los clientes de empresas
                return _clientePersistencia.ObtenerClientesEmpresas();
            }
            catch (Exception ex)
            {
                // Maneja la excepción según tus requisitos
                Console.WriteLine($"Error al obtener clientes de empresas: {ex.Message}");
                return null;
            }
        }

        public void ActualizarAutorizaciones(List<Cliente> clientesModificados)
        {
            try
            {
                buscarCliente.ActualizarAutorizaciones(clientesModificados);
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades
                throw new Exception("Error en la capa de lógica al actualizar las autorizaciones: " + ex.Message, ex);
            }

        }

        public List<Cliente> ObtenerTodosLosClientes()
        {
            return buscarCliente.ObtenerTodosLosClientesDesdeBD();
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

        public void InsertarClienteComun(string Departamento_Comun, int ID_SucursalComun, string ciClienteComun, string primerNombre, string primerApellido, string segundoNombre, string segundoApellido, string calleComun, string puertaComun, string zonaComun, string usuarioComun, string telefonoComun, string contraseñaComun, string Condicion_Clinica_Comun)
        {
            int idDepartamento = clienteRepository.ObtenerIDDepartamentoPorNombre(Departamento_Comun);
            if (idDepartamento < 0)
            {
                MessageBox.Show("El departamento no se encuentra en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                ClienteComun clienteComun = new ClienteComun
                {
                    CI_Cliente_Comun = ciClienteComun,
                    Primer_Nombre = primerNombre,
                    Primer_Apellido = primerApellido,
                    Segundo_Nombre = segundoNombre,
                    Segundo_Apellido = segundoApellido,
                    Zona_Comun = zonaComun,
                    Calle_Comun = calleComun,
                    Puerta_Comun = puertaComun,
                    UsuarioComun = usuarioComun,
                    Telefono_Comun = telefonoComun,
                    Condicion_Clinica_Comun = Condicion_Clinica_Comun,
                    Contraseña_Comun = contraseñaComun,
                    ID_SucursalComun = idDepartamento,
                    Departamento_Comun = Departamento_Comun,

                };
                clienteRepository.InsertarClienteComun(clienteComun);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex + MessageBoxButtons.OK + MessageBoxIcon.Error);

            }

            try
            {
                // Llamar al método de acceso a datos modificado
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar cliente común: " + ex.Message, ex);
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
    } 
}