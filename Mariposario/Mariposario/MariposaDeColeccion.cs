using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Autor: Luis Manuel Deras
 */

/*
 * Clase que define a una mariposa que sólo está
 * para mantenerse en una colección. Lo que distingue a esta 
 * mariposa de las demás es que tiene un precio.
 */

namespace Mariposario
{
    public class MariposaDeColeccion : Mariposa
    {
        private double precio;
        private Coleccion coleccion;

        #region Constructores

        public MariposaDeColeccion() { }

        public MariposaDeColeccion(String identificador, DateTime fechaDeCaptura, double precio, String nombreCientifico,
            String identificadorBiologo, String nombreZona, String idColeccion, Boolean liberado) : base(identificador, fechaDeCaptura, nombreCientifico,
                                                                                    identificadorBiologo, nombreZona, liberado)
        {
            Precio = precio;
            this.coleccion = new Coleccion(idColeccion);
        }

        public MariposaDeColeccion(String identificador, DateTime fechaDeCaptura, double precio, Especie especie, Zona_Geografica zona,
                                    Coleccion coleccion, Biologo biologo, Boolean liberado) :
                                    base(identificador, fechaDeCaptura, especie, zona, biologo, liberado)
        {
            Precio = precio;
            this.coleccion = coleccion;
        }

        #endregion

        #region Propiedades

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public Coleccion Coleccion
        {
            get { return coleccion; }
            set { coleccion = value; }
        }

        #endregion
    }
}
