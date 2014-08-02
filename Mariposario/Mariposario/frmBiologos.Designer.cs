namespace Mariposario
{
    partial class frmBiologos
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
            this.btnEliminarBiologo = new System.Windows.Forms.Button();
            this.btnEditarBiologo = new System.Windows.Forms.Button();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxIdBiologos = new System.Windows.Forms.ListBox();
            this.mnsBiologosMenu = new System.Windows.Forms.MenuStrip();
            this.mariposasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregarBiologos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnsBiologosMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminarBiologo
            // 
            this.btnEliminarBiologo.Image = global::Mariposario.Properties.Resources.icono_eliminar;
            this.btnEliminarBiologo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarBiologo.Location = new System.Drawing.Point(273, 165);
            this.btnEliminarBiologo.Name = "btnEliminarBiologo";
            this.btnEliminarBiologo.Size = new System.Drawing.Size(91, 30);
            this.btnEliminarBiologo.TabIndex = 23;
            this.btnEliminarBiologo.Text = "Eliminar";
            this.btnEliminarBiologo.UseVisualStyleBackColor = true;
            this.btnEliminarBiologo.Click += new System.EventHandler(this.btnEliminarBiologo_Click);
            // 
            // btnEditarBiologo
            // 
            this.btnEditarBiologo.Image = global::Mariposario.Properties.Resources.icono_actualizar;
            this.btnEditarBiologo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarBiologo.Location = new System.Drawing.Point(159, 165);
            this.btnEditarBiologo.Name = "btnEditarBiologo";
            this.btnEditarBiologo.Size = new System.Drawing.Size(91, 30);
            this.btnEditarBiologo.TabIndex = 22;
            this.btnEditarBiologo.Text = "Editar";
            this.btnEditarBiologo.UseVisualStyleBackColor = true;
            this.btnEditarBiologo.Click += new System.EventHandler(this.btnEditarBiologo_Click);
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidos.Location = new System.Drawing.Point(186, 69);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(0, 13);
            this.lblApellidos.TabIndex = 19;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.BackColor = System.Drawing.Color.Transparent;
            this.lblNombres.Location = new System.Drawing.Point(186, 36);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(0, 13);
            this.lblNombres.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(127, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(127, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombres";
            // 
            // lbxIdBiologos
            // 
            this.lbxIdBiologos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxIdBiologos.FormattingEnabled = true;
            this.lbxIdBiologos.Location = new System.Drawing.Point(12, 36);
            this.lbxIdBiologos.Name = "lbxIdBiologos";
            this.lbxIdBiologos.Size = new System.Drawing.Size(101, 212);
            this.lbxIdBiologos.TabIndex = 15;
            this.lbxIdBiologos.SelectedIndexChanged += new System.EventHandler(this.lbxIdBiologos_SelectedIndexChanged);
            // 
            // mnsBiologosMenu
            // 
            this.mnsBiologosMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mariposasToolStripMenuItem});
            this.mnsBiologosMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsBiologosMenu.Name = "mnsBiologosMenu";
            this.mnsBiologosMenu.Size = new System.Drawing.Size(419, 24);
            this.mnsBiologosMenu.TabIndex = 14;
            this.mnsBiologosMenu.Text = "menuStrip1";
            // 
            // mariposasToolStripMenuItem
            // 
            this.mariposasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAgregarBiologos,
            this.toolStripSeparator1});
            this.mariposasToolStripMenuItem.Name = "mariposasToolStripMenuItem";
            this.mariposasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.mariposasToolStripMenuItem.Text = "Biologos";
            // 
            // tsmAgregarBiologos
            // 
            this.tsmAgregarBiologos.Image = global::Mariposario.Properties.Resources.icono_agregar;
            this.tsmAgregarBiologos.Name = "tsmAgregarBiologos";
            this.tsmAgregarBiologos.Size = new System.Drawing.Size(177, 22);
            this.tsmAgregarBiologos.Text = "Agregar Biologos....";
            this.tsmAgregarBiologos.Click += new System.EventHandler(this.tsmAgregarBiologos_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // frmBiologos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(419, 271);
            this.Controls.Add(this.btnEliminarBiologo);
            this.Controls.Add(this.btnEditarBiologo);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxIdBiologos);
            this.Controls.Add(this.mnsBiologosMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBiologos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mariposario - Biologos";
            this.mnsBiologosMenu.ResumeLayout(false);
            this.mnsBiologosMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarBiologo;
        private System.Windows.Forms.Button btnEditarBiologo;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxIdBiologos;
        private System.Windows.Forms.MenuStrip mnsBiologosMenu;
        private System.Windows.Forms.ToolStripMenuItem mariposasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregarBiologos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}