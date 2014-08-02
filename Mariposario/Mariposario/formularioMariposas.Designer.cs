namespace Mariposario
{
    partial class formularioMariposas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formularioMariposas));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mariposasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoCapturaDeMariposaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.familiasNaturalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.génerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.espciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrosDeBúsquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxColeccion = new System.Windows.Forms.GroupBox();
            this.btnFichaMariposaColeccion = new System.Windows.Forms.Button();
            this.btnModificarMariposasColeccion = new System.Windows.Forms.Button();
            this.listBoxMariposasColeccion = new System.Windows.Forms.ListBox();
            this.btnEliminarMariposasColeccion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFichaMariposaObservacion = new System.Windows.Forms.Button();
            this.btnModificarMariposasObservacion = new System.Windows.Forms.Button();
            this.listBoxMariposasObservacion = new System.Windows.Forms.ListBox();
            this.btnEliminarMariposasObservacion = new System.Windows.Forms.Button();
            this.groupBoxBusqueda = new System.Windows.Forms.GroupBox();
            this.lblMariposa = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBoxColeccion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mariposasToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(703, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mariposasToolStripMenuItem
            // 
            this.mariposasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoCapturaDeMariposaToolStripMenuItem,
            this.toolStripSeparator1,
            this.familiasNaturalesToolStripMenuItem,
            this.génerosToolStripMenuItem,
            this.espciesToolStripMenuItem});
            this.mariposasToolStripMenuItem.Name = "mariposasToolStripMenuItem";
            this.mariposasToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.mariposasToolStripMenuItem.Text = "Mariposas";
            // 
            // nuevoCapturaDeMariposaToolStripMenuItem
            // 
            this.nuevoCapturaDeMariposaToolStripMenuItem.Image = global::Mariposario.Properties.Resources.icono_agregar;
            this.nuevoCapturaDeMariposaToolStripMenuItem.Name = "nuevoCapturaDeMariposaToolStripMenuItem";
            this.nuevoCapturaDeMariposaToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.nuevoCapturaDeMariposaToolStripMenuItem.Text = "Agregar nueva captura de mariposa...";
            this.nuevoCapturaDeMariposaToolStripMenuItem.Click += new System.EventHandler(this.nuevoCapturaDeMariposaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(268, 6);
            // 
            // familiasNaturalesToolStripMenuItem
            // 
            this.familiasNaturalesToolStripMenuItem.CheckOnClick = true;
            this.familiasNaturalesToolStripMenuItem.Name = "familiasNaturalesToolStripMenuItem";
            this.familiasNaturalesToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.familiasNaturalesToolStripMenuItem.Text = "Familias Naturales";
            this.familiasNaturalesToolStripMenuItem.Click += new System.EventHandler(this.familiasNaturalesToolStripMenuItem_Click);
            // 
            // génerosToolStripMenuItem
            // 
            this.génerosToolStripMenuItem.Name = "génerosToolStripMenuItem";
            this.génerosToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.génerosToolStripMenuItem.Text = "Géneros";
            this.génerosToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.génerosToolStripMenuItem_DropDownItemClicked);
            this.génerosToolStripMenuItem.Click += new System.EventHandler(this.génerosToolStripMenuItem_Click);
            // 
            // espciesToolStripMenuItem
            // 
            this.espciesToolStripMenuItem.Name = "espciesToolStripMenuItem";
            this.espciesToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.espciesToolStripMenuItem.Text = "Especies";
            this.espciesToolStripMenuItem.Click += new System.EventHandler(this.espciesToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtrosDeBúsquedaToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // filtrosDeBúsquedaToolStripMenuItem
            // 
            this.filtrosDeBúsquedaToolStripMenuItem.Name = "filtrosDeBúsquedaToolStripMenuItem";
            this.filtrosDeBúsquedaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.filtrosDeBúsquedaToolStripMenuItem.Text = "Filtros de búsqueda";
            // 
            // groupBoxColeccion
            // 
            this.groupBoxColeccion.Controls.Add(this.btnFichaMariposaColeccion);
            this.groupBoxColeccion.Controls.Add(this.btnModificarMariposasColeccion);
            this.groupBoxColeccion.Controls.Add(this.listBoxMariposasColeccion);
            this.groupBoxColeccion.Controls.Add(this.btnEliminarMariposasColeccion);
            this.groupBoxColeccion.Location = new System.Drawing.Point(12, 165);
            this.groupBoxColeccion.Name = "groupBoxColeccion";
            this.groupBoxColeccion.Size = new System.Drawing.Size(287, 309);
            this.groupBoxColeccion.TabIndex = 3;
            this.groupBoxColeccion.TabStop = false;
            this.groupBoxColeccion.Text = "Mariposas de Colección";
            // 
            // btnFichaMariposaColeccion
            // 
            this.btnFichaMariposaColeccion.Image = ((System.Drawing.Image)(resources.GetObject("btnFichaMariposaColeccion.Image")));
            this.btnFichaMariposaColeccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFichaMariposaColeccion.Location = new System.Drawing.Point(197, 79);
            this.btnFichaMariposaColeccion.Name = "btnFichaMariposaColeccion";
            this.btnFichaMariposaColeccion.Size = new System.Drawing.Size(75, 43);
            this.btnFichaMariposaColeccion.TabIndex = 5;
            this.btnFichaMariposaColeccion.Text = "Ver ficha técnica";
            this.btnFichaMariposaColeccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFichaMariposaColeccion.UseVisualStyleBackColor = true;
            this.btnFichaMariposaColeccion.Click += new System.EventHandler(this.btnFichaMariposaColeccion_Click);
            // 
            // btnModificarMariposasColeccion
            // 
            this.btnModificarMariposasColeccion.Image = global::Mariposario.Properties.Resources.icono_actualizar;
            this.btnModificarMariposasColeccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarMariposasColeccion.Location = new System.Drawing.Point(197, 138);
            this.btnModificarMariposasColeccion.Name = "btnModificarMariposasColeccion";
            this.btnModificarMariposasColeccion.Size = new System.Drawing.Size(75, 43);
            this.btnModificarMariposasColeccion.TabIndex = 3;
            this.btnModificarMariposasColeccion.Text = "Modificar";
            this.btnModificarMariposasColeccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarMariposasColeccion.UseVisualStyleBackColor = true;
            this.btnModificarMariposasColeccion.Click += new System.EventHandler(this.btnModificarMariposasColeccion_Click);
            // 
            // listBoxMariposasColeccion
            // 
            this.listBoxMariposasColeccion.FormattingEnabled = true;
            this.listBoxMariposasColeccion.Location = new System.Drawing.Point(18, 36);
            this.listBoxMariposasColeccion.Name = "listBoxMariposasColeccion";
            this.listBoxMariposasColeccion.Size = new System.Drawing.Size(162, 238);
            this.listBoxMariposasColeccion.TabIndex = 0;
            // 
            // btnEliminarMariposasColeccion
            // 
            this.btnEliminarMariposasColeccion.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarMariposasColeccion.Image")));
            this.btnEliminarMariposasColeccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarMariposasColeccion.Location = new System.Drawing.Point(197, 196);
            this.btnEliminarMariposasColeccion.Name = "btnEliminarMariposasColeccion";
            this.btnEliminarMariposasColeccion.Size = new System.Drawing.Size(75, 43);
            this.btnEliminarMariposasColeccion.TabIndex = 2;
            this.btnEliminarMariposasColeccion.Text = "Liberar";
            this.btnEliminarMariposasColeccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarMariposasColeccion.UseVisualStyleBackColor = true;
            this.btnEliminarMariposasColeccion.Click += new System.EventHandler(this.btnEliminarMariposasColeccion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFichaMariposaObservacion);
            this.groupBox1.Controls.Add(this.btnModificarMariposasObservacion);
            this.groupBox1.Controls.Add(this.listBoxMariposasObservacion);
            this.groupBox1.Controls.Add(this.btnEliminarMariposasObservacion);
            this.groupBox1.Location = new System.Drawing.Point(391, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 309);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mariposas en Observación";
            // 
            // btnFichaMariposaObservacion
            // 
            this.btnFichaMariposaObservacion.Image = ((System.Drawing.Image)(resources.GetObject("btnFichaMariposaObservacion.Image")));
            this.btnFichaMariposaObservacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFichaMariposaObservacion.Location = new System.Drawing.Point(197, 79);
            this.btnFichaMariposaObservacion.Name = "btnFichaMariposaObservacion";
            this.btnFichaMariposaObservacion.Size = new System.Drawing.Size(75, 43);
            this.btnFichaMariposaObservacion.TabIndex = 6;
            this.btnFichaMariposaObservacion.Text = "Ver ficha técnica";
            this.btnFichaMariposaObservacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFichaMariposaObservacion.UseVisualStyleBackColor = true;
            this.btnFichaMariposaObservacion.Click += new System.EventHandler(this.btnFichaMariposaObservacion_Click);
            // 
            // btnModificarMariposasObservacion
            // 
            this.btnModificarMariposasObservacion.Image = global::Mariposario.Properties.Resources.icono_actualizar;
            this.btnModificarMariposasObservacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarMariposasObservacion.Location = new System.Drawing.Point(197, 138);
            this.btnModificarMariposasObservacion.Name = "btnModificarMariposasObservacion";
            this.btnModificarMariposasObservacion.Size = new System.Drawing.Size(75, 43);
            this.btnModificarMariposasObservacion.TabIndex = 3;
            this.btnModificarMariposasObservacion.Text = "Modificar";
            this.btnModificarMariposasObservacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarMariposasObservacion.UseVisualStyleBackColor = true;
            this.btnModificarMariposasObservacion.Click += new System.EventHandler(this.btnModificarMariposasObservacion_Click);
            // 
            // listBoxMariposasObservacion
            // 
            this.listBoxMariposasObservacion.FormattingEnabled = true;
            this.listBoxMariposasObservacion.Location = new System.Drawing.Point(18, 36);
            this.listBoxMariposasObservacion.Name = "listBoxMariposasObservacion";
            this.listBoxMariposasObservacion.Size = new System.Drawing.Size(162, 238);
            this.listBoxMariposasObservacion.TabIndex = 0;
            // 
            // btnEliminarMariposasObservacion
            // 
            this.btnEliminarMariposasObservacion.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarMariposasObservacion.Image")));
            this.btnEliminarMariposasObservacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarMariposasObservacion.Location = new System.Drawing.Point(197, 196);
            this.btnEliminarMariposasObservacion.Name = "btnEliminarMariposasObservacion";
            this.btnEliminarMariposasObservacion.Size = new System.Drawing.Size(75, 43);
            this.btnEliminarMariposasObservacion.TabIndex = 2;
            this.btnEliminarMariposasObservacion.Text = "Liberar";
            this.btnEliminarMariposasObservacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarMariposasObservacion.UseVisualStyleBackColor = true;
            this.btnEliminarMariposasObservacion.Click += new System.EventHandler(this.btnEliminarMariposasObservacion_Click);
            // 
            // groupBoxBusqueda
            // 
            this.groupBoxBusqueda.Controls.Add(this.lblMariposa);
            this.groupBoxBusqueda.Controls.Add(this.txtID);
            this.groupBoxBusqueda.Location = new System.Drawing.Point(30, 42);
            this.groupBoxBusqueda.Name = "groupBoxBusqueda";
            this.groupBoxBusqueda.Size = new System.Drawing.Size(269, 74);
            this.groupBoxBusqueda.TabIndex = 5;
            this.groupBoxBusqueda.TabStop = false;
            this.groupBoxBusqueda.Text = "Buscar por ID";
            // 
            // lblMariposa
            // 
            this.lblMariposa.AutoSize = true;
            this.lblMariposa.Location = new System.Drawing.Point(16, 32);
            this.lblMariposa.Name = "lblMariposa";
            this.lblMariposa.Size = new System.Drawing.Size(67, 13);
            this.lblMariposa.TabIndex = 6;
            this.lblMariposa.Text = "ID Mariposa:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(104, 29);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(137, 20);
            this.txtID.TabIndex = 2;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // formularioMariposas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 497);
            this.Controls.Add(this.groupBoxBusqueda);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxColeccion);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formularioMariposas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mariposario - Mariposas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxColeccion.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxBusqueda.ResumeLayout(false);
            this.groupBoxBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mariposasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoCapturaDeMariposaToolStripMenuItem;
        private System.Windows.Forms.Button btnEliminarMariposasColeccion;
        private System.Windows.Forms.GroupBox groupBoxColeccion;
        private System.Windows.Forms.ListBox listBoxMariposasColeccion;
        private System.Windows.Forms.Button btnModificarMariposasColeccion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModificarMariposasObservacion;
        private System.Windows.Forms.ListBox listBoxMariposasObservacion;
        private System.Windows.Forms.Button btnEliminarMariposasObservacion;
        private System.Windows.Forms.Button btnFichaMariposaColeccion;
        private System.Windows.Forms.Button btnFichaMariposaObservacion;
        private System.Windows.Forms.GroupBox groupBoxBusqueda;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem familiasNaturalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem génerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem espciesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrosDeBúsquedaToolStripMenuItem;
        private System.Windows.Forms.Label lblMariposa;
    }
}