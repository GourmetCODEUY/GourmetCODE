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
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los pedidos.", ex);
            }
        }
    }
}
