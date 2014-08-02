namespace Mariposario
{
    partial class formularioActualizarMariposa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbEspecies = new System.Windows.Forms.ComboBox();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.groupBoxImagen = new System.Windows.Forms.GroupBox();
            this.picBoxImagen = new System.Windows.Forms.PictureBox();
            this.groupBoxDatosCaptura = new System.Windows.Forms.GroupBox();
            this.cmbBiologos = new System.Windows.Forms.ComboBox();
            this.lblBiologo = new System.Windows.Forms.Label();
            this.cmbZonas = new System.Windows.Forms.ComboBox();
            this.lblZona = new System.Windows.Forms.Label();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.rbtnColeccion = new System.Windows.Forms.RadioButton();
            this.rbtnObservacion = new System.Windows.Forms.RadioButton();
            this.numericTiempoObservacion = new System.Windows.Forms.NumericUpDown();
            this.cmbColecciones = new System.Windows.Forms.ComboBox();
            this.lblColeccion = new System.Windows.Forms.Label();
            this.numericPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblTiempoObservacion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.dateTimeFechaCaptura = new System.Windows.Forms.DateTimePicker();
            this.lblFechaCaptura = new System.Windows.Forms.Label();
            this.txtIDMariposa = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImagen)).BeginInit();
            this.groupBoxDatosCaptura.SuspendLayout();
            this.groupBoxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTiempoObservacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbEspecies);
            this.groupBox1.Controls.Add(this.lblEspecie);
            this.groupBox1.Controls.Add(this.groupBoxImagen);
            this.groupBox1.Controls.Add(this.groupBoxDatosCaptura);
            this.groupBox1.Controls.Add(this.groupBoxTipo);
            this.groupBox1.Controls.Add(this.dateTimeFechaCaptura);
            this.groupBox1.Controls.Add(this.lblFechaCaptura);
            this.groupBox1.Controls.Add(this.txtIDMariposa);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 447);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actualizar información de mariposa...";
            // 
            // cmbEspecies
            // 
            this.cmbEspecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecies.FormattingEnabled = true;
            this.cmbEspecies.Location = new System.Drawing.Point(134, 124);
            this.cmbEspecies.Name = "cmbEspecies";
            this.cmbEspecies.Size = new System.Drawing.Size(200, 21);
            this.cmbEspecies.TabIndex = 16;
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(23, 127);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(48, 13);
            this.lblEspecie.TabIndex = 15;
            this.lblEspecie.Text = "Especie:";
            // 
            // groupBoxImagen
            // 
            this.groupBoxImagen.Controls.Add(this.picBoxImagen);
            this.groupBoxImagen.Location = new System.Drawing.Point(26, 206);
            this.groupBoxImagen.Name = "groupBoxImagen";
            this.groupBoxImagen.Size = new System.Drawing.Size(308, 222);
            this.groupBoxImagen.TabIndex = 6;
            this.groupBoxImagen.TabStop = false;
            this.groupBoxImagen.Text = "Imagen";
            // 
            // picBoxImagen
            // 
            this.picBoxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxImagen.Image = global::Mariposario.Properties.Resources.mariposa_imagenPorDefecto;
            this.picBoxImagen.InitialImage = null;
            this.picBoxImagen.Location = new System.Drawing.Point(20, 20);
            this.picBoxImagen.Name = "picBoxImagen";
            this.picBoxImagen.Size = new System.Drawing.Size(269, 197);
            this.picBoxImagen.TabIndex = 0;
            this.picBoxImagen.TabStop = false;
            // 
            // groupBoxDatosCaptura
            // 
            this.groupBoxDatosCaptura.Controls.Add(this.cmbBiologos);
            this.groupBoxDatosCaptura.Controls.Add(this.lblBiologo);
            this.groupBoxDatosCaptura.Controls.Add(this.cmbZonas);
            this.groupBoxDatosCaptura.Controls.Add(this.lblZona);
            this.groupBoxDatosCaptura.Location = new System.Drawing.Point(368, 266);
            this.groupBoxDatosCaptura.Name = "groupBoxDatosCaptura";
            this.groupBoxDatosCaptura.Size = new System.Drawing.Size(293, 144);
            this.groupBoxDatosCaptura.TabIndex = 5;
            this.groupBoxDatosCaptura.TabStop = false;
            this.groupBoxDatosCaptura.Text = "Datos de Captura";
            // 
            // cmbBiologos
            // 
            this.cmbBiologos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBiologos.FormattingEnabled = true;
            this.cmbBiologos.Location = new System.Drawing.Point(156, 91);
            this.cmbBiologos.Name = "cmbBiologos";
            this.cmbBiologos.Size = new System.Drawing.Size(123, 21);
            this.cmbBiologos.TabIndex = 14;
            // 
            // lblBiologo
            // 
            this.lblBiologo.AutoSize = true;
            this.lblBiologo.Location = new System.Drawing.Point(26, 94);
            this.lblBiologo.Name = "lblBiologo";
            this.lblBiologo.Size = new System.Drawing.Size(77, 13);
            this.lblBiologo.TabIndex = 13;
            this.lblBiologo.Text = "Capturado por:";
            // 
            // cmbZonas
            // 
            this.cmbZonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZonas.FormattingEnabled = true;
            this.cmbZonas.Location = new System.Drawing.Point(156, 43);
            this.cmbZonas.Name = "cmbZonas";
            this.cmbZonas.Size = new System.Drawing.Size(121, 21);
            this.cmbZonas.TabIndex = 12;
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.Location = new System.Drawing.Point(26, 51);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(88, 13);
            this.lblZona.TabIndex = 11;
            this.lblZona.Text = "Zona geográfica:";
            // 
            // groupBoxTipo
            // 
            this.groupBoxTipo.Controls.Add(this.rbtnColeccion);
            this.groupBoxTipo.Controls.Add(this.rbtnObservacion);
            this.groupBoxTipo.Controls.Add(this.numericTiempoObservacion);
            this.groupBoxTipo.Controls.Add(this.cmbColecciones);
            this.groupBoxTipo.Controls.Add(this.lblColeccion);
            this.groupBoxTipo.Controls.Add(this.numericPrecio);
            this.groupBoxTipo.Controls.Add(this.lblTiempoObservacion);
            this.groupBoxTipo.Controls.Add(this.lblPrecio);
            this.groupBoxTipo.Location = new System.Drawing.Point(368, 19);
            this.groupBoxTipo.Name = "groupBoxTipo";
            this.groupBoxTipo.Size = new System.Drawing.Size(293, 220);
            this.groupBoxTipo.TabIndex = 4;
            this.groupBoxTipo.TabStop = false;
            this.groupBoxTipo.Text = "Tipo de Mariposa";
            // 
            // rbtnColeccion
            // 
            this.rbtnColeccion.AutoSize = true;
            this.rbtnColeccion.Location = new System.Drawing.Point(159, 36);
            this.rbtnColeccion.Name = "rbtnColeccion";
            this.rbtnColeccion.Size = new System.Drawing.Size(89, 17);
            this.rbtnColeccion.TabIndex = 20;
            this.rbtnColeccion.TabStop = true;
            this.rbtnColeccion.Text = "De Colección";
            this.rbtnColeccion.UseVisualStyleBackColor = true;
            // 
            // rbtnObservacion
            // 
            this.rbtnObservacion.AutoSize = true;
            this.rbtnObservacion.Location = new System.Drawing.Point(29, 36);
            this.rbtnObservacion.Name = "rbtnObservacion";
            this.rbtnObservacion.Size = new System.Drawing.Size(102, 17);
            this.rbtnObservacion.TabIndex = 19;
            this.rbtnObservacion.TabStop = true;
            this.rbtnObservacion.Text = "De Observación";
            this.rbtnObservacion.UseVisualStyleBackColor = true;
            // 
            // numericTiempoObservacion
            // 
            this.numericTiempoObservacion.Location = new System.Drawing.Point(157, 84);
            this.numericTiempoObservacion.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericTiempoObservacion.Name = "numericTiempoObservacion";
            this.numericTiempoObservacion.Size = new System.Drawing.Size(120, 20);
            this.numericTiempoObservacion.TabIndex = 16;
            // 
            // cmbColecciones
            // 
            this.cmbColecciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColecciones.FormattingEnabled = true;
            this.cmbColecciones.Location = new System.Drawing.Point(156, 166);
            this.cmbColecciones.Name = "cmbColecciones";
            this.cmbColecciones.Size = new System.Drawing.Size(121, 21);
            this.cmbColecciones.TabIndex = 15;
            // 
            // lblColeccion
            // 
            this.lblColeccion.AutoSize = true;
            this.lblColeccion.Location = new System.Drawing.Point(26, 169);
            this.lblColeccion.Name = "lblColeccion";
            this.lblColeccion.Size = new System.Drawing.Size(57, 13);
            this.lblColeccion.TabIndex = 11;
            this.lblColeccion.Text = "Colección:";
            // 
            // numericPrecio
            // 
            this.numericPrecio.Location = new System.Drawing.Point(158, 126);
            this.numericPrecio.Name = "numericPrecio";
            this.numericPrecio.Size = new System.Drawing.Size(120, 20);
            this.numericPrecio.TabIndex = 10;
            // 
            // lblTiempoObservacion
            // 
            this.lblTiempoObservacion.AutoSize = true;
            this.lblTiempoObservacion.Location = new System.Drawing.Point(26, 91);
            this.lblTiempoObservacion.Name = "lblTiempoObservacion";
            this.lblTiempoObservacion.Size = new System.Drawing.Size(123, 13);
            this.lblTiempoObservacion.TabIndex = 8;
            this.lblTiempoObservacion.Text = "Tiempo de Observación:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(26, 133);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio:";
            // 
            // dateTimeFechaCaptura
            // 
            this.dateTimeFechaCaptura.Location = new System.Drawing.Point(134, 82);
            this.dateTimeFechaCaptura.Name = "dateTimeFechaCaptura";
            this.dateTimeFechaCaptura.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFechaCaptura.TabIndex = 3;
            // 
            // lblFechaCaptura
            // 
            this.lblFechaCaptura.AutoSize = true;
            this.lblFechaCaptura.Location = new System.Drawing.Point(23, 82);
            this.lblFechaCaptura.Name = "lblFechaCaptura";
            this.lblFechaCaptura.Size = new System.Drawing.Size(94, 13);
            this.lblFechaCaptura.TabIndex = 2;
            this.lblFechaCaptura.Text = "Fecha de captura:";
            // 
            // txtIDMariposa
            // 
            this.txtIDMariposa.Location = new System.Drawing.Point(134, 29);
            this.txtIDMariposa.Name = "txtIDMariposa";
            this.txtIDMariposa.ReadOnly = true;
            this.txtIDMariposa.Size = new System.Drawing.Size(200, 20);
            this.txtIDMariposa.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(23, 32);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(70, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID Mariposa: ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Mariposario.Properties.Resources.icono_eliminar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(125, 483);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::Mariposario.Properties.Resources.icono_actualizar;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(30, 483);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // formularioActualizarMariposa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 528);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.groupBox1);
            this.Name = "formularioActualizarMariposa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mariposario - Actualizar mariposa...";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImagen)).EndInit();
            this.groupBoxDatosCaptura.ResumeLayout(false);
            this.groupBoxDatosCaptura.PerformLayout();
            this.groupBoxTipo.ResumeLayout(false);
            this.groupBoxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTiempoObservacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbEspecies;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.GroupBox groupBoxImagen;
        private System.Windows.Forms.PictureBox picBoxImagen;
        private System.Windows.Forms.GroupBox groupBoxDatosCaptura;
        private System.Windows.Forms.ComboBox cmbBiologos;
        private System.Windows.Forms.Label lblBiologo;
        private System.Windows.Forms.ComboBox cmbZonas;
        private System.Windows.Forms.Label lblZona;
        private System.Windows.Forms.GroupBox groupBoxTipo;
        private System.Windows.Forms.ComboBox cmbColecciones;
        private System.Windows.Forms.Label lblColeccion;
        private System.Windows.Forms.NumericUpDown numericPrecio;
        private System.Windows.Forms.Label lblTiempoObservacion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.DateTimePicker dateTimeFechaCaptura;
        private System.Windows.Forms.Label lblFechaCaptura;
        private System.Windows.Forms.TextBox txtIDMariposa;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.NumericUpDown numericTiempoObservacion;
        private System.Windows.Forms.RadioButton rbtnColeccion;
        private System.Windows.Forms.RadioButton rbtnObservacion;
    }
}