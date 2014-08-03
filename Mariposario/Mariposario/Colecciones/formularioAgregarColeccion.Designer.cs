namespace Mariposario {
    partial class formularioAgregarColeccion {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.lblEliminarMariposa = new System.Windows.Forms.Label();
            this.lblAgregarMariposa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMariposasEnColeccion = new System.Windows.Forms.ListBox();
            this.lbMariposas = new System.Windows.Forms.ListBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericPrecio = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cmbPropietario = new System.Windows.Forms.ComboBox();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.tbIDColeccion = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBoxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaInicio);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.groupBoxTipo);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericPrecio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.cmbPropietario);
            this.groupBox1.Controls.Add(this.lblEspecie);
            this.groupBox1.Controls.Add(this.tbIDColeccion);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 523);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(134, 129);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Mariposario.Properties.Resources.icono_agregar;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(374, 29);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 43);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Aceptar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::Mariposario.Properties.Resources.icono_eliminar1;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(477, 29);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 43);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBoxTipo
            // 
            this.groupBoxTipo.Controls.Add(this.lblEliminarMariposa);
            this.groupBoxTipo.Controls.Add(this.lblAgregarMariposa);
            this.groupBoxTipo.Controls.Add(this.label3);
            this.groupBoxTipo.Controls.Add(this.label2);
            this.groupBoxTipo.Controls.Add(this.lbMariposasEnColeccion);
            this.groupBoxTipo.Controls.Add(this.lbMariposas);
            this.groupBoxTipo.Location = new System.Drawing.Point(26, 211);
            this.groupBoxTipo.Name = "groupBoxTipo";
            this.groupBoxTipo.Size = new System.Drawing.Size(526, 303);
            this.groupBoxTipo.TabIndex = 21;
            this.groupBoxTipo.TabStop = false;
            this.groupBoxTipo.Text = "Mariposas";
            // 
            // lblEliminarMariposa
            // 
            this.lblEliminarMariposa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEliminarMariposa.Image = global::Mariposario.Properties.Resources.flecha_izquierda;
            this.lblEliminarMariposa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEliminarMariposa.Location = new System.Drawing.Point(246, 159);
            this.lblEliminarMariposa.Name = "lblEliminarMariposa";
            this.lblEliminarMariposa.Size = new System.Drawing.Size(40, 29);
            this.lblEliminarMariposa.TabIndex = 9;
            this.lblEliminarMariposa.Click += new System.EventHandler(this.lblEliminarMariposa_Click);
            // 
            // lblAgregarMariposa
            // 
            this.lblAgregarMariposa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAgregarMariposa.Image = global::Mariposario.Properties.Resources.flecha_derecha1;
            this.lblAgregarMariposa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAgregarMariposa.Location = new System.Drawing.Point(246, 96);
            this.lblAgregarMariposa.Name = "lblAgregarMariposa";
            this.lblAgregarMariposa.Size = new System.Drawing.Size(40, 29);
            this.lblAgregarMariposa.TabIndex = 7;
            this.lblAgregarMariposa.Click += new System.EventHandler(this.lblAgregarMariposa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mariposas de la Colección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mariposas Disponibles:";
            // 
            // lbMariposasEnColeccion
            // 
            this.lbMariposasEnColeccion.FormattingEnabled = true;
            this.lbMariposasEnColeccion.Location = new System.Drawing.Point(292, 51);
            this.lbMariposasEnColeccion.Name = "lbMariposasEnColeccion";
            this.lbMariposasEnColeccion.Size = new System.Drawing.Size(202, 238);
            this.lbMariposasEnColeccion.TabIndex = 8;
            // 
            // lbMariposas
            // 
            this.lbMariposas.FormattingEnabled = true;
            this.lbMariposas.Location = new System.Drawing.Point(38, 51);
            this.lbMariposas.Name = "lbMariposas";
            this.lbMariposas.Size = new System.Drawing.Size(202, 238);
            this.lbMariposas.TabIndex = 6;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(134, 62);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(200, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre: ";
            // 
            // numericPrecio
            // 
            this.numericPrecio.Location = new System.Drawing.Point(134, 93);
            this.numericPrecio.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericPrecio.Name = "numericPrecio";
            this.numericPrecio.Size = new System.Drawing.Size(120, 20);
            this.numericPrecio.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fecha de Inicio:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(23, 95);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 17;
            this.lblPrecio.Text = "Precio:";
            // 
            // cmbPropietario
            // 
            this.cmbPropietario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPropietario.FormattingEnabled = true;
            this.cmbPropietario.Location = new System.Drawing.Point(134, 164);
            this.cmbPropietario.Name = "cmbPropietario";
            this.cmbPropietario.Size = new System.Drawing.Size(200, 21);
            this.cmbPropietario.TabIndex = 5;
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(23, 167);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(60, 13);
            this.lblEspecie.TabIndex = 15;
            this.lblEspecie.Text = "Propietario:";
            // 
            // tbIDColeccion
            // 
            this.tbIDColeccion.Location = new System.Drawing.Point(134, 29);
            this.tbIDColeccion.Name = "tbIDColeccion";
            this.tbIDColeccion.Size = new System.Drawing.Size(200, 20);
            this.tbIDColeccion.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(23, 32);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(74, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID Colección: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // formularioAgregarColeccion
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(587, 547);
            this.Controls.Add(this.groupBox1);
            this.Name = "formularioAgregarColeccion";
            this.Text = "Mariposario - Agregar Colección";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxTipo.ResumeLayout(false);
            this.groupBoxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cmbPropietario;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.TextBox tbIDColeccion;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox groupBoxTipo;
        private System.Windows.Forms.ListBox lbMariposas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbMariposasEnColeccion;
        private System.Windows.Forms.Label lblAgregarMariposa;
        private System.Windows.Forms.Label lblEliminarMariposa;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label4;
    }
}