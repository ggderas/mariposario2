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
    public partial class frmAdminBiologos : Form
    {
        private Int32 accion;
        private Biologo biologo;
        private Conexion conexion = new Conexion();
        private frmMain main;

        public frmAdminBiologos()
        {
            InitializeComponent();
        }

        public frmAdminBiologos(Biologo biologo, Int32 accion, frmMain main)
        {
            InitializeComponent();
            this.biologo = biologo;
            this.accion = accion;
            this.prepararFormularioParaAccion(accion);
            this.main = main;
        }

        private void prepararFormularioParaAccion(Int32 accion)
        {

            switch (accion)
            {
                case 1:
                    {
                        this.Text = "Mariposario - Crear Biologo";
                        this.btnAccion.Enabled = false;
                        this.btnAccion.Text = "Crear";
                        break;
                    }
                case 2:
                    {
                        this.Text = "Mariposario - Editar Biologo";
                        this.btnAccion.Text = "Editar";
                        this.txtId.Text = biologo.Identificador;
                        this.txtNombres.Text = biologo.Nombres;
                        this.txtApellidos.Text = biologo.Apellidos;
                        break;
                    }
                case 3:
                    {
                        this.Text = "Mariposario - Eliminar Biologo";
                        this.txtId.Enabled = this.txtApellidos.Enabled = this.txtNombres.Enabled = false;
                        this.btnAccion.Text = "Eliminar";
                        this.txtId.Text = biologo.Identificador;
                        this.txtNombres.Text = biologo.Nombres;
                        this.txtApellidos.Text = biologo.Apellidos;
                        break;
                    }
            }
            this.txtId.Focus();
        }

        /*
         * Accion es un int que me determina la accion del form, ya que este form 
         * es multi proposito sirve para insertar, modificar y eliminar.
         * 1. Insertar
         * 2. Modificar
         * 3. Eliminar
         */

        private void btnAccion_Click(object sender, EventArgs e)
        {
            switch (accion)
            {
                case 1:
                    {
                        if (!this.conexion.insertarPersona(this.txtId.Text.Trim(), this.txtNombres.Text,
                            this.txtApellidos.Text,"B"))
                        {
                            MessageBox.Show("Identificador de Biologo ya existe en la Base de Datos", "Error Inserción: Identificador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.txtId.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Biologo creado con éxito.", "Creación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            main.CargarBaseDeDatos();
                            this.Close();
                        }
                        break;
                    }
                case 2:
                    {
                        if (!this.conexion.modificarPersona(this.biologo.Identificador, this.txtId.Text, this.txtNombres.Text,
                            this.txtApellidos.Text,"B"))
                        {
                            MessageBox.Show("Identificador de Biologo no existe en la Base de Datos o el identificador nuevo ya existe en la base de datos", "Error Edición: Identificador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.txtId.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Biologo editado con éxito.", "Edición Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            main.CargarBaseDeDatos();
                            this.Close();
                        }
                        break;
                    }
                case 3:
                    {
                        if (!this.conexion.eliminarPersona(this.txtId.Text.Trim()))
                        {
                            MessageBox.Show("Identificador de Biologo no existe en la Base de Datos", "Error Eliminación: Identificador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.txtId.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Biologo eliminado con éxito.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            main.CargarBaseDeDatos();
                            this.Close();
                        }
                        break;
                    }
            }
        }

        private void frmAdminBiologos_FormClosed(object sender, FormClosedEventArgs e)
        {
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
    }
}
