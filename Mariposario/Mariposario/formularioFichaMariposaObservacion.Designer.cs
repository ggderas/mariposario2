﻿namespace Mariposario
{
    partial class formularioFichaMariposaObservacion
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
            this.picBoxReloj = new System.Windows.Forms.PictureBox();
            this.groupBoxImagen = new System.Windows.Forms.GroupBox();
            this.picBoxImagen = new System.Windows.Forms.PictureBox();
            this.txtTiempoObservacion = new System.Windows.Forms.TextBox();
            this.lblTiempoObservacion = new System.Windows.Forms.Label();
            this.txtBiologo = new System.Windows.Forms.TextBox();
            this.txtFechaCaptura = new System.Windows.Forms.TextBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblBiologo = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblFechaCaptura = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.checkLiberado = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReloj)).BeginInit();
            this.groupBoxImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkLiberado);
            this.groupBox1.Controls.Add(this.picBoxReloj);
            this.groupBox1.Controls.Add(this.groupBoxImagen);
            this.groupBox1.Controls.Add(this.txtTiempoObservacion);
            this.groupBox1.Controls.Add(this.lblTiempoObservacion);
            this.groupBox1.Controls.Add(this.txtBiologo);
            this.groupBox1.Controls.Add(this.txtFechaCaptura);
            this.groupBox1.Controls.Add(this.txtEspecie);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lblBiologo);
            this.groupBox1.Controls.Add(this.lblEspecie);
            this.groupBox1.Controls.Add(this.lblFechaCaptura);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 296);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mariposa en Observación";
            // 
            // picBoxReloj
            // 
            this.picBoxReloj.Image = global::Mariposario.Properties.Resources.icono_reloj1;
            this.picBoxReloj.Location = new System.Drawing.Point(90, 198);
            this.picBoxReloj.Name = "picBoxReloj";
            this.picBoxReloj.Size = new System.Drawing.Size(38, 37);
            this.picBoxReloj.TabIndex = 13;
            this.picBoxReloj.TabStop = false;
            // 
            // groupBoxImagen
            // 
            this.groupBoxImagen.Controls.Add(this.picBoxImagen);
            this.groupBoxImagen.Location = new System.Drawing.Point(284, 23);
            this.groupBoxImagen.Name = "groupBoxImagen";
            this.groupBoxImagen.Size = new System.Drawing.Size(266, 218);
            this.groupBoxImagen.TabIndex = 12;
            this.groupBoxImagen.TabStop = false;
            this.groupBoxImagen.Text = "Imagen";
            // 
            // picBoxImagen
            // 
            this.picBoxImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxImagen.Image = global::Mariposario.Properties.Resources.mariposa_imagenPorDefecto;
            this.picBoxImagen.Location = new System.Drawing.Point(16, 19);
            this.picBoxImagen.Name = "picBoxImagen";
            this.picBoxImagen.Size = new System.Drawing.Size(244, 193);
            this.picBoxImagen.TabIndex = 0;
            this.picBoxImagen.TabStop = false;
            // 
            // txtTiempoObservacion
            // 
            this.txtTiempoObservacion.Location = new System.Drawing.Point(134, 198);
            this.txtTiempoObservacion.Name = "txtTiempoObservacion";
            this.txtTiempoObservacion.ReadOnly = true;
            this.txtTiempoObservacion.Size = new System.Drawing.Size(100, 20);
            this.txtTiempoObservacion.TabIndex = 9;
            // 
            // lblTiempoObservacion
            // 
            this.lblTiempoObservacion.AutoSize = true;
            this.lblTiempoObservacion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTiempoObservacion.Location = new System.Drawing.Point(24, 170);
            this.lblTiempoObservacion.Name = "lblTiempoObservacion";
            this.lblTiempoObservacion.Size = new System.Drawing.Size(123, 13);
            this.lblTiempoObservacion.TabIndex = 8;
            this.lblTiempoObservacion.Text = "Tiempo de Observación:";
            this.lblTiempoObservacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBiologo
            // 
            this.txtBiologo.Location = new System.Drawing.Point(134, 102);
            this.txtBiologo.Name = "txtBiologo";
            this.txtBiologo.ReadOnly = true;
            this.txtBiologo.Size = new System.Drawing.Size(100, 20);
            this.txtBiologo.TabIndex = 7;
            // 
            // txtFechaCaptura
            // 
            this.txtFechaCaptura.Location = new System.Drawing.Point(134, 132);
            this.txtFechaCaptura.Name = "txtFechaCaptura";
            this.txtFechaCaptura.ReadOnly = true;
            this.txtFechaCaptura.Size = new System.Drawing.Size(100, 20);
            this.txtFechaCaptura.TabIndex = 6;
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(134, 72);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.ReadOnly = true;
            this.txtEspecie.Size = new System.Drawing.Size(100, 20);
            this.txtEspecie.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(134, 37);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            // 
            // lblBiologo
            // 
            this.lblBiologo.AutoSize = true;
            this.lblBiologo.Location = new System.Drawing.Point(24, 105);
            this.lblBiologo.Name = "lblBiologo";
            this.lblBiologo.Size = new System.Drawing.Size(77, 13);
            this.lblBiologo.TabIndex = 3;
            this.lblBiologo.Text = "Capturado por:";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(24, 75);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(45, 13);
            this.lblEspecie.TabIndex = 2;
            this.lblEspecie.Text = "Especie";
            // 
            // lblFechaCaptura
            // 
            this.lblFechaCaptura.AutoSize = true;
            this.lblFechaCaptura.Location = new System.Drawing.Point(24, 135);
            this.lblFechaCaptura.Name = "lblFechaCaptura";
            this.lblFechaCaptura.Size = new System.Drawing.Size(94, 13);
            this.lblFechaCaptura.TabIndex = 1;
            this.lblFechaCaptura.Text = "Fecha de captura:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(24, 40);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(67, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID Mariposa:";
            // 
            // checkLiberado
            // 
            this.checkLiberado.AutoSize = true;
            this.checkLiberado.Enabled = false;
            this.checkLiberado.Location = new System.Drawing.Point(27, 255);
            this.checkLiberado.Name = "checkLiberado";
            this.checkLiberado.Size = new System.Drawing.Size(106, 17);
            this.checkLiberado.TabIndex = 16;
            this.checkLiberado.Text = "Ejemplar liberado";
            this.checkLiberado.UseVisualStyleBackColor = true;
            // 
            // formularioFichaMariposaObservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 329);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formularioFichaMariposaObservacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ficha técnica - Mariposa en Observación";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxReloj)).EndInit();
            this.groupBoxImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxImagen;
        private System.Windows.Forms.PictureBox picBoxImagen;
        private System.Windows.Forms.TextBox txtTiempoObservacion;
        private System.Windows.Forms.Label lblTiempoObservacion;
        private System.Windows.Forms.TextBox txtBiologo;
        private System.Windows.Forms.TextBox txtFechaCaptura;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblBiologo;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblFechaCaptura;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox picBoxReloj;
        private System.Windows.Forms.CheckBox checkLiberado;
    }
}