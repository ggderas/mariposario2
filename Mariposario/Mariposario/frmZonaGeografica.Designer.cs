namespace Mariposario
{
    partial class frmZonaGeografica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbxZonas = new System.Windows.Forms.ListBox();
            this.txtInsertar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEditar = new System.Windows.Forms.TextBox();
            this.pbxCancelar = new System.Windows.Forms.PictureBox();
            this.pbxEjecutarEdicion = new System.Windows.Forms.PictureBox();
            this.pbxEjecutarInsercion = new System.Windows.Forms.PictureBox();
            this.btnEditarZona = new System.Windows.Forms.Button();
            this.btnEliminarZona = new System.Windows.Forms.Button();
            this.btnInsertarZona = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEjecutarEdicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEjecutarInsercion)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbxZonas
            // 
            this.lbxZonas.FormattingEnabled = true;
            this.lbxZonas.Location = new System.Drawing.Point(10, 29);
            this.lbxZonas.Name = "lbxZonas";
            this.lbxZonas.Size = new System.Drawing.Size(120, 212);
            this.lbxZonas.TabIndex = 6;
            this.lbxZonas.SelectedIndexChanged += new System.EventHandler(this.lbxZonas_SelectedIndexChanged);
            // 
            // txtInsertar
            // 
            this.txtInsertar.Enabled = false;
            this.txtInsertar.Location = new System.Drawing.Point(156, 70);
            this.txtInsertar.Name = "txtInsertar";
            this.txtInsertar.Size = new System.Drawing.Size(194, 20);
            this.txtInsertar.TabIndex = 7;
            this.txtInsertar.TextChanged += new System.EventHandler(this.txtInsertar_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Zonas Geográficas";
            // 
            // txtEditar
            // 
            this.txtEditar.Enabled = false;
            this.txtEditar.Location = new System.Drawing.Point(156, 148);
            this.txtEditar.Name = "txtEditar";
            this.txtEditar.Size = new System.Drawing.Size(194, 20);
            this.txtEditar.TabIndex = 8;
            this.txtEditar.TextChanged += new System.EventHandler(this.txtEditar_TextChanged);
            // 
            // pbxCancelar
            // 
            this.pbxCancelar.BackColor = System.Drawing.Color.Transparent;
            this.pbxCancelar.BackgroundImage = global::Mariposario.Properties.Resources.icono_cancelar;
            this.pbxCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxCancelar.Enabled = false;
            this.pbxCancelar.Location = new System.Drawing.Point(366, 190);
            this.pbxCancelar.Name = "pbxCancelar";
            this.pbxCancelar.Size = new System.Drawing.Size(30, 30);
            this.pbxCancelar.TabIndex = 12;
            this.pbxCancelar.TabStop = false;
            this.pbxCancelar.Click += new System.EventHandler(this.pbxCancelar_Click);
            // 
            // pbxEjecutarEdicion
            // 
            this.pbxEjecutarEdicion.BackColor = System.Drawing.Color.Transparent;
            this.pbxEjecutarEdicion.BackgroundImage = global::Mariposario.Properties.Resources.icono_ejecutar;
            this.pbxEjecutarEdicion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxEjecutarEdicion.Enabled = false;
            this.pbxEjecutarEdicion.Location = new System.Drawing.Point(366, 138);
            this.pbxEjecutarEdicion.Name = "pbxEjecutarEdicion";
            this.pbxEjecutarEdicion.Size = new System.Drawing.Size(30, 30);
            this.pbxEjecutarEdicion.TabIndex = 11;
            this.pbxEjecutarEdicion.TabStop = false;
            this.pbxEjecutarEdicion.Click += new System.EventHandler(this.pbxEjecutarEdicion_Click);
            // 
            // pbxEjecutarInsercion
            // 
            this.pbxEjecutarInsercion.BackColor = System.Drawing.SystemColors.Control;
            this.pbxEjecutarInsercion.BackgroundImage = global::Mariposario.Properties.Resources.icono_ejecutar;
            this.pbxEjecutarInsercion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxEjecutarInsercion.Enabled = false;
            this.pbxEjecutarInsercion.Location = new System.Drawing.Point(366, 60);
            this.pbxEjecutarInsercion.Name = "pbxEjecutarInsercion";
            this.pbxEjecutarInsercion.Size = new System.Drawing.Size(30, 30);
            this.pbxEjecutarInsercion.TabIndex = 10;
            this.pbxEjecutarInsercion.TabStop = false;
            this.pbxEjecutarInsercion.Click += new System.EventHandler(this.pbxEjecutarInsercion_Click);
            // 
            // btnEditarZona
            // 
            this.btnEditarZona.Enabled = false;
            this.btnEditarZona.Image = global::Mariposario.Properties.Resources.icono_actualizar;
            this.btnEditarZona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarZona.Location = new System.Drawing.Point(156, 107);
            this.btnEditarZona.Name = "btnEditarZona";
            this.btnEditarZona.Size = new System.Drawing.Size(61, 35);
            this.btnEditarZona.TabIndex = 2;
            this.btnEditarZona.Text = "Editar";
            this.btnEditarZona.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarZona.UseVisualStyleBackColor = true;
            this.btnEditarZona.Click += new System.EventHandler(this.btnEditarZona_Click);
            // 
            // btnEliminarZona
            // 
            this.btnEliminarZona.Enabled = false;
            this.btnEliminarZona.Image = global::Mariposario.Properties.Resources.icono_eliminar;
            this.btnEliminarZona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarZona.Location = new System.Drawing.Point(156, 185);
            this.btnEliminarZona.Name = "btnEliminarZona";
            this.btnEliminarZona.Size = new System.Drawing.Size(75, 35);
            this.btnEliminarZona.TabIndex = 1;
            this.btnEliminarZona.Text = "Eliminar";
            this.btnEliminarZona.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarZona.UseVisualStyleBackColor = true;
            this.btnEliminarZona.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnInsertarZona
            // 
            this.btnInsertarZona.Image = global::Mariposario.Properties.Resources.icono_agregar;
            this.btnInsertarZona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertarZona.Location = new System.Drawing.Point(156, 29);
            this.btnInsertarZona.Name = "btnInsertarZona";
            this.btnInsertarZona.Size = new System.Drawing.Size(61, 35);
            this.btnInsertarZona.TabIndex = 0;
            this.btnInsertarZona.Text = "Añadir";
            this.btnInsertarZona.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertarZona.UseVisualStyleBackColor = true;
            this.btnInsertarZona.Click += new System.EventHandler(this.btnInsertarZona_Click);
            // 
            // frmZonaGeografica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 260);
            this.Controls.Add(this.pbxCancelar);
            this.Controls.Add(this.pbxEjecutarEdicion);
            this.Controls.Add(this.pbxEjecutarInsercion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEditar);
            this.Controls.Add(this.txtInsertar);
            this.Controls.Add(this.lbxZonas);
            this.Controls.Add(this.btnEditarZona);
            this.Controls.Add(this.btnEliminarZona);
            this.Controls.Add(this.btnInsertarZona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmZonaGeografica";
            this.Text = "Mariposario Zona Geografica";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmZonaGeografica_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEjecutarEdicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEjecutarInsercion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInsertar;
        private System.Windows.Forms.ListBox lbxZonas;
        private System.Windows.Forms.Button btnEditarZona;
        private System.Windows.Forms.Button btnEliminarZona;
        private System.Windows.Forms.Button btnInsertarZona;
        private System.Windows.Forms.PictureBox pbxEjecutarInsercion;
        private System.Windows.Forms.TextBox txtEditar;
        private System.Windows.Forms.PictureBox pbxEjecutarEdicion;
        private System.Windows.Forms.PictureBox pbxCancelar;
    }
}