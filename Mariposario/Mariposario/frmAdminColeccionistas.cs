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
    public partial class frmAdminColeccionistas : Form
    {
        private Int32 accion;
        private Coleccionista coleccionista;
        private Conexion conexion = new Conexion();
        private frmMain main;

        public frmAdminColeccionistas()
        {
            InitializeComponent();
        }

        /*
         * Accion es un int que me determina la accion del form, ya que este form 
         * es multi proposito sirve para insertar, modificar y eliminar.
         * 1. Insertar
         * 2. Modificar
         * 3. Eliminar
         */
        public frmAdminColeccionistas(Coleccionista coleccionista, Int32 accion, frmMain main)
        {
            InitializeComponent();
            this.coleccionista = coleccionista;
            this.accion = accion;
            this.cbxColeccion.Items.Clear();
            this.prepararFormularioParaAccion(accion);
            this.main = main;
        }

        private void frmAdminColeccionistas_Load(object sender, EventArgs e)
        {

        }

        private void prepararFormularioParaAccion(Int32 accion)
        {
            
            switch (accion)
            {
                case 1:
                    {
                        this.Text = "Mariposario - Crear Coleccionista";
                        this.lblColeccion.Visible = this.cbxColeccion.Visible = this.btnAccion.Enabled = false;
                        this.btnAccion.Text = "Crear";
                        break;
                    }
                case 2:
                    {
                        this.Text = "Mariposario - Editar Coleccionista";
                        this.btnAccion.Text = "Editar";
                        this.txtId.Text = coleccionista.Identificador;
                        this.txtNombres.Text = coleccionista.Nombres;
                        this.txtApellidos.Text = coleccionista.Apellidos;
                        break;
                    }
                case 3:
                    {
                        this.Text = "Mariposario - Eliminar Coleccionista";
                        this.txtId.Enabled = this.txtApellidos.Enabled = this.txtNombres.Enabled = this.cbxColeccion.Enabled
                            = false;
                        this.btnAccion.Text = "Eliminar";
                        this.txtId.Text = coleccionista.Identificador;
                        this.txtNombres.Text = coleccionista.Nombres;
                        this.txtApellidos.Text = coleccionista.Apellidos;
                        break;
                    }
            }
            this.txtId.Focus();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            switch (accion)
            {
                case 1:
                    {
                        if (!this.conexion.insertarPersona(this.txtId.Text.Trim(), this.txtNombres.Text,
                            this.txtApellidos.Text, "C"))
                        {
                            MessageBox.Show("Identificador de Coleccionista ya existe en la Base de Datos", "Error Inserción: Identificador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.txtId.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Coleccionista creado con éxito.", "Creación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            main.CargarBaseDeDatos();
                            this.Close();
                        }
                        break;
                    }
                case 2:
                    {
                        if (!this.conexion.modificarPersona(this.coleccionista.Identificador, this.txtId.Text, this.txtNombres.Text,
                            this.txtApellidos.Text, "C"))
                        {
                            MessageBox.Show("Identificador de Coleccionista no existe en la Base de Datos o el identificador nuevo ya existe en la base de datos", "Error Edición: Identificador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.txtId.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Coleccionista editado con éxito.", "Edición Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            main.CargarBaseDeDatos();
                            this.Close();
                        }
                        break;
                    }
                case 3:
                    {
                        if (!this.conexion.eliminarPersona(this.txtId.Text.Trim()))
                        {
                            MessageBox.Show("Identificador de Coleccionista no existe en la Base de Datos", "Error Eliminación: Identificador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.txtId.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Coleccionista eliminado con éxito.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            main.CargarBaseDeDatos();
                            this.Close();
                        }
                        break;
                    }
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (!this.txtId.Text.Equals(String.Empty))
            {
                this.btnAccion.Enabled = true;
            }
            else
            {
                this.btnAccion.Enabled = false;
            }

            if (this.txtId.Text.Length > 10)
            {
                this.errorProvider1.SetError(this.txtId, "Identificador no puede contener más de 10 caracteres.");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            if (this.txtNombres.Text.Length > 50)
            {
                this.errorProvider1.SetError(this.txtNombres, "Nombres no pueden contener más de 50 caracteres.");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            if (this.txtApellidos.Text.Length > 50)
            {
                this.errorProvider1.SetError(this.txtApellidos, "Apellidos no pueden contener más de 50 caracteres.");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void frmAdminColeccionistas_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
