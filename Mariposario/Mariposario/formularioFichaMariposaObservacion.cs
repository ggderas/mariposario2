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
    public partial class formularioFichaMariposaObservacion : Form
    {
        private MariposaEnObservacion mariposa;

        public formularioFichaMariposaObservacion()
        {
            InitializeComponent();
        }

        public formularioFichaMariposaObservacion(MariposaEnObservacion mariposa)
        {
            InitializeComponent();
            this.mariposa = mariposa;

            this.establecerInformacion();
        }

        #region Establecer información de Mariposa
            
        private void establecerInformacion()
        {
            this.txtID.Text = this.mariposa.Identificador;
            this.txtFechaCaptura.Text = this.mariposa.FechaDeCaptura.ToShortDateString();
            this.txtEspecie.Text = this.mariposa.Especie.NombreCientifico;
            this.txtTiempoObservacion.Text = Convert.ToString(this.mariposa.TiempoDeObservacion) + " horas";
            this.txtBiologo.Text = this.mariposa.Biologo.Nombres;

            if (this.mariposa.Liberado)
            {
                this.checkLiberado.CheckState = CheckState.Checked;
            }
        }

        #endregion
    }
}
