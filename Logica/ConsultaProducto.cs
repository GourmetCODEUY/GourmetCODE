using Proyecto.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.Logica
{
    public class ConsultaProducto
    {
        private readonly ConsultarProductoRepository consultarProducto;

        public ConsultaProducto()
        {
            consultarProducto = new ConsultarProductoRepository();
        }

        public List<Producto> ConsultarProductos()
        {
            try
            {
                return consultarProducto.ObtenerProductos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los productos.", ex);
            }
        }
        public void ActualizarEstadoProducto(int numMenu, bool nuevoEstado)
        {
            try
            {
                consultarProducto.ActualizarEstadoProducto(numMenu, nuevoEstado);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el estado en la base de datos.", ex);
            }
        }
        public List<Producto> ConsultarProductosDeshabilitados()
        {
            try
            {
                return consultarProducto.ObtenerProductos().FindAll(p => !p.Habilitado);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los productos deshabilitados.", ex);
            }
        }
        public List<Producto> ConsultarProductosHabilitados()
        {
            try
            {
                return consultarProducto.ObtenerProductos().FindAll(p => p.Habilitado);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los productos habilitados.", ex);
            }
        }
    }
}
