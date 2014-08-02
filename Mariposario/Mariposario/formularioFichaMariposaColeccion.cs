using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Autor : Luis Manuel Deras
 */

namespace Mariposario
{
    public partial class formularioFichaMariposaColeccion : Form
    {

        private MariposaDeColeccion mariposa;

        public formularioFichaMariposaColeccion()
        {
            InitializeComponent();
        }

        public formularioFichaMariposaColeccion(MariposaDeColeccion mariposa)
        {
            InitializeComponent();
            this.mariposa = mariposa;

            this.establecerInformacion();
        }

        #region Establecer información de la mariposa

        private void establecerInformacion()
        {
            this.txtID.Text = this.mariposa.Identificador;
            this.txtFechaCaptura.Text = this.mariposa.FechaDeCaptura.ToShortDateString();
            this.txtEspecie.Text = this.mariposa.Especie.NombreCientifico;
            this.txtColeccion.Text = this.mariposa.Coleccion.Nombre;
            this.txtPrecio.Text = Convert.ToString(this.mariposa.Precio);
            this.txtBiologo.Text = this.mariposa.Biologo.Nombres;

            if (this.mariposa.Liberado)
            {
                this.checkLiberado.CheckState = CheckState.Checked;
            }
        }

        #endregion
    }
}
