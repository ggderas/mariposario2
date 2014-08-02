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
        public frmMain FrmMain { set; get; }

        public FrmActualizar()
        {
            InitializeComponent();
        }

        /*Formulario que activa o desactiva los controles de acuerdo al tipo de objeto
             que se le envie
        */
        public FrmActualizar(object obj,frmMain frmMain)
        {
            InitializeComponent();
            clasificador = obj;
            this.FrmMain = frmMain;
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
                    this.listaFamiliaNatural = this.FrmMain.FamiliasNaturales;
                    if (listaFamiliaNatural != null) {
                        this.cbFamiliaGeneros.Items.AddRange(listaFamiliaNatural.ToArray());
                        if (cbFamiliaGeneros.Items.Count != 0) {
                            if (buscarFamilia() != -1) {
                                this.cbFamiliaGeneros.SelectedIndex = buscarFamilia();    
                   
                            }
                            
                          }
                     }
                 }
                else if (obj is Especie)
               {
                   this.txtNombre.Visible = false;
                    this.lblCodigo.Text = "Nombre Científico";
                    this.txtIdentificador.Location = new Point(140, 27);
                    this.txtIdentificador.Size = new Size(100, 20);
                    this.lblNombre.Text = "Código Género: ";
                    this.cbFamiliaGeneros.Visible = true;
                    this.cbFamiliaGeneros.Size = new Size(100, 20);
                    this.cbFamiliaGeneros.Location = new Point(140, 67); 
                    Especie e = (Especie)obj;
                    this.txtIdentificador.Text = e.NombreCientifico;
                    listaGenero = FrmMain.Generos;
                    if ( listaGenero != null ) {
                        cbFamiliaGeneros.Items.AddRange(listaGenero.ToArray());
                        if (cbFamiliaGeneros.Items.Count != 0) {
                            if (buscarGenero() != -1) {
                                this.cbFamiliaGeneros.SelectedIndex = buscarGenero();
                            }
                        }
                    }
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

        /*Metodo que busca el género de la Especie*/
      
        private int buscarGenero() {

            Especie e = (Especie)this.clasificador;
            for (int i = 0; i < listaGenero.Count; i++)
            {
                if (listaGenero[i].Identificador.Equals(e.Genero.Identificador))
                {
                    return i;
                }
            }

            return -1;
        }


        /*Metodo que verifica que todos los campos esten llenos*/
        private bool NohayCamposVacios()
        {
            if (clasificador is FamiliaNatural || clasificador is Genero) {
                if (String.IsNullOrWhiteSpace(txtIdentificador.Text) || String.IsNullOrWhiteSpace(txtNombre.Text))
                {   MessageBox.Show("Llene todos los campos, es de cáracter obligatorio","Actualizar",MessageBoxButtons.OK);
                    return false;
                }
            }
            else if (clasificador is Especie) {
                if (String.IsNullOrWhiteSpace(txtIdentificador.Text))
                {
                    MessageBox.Show("Llene todos los campos, es de cáracter obligatorio", "Actualizar", MessageBoxButtons.OK);
                    return false;
                } 
            }
            
            return true;
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
                        this.FrmMain.CargarBaseDeDatos();
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Actualización Exitosa", "Actualizar Familia Natural", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Actualización Fallida", "Actualizar Familia Natural", MessageBoxButtons.OK);
                       
                    }
                }
             }
            else if (clasificador is Especie)
                   {  Especie e = (Especie)clasificador;
                        
                      if (NohayCamposVacios()) { 
                            Genero genero = (Genero)this.cbFamiliaGeneros.SelectedItem;
                            if (conexion.modificarEspecie(e.NombreCientifico, this.txtIdentificador.Text, genero.Identificador))
                            {
                                this.FrmMain.CargarBaseDeDatos();
                                MessageBox.Show("Actualización Exitosa", "Actualizar Género..", MessageBoxButtons.OK);
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else {
                                MessageBox.Show("Actualización Fallida", "Actualizar Especie", MessageBoxButtons.OK);
                        
                            }

                        }

                   }
            else if (clasificador is Genero)
                   {   Genero genero = (Genero)clasificador;
                      if (NohayCamposVacios())
                     {
                          FamiliaNatural f = (FamiliaNatural)this.cbFamiliaGeneros.SelectedItem;
                          if (conexion.modificarGenero(genero.Identificador, txtIdentificador.Text, txtNombre.Text, f.Identificador))
                          {
                              this.FrmMain.CargarBaseDeDatos();
                              MessageBox.Show("Actualización Exitosa", "Actualizar Género..", MessageBoxButtons.OK);
                              this.DialogResult = DialogResult.OK;
                              this.Close();
                          }
                          else {
                              MessageBox.Show("Actualización Fallida", "Actualizar Género..", MessageBoxButtons.OK);
                             
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
