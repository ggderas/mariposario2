using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Autor: Carlos Alberto Salgado
 */

namespace Mariposario
{
    public class Biologo:Persona
    {
        private List<Mariposa> listaDeMariposas;

        public List<Mariposa> ListaDeMariposasEnObservacion
        {
            get { return listaDeMariposas; }
            set { listaDeMariposas = value; }
        }

        #region Constructores
        public Biologo() { }

        public Biologo(String identificador, String nombre, String apellidos, List<Mariposa> mariposas)
        {
            Identificador = identificador;
            Nombres = nombre;
            Apellidos = apellidos;
            ListaDeMariposasEnObservacion = mariposas;
        }

        public Biologo(String identificador)
        {
            Identificador = identificador;
        }

        #endregion

        public override string ToString()
        {
            return Identificador.Trim();
        }
    }
}
