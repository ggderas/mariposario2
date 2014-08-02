using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mariposario{
    public partial class formularioAgregarColeccion:Form {
        Conexion conexion;
        public List<Biologo> personas;
        public List<MariposaEnObservacion> mariposas;
        public List<MariposaDeColeccion> mariposasColeccion;
        public List<Coleccion> colecciones;
        public List<Coleccionista> coleccionistas;
        public formularioAgregarColeccion(List<Coleccion> colecciones, List<Biologo> b, List<Coleccionista> c, List<MariposaEnObservacion> mariposas, List<MariposaDeColeccion> mariposasColeccion, Conexion conn) {
            InitializeComponent();
            this.conexion=conn;
            this.colecciones=colecciones;
            this.coleccionistas = c;
            this.mariposasColeccion=mariposasColeccion;
            personas=b;
            this.cmbPropietario.DataSource=personas;
            this.mariposas = mariposas;
            this.mariposasColeccion=new List<MariposaDeColeccion>();
            this.llenarListBox();
        }

        #region Agregar-Eliminar Mariposas
        //Evento que se lanza al presionar el label con la imagen de la flecha '->' que agregar una mariposa a la colección
        private void lblAgregarMariposa_Click(object sender, EventArgs e) {
            if(this.lbMariposas.SelectedIndex>=0) {
                frmAgregarPrecio f = new frmAgregarPrecio();
                f.ShowDialog();
                float precio=f.precio;
                MariposaEnObservacion m = this.mariposas.ElementAt(lbMariposas.SelectedIndex);
                this.mariposas.Remove(m);
                MariposaDeColeccion mC = new MariposaDeColeccion(m.Identificador, m.FechaDeCaptura, precio, m.Especie, m.Zona, null, m.Biologo,false);
                this.mariposasColeccion.Add(mC);
                this.llenarListBox();
            } else MessageBox.Show("Debe seleccionar una mariposa","Error al agregar mariposa",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        //Evento que se lanza al presionar el label con la imagen de la flecha '<-' que elimina una mariposa a la colección
        private void lblEliminarMariposa_Click(object sender, EventArgs e) {
            if(this.lbMariposasEnColeccion.SelectedIndex>=0) {
                MariposaDeColeccion m = (MariposaDeColeccion)lbMariposasEnColeccion.SelectedItem;
                MariposaEnObservacion mN = new MariposaEnObservacion(m.Identificador, m.FechaDeCaptura, 10, m.Especie, m.Zona, m.Biologo,false);
                this.mariposasColeccion.RemoveAt(lbMariposasEnColeccion.SelectedIndex);
                this.mariposas.Add(mN);
                this.llenarListBox();
            } else MessageBox.Show("Debe seleccionar una mariposa", "Error al quitar mariposa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        #endregion
        //Agrega una colección a la lista de colecciones y a la BD y cierra el form
        private void btnAgregar_Click(object sender, EventArgs e){
            this.errorProvider1.Clear();
            if(this.tbIDColeccion.Text=="") {
                errorProvider1.SetError(this.tbIDColeccion,"Debe introducir un ID para la colección");
                this.tbIDColeccion.Focus();
            }else if(this.tbNombre.Text=="") {
                errorProvider1.SetError(this.tbNombre, "Debe introducir un nombre para la colección");
                this.tbNombre.Focus();
            }else if(this.numericPrecio.Value<=0) {
                errorProvider1.SetError(this.numericPrecio, "Ingrese un precio mayor de 0");
                this.numericPrecio.Focus();
            } else if(this.cmbPropietario.SelectedIndex<0) {
                errorProvider1.SetError(this.cmbPropietario, "No ha seleccionado la persona que será propietario.");
                this.cmbPropietario.Focus();
            } else if(this.lbMariposasEnColeccion.Items.Count==0) {
                errorProvider1.SetError(lbMariposasEnColeccion, "La colección debe tener al menos una mariposa.");
                this.lblAgregarMariposa.Focus();
            } else {
                Biologo p = (Biologo)this.personas.ElementAt(this.cmbPropietario.SelectedIndex);
                if(colecciones==null) this.colecciones= new List<Coleccion>();
                Coleccion c = new Coleccion(this.tbIDColeccion.Text, this.tbNombre.Text, this.numericPrecio.Value,this.dtpFechaInicio.Value.Date, this.mariposasColeccion, null);
                foreach(MariposaDeColeccion mC in mariposasColeccion)
                    mC.Coleccion=c;
                if(this.conexion.insertarColeccion(this.tbIDColeccion.Text, this.tbNombre.Text, this.numericPrecio.Value,this.dtpFechaInicio.Value, p, colecciones, this.mariposasColeccion)) {
                    Coleccionista coleccionista = new Coleccionista(p.Identificador, p.Nombres, p.Apellidos);
                    c.Dueño=coleccionista;
                    this.colecciones.Add(c); this.coleccionistas.Add(coleccionista);
                    this.personas.Remove(p);
                    this.Dispose();
                } else {
                    foreach(MariposaDeColeccion mC in mariposasColeccion)
                        mC.Coleccion=null;
                    MessageBox.Show("Ya existe una colección con este ID");
                    this.tbIDColeccion.Focus();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {this.Dispose();}

       

        private void llenarListBox() {
            this.lbMariposas.DataSource=null;
            this.lbMariposasEnColeccion.DataSource = null;
            this.lbMariposas.DataSource=this.mariposas;
            this.lbMariposasEnColeccion.DataSource = this.mariposasColeccion;
        }
    }
}