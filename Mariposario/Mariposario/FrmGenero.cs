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
    public partial class FrmGenero : Form
    {
        public List<Genero> listaGeneros;
        Conexion conexion = new Conexion();

        public FrmGenero()
        {
            InitializeComponent();
            //borrar
            listaGeneros = conexion.obtenerGeneros();
            lbxGenero.Items.AddRange(listaGeneros.ToArray());
        }
        #region Constructor que recibe una lista de generos
        public FrmGenero(List<Genero> listaGeneros) {
            listaGeneros = conexion.obtenerGeneros();
            lbxGenero.Items.AddRange(listaGeneros.ToArray());
        }
        #endregion

        #region Carga los generos y las especies que corresponden que corresponden a un genero
        private void lbxGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lbxInformacion.Items.Clear();
            Genero genero = (Genero)lbxGenero.SelectedItem;
            if(genero!=null)
              this.lbxInformacion.Items.AddRange(genero.Especies.ToArray());
        }
        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregar_Especie_Genero_FamiliaNatural f= new FrmAgregar_Especie_Genero_FamiliaNatural(new Genero("",""));
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK) {
                this.actualizaElLisboxGeneros();
            }
        }

        #region ACTUALIZAR LISTBOX GENEROS
        private void actualizaElLisboxGeneros()
        {
            listaGeneros = conexion.obtenerGeneros();
            this.lbxGenero.Items.Clear();
            this.lbxGenero.Items.AddRange(listaGeneros.ToArray());

        }
        #endregion

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if ( this.lbxGenero.SelectedItem != null)
            {
                Genero g = (Genero)lbxGenero.SelectedItem;
                FrmActualizar f = new FrmActualizar(g);
                f.ShowDialog();
                if ( f.DialogResult == DialogResult.OK ) {
                    this.actualizaElLisboxGeneros();
                }
            }
            else {
                MessageBox.Show("Seleccione un elemento");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lbxGenero.SelectedItem != null) {
                Genero g = (Genero)lbxGenero.SelectedItem;
                if (conexion.eliminarGenero(g.Identificador)) {
                    this.actualizaElLisboxGeneros();
                    MessageBox.Show("Eliminación Exitosa");
                }
                else
                {
                    MessageBox.Show("Eliminación fallida");
                }

            }
            else
            {
                MessageBox.Show("Seleccione una Género");
            }
        }

    }
}
