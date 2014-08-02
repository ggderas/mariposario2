using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Autor: Luis Manuel Deras
 */

/*
 * Clase que tiene como objetivo guardar la información
 * de las mariposas capturadas del sistema
 */

namespace Mariposario
{
    public class Mariposa
    {
        private String identificador;
        private DateTime fechaDeCaptura;
        private Image imagen;
        private Boolean liberado;

        private Especie especie;
        private Biologo biologo;
        private Zona_Geografica zona;



        #region Constructores

        public Mariposa() { }

        public Mariposa(String identificador, DateTime fechaDeCaptura, String nombreCientifico,
                        String identificadorBiologo, String nombreZona, Boolean liberado)
        {
            Identificador = identificador;
            FechaDeCaptura = fechaDeCaptura;
            Liberado = liberado;
            this.especie = new Especie(nombreCientifico);
            this.biologo = new Biologo(identificadorBiologo);
            this.zona = new Zona_Geografica(nombreZona);
        }

        public Mariposa(String identificador, DateTime fechaDeCaptura, Especie especie, Zona_Geografica zona, Biologo biologo, Boolean liberado)
        {
            Identificador = identificador;
            FechaDeCaptura = fechaDeCaptura;
            Liberado = liberado;
            
            this.especie = especie;
            this.zona = zona;
            this.biologo = biologo;
        }

        #endregion

        #region Propiedades

        public Boolean Liberado
        {
            get { return liberado; }
            set { liberado = value; }
        }

        public String Identificador
        {
            get { return identificador; }
            set { identificador = value; }
        }

        public DateTime FechaDeCaptura
        {
            get { return fechaDeCaptura; }
            set { fechaDeCaptura = value; }
        }

        public Image Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        public Especie Especie
        {
            get { return especie; }
            set { especie = value; }
        }

        public Zona_Geografica Zona
        {
            get { return zona; }
            set { zona = value; }
        }

        public Biologo Biologo
        {
            get { return biologo; }
            set { biologo = value; }
        }

        #endregion

        #region Métodos

        public override string ToString()
        {
            return identificador;
        }

        #endregion
    }
}
