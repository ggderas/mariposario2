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
        List<Especie> listaEspecie;
        public FrmEspecie()
        {
            InitializeComponent();
            
        }

        public FrmEspecie(List<Especie> especie)
        {
            InitializeComponent();
            listaEspecie = especie;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
