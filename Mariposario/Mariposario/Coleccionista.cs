using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Autor: Carlos Alberto Salgado
 */
namespace Mariposario
{
    public class Coleccionista:Persona
    {
        #region Constructores
        public Coleccionista() { }

        public Coleccionista(String identificador, String nombre, String apellidos)
        {
            Identificador = identificador;
            Nombres = nombre;
            Apellidos = apellidos;
        }
        #endregion

        private Coleccion coleccion;

        public Coleccion Coleccion
        {
            get { return coleccion; }
            set { coleccion = value; }
        }

        public override string ToString()
        {
            return Identificador.Trim();
        }
    }
}
