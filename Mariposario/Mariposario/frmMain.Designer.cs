namespace Mariposario
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnsMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEdicion = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarZonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbOpciones = new System.Windows.Forms.GroupBox();
            this.btnColeccionistas = new System.Windows.Forms.Button();
            this.btnMariposas = new System.Windows.Forms.Button();
            this.btnBiologos = new System.Windows.Forms.Button();
            this.Coleccionistas = new System.Windows.Forms.Button();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMenuPrincipal.SuspendLayout();
            this.gpbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMenuPrincipal
            // 
            this.mnsMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenu,
            this.tsmEdicion});
            this.mnsMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsMenuPrincipal.Name = "mnsMenuPrincipal";
            this.mnsMenuPrincipal.Size = new System.Drawing.Size(534, 24);
            this.mnsMenuPrincipal.TabIndex = 0;
            this.mnsMenuPrincipal.Text = "menuStrip1";
            // 
            // tsmMenu
            // 
            this.tsmMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem});
            this.tsmMenu.Name = "tsmMenu";
            this.tsmMenu.Size = new System.Drawing.Size(50, 20);
            this.tsmMenu.Text = "Menú";
            // 
            // tsmEdicion
            // 
            this.tsmEdicion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarZonasToolStripMenuItem});
            this.tsmEdicion.Name = "tsmEdicion";
            this.tsmEdicion.Size = new System.Drawing.Size(58, 20);
            this.tsmEdicion.Text = "Edición";
            // 
            // administrarZonasToolStripMenuItem
            // 
            this.administrarZonasToolStripMenuItem.Name = "administrarZonasToolStripMenuItem";
            this.administrarZonasToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.administrarZonasToolStripMenuItem.Text = "Administrar Zonas";
            this.administrarZonasToolStripMenuItem.Click += new System.EventHandler(this.administrarZonasToolStripMenuItem_Click);
            // 
            // gpbOpciones
            // 
            this.gpbOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbOpciones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gpbOpciones.BackColor = System.Drawing.Color.Transparent;
            this.gpbOpciones.Controls.Add(this.btnColeccionistas);
            this.gpbOpciones.Controls.Add(this.btnMariposas);
            this.gpbOpciones.Controls.Add(this.btnBiologos);
            this.gpbOpciones.Controls.Add(this.Coleccionistas);
            this.gpbOpciones.Location = new System.Drawing.Point(0, 27);
            this.gpbOpciones.Name = "gpbOpciones";
            this.gpbOpciones.Size = new System.Drawing.Size(534, 316);
            this.gpbOpciones.TabIndex = 1;
            this.gpbOpciones.TabStop = false;
            this.gpbOpciones.Text = "Opciones";
            this.gpbOpciones.Enter += new System.EventHandler(this.gpbOpciones_Enter);
            // 
            // btnColeccionistas
            // 
            this.btnColeccionistas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnColeccionistas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnColeccionistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColeccionistas.Location = new System.Drawing.Point(311, 217);
            this.btnColeccionistas.Name = "btnColeccionistas";
            this.btnColeccionistas.Size = new System.Drawing.Size(162, 50);
            this.btnColeccionistas.TabIndex = 3;
            this.btnColeccionistas.Text = "Colecciones";
            this.btnColeccionistas.UseVisualStyleBackColor = false;
            this.btnColeccionistas.Click += new System.EventHandler(this.btnColeccionistas_Click);
            this.btnColeccionistas.MouseLeave += new System.EventHandler(this.Coleccionistas_MouseLeave);
            this.btnColeccionistas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Coleccionistas_MouseMove);
            // 
            // btnMariposas
            // 
            this.btnMariposas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMariposas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMariposas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMariposas.Location = new System.Drawing.Point(311, 161);
            this.btnMariposas.Name = "btnMariposas";
            this.btnMariposas.Size = new System.Drawing.Size(162, 50);
            this.btnMariposas.TabIndex = 2;
            this.btnMariposas.Text = "Mariposas";
            this.btnMariposas.UseVisualStyleBackColor = false;
            this.btnMariposas.Click += new System.EventHandler(this.btnMariposas_Click);
            this.btnMariposas.MouseLeave += new System.EventHandler(this.Coleccionistas_MouseLeave);
            this.btnMariposas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Coleccionistas_MouseMove);
            // 
            // btnBiologos
            // 
            this.btnBiologos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBiologos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBiologos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBiologos.Location = new System.Drawing.Point(311, 105);
            this.btnBiologos.Name = "btnBiologos";
            this.btnBiologos.Size = new System.Drawing.Size(162, 50);
            this.btnBiologos.TabIndex = 1;
            this.btnBiologos.Text = "Biólogos";
            this.btnBiologos.UseVisualStyleBackColor = false;
            this.btnBiologos.Click += new System.EventHandler(this.btnBiologos_Click);
            this.btnBiologos.MouseLeave += new System.EventHandler(this.Coleccionistas_MouseLeave);
            this.btnBiologos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Coleccionistas_MouseMove);
            // 
            // Coleccionistas
            // 
            this.Coleccionistas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Coleccionistas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Coleccionistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coleccionistas.Location = new System.Drawing.Point(311, 49);
            this.Coleccionistas.Name = "Coleccionistas";
            this.Coleccionistas.Size = new System.Drawing.Size(162, 50);
            this.Coleccionistas.TabIndex = 0;
            this.Coleccionistas.Text = "Coleccionistas";
            this.Coleccionistas.UseVisualStyleBackColor = false;
            this.Coleccionistas.Click += new System.EventHandler(this.Coleccionistas_Click);
            this.Coleccionistas.MouseLeave += new System.EventHandler(this.Coleccionistas_MouseLeave);
            this.Coleccionistas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Coleccionistas_MouseMove);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consultasToolStripMenuItem.Text = "Consultas";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(534, 343);
            this.Controls.Add(this.gpbOpciones);
            this.Controls.Add(this.mnsMenuPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnsMenuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menú Principal Mariposario";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnsMenuPrincipal.ResumeLayout(false);
            this.mnsMenuPrincipal.PerformLayout();
            this.gpbOpciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmEdicion;
        private System.Windows.Forms.GroupBox gpbOpciones;
        private System.Windows.Forms.Button Coleccionistas;
        private System.Windows.Forms.Button btnColeccionistas;
        private System.Windows.Forms.Button btnMariposas;
        private System.Windows.Forms.Button btnBiologos;
        private System.Windows.Forms.ToolStripMenuItem administrarZonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
    }
}

