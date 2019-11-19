namespace FrbaOfertas.ConsumirOferta
{
    partial class FormSeleccionarCliente
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblHelpUnidadesMaximas = new System.Windows.Forms.Label();
            this.ttpFechaPublicacion = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(32, 15);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(46, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Usuario:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(15, 38);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(257, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(84, 12);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(188, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // lblHelpUnidadesMaximas
            // 
            this.lblHelpUnidadesMaximas.AutoSize = true;
            this.lblHelpUnidadesMaximas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblHelpUnidadesMaximas.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblHelpUnidadesMaximas.Location = new System.Drawing.Point(11, 10);
            this.lblHelpUnidadesMaximas.Name = "lblHelpUnidadesMaximas";
            this.lblHelpUnidadesMaximas.Size = new System.Drawing.Size(24, 22);
            this.lblHelpUnidadesMaximas.TabIndex = 15;
            this.lblHelpUnidadesMaximas.Text = "ⓘ";
            this.ttpFechaPublicacion.SetToolTip(this.lblHelpUnidadesMaximas, "Escriba el username del cliente al que quiere consumir la oferta.");
            // 
            // ttpFechaPublicacion
            // 
            this.ttpFechaPublicacion.AutoPopDelay = 5000;
            this.ttpFechaPublicacion.InitialDelay = 100;
            this.ttpFechaPublicacion.ReshowDelay = 100;
            // 
            // FormSeleccionarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 68);
            this.Controls.Add(this.lblHelpUnidadesMaximas);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSeleccionarCliente";
            this.Text = "Seleccionar cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblHelpUnidadesMaximas;
        private System.Windows.Forms.ToolTip ttpFechaPublicacion;
    }
}