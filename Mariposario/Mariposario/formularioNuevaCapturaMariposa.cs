using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

/*
 * Autor: Luis Manuel Deras
 */

namespace Mariposario
{
    public partial class formularioNuevaCapturaMariposa : Form
    {
        private List<MariposaDeColeccion> listaDeMariposasDeColeccion;
        private List<MariposaEnObservacion> listaDeMariposasEnObservacion;
        private List<FamiliaNatural> listaDeFamiliasNaturales;
        private List<Coleccion> listaDeColecciones;
        private List<Especie> listaDeEspecies;
        private List<Zona_Geografica> listaDeZonas;
        private List<Biologo> listaDeBiologos;

        private Conexion conexion;
        private frmMain form;

        #region Constructores

        public formularioNuevaCapturaMariposa()
        {
            InitializeComponent();
        }

        public formularioNuevaCapturaMariposa(List<MariposaDeColeccion> listaDeMariposasDeColeccion,List<MariposaEnObservacion> listaDeMariposasEnObservacion,
                                            List<FamiliaNatural> listaDeFamiliasNaturales, List<Coleccion> listaDeColecciones, List<Zona_Geografica> listaDeZonas,
                                            List<Biologo> listaDeBiologos, Conexion conexion, frmMain form)
        {
            InitializeComponent();

            this.listaDeColecciones = listaDeColecciones;
            this.listaDeFamiliasNaturales = listaDeFamiliasNaturales;
            this.listaDeZonas = listaDeZonas;
            this.listaDeMariposasDeColeccion = listaDeMariposasDeColeccion;
            this.listaDeBiologos = listaDeBiologos;
            this.listaDeEspecies = new List<Especie>();

            this.conexion = conexion;
            this.form = form;

            this.obtenerEspecies();
            this.establecerInformacionEnControles();
        }

        #endregion

        #region Eventos

