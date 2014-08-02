using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mariposario
{
    public partial class frmBiologos : Form
    {
        private List<Biologo> Biologos = new List<Biologo>();
        private Conexion conexion = new Conexion();
        private frmMain main;

        public frmBiologos(List<Biologo> biologos, frmMain main)
        {
            InitializeComponent();
            this.Biologos = biologos;
            this.lbxIdBiologos.Items.Clear();
            this.lbxIdBiologos.Items.AddRange(Biologos.ToArray());
            this.btnEditarBiologo.Enabled = this.btnEliminarBiologo.Enabled = false;
            this.main = main;
        }

        private void btnEditarBiologo_Click(object sender, EventArgs e)
        {
            frmAdminBiologos Editar = new frmAdminBiologos((Biologo)this.lbxIdBiologos.SelectedItem, 2, this.main);
            Editar.ShowDialog();
            this.Biologos = this.main.Biologos;
            this.lbxIdBiologos.Items.Clear();
            this.lbxIdBiologos.Items.AddRange(Biologos.ToArray());
        }

        private void btnEliminarBiologo_Click(object sender, EventArgs e)
        {
            frmAdminBiologos Eliminar = new frmAdminBiologos((Biologo)this.lbxIdBiologos.SelectedItem, 3, this.main);
            Eliminar.ShowDialog();
            this.Biologos = this.main.Biologos;
            this.lbxIdBiologos.Items.Clear();
            this.lbxIdBiologos.Items.AddRange(Biologos.ToArray());
        }

        private void lbxIdBiologos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Biologo co = (Biologo)this.lbxIdBiologos.SelectedItem;
            this.lblNombres.Text = co.Nombres;
            this.lblApellidos.Text = co.Apellidos;
            this.btnEditarBiologo.Enabled = this.btnEliminarBiologo.Enabled = true;
        }

        private void tsmAgregarBiologos_Click(object sender, EventArgs e)
        {
            frmAdminBiologos Agregar = new frmAdminBiologos((Biologo)this.lbxIdBiologos.SelectedItem, 1, this.main);
            Agregar.ShowDialog();
            this.Biologos = this.main.Biologos;
            this.lbxIdBiologos.Items.Clear();
            this.lbxIdBiologos.Items.AddRange(Biologos.ToArray());
        }
    }
}
