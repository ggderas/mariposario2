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
 * de las especies de las mariposas capturadas del sistema
 */

   public class Especie
    {
       
       #region  Constructores

       public Especie(String nombreCientifico, Genero genero)
       {
           this.NombreCientifico = nombreCientifico;
           this.Genero = genero;
           NombreComun_Zona = new List<string>();
           listaMariposas = new List<Mariposa>();
           listaZonaGeografica = new List<Zona_Geografica>();
       }

       public Especie(String nombreCientifico)
       {
           NombreCientifico = nombreCientifico;
           NombreComun_Zona = new List<string>();
           listaMariposas = new List<Mariposa>();
           listaZonaGeografica = new List<Zona_Geografica>();
       }

       #endregion

       #region Propiedades
       public String NombreCientifico{set; get;}
       public List<String> NombreComun_Zona {set; get;}
       public Genero Genero{set; get;}
       public List<Mariposa> listaMariposas { set;  get; }
       public List<Zona_Geografica> listaZonaGeografica {set; get;} 
       #endregion

       public override string ToString()
       {
           return NombreCientifico;
       }
    }
}
