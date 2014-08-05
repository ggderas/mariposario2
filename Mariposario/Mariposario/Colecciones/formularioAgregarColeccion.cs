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
        public List<Coleccion> colecciones;
        public List<Coleccionista> coleccionistas;
        public formularioAgregarColeccion(List<Coleccion> colecciones, List<Biologo> b, List<Coleccionista> c, Conexion conn) {
            InitializeComponent();
            this.conexion=conn;
            this.colecciones=colecciones;
            this.coleccionistas = c;
            personas=b;
            this.cmbPropietario.DataSource=personas;
        }

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
            } else {
                Biologo p = (Biologo)this.personas.ElementAt(this.cmbPropietario.SelectedIndex);
                if(colecciones==null) this.colecciones= new List<Coleccion>();
                Coleccion c = new Coleccion(this.tbIDColeccion.Text, this.tbNombre.Text, this.numericPrecio.Value,this.dtpFechaInicio.Value.Date, null, null);
                if(this.conexion.insertarColeccion(this.tbIDColeccion.Text, this.tbNombre.Text, this.numericPrecio.Value,this.dtpFechaInicio.Value, p, colecciones)) {
                    Coleccionista coleccionista = new Coleccionista(p.Identificador, p.Nombres, p.Apellidos);
                    c.Dueño=coleccionista;
                    this.colecciones.Add(c); this.coleccionistas.Add(coleccionista);
                    this.personas.Remove(p);
                    MessageBox.Show("Se ha agregado la colección exitosamente.","Mariposario - Colecciones",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Dispose();
                } else {
                    MessageBox.Show("Ya existe una colección con este ID");
                    this.tbIDColeccion.Focus();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {this.Dispose();}
    }
}