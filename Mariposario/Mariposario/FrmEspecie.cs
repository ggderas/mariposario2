using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region Autor: Cindy Carolina Alonzo

#endregion

namespace Mariposario
{
    public partial class FrmEspecie : Form
    {
        public List<Especie> listaEspecie { set; get; }
        public List<Mariposa> listaMariposa { set; get; }
        public List<Zona_Geografica> listaZonaGeografica { set; get; }
        List<String> nombresComunes { set; get; }
        public frmMain FrmMain { set; get; }
        Conexion conexion;

        public FrmEspecie()
        {
            InitializeComponent();
           
        }

        public FrmEspecie( frmMain frmMain)
        {
            InitializeComponent();
            conexion = new Conexion();
           
            this.FrmMain = frmMain;
            listaEspecie = this.FrmMain.Especies;
            if (listaEspecie != null) {
                this.lbxEspecies.Items.AddRange(listaEspecie.ToArray());
                this.lbxEspecies.SelectedIndex = 0;
                
            }

            
        }


        private void cargarInformacionCombobox() {

            Especie especie = (Especie)this.lbxEspecies.SelectedItem;
            if ( especie != null ) {
              
                this.cbNombreComun.Items.AddRange(especie.NombreComun_Zona.ToArray());
                if (cbNombreComun.Items.Count != 0) { cbNombreComun.SelectedIndex = 0; }
                this.cbMariposas.Items.AddRange(especie.listaMariposas.ToArray());
                if (cbMariposas.Items.Count != 0) { cbMariposas.SelectedIndex = 0; }
                this.cbZonas.Items.AddRange(especie.listaZonaGeografica.ToArray());
                if (cbZonas.Items.Count != 0) { cbZonas.SelectedIndex = 0; }
                this.cbGeneros.Items.Add(especie.Genero.ToString());
                if(cbGeneros.Items.Count!=0)this.cbGeneros.SelectedIndex = 0;

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregar_Especie_Genero_FamiliaNatural f = new FrmAgregar_Especie_Genero_FamiliaNatural(new Especie(""), this.FrmMain);
            f.ShowDialog();
            if(f.DialogResult == DialogResult.OK){
                this.actualizarLisboxEspecie();
            }

        }

        private void actualizarLisboxEspecie() {
            this.FrmMain.CargarBaseDeDatos();
            listaEspecie = FrmMain.Especies;
            lbxEspecies.Items.Clear();
            this.lbxEspecies.Items.AddRange(listaEspecie.ToArray());

        }

        private void lbxEspecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbGeneros.Items.Clear();
            this.cbMariposas.Items.Clear();
            this.cbNombreComun.Items.Clear();
            this.cbZonas.Items.Clear();
            cargarInformacionCombobox();
        }

        #region Actualiza las Especie
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if( this.lbxEspecies.SelectedItem!=null ){
                Especie especie = (Especie)this.lbxEspecies.SelectedItem;
                FrmActualizar f = new FrmActualizar(especie, FrmMain);
                f.ShowDialog();
                actualizarLisboxEspecie();
            }
            else
            {
                MessageBox.Show("Seleccione un elemento", "Especie", MessageBoxButtons.OK);
            }
        }
        #endregion

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lbxEspecies.SelectedItem != null)
            {
                Especie f = (Especie)this.lbxEspecies.SelectedItem;
                if ((conexion.eliminarEspecie(f.NombreCientifico)))
                {
                    this.actualizarLisboxEspecie();
                    MessageBox.Show("Eliminación Exitosa", "Eliminar Especie...", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Eliminación fallida", "Eliminar Especie...", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una Especie", "Especie...", MessageBoxButtons.OK);
            }
        }

       
    }
}
