using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static proyecto.Persistencia.BuscarClIENTE;
using proyecto.Persistencia;
namespace proyecto.Logica
{
namespace CapaLogica
    {
        public class ClienteManager
        {
            public void CrearNuevoCliente(string numero_cliente)
            {
                ClienteDAO clienteDAO = new ClienteDAO();
                clienteDAO.InsertarNuevoCliente(numero_cliente);
            }
        }
    }
}
