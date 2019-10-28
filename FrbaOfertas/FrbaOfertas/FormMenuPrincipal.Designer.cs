namespace FrbaOfertas
{
    partial class FormMenuPrincipal
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lnkLogout = new System.Windows.Forms.LinkLabel();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(12, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(216, 17);
            this.lblUsername.TabIndex = 2;
            // 
            // lnkLogout
            // 
            this.lnkLogout.AutoSize = true;
            this.lnkLogout.Location = new System.Drawing.Point(234, 9);
            this.lnkLogout.Name = "lnkLogout";
            this.lnkLogout.Size = new System.Drawing.Size(93, 17);
            this.lnkLogout.TabIndex = 3;
            this.lnkLogout.TabStop = true;
            this.lnkLogout.Text = "Cerrar sesión";
            this.lnkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogout_LinkClicked);
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Location = new System.Drawing.Point(12, 40);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(315, 30);
            this.pnlOpciones.TabIndex = 4;
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 79);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.lnkLogout);
            this.Controls.Add(this.lblUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRBA Ofertas - Menú principal";
            this.Load += new System.EventHandler(this.FormMenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.LinkLabel lnkLogout;
        private System.Windows.Forms.Panel pnlOpciones;

    }
}

