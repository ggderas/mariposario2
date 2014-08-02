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
    public partial class FrmActualizar : Form
    {
        object clasificador;
        Conexion conexion = new Conexion();
        List<FamiliaNatural> listaFamiliaNatural;
        List<Genero> listaGenero;

        public FrmActualizar()
        {
            InitializeComponent();
        }

        /*Formulario que activa o desactiva los controles de acuerdo al tipo de objeto
             que se le envie
        */
        public FrmActualizar(object obj)
        {
            InitializeComponent();
            clasificador = obj;

            if (obj is FamiliaNatural) {
                FamiliaNatural f = (FamiliaNatural)obj;
                this.txtIdentificador.Text = f.Identificador;
                this.txtNombre.Text = f.Nombre;
            }

                if (obj is Genero) {
                    this.lblcodigoFG.Visible = true;
                    this.lblcodigoFG.Text = "Código Familia";
                    Genero g = (Genero)clasificador;
                    this.txtNombre.Text = g.Nombre;
                    this.txtIdentificador.Text = g.Identificador;
                    this.cbFamiliaGeneros.Visible = true;
                    this.listaFamiliaNatural = conexion.obtenerFamiliaNatural();
                    if (listaFamiliaNatural != null) {
                        this.cbFamiliaGeneros.Items.AddRange(listaFamiliaNatural.ToArray());
                        this.cbFamiliaGeneros.SelectedIndex =buscarFamilia();    
                    }
                 }
                else if (obj is Especie)
               {
                    this.lblCodigo.Text = "Nombre Científico";
                    this.lblNombre.Text = "Código Genero";
                    Especie e = (Especie)obj;
                    this.txtNombre.Text = e.NombreCientifico;
                }

        }
        
        /*Metodo que busca la familia del genero*/
        private int buscarFamilia() {
            Genero g = (Genero)this.clasificador;
            for (int i = 0; i < listaFamiliaNatural.Count;i++ )
            {
                if (listaFamiliaNatural[i].Identificador.Equals(g.FamiliaNatural.Identificador))
                {
                    return i;
                }
            }
           return -1;
        }

        /*Metodo que verifica que todos los campos esten llenos*/
        private bool NohayCamposVacios()
        {
            if (clasificador is FamiliaNatural || clasificador is Especie) {
                if (String.IsNullOrWhiteSpace(txtIdentificador.Text) || String.IsNullOrWhiteSpace(txtNombre.Text))
                {   MessageBox.Show("Llene todos los campos, es de cáracter obligatorio");
                    return false;
                }
            }
            else if (clasificador is Genero) {
                if (String.IsNullOrWhiteSpace(txtIdentificador.Text) || String.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Llene todos los campos, es de cáracter obligatorio");
                    return false;
                } 
            }
            
            return true;
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            insertarBaseDedatos();
            
        }

        #region Insertar en la base de datos
        public void insertarBaseDedatos( ){
            if ( clasificador is FamiliaNatural) {
                FamiliaNatural f = (FamiliaNatural)clasificador;
                if (NohayCamposVacios()) {
                    if (conexion.modificarFamiliaNatural(f.Identificador, this.txtIdentificador.Text, this.txtNombre.Text))
                    {
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Actualización Exitosa");
                        this.Close();
                    }
                }
             }
            else if (clasificador is Especie)
                   {  Genero g = (Genero)clasificador;
                   }
            else if (clasificador is Genero)
                   {   Genero genero = (Genero)clasificador;
                      if (NohayCamposVacios())
                     {
                          FamiliaNatural f = (FamiliaNatural)this.cbFamiliaGeneros.SelectedItem;
                          if (conexion.modificarGenero(genero.Identificador,txtIdentificador.Text,txtNombre.Text,f.Identificador)) {
                              MessageBox.Show("Actualización Exitosa");
                              this.DialogResult = DialogResult.OK;
                              this.Close();
                          }
                      }
                   } 
        }

        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
