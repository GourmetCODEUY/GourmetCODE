using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace proyecto.Persistencia
{
    internal class BuscarClIENTE
    {
        public class ClienteDAO
        {
            public void InsertarNuevoCliente(string numero_cliente)
            {
                string connectionString = "Server=localhost;Port=3306;Database=gourmetcode;Uid=root;Pwd=;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                string query = "INSERT INTO cliente (numero_cliente) VALUES (@numero_cliente)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("numero_cliente", numero_cliente);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

    }
}
