using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mariposario{
    public partial class frmModificarColeccion:Form {
        Conexion conexion;
        public List<Biologo> personas;
        public List<Coleccionista> coleccionistas;
        Coleccion coleccion;
        public frmModificarColeccion(Coleccion coleccion, List<Biologo> b, List<Coleccionista> coleccionistas, Conexion conn) {
            InitializeComponent();
            this.personas=b;
            this.personas.Insert(0,new Biologo(coleccion.Dueño.Identificador));
            this.cmbPropietario.DataSource = this.personas;
            this.coleccionistas=coleccionistas;
            this.conexion=conn;
            this.coleccion=coleccion;
            this.tbIDColeccion.Text=this.coleccion.Identificador;
            this.tbNombre.Text = this.coleccion.Nombre;
            this.numericPrecio.Value = this.coleccion.Precio;
            this.dtpFechaInicio.Value = this.coleccion.FechaInicio;
        }

        //Modificar una colección a la lista de colecciones y a la BD y cierra el form
        private void btnAgregar_Click(object sender, EventArgs e) {
            this.errorProvider1.Clear();
            if(this.tbNombre.Text=="") {
                errorProvider1.SetError(this.tbNombre, "Debe introducir un nombre para la colección");
                this.tbNombre.Focus();
            } else if(this.numericPrecio.Value<=0) {
                errorProvider1.SetError(this.numericPrecio, "Ingrese un precio mayor de 0");
                this.numericPrecio.Focus();
            } else if(this.cmbPropietario.SelectedIndex<0) {
                errorProvider1.SetError(this.cmbPropietario, "No ha seleccionado la persona que será propietario.");
                this.cmbPropietario.Focus();
            } else {
                this.coleccion.Precio=this.numericPrecio.Value;
                this.coleccion.Nombre=tbNombre.Text;
                this.coleccion.FechaInicio = this.dtpFechaInicio.Value.Date;
                if(this.cmbPropietario.SelectedIndex>0) {
                    Biologo p = this.personas.ElementAt(this.cmbPropietario.SelectedIndex);
                    this.personas.Add(new Biologo(this.coleccion.Dueño.Identificador,this.coleccion.Dueño.Nombres,this.coleccion.Dueño.Apellidos,null));
                    this.conexion.modificarPersona(this.coleccion.Dueño.Identificador,this.coleccion.Dueño.Identificador, this.coleccion.Dueño.Nombres, this.coleccion.Dueño.Apellidos, "B");
                    Coleccionista col=null;
                    foreach(Coleccionista c in this.coleccionistas)
                        if(c.Identificador==this.coleccion.Dueño.Identificador) { col=c; break; }
                    this.coleccionistas.Remove(col);
                    this.coleccion.Dueño = new Coleccionista(p.Identificador,p.Nombres,p.Apellidos);
                    this.personas.Remove(p);
                    
                    this.coleccionistas.Add(this.coleccion.Dueño);
                }
                
                if(this.conexion.actualizarColeccion(this.coleccion)) MessageBox.Show("Colección " +this.coleccion.Identificador+ " actualizada con éxito", "Colecciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("¡Error al actualizar!","¡ERROR!",MessageBoxButtons.OK,MessageBoxIcon.Error);

                this.personas.RemoveAt(0);
                this.Dispose();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {this.Dispose();}
    }
}
