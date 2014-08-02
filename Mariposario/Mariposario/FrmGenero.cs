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
        public List<Genero> listaGeneros { set; get; }
        List<Especie> listaEspecie { set; get; }
        public frmMain FrmMain { set; get; }
        Conexion conexion = new Conexion();

        public FrmGenero()
        {
            InitializeComponent();
            //listaGeneros = conexion.obtenerGeneros();
            //lbxGenero.Items.AddRange(listaGeneros.ToArray());
        }
        #region Constructor que recibe una lista de generos
        public FrmGenero(frmMain frmMain) {
            InitializeComponent();
            this.FrmMain = frmMain;
            this.listaEspecie = this.FrmMain.Especies;
            listaGeneros = FrmMain.Generos;
            if( listaGeneros.Count!=0 )
                lbxGenero.Items.AddRange(listaGeneros.ToArray());
        }
        #endregion
        #region Carga los generos y las especies que corresponden que corresponden a un genero
        private void lbxGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lbxInformacion.Items.Clear();
            Genero genero = (Genero)lbxGenero.SelectedItem;
            if (genero != null)
                this.txtCodigo.Text = genero.Identificador;
              this.lbxInformacion.Items.AddRange(genero.Especies.ToArray());
        }
        #endregion
        #region AgregarGenero
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregar_Especie_Genero_FamiliaNatural f= new FrmAgregar_Especie_Genero_FamiliaNatural(new Genero("",""),FrmMain);
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK) {
                this.actualizaElLisboxGeneros();
            }
        }
        #endregion
        #region ACTUALIZAR LISTBOX GENEROS
        private void actualizaElLisboxGeneros()
        {
            this.FrmMain.CargarBaseDeDatos();
            listaGeneros = this.FrmMain.Generos;
            this.lbxGenero.Items.Clear();
            this.lbxGenero.Items.AddRange(listaGeneros.ToArray());

        }
        #endregion
        #region Actualizar Género
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if ( this.lbxGenero.SelectedItem != null)
            {
                    Genero g = (Genero)lbxGenero.SelectedItem;
                    FrmActualizar f = new FrmActualizar(g,this.FrmMain);
                    f.ShowDialog();
                    if (f.DialogResult == DialogResult.OK)
                    {
                        MessageBox.Show("Actualización Exitosa", "Actualizar género...", MessageBoxButtons.OK);
                        this.actualizaElLisboxGeneros();

                    }
            }
            else {
                MessageBox.Show("Seleccione un elemento", "Género", MessageBoxButtons.OK);
            }
        }
        #endregion
        #region Eliminar Género
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lbxGenero.SelectedItem != null) {

                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este elemento?", "Eliminar género", MessageBoxButtons.YesNoCancel);
                if (resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    Genero g = (Genero)lbxGenero.SelectedItem;
                    if (conexion.eliminarGenero(g.Identificador))
                    {
                        this.actualizaElLisboxGeneros();
                        MessageBox.Show("Eliminación Exitosa", "Eliminar género...", MessageBoxButtons.OK);
                    }
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
        #endregion
    }
}
