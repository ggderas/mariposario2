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
            this.rbBusquedaPropietario = new System.Windows.Forms.RadioButton();
            this.rbBusquedaID = new System.Windows.Forms.RadioButton();
            this.cmbPropietario = new System.Windows.Forms.ComboBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.gbColeccion = new System.Windows.Forms.GroupBox();
            this.lbColecciones = new System.Windows.Forms.ListBox();
            this.btnFichaMariposaColeccion = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificarMariposasColeccion = new System.Windows.Forms.Button();
            this.btnEliminarMariposasColeccion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxBusqueda.SuspendLayout();
            this.gbColeccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBusqueda
            // 
            this.groupBoxBusqueda.Controls.Add(this.button1);
            this.groupBoxBusqueda.Controls.Add(this.rbBusquedaPropietario);
            this.groupBoxBusqueda.Controls.Add(this.rbBusquedaID);
            this.groupBoxBusqueda.Controls.Add(this.cmbPropietario);
            this.groupBoxBusqueda.Controls.Add(this.tbID);
            this.groupBoxBusqueda.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBusqueda.Name = "groupBoxBusqueda";
            this.groupBoxBusqueda.Size = new System.Drawing.Size(409, 106);
            this.groupBoxBusqueda.TabIndex = 6;
            this.groupBoxBusqueda.TabStop = false;
            this.groupBoxBusqueda.Text = "Buscar";
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
            // 
            // cmbPropietario
            // 
            this.cmbPropietario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPropietario.FormattingEnabled = true;
            this.cmbPropietario.Location = new System.Drawing.Point(172, 61);
            this.cmbPropietario.Name = "cmbPropietario";
            this.cmbPropietario.Size = new System.Drawing.Size(231, 21);
            this.cmbPropietario.TabIndex = 3;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(172, 26);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(137, 20);
            this.tbID.TabIndex = 2;
            // 
            // gbColeccion
            // 
            this.gbColeccion.Controls.Add(this.btnFichaMariposaColeccion);
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
            // lbColecciones
            // 
            this.lbColecciones.FormattingEnabled = true;
            this.lbColecciones.Location = new System.Drawing.Point(54, 36);
            this.lbColecciones.Name = "lbColecciones";
            this.lbColecciones.Size = new System.Drawing.Size(202, 238);
            this.lbColecciones.TabIndex = 0;
            // 
            // btnFichaMariposaColeccion
            // 
            this.btnFichaMariposaColeccion.Image = ((System.Drawing.Image)(resources.GetObject("btnFichaMariposaColeccion.Image")));
            this.btnFichaMariposaColeccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFichaMariposaColeccion.Location = new System.Drawing.Point(317, 216);
            this.btnFichaMariposaColeccion.Name = "btnFichaMariposaColeccion";
            this.btnFichaMariposaColeccion.Size = new System.Drawing.Size(75, 43);
            this.btnFichaMariposaColeccion.TabIndex = 6;
            this.btnFichaMariposaColeccion.Text = "Detalles";
            this.btnFichaMariposaColeccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFichaMariposaColeccion.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Mariposario.Properties.Resources.icono_agregar;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAgregar.Location = new System.Drawing.Point(317, 36);
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
            this.btnModificarMariposasColeccion.Location = new System.Drawing.Point(317, 98);
            this.btnModificarMariposasColeccion.Name = "btnModificarMariposasColeccion";
            this.btnModificarMariposasColeccion.Size = new System.Drawing.Size(75, 43);
            this.btnModificarMariposasColeccion.TabIndex = 3;
            this.btnModificarMariposasColeccion.Text = "Modificar";
            this.btnModificarMariposasColeccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarMariposasColeccion.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMariposasColeccion
            // 
            this.btnEliminarMariposasColeccion.Image = global::Mariposario.Properties.Resources.icono_eliminar1;
            this.btnEliminarMariposasColeccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarMariposasColeccion.Location = new System.Drawing.Point(317, 156);
            this.btnEliminarMariposasColeccion.Name = "btnEliminarMariposasColeccion";
            this.btnEliminarMariposasColeccion.Size = new System.Drawing.Size(75, 43);
            this.btnEliminarMariposasColeccion.TabIndex = 2;
            this.btnEliminarMariposasColeccion.Text = "Eliminar ";
            this.btnEliminarMariposasColeccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarMariposasColeccion.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(324, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.ComboBox cmbPropietario;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.RadioButton rbBusquedaID;
        private System.Windows.Forms.RadioButton rbBusquedaPropietario;
        private System.Windows.Forms.GroupBox gbColeccion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificarMariposasColeccion;
        private System.Windows.Forms.ListBox lbColecciones;
        private System.Windows.Forms.Button btnEliminarMariposasColeccion;
        private System.Windows.Forms.Button btnFichaMariposaColeccion;
        private System.Windows.Forms.Button button1;
    }
}