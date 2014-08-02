namespace Mariposario
{
    partial class frmColeccionistas
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
            this.mnsColeccionistasMenu = new System.Windows.Forms.MenuStrip();
            this.mariposasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregarColeccionista = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxIdColeccionistas = new System.Windows.Forms.ListBox();
            this.lblNombreColeccion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditarColeccionista = new System.Windows.Forms.Button();
            this.btnEliminarColeccionista = new System.Windows.Forms.Button();
            this.mnsColeccionistasMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsColeccionistasMenu
            // 
            this.mnsColeccionistasMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mariposasToolStripMenuItem});
            this.mnsColeccionistasMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsColeccionistasMenu.Name = "mnsColeccionistasMenu";
            this.mnsColeccionistasMenu.Size = new System.Drawing.Size(419, 24);
            this.mnsColeccionistasMenu.TabIndex = 1;
            this.mnsColeccionistasMenu.Text = "menuStrip1";
            // 
            // mariposasToolStripMenuItem
            // 
            this.mariposasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAgregarColeccionista,
            this.toolStripSeparator1});
            this.mariposasToolStripMenuItem.Name = "mariposasToolStripMenuItem";
            this.mariposasToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.mariposasToolStripMenuItem.Text = "Coleccionistas";
            // 
            // tsmAgregarColeccionista
            // 
            this.tsmAgregarColeccionista.Image = global::Mariposario.Properties.Resources.icono_agregar;
            this.tsmAgregarColeccionista.Name = "tsmAgregarColeccionista";
            this.tsmAgregarColeccionista.Size = new System.Drawing.Size(199, 22);
            this.tsmAgregarColeccionista.Text = "Agregar Coleccionista...";
            this.tsmAgregarColeccionista.Click += new System.EventHandler(this.tsmAgregarColeccionista_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidos.Location = new System.Drawing.Point(186, 72);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(0, 13);
            this.lblApellidos.TabIndex = 9;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.BackColor = System.Drawing.Color.Transparent;
            this.lblNombres.Location = new System.Drawing.Point(186, 39);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(0, 13);
            this.lblNombres.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(127, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(127, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombres";
            // 
            // lbxIdColeccionistas
            // 
            this.lbxIdColeccionistas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxIdColeccionistas.FormattingEnabled = true;
            this.lbxIdColeccionistas.Location = new System.Drawing.Point(12, 39);
            this.lbxIdColeccionistas.Name = "lbxIdColeccionistas";
            this.lbxIdColeccionistas.Size = new System.Drawing.Size(101, 212);
            this.lbxIdColeccionistas.TabIndex = 5;
            this.lbxIdColeccionistas.SelectedIndexChanged += new System.EventHandler(this.lbxIdColeccionistas_SelectedIndexChanged);
            // 
            // lblNombreColeccion
            // 
            this.lblNombreColeccion.AutoSize = true;
            this.lblNombreColeccion.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreColeccion.Location = new System.Drawing.Point(227, 105);
            this.lblNombreColeccion.Name = "lblNombreColeccion";
            this.lblNombreColeccion.Size = new System.Drawing.Size(0, 13);
            this.lblNombreColeccion.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(127, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre Colección";
            // 
            // btnEditarColeccionista
            // 
            this.btnEditarColeccionista.Image = global::Mariposario.Properties.Resources.icono_actualizar;
            this.btnEditarColeccionista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarColeccionista.Location = new System.Drawing.Point(159, 168);
            this.btnEditarColeccionista.Name = "btnEditarColeccionista";
            this.btnEditarColeccionista.Size = new System.Drawing.Size(91, 30);
            this.btnEditarColeccionista.TabIndex = 12;
            this.btnEditarColeccionista.Text = "Editar";
            this.btnEditarColeccionista.UseVisualStyleBackColor = true;
            this.btnEditarColeccionista.Click += new System.EventHandler(this.btnEditarColeccionista_Click);
            // 
            // btnEliminarColeccionista
            // 
            this.btnEliminarColeccionista.Image = global::Mariposario.Properties.Resources.icono_eliminar;
            this.btnEliminarColeccionista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarColeccionista.Location = new System.Drawing.Point(273, 168);
            this.btnEliminarColeccionista.Name = "btnEliminarColeccionista";
            this.btnEliminarColeccionista.Size = new System.Drawing.Size(91, 30);
            this.btnEliminarColeccionista.TabIndex = 13;
            this.btnEliminarColeccionista.Text = "Eliminar";
            this.btnEliminarColeccionista.UseVisualStyleBackColor = true;
            this.btnEliminarColeccionista.Click += new System.EventHandler(this.btnEliminarColeccionista_Click);
            // 
            // frmColeccionistas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(419, 271);
            this.Controls.Add(this.btnEliminarColeccionista);
            this.Controls.Add(this.btnEditarColeccionista);
            this.Controls.Add(this.lblNombreColeccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxIdColeccionistas);
            this.Controls.Add(this.mnsColeccionistasMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmColeccionistas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mariposario - Coleccionistas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmColeccionistas_FormClosed);
            this.mnsColeccionistasMenu.ResumeLayout(false);
            this.mnsColeccionistasMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsColeccionistasMenu;
        private System.Windows.Forms.ToolStripMenuItem mariposasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregarColeccionista;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxIdColeccionistas;
        private System.Windows.Forms.Label lblNombreColeccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditarColeccionista;
        private System.Windows.Forms.Button btnEliminarColeccionista;
    }
}