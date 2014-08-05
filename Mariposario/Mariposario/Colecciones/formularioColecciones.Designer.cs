namespace Mariposario {
    partial class formularioColecciones {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formularioColecciones));
            this.groupBoxBusqueda = new System.Windows.Forms.GroupBox();
            this.cmbPropietario = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rbBusquedaPropietario = new System.Windows.Forms.RadioButton();
            this.rbBusquedaID = new System.Windows.Forms.RadioButton();
            this.tbID = new System.Windows.Forms.TextBox();
            this.gbColeccion = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificarMariposasColeccion = new System.Windows.Forms.Button();
            this.lbColecciones = new System.Windows.Forms.ListBox();
            this.btnEliminarMariposasColeccion = new System.Windows.Forms.Button();
            this.groupBoxBusqueda.SuspendLayout();
            this.gbColeccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBusqueda
            // 
            this.groupBoxBusqueda.Controls.Add(this.cmbPropietario);
            this.groupBoxBusqueda.Controls.Add(this.btnBuscar);
            this.groupBoxBusqueda.Controls.Add(this.rbBusquedaPropietario);
            this.groupBoxBusqueda.Controls.Add(this.rbBusquedaID);
            this.groupBoxBusqueda.Controls.Add(this.tbID);
            this.groupBoxBusqueda.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBusqueda.Name = "groupBoxBusqueda";
            this.groupBoxBusqueda.Size = new System.Drawing.Size(409, 106);
            this.groupBoxBusqueda.TabIndex = 6;
            this.groupBoxBusqueda.TabStop = false;
            this.groupBoxBusqueda.Text = "Buscar";
            // 
            // cmbPropietario
            // 
            this.cmbPropietario.Enabled = false;
            this.cmbPropietario.FormattingEnabled = true;
            this.cmbPropietario.Location = new System.Drawing.Point(172, 61);
            this.cmbPropietario.Name = "cmbPropietario";
            this.cmbPropietario.Size = new System.Drawing.Size(220, 21);
            this.cmbPropietario.TabIndex = 8;
            this.cmbPropietario.Text = "Elija una persona...";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(324, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 36);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rbBusquedaPropietario
            // 
            this.rbBusquedaPropietario.AutoSize = true;
            this.rbBusquedaPropietario.Location = new System.Drawing.Point(33, 61);
            this.rbBusquedaPropietario.Name = "rbBusquedaPropietario";
            this.rbBusquedaPropietario.Size = new System.Drawing.Size(128, 17);
            this.rbBusquedaPropietario.TabIndex = 4;
            this.rbBusquedaPropietario.TabStop = true;
            this.rbBusquedaPropietario.Text = "Buscar por propietario";
            this.rbBusquedaPropietario.UseVisualStyleBackColor = true;
            this.rbBusquedaPropietario.CheckedChanged += new System.EventHandler(this.rbBusquedaPropietario_CheckedChanged);
            // 
            // rbBusquedaID
            // 
            this.rbBusquedaID.AutoSize = true;
            this.rbBusquedaID.Location = new System.Drawing.Point(33, 26);
            this.rbBusquedaID.Name = "rbBusquedaID";
            this.rbBusquedaID.Size = new System.Drawing.Size(90, 17);
            this.rbBusquedaID.TabIndex = 4;
            this.rbBusquedaID.TabStop = true;
            this.rbBusquedaID.Text = "Buscar por ID";
            this.rbBusquedaID.UseVisualStyleBackColor = true;
            this.rbBusquedaID.CheckedChanged += new System.EventHandler(this.rbBusquedaID_CheckedChanged);
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(172, 26);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(137, 20);
            this.tbID.TabIndex = 2;
            // 
            // gbColeccion
            // 
            this.gbColeccion.Controls.Add(this.btnAgregar);
            this.gbColeccion.Controls.Add(this.btnModificarMariposasColeccion);
            this.gbColeccion.Controls.Add(this.lbColecciones);
            this.gbColeccion.Controls.Add(this.btnEliminarMariposasColeccion);
            this.gbColeccion.Location = new System.Drawing.Point(12, 124);
            this.gbColeccion.Name = "gbColeccion";
            this.gbColeccion.Size = new System.Drawing.Size(409, 290);
            this.gbColeccion.TabIndex = 7;
            this.gbColeccion.TabStop = false;
            this.gbColeccion.Text = "Colecciones";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Mariposario.Properties.Resources.icono_agregar;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAgregar.Location = new System.Drawing.Point(317, 70);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 43);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar Colección";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificarMariposasColeccion
            // 
            this.btnModificarMariposasColeccion.Image = global::Mariposario.Properties.Resources.icono_actualizar;
            this.btnModificarMariposasColeccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarMariposasColeccion.Location = new System.Drawing.Point(298, 199);
            this.btnModificarMariposasColeccion.Name = "btnModificarMariposasColeccion";
            this.btnModificarMariposasColeccion.Size = new System.Drawing.Size(94, 43);
            this.btnModificarMariposasColeccion.TabIndex = 3;
            this.btnModificarMariposasColeccion.Text = "Ver/Modificar";
            this.btnModificarMariposasColeccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarMariposasColeccion.UseVisualStyleBackColor = true;
            this.btnModificarMariposasColeccion.Click += new System.EventHandler(this.btnModificarMariposasColeccion_Click);
            // 
            // lbColecciones
            // 
            this.lbColecciones.FormattingEnabled = true;
            this.lbColecciones.Location = new System.Drawing.Point(54, 36);
            this.lbColecciones.Name = "lbColecciones";
            this.lbColecciones.Size = new System.Drawing.Size(202, 238);
            this.lbColecciones.TabIndex = 0;
            // 
            // btnEliminarMariposasColeccion
            // 
            this.btnEliminarMariposasColeccion.Image = global::Mariposario.Properties.Resources.icono_eliminar1;
            this.btnEliminarMariposasColeccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarMariposasColeccion.Location = new System.Drawing.Point(317, 139);
            this.btnEliminarMariposasColeccion.Name = "btnEliminarMariposasColeccion";
            this.btnEliminarMariposasColeccion.Size = new System.Drawing.Size(75, 43);
            this.btnEliminarMariposasColeccion.TabIndex = 2;
            this.btnEliminarMariposasColeccion.Text = "Eliminar ";
            this.btnEliminarMariposasColeccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarMariposasColeccion.UseVisualStyleBackColor = true;
            this.btnEliminarMariposasColeccion.Click += new System.EventHandler(this.btnEliminarMariposasColeccion_Click);
            // 
            // formularioColecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 421);
            this.Controls.Add(this.gbColeccion);
            this.Controls.Add(this.groupBoxBusqueda);
            this.Name = "formularioColecciones";
            this.Text = "Mariposario - Colecciones";
            this.groupBoxBusqueda.ResumeLayout(false);
            this.groupBoxBusqueda.PerformLayout();
            this.gbColeccion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBusqueda;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.RadioButton rbBusquedaID;
        private System.Windows.Forms.RadioButton rbBusquedaPropietario;
        private System.Windows.Forms.GroupBox gbColeccion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificarMariposasColeccion;
        private System.Windows.Forms.ListBox lbColecciones;
        private System.Windows.Forms.Button btnEliminarMariposasColeccion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbPropietario;
    }
}