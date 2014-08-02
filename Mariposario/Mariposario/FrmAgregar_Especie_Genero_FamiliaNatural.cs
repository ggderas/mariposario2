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
    public partial class FrmAgregar_Especie_Genero_FamiliaNatural : Form
    {
        Conexion conexion = new Conexion();
        List<FamiliaNatural> listaFamilia;
        List<Genero> listaGenero;
        object clasificador;

        public FrmAgregar_Especie_Genero_FamiliaNatural()
        {
            InitializeComponent();
        }

       /*Constructor que recibe un objeto, esto es para ver si es familia natural
            especie, genero en base a cualquiera de ellos se van a poner invisibles algunos controles.
        */
        public FrmAgregar_Especie_Genero_FamiliaNatural(object obj)
        {
            InitializeComponent();
           
            clasificador = obj;
            if ( obj is Genero ) {
                this.label2.Visible = true;
                this.label3.Visible = true;     
                this.cbFamiliasOGeneros.Visible = true;
                listaFamilia = conexion.obtenerFamiliaNatural();
                this.cbFamiliasOGeneros.Items.AddRange(listaFamilia.ToArray());
               // this.cbFamiliasOGeneros.SelectedItem = 0;

            }
        }

        /*Metodo que inserta los registros en la base de datos, ya sea una familia natural, una especie, un genero*/
        public void insertarRegistroBaseDeDatos() {
            if ( clasificador is FamiliaNatural) {
                if (NohayCamposVacios()) {
                    if (conexion.insertarFamiliaNatural(this.txtIdentificador.Text, this.txtNombre.Text))
                    {
                        MessageBox.Show("La Familia Natural fue agregada éxitosamente");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Operación fallida");
                    }
                }
            }
            else if ( clasificador is Genero ) {
                       FamiliaNatural f = (FamiliaNatural)this.cbFamiliasOGeneros.SelectedItem;
                        if (NohayCamposVacios()) {
                            if (conexion.insertarGenero(this.txtIdentificador.Text, txtNombre.Text, f.Identificador))
                            {
                                MessageBox.Show("El genero fue agregado éxitosamente");
                                this.DialogResult = DialogResult.OK;
                            }
                            else {
                                MessageBox.Show("Operación fallida");
                            }
                        }
                }
                else if ( clasificador is Especie ) {
                            Especie especie = (Especie)clasificador;
                            if (conexion.insertarEspecie(this.txtIdentificador.Text, especie.Genero.Identificador)) {
                                this.DialogResult = DialogResult.OK;
                            }
                        }
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (NohayCamposVacios() ) {
                insertarRegistroBaseDeDatos();
            }
        }

        #region Metodo NoHayCamposVacios
        /*Metodo que verifica si hay campos vacios*/
        public bool NohayCamposVacios() {
            
            if (String.IsNullOrWhiteSpace(txtIdentificador.Text) || String.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Llene todos los campos, es de cáracter obligatorio");
                    return false;
                }
            
            return true;
        }
        #endregion
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
