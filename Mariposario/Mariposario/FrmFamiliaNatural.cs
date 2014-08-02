

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

    
    public partial class FrmFamiliaNatural : Form
    {
        Conexion conexion = new Conexion();
        List<FamiliaNatural> listaFamiliaNatural;
        public frmMain FrmMain { set; get; }

        #region Constructores
        public FrmFamiliaNatural()
        {
            InitializeComponent();
            //listaFamiliaNatural = conexion.obtenerFamiliaNatural();
           //this.lbxFamiliaNatural.Items.AddRange(listaFamiliaNatural.ToArray());
           
        }

        public FrmFamiliaNatural(frmMain frmMain)
        {
            InitializeComponent();
            this.FrmMain = frmMain;
            this.listaFamiliaNatural = this.FrmMain.FamiliasNaturales;
            if(this.listaFamiliaNatural.Count!=0)
              this.lbxFamiliaNatural.Items.AddRange(listaFamiliaNatural.ToArray());

        }

        #endregion

        #region Carga las familas Naturales y los generos que corresponden a cada familia  
       
        private void lbxFamiliaNatural_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lbxInformacion.Items.Clear();
            cargarGeneros();
              
        }
        #endregion

        private void cargarGeneros() {
            
            FamiliaNatural familia = (FamiliaNatural)this.lbxFamiliaNatural.SelectedItem;
            if (familia != null) {
                if (familia.Generos != null)
                {
                    this.txtCodigo.Text = familia.Identificador;
                    this.lbxInformacion.Items.AddRange(familia.Generos.ToArray());
                } 
            }
            
        }

        #region Agregar Familia 
        private void btnAgregar_Click(object sender, EventArgs e)
        {      
            FrmAgregar_Especie_Genero_FamiliaNatural f = new FrmAgregar_Especie_Genero_FamiliaNatural(new FamiliaNatural("",""),FrmMain);
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK) {
                this.actualizaElLisboxFamiliaNatural();
               
            }
        }
        #endregion

        #region Eliminar Familia Natural
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lbxFamiliaNatural.SelectedItem != null)
            {
                FamiliaNatural f = (FamiliaNatural)this.lbxFamiliaNatural.SelectedItem;
                if ((conexion.eliminarFamiliaNatural(f.Identificador)))
                {
                    this.actualizaElLisboxFamiliaNatural();
                    MessageBox.Show("Eliminación Exitosa","Eliminar Familia Natural...",MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Eliminación fallida", "Eliminar Familia Natural...", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una Familia Natural","Familia Natural..",MessageBoxButtons.OK);
            }
        }
    
        #endregion

        #region Actualizar Familia Natural
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (lbxFamiliaNatural.SelectedItem != null)
            {
                FamiliaNatural f = (FamiliaNatural)this.lbxFamiliaNatural.SelectedItem;
                FrmActualizar frm = new FrmActualizar(f,FrmMain);
                frm.ShowDialog();
                actualizaElLisboxFamiliaNatural();
            }
            else
            {
                MessageBox.Show("Seleccione un elemento","Familia Natural",MessageBoxButtons.OK );
            }
        }
        #endregion

        #region obtener Familia Natural

        private void actualizaElLisboxFamiliaNatural() {
            this.FrmMain.CargarBaseDeDatos();
            listaFamiliaNatural = this.FrmMain.FamiliasNaturales;
            this.lbxFamiliaNatural.Items.Clear();
            this.lbxFamiliaNatural.Items.AddRange(listaFamiliaNatural.ToArray());
                     
        }
        #endregion

    
      
    }
}
