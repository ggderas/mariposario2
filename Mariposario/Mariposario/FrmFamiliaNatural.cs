

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

    public enum Clasificacion{FamiliaNatural, Especie, Genero}

    public partial class FrmFamiliaNatural : Form
    {
        Conexion conexion = new Conexion();
        List<FamiliaNatural> listaFamiliaNatural;
      
        #region Constructores
        public FrmFamiliaNatural()
        {
            InitializeComponent();
           listaFamiliaNatural = conexion.obtenerFamiliaNatural();
           this.lbxFamiliaNatural.Items.AddRange(listaFamiliaNatural.ToArray());
           
        }

        public FrmFamiliaNatural(List<FamiliaNatural> lista)
        {
            InitializeComponent();
            listaFamiliaNatural = lista;
            this.lbxFamiliaNatural.Items.AddRange(listaFamiliaNatural.ToArray());
        }

        #endregion

        #region Carga las familas Naturales y los generos que corresponden a cada familia
       
        private void lbxFamiliaNatural_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lbxInformacion.Items.Clear();
            cargarFamiliaNatural();
              
        }
        #endregion

        private void cargarFamiliaNatural() {
            FamiliaNatural familia = (FamiliaNatural)this.lbxFamiliaNatural.SelectedItem;
            if (familia != null) {
                if (familia.Generos != null)
                {
                    this.lbxInformacion.Items.AddRange(familia.Generos.ToArray());
                } 
            }
            
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {      
            FrmAgregar_Especie_Genero_FamiliaNatural f = new FrmAgregar_Especie_Genero_FamiliaNatural(new FamiliaNatural("",""));
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK) {
                this.actualizaElLisboxFamiliaNatural();
            }
        }

        
        #region Eliminar Familia Natural
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lbxFamiliaNatural.SelectedItem != null)
            {
                FamiliaNatural f = (FamiliaNatural)this.lbxFamiliaNatural.SelectedItem;
                if ((conexion.eliminarFamiliaNatural(f.Identificador)))
                {
                    this.actualizaElLisboxFamiliaNatural();
                    MessageBox.Show("Eliminación Exitosa");
                }
                else
                {
                    MessageBox.Show("Eliminación fallida");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una Familia Natural");
            }
        }
    
        #endregion

        #region Actualizar Familia Natural
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (lbxFamiliaNatural.SelectedItem != null)
            {
                FamiliaNatural f = (FamiliaNatural)this.lbxFamiliaNatural.SelectedItem;
                FrmActualizar frm = new FrmActualizar(f);
                frm.ShowDialog();
                actualizaElLisboxFamiliaNatural();
            }
            else
            {
                MessageBox.Show("Seleccione un elemento");
            }
        }
        #endregion

        #region obtener Familia Natural
        private void actualizaElLisboxFamiliaNatural() {
            listaFamiliaNatural = conexion.obtenerFamiliaNatural();
            this.lbxFamiliaNatural.Items.Clear();
            this.lbxFamiliaNatural.Items.AddRange(listaFamiliaNatural.ToArray());
                     
        }
        #endregion

      
    }
}
