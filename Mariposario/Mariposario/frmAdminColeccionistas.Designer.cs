namespace Mariposario
{
    partial class frmAdminColeccionistas
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
            this.components = new System.ComponentModel.Container();
            this.btnAccion = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblColeccion = new System.Windows.Forms.Label();
            this.cbxColeccion = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccion
            // 
            this.btnAccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccion.Location = new System.Drawing.Point(121, 244);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(131, 36);
            this.btnAccion.TabIndex = 0;
            this.btnAccion.Text = "button1";
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Location = new System.Drawing.Point(57, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(149, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(167, 20);
            this.txtId.TabIndex = 2;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(149, 79);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(167, 20);
            this.txtNombres.TabIndex = 4;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.BackColor = System.Drawing.Color.Transparent;
            this.lblNombres.Location = new System.Drawing.Point(57, 79);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 3;
            this.lblNombres.Text = "Nombres";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(149, 129);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(167, 20);
            this.txtApellidos.TabIndex = 6;
            this.txtApellidos.TextChanged += new System.EventHandler(this.txtApellidos_TextChanged);
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidos.Location = new System.Drawing.Point(57, 129);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 5;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblColeccion
            // 
            this.lblColeccion.AutoSize = true;
            this.lblColeccion.BackColor = System.Drawing.Color.Transparent;
            this.lblColeccion.Location = new System.Drawing.Point(57, 181);
            this.lblColeccion.Name = "lblColeccion";
            this.lblColeccion.Size = new System.Drawing.Size(54, 13);
            this.lblColeccion.TabIndex = 7;
            this.lblColeccion.Text = "Colección";
            // 
            // cbxColeccion
            // 
            this.cbxColeccion.FormattingEnabled = true;
            this.cbxColeccion.Location = new System.Drawing.Point(149, 181);
            this.cbxColeccion.Name = "cbxColeccion";
            this.cbxColeccion.Size = new System.Drawing.Size(167, 21);
            this.cbxColeccion.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAdminColeccionistas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(373, 318);
            this.Controls.Add(this.cbxColeccion);
            this.Controls.Add(this.lblColeccion);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnAccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAdminColeccionistas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mariposario - Coleccionistas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdminColeccionistas_FormClosed);
            this.Load += new System.EventHandler(this.frmAdminColeccionistas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblColeccion;
        private System.Windows.Forms.ComboBox cbxColeccion;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}