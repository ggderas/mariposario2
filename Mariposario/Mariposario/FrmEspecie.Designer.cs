namespace Mariposario
{
    partial class FrmEspecie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEspecie));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbInformacion = new System.Windows.Forms.GroupBox();
            this.lbxInformacion = new System.Windows.Forms.ListBox();
            this.lbxFamiliaNatural = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grbInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.grbInformacion);
            this.groupBox1.Controls.Add(this.lbxFamiliaNatural);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Location = new System.Drawing.Point(1, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 345);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Especie";
            // 
            // grbInformacion
            // 
            this.grbInformacion.Controls.Add(this.lbxInformacion);
            this.grbInformacion.Location = new System.Drawing.Point(373, 32);
            this.grbInformacion.Name = "grbInformacion";
            this.grbInformacion.Size = new System.Drawing.Size(258, 165);
            this.grbInformacion.TabIndex = 6;
            this.grbInformacion.TabStop = false;
            this.grbInformacion.Text = "Información";
            // 
            // lbxInformacion
            // 
            this.lbxInformacion.FormattingEnabled = true;
            this.lbxInformacion.Location = new System.Drawing.Point(9, 20);
            this.lbxInformacion.Name = "lbxInformacion";
            this.lbxInformacion.Size = new System.Drawing.Size(238, 134);
            this.lbxInformacion.TabIndex = 4;
            // 
            // lbxFamiliaNatural
            // 
            this.lbxFamiliaNatural.FormattingEnabled = true;
            this.lbxFamiliaNatural.Location = new System.Drawing.Point(9, 18);
            this.lbxFamiliaNatural.Name = "lbxFamiliaNatural";
            this.lbxFamiliaNatural.Size = new System.Drawing.Size(238, 316);
            this.lbxFamiliaNatural.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(257, 198);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 37);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "&Eliminar ";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(257, 152);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(101, 37);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "&Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(257, 109);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 37);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "&Agregar ";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmEspecie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(636, 340);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEspecie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Especies";
            this.groupBox1.ResumeLayout(false);
            this.grbInformacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbInformacion;
        private System.Windows.Forms.ListBox lbxInformacion;
        private System.Windows.Forms.ListBox lbxFamiliaNatural;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
    }
}