using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mariposario{
    public partial class frmAgregarPrecio:Form {
        public float precio;
        public frmAgregarPrecio() {
            InitializeComponent();
            this.numerocPrecio.Focus();
        }

        private void frmAgregarPrecio_FormClosed(object sender, FormClosedEventArgs e) { if(precio<=0)precio=100; this.Dispose(); }

        private void btnAceptar_Click(object sender, EventArgs e) {
            this.precio = (float)numerocPrecio.Value;
            this.Dispose();
        }

        private void frmAgregarPrecio_Load(object sender, EventArgs e) {
            this.numerocPrecio.Focus();
        }
    }
}
