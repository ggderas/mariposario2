﻿namespace Mariposario {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminarMariposasColeccion = new System.Windows.Forms.Button();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAgregarMariposa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMariposasEnColeccion = new System.Windows.Forms.ListBox();
            this.lbMariposas = new System.Windows.Forms.ListBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cmbPropietario = new System.Windows.Forms.ComboBox();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.tbIDColeccion = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnEliminarMariposasColeccion);
            this.groupBox1.Controls.Add(this.groupBoxTipo);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericPrecio);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.cmbPropietario);
            this.groupBox1.Controls.Add(this.lblEspecie);
            this.groupBox1.Controls.Add(this.tbIDColeccion);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 495);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Mariposario.Properties.Resources.icono_agregar;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(374, 29);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 43);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Aceptar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminarMariposasColeccion
            // 
            this.btnEliminarMariposasColeccion.Image = global::Mariposario.Properties.Resources.icono_eliminar1;
            this.btnEliminarMariposasColeccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarMariposasColeccion.Location = new System.Drawing.Point(477, 29);
            this.btnEliminarMariposasColeccion.Name = "btnEliminarMariposasColeccion";
            this.btnEliminarMariposasColeccion.Size = new System.Drawing.Size(75, 43);
            this.btnEliminarMariposasColeccion.TabIndex = 22;
            this.btnEliminarMariposasColeccion.Text = "Cancelar";
            this.btnEliminarMariposasColeccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarMariposasColeccion.UseVisualStyleBackColor = true;
            // 
            // groupBoxTipo
            // 
            this.groupBoxTipo.Controls.Add(this.label4);
            this.groupBoxTipo.Controls.Add(this.lblAgregarMariposa);
            this.groupBoxTipo.Controls.Add(this.label3);
            this.groupBoxTipo.Controls.Add(this.label2);
            this.groupBoxTipo.Controls.Add(this.lbMariposasEnColeccion);
            this.groupBoxTipo.Controls.Add(this.lbMariposas);
            this.groupBoxTipo.Location = new System.Drawing.Point(26, 168);
            this.groupBoxTipo.Name = "groupBoxTipo";
            this.groupBoxTipo.Size = new System.Drawing.Size(526, 303);
            this.groupBoxTipo.TabIndex = 21;
            this.groupBoxTipo.TabStop = false;
            this.groupBoxTipo.Text = "Mariposas";
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Image = global::Mariposario.Properties.Resources.flecha_izquierda;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(246, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 29);
            this.label4.TabIndex = 6;
            // 
            // lblAgregarMariposa
            // 
            this.lblAgregarMariposa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAgregarMariposa.Image = global::Mariposario.Properties.Resources.flecha_derecha1;
            this.lblAgregarMariposa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAgregarMariposa.Location = new System.Drawing.Point(246, 96);
            this.lblAgregarMariposa.Name = "lblAgregarMariposa";
            this.lblAgregarMariposa.Size = new System.Drawing.Size(40, 29);
            this.lblAgregarMariposa.TabIndex = 6;
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
            this.lbMariposasEnColeccion.TabIndex = 2;
            // 
            // lbMariposas
            // 
            this.lbMariposas.FormattingEnabled = true;
            this.lbMariposas.Location = new System.Drawing.Point(38, 51);
            this.lbMariposas.Name = "lbMariposas";
            this.lbMariposas.Size = new System.Drawing.Size(202, 238);
            this.lbMariposas.TabIndex = 1;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(134, 62);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(200, 20);
            this.tbNombre.TabIndex = 20;
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
            this.numericPrecio.Name = "numericPrecio";
            this.numericPrecio.Size = new System.Drawing.Size(120, 20);
            this.numericPrecio.TabIndex = 18;
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
            this.cmbPropietario.Location = new System.Drawing.Point(134, 124);
            this.cmbPropietario.Name = "cmbPropietario";
            this.cmbPropietario.Size = new System.Drawing.Size(200, 21);
            this.cmbPropietario.TabIndex = 16;
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(23, 127);
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
            // formularioAgregarColeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 519);
            this.Controls.Add(this.groupBox1);
            this.Name = "formularioAgregarColeccion";
            this.Text = "Mariposario - Agregar Colección";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxTipo.ResumeLayout(false);
            this.groupBoxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecio)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminarMariposasColeccion;
    }
}