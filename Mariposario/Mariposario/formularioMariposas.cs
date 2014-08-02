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
 * Autor: Luis Manuel Deras
 */

namespace Mariposario
{
    public partial class formularioMariposas : Form
    {
        private List<MariposaDeColeccion> listaDeMariposasDeColeccion;
        private List<MariposaEnObservacion> listaDeMariposasEnObservacion;
        private List<FamiliaNatural> listaDeFamiliasNaturales;
        private List<Coleccion> listaDeColecciones;
        private List<Zona_Geografica> listaDeZonas;
        private List<Biologo> listaDeBiologos;
        private frmMain form;

        private Conexion conexion;

        #region Constructores

        public formularioMariposas()
        {
            InitializeComponent();
        }

        public formularioMariposas(List<MariposaDeColeccion> mariposasDeColeccion, List<MariposaEnObservacion> mariposasEnObservacion,
                                Conexion conexion, List<FamiliaNatural> listaDeFamiliasNaturales, List<Coleccion> listaDeColecciones,
                                List<Zona_Geografica> listaDeZonas, List<Biologo> listaDeBiologos, frmMain form)
        {
            InitializeComponent();

            this.listaDeMariposasDeColeccion = mariposasDeColeccion;
            this.listaDeMariposasEnObservacion = mariposasEnObservacion;
            this.listaDeFamiliasNaturales = listaDeFamiliasNaturales;
            this.listaDeColecciones = listaDeColecciones;
            this.listaDeZonas = listaDeZonas;
            this.listaDeBiologos = listaDeBiologos;

            this.form = form;

            this.conexion = conexion;

            establecerMariposasEnListbox();
        }

        #endregion

        #region Eventos

        /*
         * Evento que se dispara del menu 'Nueva captura de mariposa'
         * Unicamente abre el formulario para añadir una nueva
         * mariposa al sistema
         */
        private void nuevoCapturaDeMariposaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularioNuevaCapturaMariposa nuevaCaptura = new formularioNuevaCapturaMariposa(this.listaDeMariposasDeColeccion, this.listaDeMariposasEnObservacion
                                                            ,this.listaDeFamiliasNaturales, this.listaDeColecciones, this.listaDeZonas,
                                                            this.listaDeBiologos, this.conexion, this.form);

