using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mariposario {
    //Formulario que manipula todo lo relacionado a las Colecciones de mariposas.
    public partial class formularioColecciones:Form {
        private Conexion conexion;
        public List<Coleccion> colecciones;
        public List<Biologo> personas;
        public List<Coleccionista> coleccionistas;
        public List<MariposaEnObservacion> mariposas;
        public List<MariposaDeColeccion> mariposasColeccion;
        public formularioColecciones(List<Coleccion> colecciones, List<Biologo> b,List<Coleccionista> col, List<MariposaEnObservacion> mariposas,List<MariposaDeColeccion> mariposasColeccion,Conexion c) {
            InitializeComponent();
            conexion = c;
            this.mariposasColeccion=mariposasColeccion;
            this.colecciones=colecciones;
            personas = b;
            this.coleccionistas=col;
            this.llenarListBox();
            this.mariposas=mariposas;
        }

        //Evento que abre el formulario para agregar una nueva colección.
        private void btnAgregar_Click(object sender, EventArgs e) {
            formularioAgregarColeccion f = new formularioAgregarColeccion(this.colecciones,this.personas,this.coleccionistas,this.mariposas,this.mariposasColeccion,this.conexion);
            f.ShowDialog();
            this.colecciones = f.colecciones;
            this.coleccionistas = f.coleccionistas;
            this.mariposas=f.mariposas;
            this.mariposasColeccion=f.mariposasColeccion;
            this.llenarListBox();
        }

        private void rbBusquedaID_CheckedChanged(object sender, EventArgs e) {
            if(this.rbBusquedaID.Checked) this.tbID.Enabled=true;
            else this.tbID.Enabled=false;
            this.btnBuscar.Enabled=true;
        }

        private void rbBusquedaPropietario_CheckedChanged(object sender, EventArgs e) {
            if(this.rbBusquedaPropietario.Checked) { this.tbID.Text=""; this.cmbPropietario.Enabled=true; } else this.cmbPropietario.Enabled=false;
            this.btnBuscar.Enabled=true;
        }

        private void llenarListBox() {
            this.lbColecciones.DataSource =null;
            this.cmbPropietario.DataSource = null;
            this.lbColecciones.DataSource = this.colecciones;
            this.cmbPropietario.DataSource = this.coleccionistas;
        }

        private void btnEliminarMariposasColeccion_Click(object sender, EventArgs e) {
            if(lbColecciones.SelectedIndex>=0) {
                Coleccion c = this.colecciones.ElementAt(this.lbColecciones.SelectedIndex);
                DialogResult r = MessageBox.Show("¿Seguro que desea eliminar la colección "+ c.Identificador+"?", "Colecciones - Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(r==DialogResult.Yes) {
                    if(this.conexion.eliminarColeccion(c)) {
                        Biologo biologo = new Biologo(c.Dueño.Identificador, c.Dueño.Nombres, c.Dueño.Apellidos, null);
                        c.Dueño.Coleccion=null;
                        Coleccionista dueño=null;
                        foreach(Coleccionista d in coleccionistas)
                            if(d.Identificador==c.Dueño.Identificador) dueño=d;
                        foreach(MariposaDeColeccion m in c.Mariposas)
                            this.mariposas.Add(new MariposaEnObservacion(m.Identificador, m.FechaDeCaptura, 10, m.Especie, m.Zona, m.Biologo,false));
                        this.colecciones.Remove(c); this.coleccionistas.Remove(dueño);
                        this.personas.Add(biologo);
                        this.llenarListBox();
                    }
                }
            } else MessageBox.Show("No ha seleccionado ninguna colección.", "Colecciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnModificarMariposasColeccion_Click(object sender, EventArgs e) {
            if(lbColecciones.SelectedIndex>=0) {
                Coleccion c = this.colecciones.ElementAt(this.lbColecciones.SelectedIndex);
                frmModificarColeccion f = new frmModificarColeccion(c, this.personas, this.coleccionistas, this.mariposas, this.conexion);
                f.ShowDialog();
                this.coleccionistas = f.coleccionistas;
                this.mariposas=f.mariposas;
                this.personas=f.personas;
                this.mariposasColeccion=f.mariposasColeccion;
                this.llenarListBox();
            } else MessageBox.Show("No ha seleccionado ninguna colección.", "Colecciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            if(this.rbBusquedaID.Checked) {
                bool f=false;
                for(int i=0; i<this.colecciones.Count; i++)
                    if(this.colecciones.ElementAt(i).Identificador==this.tbID.Text) { this.lbColecciones.SelectedIndex=i; f=true; break; }
                if(!f) MessageBox.Show("No existe una colección con ese ID.","Colecciones",MessageBoxButtons.OK,MessageBoxIcon.Information);
            } else {
                bool f=false;
                for(int i=0; i<this.colecciones.Count; i++)
                    if(this.colecciones.ElementAt(i).Dueño.Identificador==((Coleccionista)this.cmbPropietario.SelectedItem).Identificador) { this.lbColecciones.SelectedIndex=i; f=true; break; }
                if(!f) MessageBox.Show("Esa persona no tiene ninguna colección.", "Colecciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