        /*
        * Evento que se dispara cuando se el usuario
        * da click en 'Finalizar' para agregar
        * una nueva mariposa
        */
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (!hayCamposVacios())
            {
                char tipo = ' ';

                if (this.rbtnColeccion.Checked)
                {
                    tipo = 'C';
                }
                else if (this.rbtnObservacion.Checked)
                {
                    tipo = 'O';
                }

                if (agregarMariposaBaseDeDatos(tipo))
                {
                    try
                    {
                        MessageBox.Show("Mariposa agregada exitosamente", "Agregar nueva mariposa...", MessageBoxButtons.OK);

                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                    }
                    catch (SqlException sql)
                    {
                        MessageBox.Show(sql.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Existe una mariposa con ese identificador", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            else
            {
                MessageBox.Show("Llene los campos vacíos","Agregar nueva mariposa...", MessageBoxButtons.OK);
            }
        }


        private void rbtnObservacion_CheckedChanged(object sender, EventArgs e)
        {
            desactivarControles(this.rbtnObservacion);
        }

        private void rbtnColeccion_CheckedChanged(object sender, EventArgs e)
        {
            desactivarControles(this.rbtnColeccion);
        }

        /*
         * Evento que se dispara cuando el usuario da click
         * en 'Cancelar' para salir del formulario
         */
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        #region Desactivar controles

        /*
         * Método que desactiva controles en la sección de 'Tipo de Mariposa'
         * dependiendo del checkbox que se mande.
         */
        private void desactivarControles(RadioButton radioButton)
        {
            switch (radioButton.Name)
            {
                case "rbtnObservacion":
                    {
                        this.numericTiempoObservacion.Enabled = true;
                        this.cmbColecciones.Enabled = false;
                        this.numericPrecio.Enabled = false;
                        break;
                    }
                case "rbtnColeccion":
                    {
                        this.cmbColecciones.Enabled = true;
                        this.numericPrecio.Enabled = true;
                        this.numericTiempoObservacion.Enabled = false;
                        break;
                    }
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

        #region Establecer información en los controles de selección

        /*
         * Método que establece información como especies disponibles,
         * colecciones, biologos en los comboboxes para que el usuario elija
         */

        private void establecerInformacionEnControles()
        {
            this.cmbColecciones.Items.AddRange(this.listaDeColecciones.ToArray());
            this.cmbEspecies.Items.AddRange(this.listaDeEspecies.ToArray());
            this.cmbZonas.Items.AddRange(this.listaDeZonas.ToArray());
            this.cmbBiologos.Items.AddRange(listaDeBiologos.ToArray());
        }

        #endregion

        #region Agregar Mariposa a la base de datos

        /*
         * Método que agrega una mariposa a la base de datos
         * Retorna verdadero si se agregó exitosamente.
         * Falso para lo contrario
         */
        private Boolean agregarMariposaBaseDeDatos(char tipo)
        {
            String idMariposa = this.txtIDMariposa.Text;
            DateTime fechaCaptura = this.datePickFechaCaptura.Value;
            String nombreCientifico = ((Especie)this.cmbEspecies.SelectedItem).NombreCientifico;
            String idBiologo = ((Biologo)this.cmbBiologos.SelectedItem).Identificador;
            String nombreZona = ((Zona_Geografica)this.cmbZonas.SelectedItem).NombreZona;
            decimal tiempoObservacion = this.numericTiempoObservacion.Value;
            decimal precio = this.numericPrecio.Value;

            String idColeccion = "";

            if (tipo == 'C')
            {
                idColeccion = ((Coleccion)this.cmbColecciones.SelectedItem).Identificador;
            }

            return this.conexion.agregarMariposa(idMariposa, fechaCaptura, nombreCientifico, tipo, idBiologo,
                                nombreZona, tiempoObservacion, precio, idColeccion);

        }

        #endregion

        #region Agregar mariposa a objetos

        /*
         * Método que agrega la nueva referencia de tipo Mariposa
         * a los demás objetos con los que tenga que ver
         */

        private void agregarMariposaObjetos(char tipo)
        {
            Mariposa mariposa = new Mariposa();

            mariposa.Especie = (Especie)this.cmbEspecies.SelectedItem;
            mariposa.FechaDeCaptura = this.datePickFechaCaptura.Value;
            mariposa.Identificador = this.txtIDMariposa.Text;

            //Agregar a la mariposa a la lista de mariposas correspondiente

            if(tipo == 'C')
            {
                MariposaDeColeccion mariposaColeccion = new MariposaDeColeccion(mariposa.Identificador, mariposa.FechaDeCaptura, 
                                    Convert.ToDouble(this.numericPrecio.Value), mariposa.Especie, mariposa.Zona,
                                    (Coleccion)this.cmbColecciones.SelectedItem, mariposa.Biologo, mariposa.Liberado);

                this.listaDeMariposasDeColeccion.Add(mariposaColeccion);

                mariposa = mariposaColeccion;

                //Agregar la mariposa a la colección correspondiente
    
                Coleccion coleccion = (Coleccion)this.cmbColecciones.SelectedItem;
                foreach(Coleccion coleccionActual in this.listaDeColecciones)
                {
                    if(coleccionActual.Identificador.Equals(coleccion))
                    {
                        coleccionActual.Mariposas.Add(mariposaColeccion);
                    }
                }

            }
            else
            {
                MariposaEnObservacion mariposaObservacion = new MariposaEnObservacion(mariposa.Identificador, mariposa.FechaDeCaptura,
                                                this.numericTiempoObservacion.Value,mariposa.Especie, mariposa.Zona,mariposa.Biologo,
                                                mariposa.Liberado);

                this.listaDeMariposasEnObservacion.Add(mariposaObservacion);

                mariposa = mariposaObservacion;
            }


            //Agregar a la especie correspondiente

            Especie especie = (Especie)this.cmbEspecies.SelectedItem;

            foreach(FamiliaNatural familia in this.listaDeFamiliasNaturales)
            {
                foreach(Genero genero in familia.Generos)
                {
                    foreach(Especie especieActual in genero.Especies)
                    {
                        if(especieActual.NombreCientifico.Equals(especie.NombreCientifico))
                        {
                            especieActual.listaMariposas.Add(mariposa);
                            break;
                        }
                    }
                }
            }

            //Asignar al biologo correspondiente

            Biologo biologo = (Biologo)this.cmbBiologos.SelectedItem;

            foreach(Biologo biologoActual in this.listaDeBiologos)
            {
                if(biologoActual.Identificador.Equals(biologo.Identificador))
                {
                    biologo.ListaDeMariposasEnObservacion.Add(mariposa);
                    break;
                }
            }

            //Asignar a la zona geográfica correspondiente

            Zona_Geografica zona = (Zona_Geografica)this.cmbZonas.SelectedItem;

            foreach (Zona_Geografica zonaActual in this.listaDeZonas)
            {
                if (zonaActual.NombreZona.Equals(zona.NombreZona))
                {
                    zonaActual.ListaDeMariposas.Add(mariposa);
                    break;
                }
            }

        }

        #endregion

        #region Actualizar objetos

        private void actualizarObjetos()
        {
            this.listaDeBiologos = this.form.Biologos;
            this.listaDeColecciones = this.form.Colecciones;
            this.listaDeEspecies = this.form.Especies;
            this.listaDeFamiliasNaturales = this.form.FamiliasNaturales;
            this.listaDeZonas = this.form.Zonas_geograficas;
            this.listaDeMariposasEnObservacion = this.form.MariposasObservacion;
            this.listaDeMariposasDeColeccion = this.form.MariposasColecccion;
        }
        #endregion

        #region Hay campos vacios

        /*
         * Método que determina si hay campos vacios en el formulario
         */

        private Boolean hayCamposVacios()
        {
            if (!this.rbtnColeccion.Checked && !this.rbtnObservacion.Checked)
            {
                return true;
            }

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
