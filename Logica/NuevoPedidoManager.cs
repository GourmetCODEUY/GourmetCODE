using proyecto.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.Logica
{
    internal class NuevoPedidoManager
    {
        public List<string> ObtenerZonas()
        {
            try
            {
                // En una aplicación real, puedes obtener las zonas desde la capa de persistencia
                List<string> zonas = new List<string>
                {
                    "Zona 1",
                    "Zona 2",
                    "Zona 3",
                    "Zona 4",
                    "Zona 5",
                    "Zona 6",
                    "Zona 7"
                };

                return zonas;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las zonas.", ex);
            }
        }

        public List<string> ObtenerBarrios(string zonaSeleccionada)
        {
            try
            {
                // En una aplicación real, puedes obtener los barrios desde la capa de persistencia
                List<string> barrios = new List<string>();

                // Llena los barrios según la zona seleccionada
                switch (zonaSeleccionada)
                {
                    case "Zona 1":
                        barrios.Add("Sayago");
                        barrios.Add("Paso Molino / Belvedere / Paso de las Duranas");
                        barrios.Add("Prado / Atahualpa");
                        barrios.Add("Parque Posadas / Aires Puros");
                        barrios.Add("Brazo Oriental");
                        barrios.Add("Jacinto Vera / La Figurita / Nuevo Centro");
                        barrios.Add("Reducto");
                        break;
                    case "Zona 2":
                        barrios.Add("Bella Vista / Capurro");
                        barrios.Add("Aguada / Arroyo Seco");
                        barrios.Add("Goes");
                        barrios.Add("Villa Muñoz / La Comercial");
                        barrios.Add("Larrañaga / Mercado Modelo");
                        barrios.Add("La Unión");
                        break;
                    case "Zona 3":
                        barrios.Add("Ciudad Vieja / Aduana");
                        barrios.Add("Centro / Cordón");
                        barrios.Add("Barrio Sur");
                        barrios.Add("Palermo");
                        break;
                    case "Zona 4":
                        barrios.Add("Tres Cruces / Mondiola");
                        barrios.Add("La Blanqueada");
                        barrios.Add("Parque Batlle");
                        barrios.Add("Villa Dolores");
                        barrios.Add("Parque Rodó");
                        break;
                    case "Zona 5":
                        barrios.Add("Pocitos / Pocitos Nuevo");
                        barrios.Add("Punta Carretas / Trouville / Villa Biarritz");
                        barrios.Add("Buceo");
                        barrios.Add("Malvín / Malvín Nuevo");
                        barrios.Add("Parte de Malvín Norte");
                        break;
                    case "Zona 6":
                        barrios.Add("Barrio Parque Rivera");
                        barrios.Add("Punta Gorda");
                        barrios.Add("Todo Carrasco / Carrasco Sur");
                        barrios.Add("Manantiales de Carrasco");
                        barrios.Add("Todo Carrasco Norte");
                        barrios.Add("San Nicolás");
                        barrios.Add("Los Olivos");
                        barrios.Add("Parques Barrio Jardín");
                        barrios.Add("Jardines de Carrasco");
                        break;
                    case "Zona 7":
                        barrios.Add("Barra de Carrasco");
                        barrios.Add("Lagos de Carrasco");
                        barrios.Add("La Bahía Lagos");
                        break;
                    default:
                        break;
                }

                return barrios;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los barrios.", ex);
            }
        }

        public bool GuardarPedido(string descPedido, string calleCliente, string puertaCliente, string zonaCliente, string barrioCliente)
        {
            try
            {
                NuevoPedido persistencia = new NuevoPedido();
                bool resultado = persistencia.GuardarPedido(descPedido, calleCliente, puertaCliente, zonaCliente, barrioCliente);

                // Aquí puedes agregar lógica adicional si es necesario
                // Por ejemplo, actualizar la interfaz de usuario o realizar otras operaciones relacionadas con el pedido.

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de lógica al guardar el pedido.", ex);
            }
        }
    }

    
}
