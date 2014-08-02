using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariposario
{
    /*
* Autor: Cindy Carolina lonzo
*/

    /*
     * Clase que tiene como objetivo guardar la información
     * del genero de las  especies de las mariposas capturadas del sistema
     */
   public class Genero
   {
       #region Constructor
       public Genero(String identificador, String nombre,FamiliaNatural familia) {
           Identificador = identificador;
           Nombre = nombre;
           FamiliaNatural = familia;
           Especies = new List<Especie>();
       }
       public Genero(String identificador, String nombre)
       {
           Identificador = identificador;
           Nombre = nombre;
           Especies = new List<Especie>();
           
       }
       #endregion
  
       #region Propiedades
       public String Identificador{set; get;}
       public String Nombre{set; get;}
       public FamiliaNatural FamiliaNatural{set; get;}
       public List<Especie> Especies { set; get; }
       #endregion

       public override string ToString()
       {
           return  this.Nombre;
       }
   }
}
