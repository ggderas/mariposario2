using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mariposario
{
    public partial class frmZonaGeografica : Form
    {
        private List<Zona_Geografica> Zonas;
        private Conexion conexion = new Conexion();
        private Button btnInsertarZona;
        private Button btnEditarZona;
        private Button btnEliminarZona;
        private Label label1;
        private ListBox lbxZonas;
        private ErrorProvider errorProvider1;
        private IContainer components;
        private PictureBox pbxEjecutarInsercion;
        private PictureBox pbxEjecutarEdicion;
        private PictureBox pbxCancelar;
        private TextBox txtInsertar;
        private TextBox txtEditar;
        private Zona_Geografica zona;
        private frmMain main;

        public frmZonaGeografica()
        {
            InitializeComponent();
        }

        public frmZonaGeografica(List<Zona_Geografica> zonas, frmMain main)
        {
            InitializeComponent();
            this.Zonas = zonas;
            this.cargarListBox();
            this.main = main;
        }

        private void cargarListBox()
        {
            this.lbxZonas.Items.Clear();
            this.lbxZonas.Items.AddRange(this.Zonas.ToArray());
            //this.lbxZonas.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zona_Geografica zona = (Zona_Geografica)this.lbxZonas.SelectedItem;
            if (MessageBox.Show("¿Está seguro que desea eliminar la zona " + zona.NombreZona + "?", "Eliminar Zona", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == System.Windows.Forms.DialogResult.Yes)
            {
                this.conexion.eliminarZonaGeografica(zona.NombreZona);
                MessageBox.Show("Zona Geográfica eliminada exitosamente", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.main.CargarBaseDeDatos();
                this.Zonas = this.main.Zonas_geograficas;
                cargarListBox();
            }

        }

        private void lbxZonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.lbxZonas.SelectedItem.Equals(null))
            {
                this.btnEditarZona.Enabled = true;
                this.btnEliminarZona.Enabled = true;
                this.zona = (Zona_Geografica)this.lbxZonas.SelectedItem;
            }
            else
            {
                this.txtEditar.Text = this.txtInsertar.Text = String.Empty;
                this.btnEditarZona.Enabled = this.txtEditar.Enabled = false;
                this.btnInsertarZona.Enabled = this.txtInsertar.Enabled = false;
            }
        }

        private void btnEditarZona_Click(object sender, EventArgs e)
        {
            this.txtEditar.Enabled = this.pbxCancelar.Enabled = this.pbxEjecutarEdicion.Enabled = true;
            this.lbxZonas.Enabled = false;
        }

        private void btnInsertarZona_Click(object sender, EventArgs e)
        {
            this.txtInsertar.Enabled = this.pbxCancelar.Enabled = this.pbxEjecutarInsercion.Enabled = true;
        }

        private void txtInsertar_TextChanged(object sender, EventArgs e)
        {
            if (!this.txtInsertar.Text.Equals(String.Empty) || this.txtInsertar.Text.Length < 51)
            {
                this.pbxEjecutarInsercion.Enabled = true;
            }
            else
            {
                this.pbxEjecutarInsercion.Enabled = false;
                if (this.txtInsertar.Text.Length > 50)
                    this.errorProvider1.SetError(this.txtInsertar, "Nombre de Zona Geográfica debe tener 50 o menos caracteres.");
                else
                    this.errorProvider1.Clear();
            }
        }

        private void txtEditar_TextChanged(object sender, EventArgs e)
        {
            if (!this.txtEditar.Text.Equals(String.Empty) || this.txtEditar.Text.Length < 51)
            {
                this.pbxEjecutarEdicion.Enabled = true;
            }
            else
            {
                this.pbxEjecutarEdicion.Enabled = false;
                if (this.txtEditar.Text.Length > 50)
                    this.errorProvider1.SetError(this.txtEditar, "Nombre de Zona Geográfica debe tener 50 o menos caracteres.");
                else
                    this.errorProvider1.Clear();
            }
        }

        private void pbxEjecutarInsercion_Click(object sender, EventArgs e)
        {

            if (this.conexion.insertarZonaGeografica(this.txtInsertar.Text.Trim()))
            {
                MessageBox.Show("Zona Geográfica Inserte con éxito", "Inserción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.main.CargarBaseDeDatos();
                this.txtInsertar.Text = this.txtEditar.Text = String.Empty;
                this.txtInsertar.Enabled = false;
                this.Zonas = this.main.Zonas_geograficas;
                cargarListBox();
            }
            else
            {
                MessageBox.Show("Zona ya existe.", "Error: Insercion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtInsertar.Focus();
            }
        }

        private void pbxEjecutarEdicion_Click(object sender, EventArgs e)
        {
            if (this.conexion.insertarZonaGeografica(this.txtEditar.Text.Trim()))
            {
                MessageBox.Show("Zona Geográfica Editada con éxito", "Inserción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.main.CargarBaseDeDatos();
                this.txtInsertar.Text = this.txtEditar.Text = String.Empty;
                this.txtEditar.Enabled = false;
                this.lbxZonas.Enabled = true;
                this.Zonas = this.main.Zonas_geograficas;
                cargarListBox();
            }
            else
            {
                MessageBox.Show("Zona ya existe.", "Error: Insercion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtEditar.Focus();
            }
        }

        private void pbxCancelar_Click(object sender, EventArgs e)
        {
            this.lbxZonas.Enabled = true;
            this.txtEditar.Text = this.txtInsertar.Text = String.Empty;
            this.txtInsertar.Enabled = this.txtEditar.Enabled = this.pbxEjecutarEdicion.Enabled = 
                this.pbxEjecutarInsercion.Enabled = false;
        }

        private void frmZonaGeografica_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZonaGeografica));
            this.btnInsertarZona = new System.Windows.Forms.Button();
            this.btnEditarZona = new System.Windows.Forms.Button();
            this.btnEliminarZona = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxZonas = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbxEjecutarInsercion = new System.Windows.Forms.PictureBox();
            this.pbxEjecutarEdicion = new System.Windows.Forms.PictureBox();
            this.pbxCancelar = new System.Windows.Forms.PictureBox();
            this.txtEditar = new System.Windows.Forms.TextBox();
            this.txtInsertar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEjecutarInsercion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEjecutarEdicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertarZona
            // 
            this.btnInsertarZona.Image = global::Mariposario.Properties.Resources.icono_agregar;
            this.btnInsertarZona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertarZona.Location = new System.Drawing.Point(147, 49);
            this.btnInsertarZona.Name = "btnInsertarZona";
            this.btnInsertarZona.Size = new System.Drawing.Size(75, 40);
            this.btnInsertarZona.TabIndex = 0;
            this.btnInsertarZona.Text = "Insertar";
            this.btnInsertarZona.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertarZona.UseVisualStyleBackColor = true;
            this.btnInsertarZona.Click += new System.EventHandler(this.btnInsertarZona_Click);
            // 
            // btnEditarZona
            // 
            this.btnEditarZona.Image = global::Mariposario.Properties.Resources.icono_actualizar;
            this.btnEditarZona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarZona.Location = new System.Drawing.Point(147, 121);
            this.btnEditarZona.Name = "btnEditarZona";
            this.btnEditarZona.Size = new System.Drawing.Size(60, 40);
            this.btnEditarZona.TabIndex = 1;
            this.btnEditarZona.Text = "Editar";
            this.btnEditarZona.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarZona.UseVisualStyleBackColor = true;
            this.btnEditarZona.Click += new System.EventHandler(this.btnEditarZona_Click);
            // 
            // btnEliminarZona
            // 
            this.btnEliminarZona.Image = global::Mariposario.Properties.Resources.icono_eliminar;
            this.btnEliminarZona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarZona.Location = new System.Drawing.Point(147, 193);
            this.btnEliminarZona.Name = "btnEliminarZona";
            this.btnEliminarZona.Size = new System.Drawing.Size(75, 40);
            this.btnEliminarZona.TabIndex = 2;
            this.btnEliminarZona.Text = "Eliminar";
            this.btnEliminarZona.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarZona.UseVisualStyleBackColor = true;
            this.btnEliminarZona.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zonas Geográficas";
            // 
            // lbxZonas
            // 
            this.lbxZonas.FormattingEnabled = true;
            this.lbxZonas.Location = new System.Drawing.Point(12, 29);
            this.lbxZonas.Name = "lbxZonas";
            this.lbxZonas.Size = new System.Drawing.Size(120, 238);
            this.lbxZonas.TabIndex = 4;
            this.lbxZonas.SelectedIndexChanged += new System.EventHandler(this.lbxZonas_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pbxEjecutarInsercion
            // 
            this.pbxEjecutarInsercion.BackColor = System.Drawing.Color.Transparent;
            this.pbxEjecutarInsercion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxEjecutarInsercion.BackgroundImage")));
            this.pbxEjecutarInsercion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxEjecutarInsercion.Enabled = false;
            this.pbxEjecutarInsercion.Location = new System.Drawing.Point(327, 85);
            this.pbxEjecutarInsercion.Name = "pbxEjecutarInsercion";
            this.pbxEjecutarInsercion.Size = new System.Drawing.Size(30, 30);
            this.pbxEjecutarInsercion.TabIndex = 7;
            this.pbxEjecutarInsercion.TabStop = false;
            this.pbxEjecutarInsercion.Click += new System.EventHandler(this.pbxEjecutarInsercion_Click);
            // 
            // pbxEjecutarEdicion
            // 
            this.pbxEjecutarEdicion.BackColor = System.Drawing.Color.Transparent;
            this.pbxEjecutarEdicion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxEjecutarEdicion.BackgroundImage")));
            this.pbxEjecutarEdicion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxEjecutarEdicion.Enabled = false;
            this.pbxEjecutarEdicion.Location = new System.Drawing.Point(327, 157);
            this.pbxEjecutarEdicion.Name = "pbxEjecutarEdicion";
            this.pbxEjecutarEdicion.Size = new System.Drawing.Size(30, 30);
            this.pbxEjecutarEdicion.TabIndex = 6;
            this.pbxEjecutarEdicion.TabStop = false;
            this.pbxEjecutarEdicion.Click += new System.EventHandler(this.pbxEjecutarEdicion_Click);
            // 
            // pbxCancelar
            // 
            this.pbxCancelar.BackColor = System.Drawing.Color.Transparent;
            this.pbxCancelar.BackgroundImage = global::Mariposario.Properties.Resources.icono_cancelar;
            this.pbxCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxCancelar.Enabled = false;
            this.pbxCancelar.Location = new System.Drawing.Point(327, 203);
            this.pbxCancelar.Name = "pbxCancelar";
            this.pbxCancelar.Size = new System.Drawing.Size(30, 30);
            this.pbxCancelar.TabIndex = 5;
            this.pbxCancelar.TabStop = false;
            this.pbxCancelar.Click += new System.EventHandler(this.pbxCancelar_Click);
            // 
            // txtEditar
            // 
            this.txtEditar.Enabled = false;
            this.txtEditar.Location = new System.Drawing.Point(147, 167);
            this.txtEditar.Name = "txtEditar";
            this.txtEditar.Size = new System.Drawing.Size(146, 20);
            this.txtEditar.TabIndex = 8;
            this.txtEditar.TextChanged += new System.EventHandler(this.pbxEjecutarEdicion_Click);
            // 
            // txtInsertar
            // 
            this.txtInsertar.Enabled = false;
            this.txtInsertar.Location = new System.Drawing.Point(147, 95);
            this.txtInsertar.Name = "txtInsertar";
            this.txtInsertar.Size = new System.Drawing.Size(146, 20);
            this.txtInsertar.TabIndex = 9;
            this.txtInsertar.TextChanged += new System.EventHandler(this.txtInsertar_TextChanged);
            // 
            // frmZonaGeografica
            // 
            this.ClientSize = new System.Drawing.Size(381, 283);
            this.Controls.Add(this.txtInsertar);
            this.Controls.Add(this.txtEditar);
            this.Controls.Add(this.pbxEjecutarInsercion);
            this.Controls.Add(this.pbxEjecutarEdicion);
            this.Controls.Add(this.pbxCancelar);
            this.Controls.Add(this.lbxZonas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarZona);
            this.Controls.Add(this.btnEditarZona);
            this.Controls.Add(this.btnInsertarZona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmZonaGeografica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mariposario - Zona Geografica";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEjecutarInsercion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEjecutarEdicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
