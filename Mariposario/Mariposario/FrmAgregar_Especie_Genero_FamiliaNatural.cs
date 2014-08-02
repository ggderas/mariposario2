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
        public frmMain Frmain { set; get; }

        public FrmAgregar_Especie_Genero_FamiliaNatural()
        {
            InitializeComponent();
        }

       /*Constructor que recibe un objeto, esto es para ver si es familia natural
            especie, genero en base a cualquiera de ellos se van a poner invisibles algunos controles.
        */
        public FrmAgregar_Especie_Genero_FamiliaNatural(object obj,frmMain frmMain)
        {
            InitializeComponent();
            this.Frmain = frmMain;
            clasificador = obj;
            if ( obj is Genero ) {
                this.label2.Visible = true;
                this.label3.Visible = true;     
                this.cbFamiliasOGeneros.Visible = true;
                listaFamilia = this.Frmain.FamiliasNaturales;
                if (listaFamilia!=null) {
                    this.cbFamiliasOGeneros.Items.AddRange(listaFamilia.ToArray());
                    if (this.cbFamiliasOGeneros.Items.Count != 0)
                    {
                        this.cbFamiliasOGeneros.SelectedIndex = 0;
                    }
                }
            }
            else if( obj is Especie) {
                    this.label1.Text = "Nombre Cientifico: ";
                    this.txtIdentificador.Location = new Point(140, 27);
                    this.txtIdentificador.Size = new Size(100, 20);
                    this.label2.Text = "Familias: ";
                    this.txtNombre.Visible = false;
                    this.cbFamiliasOGeneros.Location = new Point(140,67);
                    this.cbFamiliasOGeneros.Size = new Size(100, 20); 
                    this.cbFamiliasOGeneros.Visible = true;
                    listaGenero = Frmain.Generos;
                    if ( listaGenero != null) {
                        this.cbFamiliasOGeneros.Items.AddRange(listaGenero.ToArray());
                        if (this.cbFamiliasOGeneros.Items.Count != 0)
                        {
                            this.cbFamiliasOGeneros.SelectedIndex = 0;
                        }
                    }
            
                }
        }

        /*Metodo que inserta los registros en la base de datos, ya sea una familia natural, una especie, un genero*/
        public void insertarRegistroBaseDeDatos() {
            if ( clasificador is FamiliaNatural) {
                if (NohayCamposVacios()) {
                    if (conexion.insertarFamiliaNatural(this.txtIdentificador.Text, this.txtNombre.Text))
                    {
                        this.Frmain.CargarBaseDeDatos();
                        MessageBox.Show("La Familia Natural fue agregada éxitosamente","Agregar Familia Natural",MessageBoxButtons.OK);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Operación fallida", "Agregar Familia Natural", MessageBoxButtons.OK);
                    }
                }
            }
            else if ( clasificador is Genero ) {
                       FamiliaNatural f = (FamiliaNatural)this.cbFamiliasOGeneros.SelectedItem;
                        if (NohayCamposVacios()) {
                            if (conexion.insertarGenero(this.txtIdentificador.Text, txtNombre.Text, f.Identificador))
                            {
                                this.Frmain.CargarBaseDeDatos();
                                MessageBox.Show("El género fue agregado éxitosamente","Agregar Género",MessageBoxButtons.OK);
                                this.DialogResult = DialogResult.OK;
                            }
                            else {
                                MessageBox.Show("Operación fallida", "Agregar Género", MessageBoxButtons.OK);
                            }
                        }
                }
                else if ( clasificador is Especie ) {
                                Genero genero = (Genero)this.cbFamiliasOGeneros.SelectedItem;
                            if (NohayCamposVacios()) {
                                if (conexion.insertarEspecie(this.txtIdentificador.Text, genero.Identificador))
                                {
                                    this.DialogResult = DialogResult.OK;
                                    this.Frmain.CargarBaseDeDatos();
                                    MessageBox.Show("La Especie fue agregado éxitosamente", "Agregar Especie", MessageBoxButtons.OK);

                                }
                                 else
                                     {
                                          MessageBox.Show("Operación fallida", "Agregar Especie", MessageBoxButtons.OK);
                                     }
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

            if (clasificador is Especie) {
                if (String.IsNullOrWhiteSpace(txtIdentificador.Text))
                {
                    MessageBox.Show("Llene todos los campos, es de cáracter obligatorio");
                    return false;
                }
            }

            else if (String.IsNullOrWhiteSpace(txtIdentificador.Text) || String.IsNullOrWhiteSpace(txtNombre.Text))
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
