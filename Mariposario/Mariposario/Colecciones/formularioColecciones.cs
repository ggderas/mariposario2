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
        private List<Coleccion> colecciones;
        private List<Coleccionista> coleccionistas;
        public formularioColecciones() {
            InitializeComponent();
            Conexion c = new Conexion();
            this.colecciones=c.obtenerColecciones();
            this.lbColecciones.DataSource = colecciones;
            //this.coleccionistas=c.obtenerColeccionistas();
            //this.cmbPropietario.DataSource=this.coleccionistas;
        }

        //Evento que abre el formulario para agregar una nueva colección.
        private void btnAgregar_Click(object sender, EventArgs e) {
            formularioAgregarColeccion f = new formularioAgregarColeccion();
            f.Show();
        }
    }
}
