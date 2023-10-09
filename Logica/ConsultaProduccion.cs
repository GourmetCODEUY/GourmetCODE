using System;
using System.Collections.Generic;
using Proyecto.Persistencia;

namespace Proyecto.Logica
{
    public class ConsultaProduccionManager
    {
        private readonly ConsultarProduccionRepository consultarProduccionRepository;

        public ConsultaProduccionManager()
        {
            consultarProduccionRepository = new ConsultarProduccionRepository();
        }

        public List<Produccion> ConsultarProduccion()
        {
            try
            {
                return consultarProduccionRepository.ObtenerProduccion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar la producción.", ex);
            }
        }
    }
}
