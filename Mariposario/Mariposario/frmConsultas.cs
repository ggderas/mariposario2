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
    public partial class frmConsultas : Form
    {

        private Conexion conexion;
        public frmConsultas()
        {
            InitializeComponent();
        }

        public frmConsultas(Conexion conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
        }

        private void btnConsulta1_Click(object sender, EventArgs e)
        {
            DataTable resultado = this.conexion.consulta1();
            this.dgvResultados.DataSource = resultado;
        }

        private void btnConsulta1_MouseMove(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.Khaki;
        }

        private void btnConsulta1_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.LightSteelBlue;
        }

        private void btnConsulta2_Click(object sender, EventArgs e)
        {
            DataTable resultado = this.conexion.consulta2();
            this.dgvResultados.DataSource = resultado;
        }

        private void btnConsulta3_Click(object sender, EventArgs e)
        {

        }

        private void btnConsulta4_Click(object sender, EventArgs e)
        {

        }

        private void btnConsulta5_Click(object sender, EventArgs e)
        {

        }

        private void btnConsulta6_Click(object sender, EventArgs e)
        {

        }

        private void btnConsulta7_Click(object sender, EventArgs e)
        {

        }

        private void btnConsulta8_Click(object sender, EventArgs e)
        {

        }
    }
}
