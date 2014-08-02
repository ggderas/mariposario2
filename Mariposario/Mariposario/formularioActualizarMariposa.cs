using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mariposario
{
    public partial class formularioActualizarMariposa : Form
    {
        private Mariposa mariposa;

        private List<FamiliaNatural> listaDeFamiliasNaturales;
        private List<Coleccion> listaDeColecciones;
        private List<Especie> listaDeEspecies;
        private List<Zona_Geografica> listaDeZonas;
        private List<Biologo> listaDeBiologos;

        private Conexion conexion;

        #region Eventos

        /*
         * Evento que se dispara cuando el usuario
         * da click en 'Cancelar' para salir del formulario
         */
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         * Evento que se dispara cuando el usuario
         * da click en 'Actualizar' para actualizar la información
         * de la mariposa
         */
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!hayCamposVacios())
            {
                if (actualizarMariposaBaseDeDatos())
                {
                    MessageBox.Show("Mariposa actualizada exitosamente", "Actualizar mariposa...", MessageBoxButtons.OK);

                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Llene los campos necesrios", "Actualizar mariposa...", MessageBoxButtons.OK);
            }
            
        }

        #endregion

        #region Constructores

        public formularioActualizarMariposa()
        {
            InitializeComponent();
        }

        public formularioActualizarMariposa(Mariposa mariposa, List<FamiliaNatural> listaDeFamiliasNaturales, List<Coleccion> listaDeColecciones,
                                            List<Zona_Geografica> listaDeZonas, List<Biologo> listaDeBiologos, Conexion conexion)
        {
            InitializeComponent();

            this.mariposa = mariposa;

            this.listaDeColecciones = listaDeColecciones;
            this.listaDeFamiliasNaturales = listaDeFamiliasNaturales;
            this.listaDeZonas = listaDeZonas;
            this.listaDeBiologos = listaDeBiologos;
            this.listaDeEspecies = new List<Especie>();

            this.conexion = conexion;

            this.obtenerEspecies();
            this.desactivarControles();

            this.establecerInformacionDeMariposa();
        }

        #endregion

        #region Desactivar controles dependiendo el tipo de mariposa

        /*
         * Método que deshabilita los controles dependiendo
         * del tipo de mariposa que se esté actualizando
         */

        private void desactivarControles()
        {
            if (this.mariposa is MariposaDeColeccion)
            {
                this.rbtnColeccion.Checked = true;

                this.numericTiempoObservacion.Enabled = false;
                this.rbtnObservacion.Enabled = false;
            }
            else if (this.mariposa is MariposaEnObservacion)
            {
                this.rbtnObservacion.Checked = true;

                this.numericTiempoObservacion.Enabled = true;
                this.numericPrecio.Enabled = false;
                this.rbtnColeccion.Enabled = false;
            }
        }

        #endregion

        #region Obtener especies

        /*
         * Método que establece las especies provenientes de las
         * listas de familias naturales
         */

        private void obtenerEspecies()
        {
            foreach (FamiliaNatural familia in this.listaDeFamiliasNaturales)
            {
                foreach (Genero genero in familia.Generos)
                {
                    foreach (Especie especie in genero.Especies)
                    {
                        this.listaDeEspecies.Add(especie);
                    }
                }
            }
        }

        #endregion

        #region Establecer información de la mariposa

        /*
         * Método que establece la información de la mariposa
         * en el formulario, dependiendo el tipo de mariposa que sea
         */

        private void establecerInformacionDeMariposa()
        {
            this.cmbBiologos.Items.AddRange(this.listaDeBiologos.ToArray());
            this.cmbColecciones.Items.AddRange(this.listaDeColecciones.ToArray());
            this.cmbEspecies.Items.AddRange(this.listaDeEspecies.ToArray());
            this.cmbZonas.Items.AddRange(this.listaDeZonas.ToArray());

            this.txtIDMariposa.Text = this.mariposa.Identificador;
            this.dateTimeFechaCaptura.Value = this.mariposa.FechaDeCaptura;
            this.cmbEspecies.SelectedItem = this.mariposa.Especie;
            this.cmbZonas.SelectedItem = this.mariposa.Zona;
            this.cmbBiologos.SelectedItem = this.mariposa.Biologo;

            if (this.mariposa is MariposaDeColeccion)
            {
                this.cmbColecciones.SelectedItem = ((MariposaDeColeccion)this.mariposa).Coleccion;
                this.numericPrecio.Value = Convert.ToDecimal(((MariposaDeColeccion)this.mariposa).Precio);
            }
            else if (this.mariposa is MariposaEnObservacion)
            {
                this.numericTiempoObservacion.Value = Convert.ToDecimal(((MariposaEnObservacion)this.mariposa).TiempoDeObservacion);
            }
        }

        #endregion

        #region Actualizar mariposa en la base de datos

        private Boolean actualizarMariposaBaseDeDatos()
        {
            String idMariposa = mariposa.Identificador;
            DateTime fechaCaptura = this.dateTimeFechaCaptura.Value;
            String nombreCientifico = ((Especie)this.cmbEspecies.SelectedItem).NombreCientifico;
            String idBiologo = ((Biologo)this.cmbBiologos.SelectedItem).Identificador;
            String nombreZona = ((Zona_Geografica)this.cmbZonas.SelectedItem).NombreZona;
            String idColeccion = "";
            decimal precio = 0;
            decimal tiempoDeObservacion = 0;

            if (this.mariposa is MariposaDeColeccion)
            {
                precio = this.numericPrecio.Value;
                idColeccion = ((Coleccion)this.cmbColecciones.SelectedItem).Identificador;

                return this.conexion.actualizarMariposa(idMariposa, fechaCaptura, nombreCientifico, 'C', idBiologo, nombreZona,
                            tiempoDeObservacion, precio, idColeccion);
            }
            else if (this.mariposa is MariposaEnObservacion)
            {
                tiempoDeObservacion = this.numericTiempoObservacion.Value;

                return this.conexion.actualizarMariposa(idMariposa, fechaCaptura, nombreCientifico, 'O', idBiologo, nombreZona,
                tiempoDeObservacion, precio, idColeccion);
            }

            return false;
        }


        #endregion

        #region Actualizar mariposa en objetos

        /*
         * Método que actualiza la información de la mariposa
         * en términos de objetos
         */

        private void actualizarMariposaObjetos()
        {
            this.mariposa.FechaDeCaptura = this.dateTimeFechaCaptura.Value;
            this.mariposa.Especie = (Especie)this.cmbEspecies.SelectedItem;

            if (this.mariposa is MariposaDeColeccion)
            {
                ((MariposaDeColeccion)this.mariposa).Precio = Convert.ToDouble(this.numericPrecio.Value);
                ((MariposaDeColeccion)this.mariposa).Coleccion = (Coleccion)this.cmbColecciones.SelectedItem;
            }
            else if (this.mariposa is MariposaEnObservacion)
            {
                ((MariposaEnObservacion)this.mariposa).TiempoDeObservacion = this.numericTiempoObservacion.Value;
            }
        }

        #endregion

        #region Hay campos vacios

        /*
         * Método que determina si hay campos vacios en el formulario
         */

        private Boolean hayCamposVacios()
        {
            if (this.txtIDMariposa.Text.Equals(""))
            {
                return true;
            }
            if (cmbEspecies.SelectedItem == null)
            {
                return true;
            }
            if (cmbZonas.SelectedItem == null)
            {
                return true;
            }
            if (cmbBiologos.SelectedItem == null)
            {
                return true;
            }

            if (this.rbtnColeccion.Checked)
            {
                if (this.cmbColecciones.SelectedItem == null)
                {
                    return true;
                }
                if (this.numericPrecio.Value == 0)
                {
                    return true;
                }
            }
            if (this.rbtnObservacion.Checked)
            {
                if (this.numericTiempoObservacion.Value == 0)
                {
                    return true;
                }
            }

            return false;
        }

        #endregion

    }
}
