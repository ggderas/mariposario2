namespace Mariposario {
    partial class frmAgregarPrecio {
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.numerocPrecio = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numerocPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(130, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // numerocPrecio
            // 
            this.numerocPrecio.Location = new System.Drawing.Point(4, 4);
            this.numerocPrecio.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numerocPrecio.Name = "numerocPrecio";
            this.numerocPrecio.Size = new System.Drawing.Size(120, 20);
            this.numerocPrecio.TabIndex = 2;
            // 
            // frmAgregarPrecio
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 30);
            this.Controls.Add(this.numerocPrecio);
            this.Controls.Add(this.btnAceptar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarPrecio";
            this.Text = "Precio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAgregarPrecio_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numerocPrecio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.NumericUpDown numerocPrecio;
    }
}