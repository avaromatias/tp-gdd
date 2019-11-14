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
            this.lblUsername.Location = new System.Drawing.Point(9, 7);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(162, 14);
            this.lblUsername.TabIndex = 2;
            // 
            // lnkLogout
            // 
            this.lnkLogout.AutoSize = true;
            this.lnkLogout.Location = new System.Drawing.Point(176, 7);
            this.lnkLogout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkLogout.Name = "lnkLogout";
            this.lnkLogout.Size = new System.Drawing.Size(68, 13);
            this.lnkLogout.TabIndex = 3;
            this.lnkLogout.TabStop = true;
            this.lnkLogout.Text = "Cerrar sesión";
            this.lnkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogout_LinkClicked);
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Location = new System.Drawing.Point(9, 32);
            this.pnlOpciones.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(236, 24);
            this.pnlOpciones.TabIndex = 4;
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 64);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.lnkLogout);
            this.Controls.Add(this.lblUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRBA Ofertas - Menú principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenuPrincipal_FormClosing);
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

