using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;

namespace proyecto.Persistencia
{
    public class ClienteComun
    {
        public string CI_Cliente_Comun { get; set; }
        public string Primer_Nombre { get; set; }
        public string Segundo_Nombre { get; set; }
        public string Primer_Apellido { get; set; }
        public string Segundo_Apellido { get; set; }
        public string Calle_Comun { get; set; }
        public string Puerta_Comun { get; set; }
        public string Usuario_Comun { get; set; }
        public string Contraseña_Comun { get; set; }
        public string Telefono_Comun { get; set; }

    }

    public class ClienteEmpresa
    {
        public string UsuarioEmpresa { get; set; }
        public string ContraseñaEmpresa { get; set; }
        public string Rut { get; set; }
        public string Nom_Empresa { get; set; }
        public string Telefono_Empresa { get; set; }
        public string Calle_Empresa { get; set; }
        public string Puerta_Empresa { get; set; }
        public string Zona_Empresa { get; set; }
        public string Autorizacion { get; set; }
        public string Condicion_Clinica{ get; set; }
    }

    public class ClienteRepository
    {
        private readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["conexionSQL"].ConnectionString;

        // Inserción de cliente común
        public void InsertarClienteComun(ClienteComun clienteComun)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consultaComun = "INSERT INTO cliente_comun (CI_Cliente_Comun, Primer_Nombre, Segundo_Nombre, Primer_Apellido, Segundo_Apellido) " +
                                      "VALUES (@CI_Cliente_Comun, @PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido)";
                    MySqlCommand cmd = new MySqlCommand(consultaComun, conexion);
                    cmd.Parameters.AddWithValue("@CI_Cliente_Comun", clienteComun.CI_Cliente_Comun);
                    cmd.Parameters.AddWithValue("@PrimerNombre", clienteComun.Primer_Nombre);
                    cmd.Parameters.AddWithValue("@SegundoNombre", clienteComun.Segundo_Nombre);
                    cmd.Parameters.AddWithValue("@PrimerApellido", clienteComun.Primer_Apellido);
                    cmd.Parameters.AddWithValue("@SegundoApellido", clienteComun.Segundo_Apellido);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar el cliente común en la base de datos.", ex);
            }
        }

        // Inserción de cliente de empresa
        public void InsertarClienteEmpresa(ClienteEmpresa clienteEmpresa)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    try
                    {
                        string consultaCliente = "INSERT INTO cliente (Num_Cliente, Calle_Cliente, Puerta_Cliente, Zona_cliente, Autorizacion, Condicion_Clinica, Telefono) " + "VALUES (@Num_Cliente, @Calle_Cliente, @Puerta_Cliente, @Zona_cliente, @Autorizacion, @Condicion_Clinica, @Telefono)";
                        MySqlCommand cmdEmpresa = new MySqlCommand(consultaCliente, conexion);
                        cmdEmpresa.Parameters.AddWithValue("@Num_Cliente", "NULL");
                        cmdEmpresa.Parameters.AddWithValue("@Calle_Cliente", clienteEmpresa.Calle_Empresa);
                        cmdEmpresa.Parameters.AddWithValue("@Puerta_Cliente", clienteEmpresa.Puerta_Empresa);
                        cmdEmpresa.Parameters.AddWithValue("@Zona_Cliente", "0");
                        cmdEmpresa.Parameters.AddWithValue("@Autorizacion", "0");
                        cmdEmpresa.Parameters.AddWithValue("@Condicion_Clinica", "0");
                        cmdEmpresa.Parameters.AddWithValue("@Telefono", clienteEmpresa.Telefono_Empresa);
                        cmdEmpresa.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error INSERT Tabla CLIENTE" + ex.Message, ex);
                    }
                   
                    try 
                    {
                        string consultaEmpresa = "INSERT INTO cliente_empresa (Num_Cliente, Rut, Nombre_Empresa, Usuario_Login, Contraseña_Login) " +
                                     "VALUES (@Num_Cliente, @Rut, @NomEmpresa, @UsuarioEmpresa, @ContraseñaEmpresa)";
                        MySqlCommand cmd = new MySqlCommand(consultaEmpresa, conexion);
                        cmd.Parameters.AddWithValue("@Num_Cliente", "NULL");
                        cmd.Parameters.AddWithValue("@Rut", clienteEmpresa.Rut);
                        cmd.Parameters.AddWithValue("@NomEmpresa", clienteEmpresa.Nom_Empresa);
                        cmd.Parameters.AddWithValue("@UsuarioEmpresa", clienteEmpresa.UsuarioEmpresa);
                        cmd.Parameters.AddWithValue("@ContraseñaEmpresa", clienteEmpresa.ContraseñaEmpresa);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al insertar el cliente de empresa en la base de datos." + ex.Message, ex);
                    }
                   
                    try
                    {
                        string consultaTelefono = "INSERT INTO cliente_telefono (Telefono)" + "VALUES (@Telefono_Empresa)";
                        MySqlCommand cmdTelefono = new MySqlCommand(consultaTelefono, conexion);
                        cmdTelefono.Parameters.AddWithValue("@Telefono_Empresa", clienteEmpresa.Telefono_Empresa);
                        cmdTelefono.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error INSERT Cliente Telefono" + ex.Message, ex);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar en la base de datos." + ex.Message, ex);
            }
        }
    }
}