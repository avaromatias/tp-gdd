namespace FrbaOfertas.AbmRol
{
    partial class FormABMRol
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
            this.gvwRoles = new System.Windows.Forms.DataGridView();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvwRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // gvwRoles
            // 
            this.gvwRoles.AllowUserToAddRows = false;
            this.gvwRoles.AllowUserToDeleteRows = false;
            this.gvwRoles.AllowUserToOrderColumns = true;
            this.gvwRoles.AllowUserToResizeColumns = false;
            this.gvwRoles.AllowUserToResizeRows = false;
            this.gvwRoles.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gvwRoles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvwRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvwRoles.ColumnHeadersVisible = false;
            this.gvwRoles.Location = new System.Drawing.Point(12, 12);
            this.gvwRoles.Name = "gvwRoles";
            this.gvwRoles.ReadOnly = true;
            this.gvwRoles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvwRoles.RowTemplate.Height = 24;
            this.gvwRoles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvwRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvwRoles.Size = new System.Drawing.Size(723, 143);
            this.gvwRoles.TabIndex = 0;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(12, 161);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(241, 30);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "Agregar";
            this.btnAlta.UseVisualStyleBackColor = true;
            // 
            // btnModificacion
            // 
            this.btnModificacion.Location = new System.Drawing.Point(253, 161);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(241, 30);
            this.btnModificacion.TabIndex = 2;
            this.btnModificacion.Text = "Modificar";
            this.btnModificacion.UseVisualStyleBackColor = true;
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(494, 161);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(241, 30);
            this.btnBaja.TabIndex = 3;
            this.btnBaja.Text = "Eliminar";
            this.btnBaja.UseVisualStyleBackColor = true;
            // 
            // FormABMRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 197);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModificacion);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.gvwRoles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormABMRol";
            this.Text = "FRBA Ofertas - ABM de Roles";
            ((System.ComponentModel.ISupportInitialize)(this.gvwRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvwRoles;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Button btnBaja;
    }
}