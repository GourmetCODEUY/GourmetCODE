using MySql.Data.MySqlClient;
using Proyecto.Persistencia;
using System;
using System.Collections.Generic;

namespace Proyecto.Logica
{
    internal class ConsultaPedidoManager
    {
        private readonly ConsultarPedido consultarPedido;

        public ConsultaPedidoManager()
        {
            consultarPedido = new ConsultarPedido();
        }

        public List<Pedido> ConsultarPedidos()
        {
            try
            {
                return consultarPedido.ObtenerPedidos();
            }
            catch (MySqlException mySqlEx)
            {
                // Agregar detalles específicos del error de MySQL
                string mensajeError = "Error al guardar el pedido en la base de datos. Detalles: " + mySqlEx.Message;
                throw new Exception(mensajeError, mySqlEx);
            }
        }
    }
}
