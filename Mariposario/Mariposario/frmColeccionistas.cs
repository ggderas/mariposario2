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
    public partial class frmColeccionistas : Form
    {
        private List<Coleccionista> Coleccionistas = new List<Coleccionista>();
        private Conexion conexion = new Conexion();
        private frmMain main;

        public frmColeccionistas(List<Coleccionista> coleccionistas, frmMain main)
        {
            InitializeComponent();
            Coleccionistas = coleccionistas;
            this.lbxIdColeccionistas.Items.Clear();
            this.lbxIdColeccionistas.Items.AddRange(Coleccionistas.ToArray());
            this.btnEditarColeccionista.Enabled = this.btnEliminarColeccionista.Enabled = false;
            this.main = main;
        }

        private void lbxIdColeccionistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Coleccionista co = (Coleccionista)this.lbxIdColeccionistas.SelectedItem;
            this.lblNombres.Text = co.Nombres;
            this.lblApellidos.Text = co.Apellidos;
            this.btnEditarColeccionista.Enabled = this.btnEliminarColeccionista.Enabled = true;
        }

        private void btnEditarColeccionista_Click(object sender, EventArgs e)
        {
            frmAdminColeccionistas Editar = new frmAdminColeccionistas((Coleccionista)this.lbxIdColeccionistas.SelectedItem,2,this.main);
            Editar.ShowDialog();
            this.Coleccionistas = this.main.ColeccionistasL;
            this.lbxIdColeccionistas.Items.Clear();
            this.lbxIdColeccionistas.Items.AddRange(Coleccionistas.ToArray());

        }

        private void btnEliminarColeccionista_Click(object sender, EventArgs e)
        {
            frmAdminColeccionistas Eliminar = new frmAdminColeccionistas((Coleccionista)this.lbxIdColeccionistas.SelectedItem, 3, this.main);
            Eliminar.ShowDialog();
            this.Coleccionistas = this.main.ColeccionistasL;
            this.lbxIdColeccionistas.Items.Clear();
            this.lbxIdColeccionistas.Items.AddRange(Coleccionistas.ToArray());
        }

        private void tsmAgregarColeccionista_Click(object sender, EventArgs e)
        {
            frmAdminColeccionistas Agregar = new frmAdminColeccionistas((Coleccionista)this.lbxIdColeccionistas.SelectedItem, 1, this.main);
            Agregar.ShowDialog();
            this.Coleccionistas = this.main.ColeccionistasL;
            this.lbxIdColeccionistas.Items.Clear();
            this.lbxIdColeccionistas.Items.AddRange(Coleccionistas.ToArray());
        }

        private void frmColeccionistas_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