            DialogResult resultado = nuevaCaptura.ShowDialog();
            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                this.form.CargarBaseDeDatos();
                this.actualizarObjetos();
                this.refrescarControles();
            }
            
        }

        /*
         * Evento que se dispara cuando cambia el texto para
         * realizar la busqueda por ID
         */
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            busquedaPorID();
        }

        /*
         * Evento que se dispara cuando se da click en 'Ver Ficha Técnica' para
         * las mariposas de colección
         */
        private void btnFichaMariposaColeccion_Click(object sender, EventArgs e)
        {
            MariposaDeColeccion mariposa = (MariposaDeColeccion)this.listBoxMariposasColeccion.SelectedItem;

            if (mariposa != null)
            {
                formularioFichaMariposaColeccion formulario = new formularioFichaMariposaColeccion(mariposa);
                formulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un elemento", "Mariposario", MessageBoxButtons.OK);
            }
        }

        /*
        * Evento que se dispara cuando se da click en 'Ver Ficha Técnica' para
        * las mariposas en observacion
        */
        private void btnFichaMariposaObservacion_Click(object sender, EventArgs e)
        {
            MariposaEnObservacion mariposa = (MariposaEnObservacion)this.listBoxMariposasObservacion.SelectedItem;

            if (mariposa != null)
            {
                formularioFichaMariposaObservacion formulario = new formularioFichaMariposaObservacion(mariposa);
                formulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un elemento", "Mariposario", MessageBoxButtons.OK);
            }
        }

        /*
        * Evento que se dispara cuando se quiere actualizar información sobre una mariposa de colección
        * Se abre el formulario de actualización
        */
        private void btnModificarMariposasColeccion_Click(object sender, EventArgs e)
        {
            MariposaDeColeccion mariposa = (MariposaDeColeccion)this.listBoxMariposasColeccion.SelectedItem;

            if (mariposa != null)
            {
                formularioActualizarMariposa formulario = new formularioActualizarMariposa(mariposa, this.listaDeFamiliasNaturales,
                                                            this.listaDeColecciones, this.listaDeZonas, this.listaDeBiologos, this.conexion);

                DialogResult result = formulario.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    this.form.CargarBaseDeDatos();
                    this.actualizarObjetos();
                    this.refrescarControles();
                }

            }
            else
            {
                MessageBox.Show("Seleccione un elemento", "Mariposario", MessageBoxButtons.OK);
            }
        }

        /*
        * Evento que se dispara cuando se quiere actualizar información sobre una mariposa en observación
        * Se abre el formulario de actualización
         */
        private void btnModificarMariposasObservacion_Click(object sender, EventArgs e)
        {
            MariposaEnObservacion mariposa = (MariposaEnObservacion)this.listBoxMariposasObservacion.SelectedItem;

            if (mariposa != null)
            {
                formularioActualizarMariposa formulario = new formularioActualizarMariposa(mariposa, this.listaDeFamiliasNaturales,
                                                            this.listaDeColecciones, this.listaDeZonas, this.listaDeBiologos, this.conexion);

                DialogResult result = formulario.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    this.form.CargarBaseDeDatos();
                    this.actualizarObjetos();
                    this.refrescarControles();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un elemento", "Mariposario", MessageBoxButtons.OK);
            }
        }

        /*
        * Evento que se dispara cuando se pretende eliminar 
        * una mariposa de colección
        */
        private void btnEliminarMariposasColeccion_Click(object sender, EventArgs e)
        {
            if (eliminarMariposaBaseDeDatos(new MariposaDeColeccion()))
            {
                this.form.CargarBaseDeDatos();
                this.actualizarObjetos();
                this.refrescarControles();
            }
        }

        /*
        * Evento que se dispara cuando se pretende eliminar 
        * una mariposa en observación
        */
        private void btnEliminarMariposasObservacion_Click(object sender, EventArgs e)
        {
            if (eliminarMariposaBaseDeDatos(new MariposaEnObservacion()))
            {
                this.form.CargarBaseDeDatos();
                this.actualizarObjetos();
                this.refrescarControles();
            }
        }

        private void familiasNaturalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFamiliaNatural formulario = new FrmFamiliaNatural();
            formulario.ShowDialog();
        }

        private void génerosToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            FrmGenero formulario = new FrmGenero();
            formulario.ShowDialog();
        }

        private void génerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenero formulario = new FrmGenero();
            formulario.ShowDialog();
        }

        private void espciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEspecie formulario = new FrmEspecie();
            formulario.ShowDialog();
        }

        #endregion

        #region Establecer mariposas en los listbox

        /*
         * Llena los controles listbox de mariposas
         */
        private void establecerMariposasEnListbox()
        {
            this.listBoxMariposasColeccion.Items.AddRange(this.listaDeMariposasDeColeccion.ToArray());
            this.listBoxMariposasObservacion.Items.AddRange(this.listaDeMariposasEnObservacion.ToArray());
        }

        #endregion

        #region Busqueda por ID

        /*
         * Busqueda que se realiza por ID en ambas listas
         * de mariposas de colección y de observació
         */
        private void busquedaPorID()
        {
            String ID = this.txtID.Text;

            this.listBoxMariposasObservacion.Items.Clear();
            this.listBoxMariposasColeccion.Items.Clear();

            if (ID.Equals("")) //Si está vacio
            {
                this.listBoxMariposasColeccion.Items.AddRange(this.listaDeMariposasDeColeccion.ToArray());
                this.listBoxMariposasObservacion.Items.AddRange(this.listaDeMariposasEnObservacion.ToArray());
            }
            else 
            {
                List<MariposaDeColeccion> mariposasColeccion = new List<MariposaDeColeccion>();
                List<MariposaEnObservacion> mariposasObservacion = new List<MariposaEnObservacion>();

                foreach (MariposaDeColeccion mariposa in this.listaDeMariposasDeColeccion)
                {
                    if (mariposa.Identificador.StartsWith(ID))
                    {
                        mariposasColeccion.Add(mariposa);
                    }
                }

                foreach (MariposaEnObservacion mariposa in this.listaDeMariposasEnObservacion)
                {
                    if (mariposa.Identificador.StartsWith(ID))
                    {
                        mariposasObservacion.Add(mariposa);
                    }
                }

                this.listBoxMariposasColeccion.Items.AddRange(mariposasColeccion.ToArray());
                this.listBoxMariposasObservacion.Items.AddRange(mariposasObservacion.ToArray());
                
            }
        }

        #endregion

        #region Eliminar mariposa de la base de datos

        /*
         * Método que elimina las mariposas. Este hace el llamado al  método eliminar
         * mariposa en el objeto conexión. Luego manda a llamar al método que elimina las 
         * referencias de esa mariposa en los demás objetos
         */
        private Boolean eliminarMariposaBaseDeDatos(Mariposa tipoMariposa)
        {
            Mariposa mariposa = new Mariposa();

            if (tipoMariposa is MariposaDeColeccion)
            {
                mariposa = (MariposaDeColeccion)this.listBoxMariposasColeccion.SelectedItem;
            }
            else
            {
                mariposa = (MariposaEnObservacion)this.listBoxMariposasObservacion.SelectedItem;
            }

            if (mariposa != null)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este elemento?", "Eliminar mariposa", MessageBoxButtons.YesNoCancel);

                if (resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    if (this.conexion.eliminarMariposa(mariposa.Identificador))
                    {
                        MessageBox.Show("Mariosa eliminada exitosamente", "Eliminar mariposa...", MessageBoxButtons.OK);
                        return true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un elemento", "Eliminar mariposa...", MessageBoxButtons.OK);
                return false;
            }

            return false;
        }

        #endregion

        #region Eliminar mariposa de objetos

        private void eliminarMariposaObjetos(Mariposa tipoDeMariposa)
        {
            if (tipoDeMariposa is MariposaDeColeccion)
            {
                MariposaDeColeccion mariposa = (MariposaDeColeccion)this.listBoxMariposasColeccion.SelectedItem;

                //Eliminar de la lista de mariposas de colección
                this.listaDeMariposasDeColeccion.Remove(mariposa);

                //Eliminar de la especie correspondiente

                foreach (FamiliaNatural familia in this.listaDeFamiliasNaturales)
                {
                    foreach (Genero genero in familia.Generos)
                    {
                        foreach (Especie especie in genero.Especies)
                        {
                            if (especie.NombreCientifico.Equals(mariposa.Especie.NombreCientifico))
                            {
                                especie.listaMariposas.Remove(mariposa);
                                break;
                            }
                        }
                    }
                }

                //Eliminar de la lista del biólogo correspondiente
            }
            else if(tipoDeMariposa is MariposaEnObservacion)
            {
                MariposaEnObservacion mariposa = (MariposaEnObservacion)this.listBoxMariposasObservacion.SelectedItem;

                //Eliminar de la especie correspondiente

                foreach (FamiliaNatural familia in this.listaDeFamiliasNaturales)
                {
                    foreach (Genero genero in familia.Generos)
                    {
                        foreach (Especie especie in genero.Especies)
                        {
                            if (especie.NombreCientifico.Equals(mariposa.Especie.NombreCientifico))
                            {
                                especie.listaMariposas.Remove(mariposa);
                                break;
                            }
                        }
                    }
                }

                //Eliminar de la lista del biólogo correspondiente
            
            }
        }

        #endregion        

        #region Actualizar objetos

        private void actualizarObjetos()
        {
            this.listaDeBiologos = this.form.Biologos;
            this.listaDeColecciones = this.form.Colecciones;
            this.listaDeFamiliasNaturales = this.form.FamiliasNaturales;
            this.listaDeZonas = this.form.Zonas_geograficas;
            this.listaDeMariposasEnObservacion = this.form.MariposasObservacion;
            this.listaDeMariposasDeColeccion = this.form.MariposasColecccion;
        }
        #endregion

        #region Refrescar controles

        private void refrescarControles()
        {
            this.listBoxMariposasColeccion.Items.Clear();
            this.listBoxMariposasObservacion.Items.Clear();

            this.listBoxMariposasColeccion.Items.AddRange(this.listaDeMariposasDeColeccion.ToArray());
            this.listBoxMariposasObservacion.Items.AddRange(this.listaDeMariposasEnObservacion.ToArray());
        }

        #endregion

    }
}
