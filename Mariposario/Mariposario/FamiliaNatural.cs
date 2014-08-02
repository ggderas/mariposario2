using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariposario
{

    #region Autor: Cindy Carolina Alonzo

    #endregion
    /*
     * Clase que tiene como objetivo guardar la información
     * de la familia natural de las mariposas capturadas del sistema
     */
    public class FamiliaNatural
    {        
       #region Constructores 
        public FamiliaNatural(String identificador, String nombre) {
            Identificador = identificador;
            Nombre = nombre;
            Generos = new List<Genero>();
        }

       #endregion     
       #region Propiedades
        public String Identificador { set; get; }
        public String Nombre{set; get;}
        public List<Genero> Generos{set; get; }
       #endregion

        public override string ToString()
        {
            return this.Nombre;
        } 
    }
}
