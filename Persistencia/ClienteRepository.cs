using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Reflection.Metadata;

namespace proyecto.Persistencia
{
    public class Cliente
    {
        public string Num_Cliente { get; set; }
        public string Calle_Cliente { get; set; }
        public string Puerta_Cliente { get; set; }
        public string Zona_Cliente { get; set; }
        public string Autorizacion { get; set; }
        public string Condicion_Clinica { get; set; }
        public string Telefono { get; set; }
    }

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
        public string Nombre_Empresa { get; set; }
        public string Telefono_Empresa { get; set; }
        public string Calle_Empresa { get; set; }
        public string Puerta_Empresa { get; set; }
        public string Zona_Empresa { get; set; }
        public string Autorizacion { get; set; }
        public string Condicion_Clinica{ get; set; }
        public string Zona { get; set; } 
        public string Departamento { get; set; }
        public int ID_Sucursal { get; set; }

        public int idDepartamento { get; set; }
    }

    public class ClienteRepository
    {
        public List<string> ObtenerZonasPorDepartamentoDesdeBD(string nombreDepartamento)
        {
            List<string> zonas = new List<string>();

            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT Num_Zona FROM divide WHERE ID_Departamento = @IDDepartamento";
                MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@IDDepartamento", ObtenerIDDepartamentoPorNombre(nombreDepartamento));
                MessageBox.Show("Se pudo encontrar " + ObtenerIDDepartamentoPorNombre);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string zona = reader["Num_Zona"].ToString();
                        zonas.Add(zona);
                    }
                }
            }
            return zonas;
        }

        private readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["conexionSQL"].ConnectionString;
        public int ObtenerIDDepartamentoPorNombre(string departamentoEmpresa)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT ID_Departamento FROM departamento WHERE Nombre = @NombreDepartamento";
                MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@NombreDepartamento", departamentoEmpresa);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                return -1; // Si no se encuentra, se devuelve un valor negativo como indicador de error.
            }
        }
        public List<string> ObtenerDepartamentosDesdeBD()
        {
            List<string> departamentos = new List<string>();

            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT Nombre FROM departamento";
                MySqlCommand cmd = new MySqlCommand(consulta, conexion);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string departamento = reader["Nombre"].ToString();
                        departamentos.Add(departamento);
                    }
                }
            }

            return departamentos;
        }
       

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

                    // Insertar en la tabla usuario
                    using (MySqlCommand cmdUsuario = conexion.CreateCommand())
                    {
                        try
                        {
                            string consultaUsuario = "INSERT INTO usuario (Usuario_Login, Contraseña_Login) " +
                                "VALUES (@Usuario_Login, @Contraseña_Login)";
                            cmdUsuario.CommandText = consultaUsuario;
                            cmdUsuario.Parameters.AddWithValue("@Usuario_Login", clienteEmpresa.UsuarioEmpresa);
                            cmdUsuario.Parameters.AddWithValue("@Contraseña_Login", clienteEmpresa.ContraseñaEmpresa);
                            cmdUsuario.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Error al insertar en la tabla usuario: " + ex.Message, ex);
                        }
                    }

                    using (MySqlCommand cmdUsuarioRol = conexion.CreateCommand())
                    {
                        try
                        {
                            string consultaUsuarioRol = "INSERT INTO rol (Rol, Usuario_Login) " +
                                "VALUES (@Rol, @Usuario_Login)";
                            cmdUsuarioRol.CommandText = consultaUsuarioRol;
                            cmdUsuarioRol.Parameters.AddWithValue("@Usuario_Login", clienteEmpresa.UsuarioEmpresa);
                            cmdUsuarioRol.Parameters.AddWithValue("@Rol", "8"); // "8" ES EL ID DE ROL DE CLIENTE EMPRESA
                            cmdUsuarioRol.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Error al insertar en la tabla rol: " + ex.Message, ex);
                        }
                    }

                    // Insertar en la tabla cliente
                    using (MySqlCommand cmdCliente = conexion.CreateCommand())
                    {
                        try
                        {
                            string consultaCliente = "INSERT INTO cliente (Calle_Cliente, Puerta_Cliente, Zona_cliente, Autorizacion, Condicion_Clinica, Telefono) " +
                                "VALUES (@Calle_Cliente, @Puerta_Cliente, @Zona_cliente, @Autorizacion, @Condicion_Clinica, @Telefono)";
                            cmdCliente.CommandText = consultaCliente;
                            cmdCliente.Parameters.AddWithValue("@Calle_Cliente", clienteEmpresa.Calle_Empresa);
                            cmdCliente.Parameters.AddWithValue("@Puerta_Cliente", clienteEmpresa.Puerta_Empresa);
                            cmdCliente.Parameters.AddWithValue("@Zona_cliente", clienteEmpresa.Zona_Empresa);
                            cmdCliente.Parameters.AddWithValue("@Autorizacion", "0");
                            cmdCliente.Parameters.AddWithValue("@Condicion_Clinica", clienteEmpresa.Condicion_Clinica);
                            cmdCliente.Parameters.AddWithValue("@Telefono", clienteEmpresa.Telefono_Empresa);
                            cmdCliente.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Error al insertar en la tabla cliente: " + ex.Message, ex);
                        }
                    }

                    // Obtener el último ID insertado en cliente
                    ulong ultimoIDCliente;
                    using (MySqlCommand cmdUltimoIDCliente = new MySqlCommand("SELECT LAST_INSERT_ID()", conexion))
                    {
                        ultimoIDCliente = (ulong)cmdUltimoIDCliente.ExecuteScalar();
                    }

                    using (MySqlCommand cmdEmpresaReside = conexion.CreateCommand())
                    {
                        try
                        {
                            string consultaEmpresa = "INSERT INTO reside (Num_Cliente, ID_Sucursal) " +
                                "VALUES (@Num_Cliente, @ID_Sucursal)";
                            cmdEmpresaReside.CommandText = consultaEmpresa;
                            cmdEmpresaReside.Parameters.AddWithValue("@Num_Cliente", Convert.ToInt64(ultimoIDCliente)); // Convertir a Int64
                            cmdEmpresaReside.Parameters.AddWithValue("@ID_Sucursal", ObtenerIDDepartamentoPorNombre(clienteEmpresa.Departamento));
                            cmdEmpresaReside.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Error al insertar en la tabla Reside: " + ex.Message, ex);
                        }
                    }

                    // Insertar en la tabla cliente_empresa
                    using (MySqlCommand cmdEmpresa = conexion.CreateCommand())
                    {
                        try
                        {
                            string consultaEmpresa = "INSERT INTO cliente_empresa (Num_Cliente, Rut, Nombre_Empresa, Usuario_Login, Contraseña_Login) " +
                                "VALUES (@Num_Cliente, @Rut, @Nombre_Empresa, @Usuario_Login, @Contraseña_Login)";
                            cmdEmpresa.CommandText = consultaEmpresa;
                            cmdEmpresa.Parameters.AddWithValue("@Num_Cliente", Convert.ToInt64(ultimoIDCliente)); // Convertir a Int64
                            cmdEmpresa.Parameters.AddWithValue("@Rut", clienteEmpresa.Rut);
                            cmdEmpresa.Parameters.AddWithValue("@Nombre_Empresa", clienteEmpresa.Nombre_Empresa);
                            cmdEmpresa.Parameters.AddWithValue("@Usuario_Login", clienteEmpresa.UsuarioEmpresa);
                            cmdEmpresa.Parameters.AddWithValue("@Contraseña_Login", clienteEmpresa.ContraseñaEmpresa);
                            cmdEmpresa.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Error al insertar en la tabla cliente_empresa: " + ex.Message, ex);
                        }
                    }

                    // Insertar en la tabla cliente_telefono
                    using (MySqlCommand cmdTelefono = conexion.CreateCommand())
                    {
                        try
                        {
                            string consultaTelefono = "INSERT INTO cliente_telefono (Num_Cliente, Telefono) VALUES (@Num_Cliente, @Telefono_Empresa)";
                            cmdTelefono.CommandText = consultaTelefono;
                            cmdTelefono.Parameters.AddWithValue("@Num_Cliente", Convert.ToInt64(ultimoIDCliente)); // Convertir a Int64
                            cmdTelefono.Parameters.AddWithValue("@Telefono_Empresa", clienteEmpresa.Telefono_Empresa);
                            cmdTelefono.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Error al insertar en la tabla cliente_telefono: " + ex.Message, ex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar en la base de datos: " + ex.Message, ex);
            }
        }
    }
}