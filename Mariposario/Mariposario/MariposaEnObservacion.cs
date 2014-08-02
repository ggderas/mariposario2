using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Autor: Luis Manuel Deras
 */

/*
 * Clase que define a una mariposa que únicamente
 * se tiene en observación.
 */

namespace Mariposario
{
    public class MariposaEnObservacion : Mariposa
    {
        private decimal tiempoDeObservacion;

        #region Constructores

        public MariposaEnObservacion() { }

        public MariposaEnObservacion(String identificador, DateTime fechaDeCaptura, decimal tiempoDeObservacion, String nombreCientifico,
            String identificadorBiologo, String nombreZona, Boolean liberado) :
              base(identificador, fechaDeCaptura, nombreCientifico, identificadorBiologo, nombreZona, liberado)
        {
            TiempoDeObservacion = tiempoDeObservacion;
        }

        public MariposaEnObservacion(String identificador, DateTime fechaDeCaptura, decimal tiempoDeObservacion, Especie especie, Zona_Geografica zona,
                                Biologo biologo, Boolean liberado) : base(identificador, fechaDeCaptura, especie, zona, biologo, liberado)
        {
            TiempoDeObservacion = tiempoDeObservacion;
        }

        #endregion

        #region Propiedades

        public decimal TiempoDeObservacion
        {
            get { return tiempoDeObservacion; }
            set { tiempoDeObservacion = value; }
        }

        #endregion

    }
}
