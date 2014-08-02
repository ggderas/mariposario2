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
    public class Persona
    {
        private String identificador;
        private String nombres;
        private String apellidos;

        #region Constructores
        public Persona() { }

        public Persona(String identificador, String nombres, String apellidos)
        {
            Identificador = identificador;
            Nombres = nombres;
            Apellidos = apellidos;
        }

        #endregion

        #region Propiedades
        public String Identificador
        {
            get { return identificador; }
            set { identificador = value; }
        }
        
        public String Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        
        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        #endregion


    }
}
