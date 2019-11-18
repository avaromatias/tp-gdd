namespace FrbaOfertas.ModificarContrasena
{
    partial class FormModificarContrasena
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNuevaContrasena = new System.Windows.Forms.TextBox();
            this.lblNuevaContrasena = new System.Windows.Forms.Label();
            this.txtRepitaNuevaContrasena = new System.Windows.Forms.TextBox();
            this.lblRepitaNuevaContrasena = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNuevaContrasena
            // 
            this.txtNuevaContrasena.Location = new System.Drawing.Point(126, 12);
            this.txtNuevaContrasena.Name = "txtNuevaContrasena";
            this.txtNuevaContrasena.Size = new System.Drawing.Size(186, 20);
            this.txtNuevaContrasena.TabIndex = 3;
            this.txtNuevaContrasena.UseSystemPasswordChar = true;
            // 
            // lblNuevaContrasena
            // 
            this.lblNuevaContrasena.AutoSize = true;
            this.lblNuevaContrasena.Location = new System.Drawing.Point(12, 15);
            this.lblNuevaContrasena.Name = "lblNuevaContrasena";
            this.lblNuevaContrasena.Size = new System.Drawing.Size(98, 13);
            this.lblNuevaContrasena.TabIndex = 2;
            this.lblNuevaContrasena.Text = "Nueva contraseña:";
            // 
            // txtRepitaNuevaContrasena
            // 
            this.txtRepitaNuevaContrasena.Location = new System.Drawing.Point(126, 38);
            this.txtRepitaNuevaContrasena.Name = "txtRepitaNuevaContrasena";
            this.txtRepitaNuevaContrasena.Size = new System.Drawing.Size(186, 20);
            this.txtRepitaNuevaContrasena.TabIndex = 5;
            this.txtRepitaNuevaContrasena.UseSystemPasswordChar = true;
            // 
            // lblRepitaNuevaContrasena
            // 
            this.lblRepitaNuevaContrasena.AutoSize = true;
            this.lblRepitaNuevaContrasena.Location = new System.Drawing.Point(12, 41);
            this.lblRepitaNuevaContrasena.Name = "lblRepitaNuevaContrasena";
            this.lblRepitaNuevaContrasena.Size = new System.Drawing.Size(108, 13);
            this.lblRepitaNuevaContrasena.TabIndex = 4;
            this.lblRepitaNuevaContrasena.Text = "Repita la contraseña:";
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(15, 64);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(297, 25);
            this.btnGuardarCambios.TabIndex = 6;
            this.btnGuardarCambios.Text = "Guardar cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // FormModificarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 96);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.txtRepitaNuevaContrasena);
            this.Controls.Add(this.lblRepitaNuevaContrasena);
            this.Controls.Add(this.txtNuevaContrasena);
            this.Controls.Add(this.lblNuevaContrasena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormModificarContrasena";
            this.Text = "FRBA Ofertas - Modificar contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNuevaContrasena;
        private System.Windows.Forms.Label lblNuevaContrasena;
        private System.Windows.Forms.TextBox txtRepitaNuevaContrasena;
        private System.Windows.Forms.Label lblRepitaNuevaContrasena;
        private System.Windows.Forms.Button btnGuardarCambios;
    }
}