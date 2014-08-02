using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariposario
{
    /*
    * Autor: Carlos Alberto Salgado
    */

    public class Zona_Geografica
    {
        private String nombreZona;
        private List<Especie> especies_Zona;
        private List<Mariposa> listaDeMariposas;


        #region Propiedades
        public String NombreZona
        {
            get { return nombreZona; }
            set { nombreZona = value; }
        }

        public List<Mariposa> ListaDeMariposas
        {
            get { return listaDeMariposas; }
            set { listaDeMariposas = value; }
        }

        public List<Especie> Especies_Zona
        {
            get { return especies_Zona; }
            set { especies_Zona = value; }
        }
        #endregion

        #region Constructores
        public Zona_Geografica() 
        {
            Especies_Zona = new List<Especie>();
            ListaDeMariposas = new List<Mariposa>();
        }

        public Zona_Geografica(String nombre)
        {
            NombreZona = nombre;
            Especies_Zona = new List<Especie>();
            ListaDeMariposas = new List<Mariposa>();
        }
        #endregion

        public override string ToString()
        {
            return NombreZona;
        }
    }
}
