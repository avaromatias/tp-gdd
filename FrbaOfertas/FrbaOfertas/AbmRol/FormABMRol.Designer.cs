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
            this.gbxFiltros = new System.Windows.Forms.GroupBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtRol = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvwRoles)).BeginInit();
            this.gbxFiltros.SuspendLayout();
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
            this.gvwRoles.Location = new System.Drawing.Point(12, 81);
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
            this.btnAlta.Location = new System.Drawing.Point(12, 230);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(241, 30);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "Agregar";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnModificacion
            // 
            this.btnModificacion.Location = new System.Drawing.Point(253, 230);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(241, 30);
            this.btnModificacion.TabIndex = 2;
            this.btnModificacion.Text = "Modificar";
            this.btnModificacion.UseVisualStyleBackColor = true;
            this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(494, 230);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(241, 30);
            this.btnBaja.TabIndex = 3;
            this.btnBaja.Text = "Eliminar";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.lblRol);
            this.gbxFiltros.Controls.Add(this.btnLimpiar);
            this.gbxFiltros.Controls.Add(this.btnBuscar);
            this.gbxFiltros.Controls.Add(this.txtRol);
            this.gbxFiltros.Location = new System.Drawing.Point(12, 12);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Size = new System.Drawing.Size(723, 63);
            this.gbxFiltros.TabIndex = 4;
            this.gbxFiltros.TabStop = false;
            this.gbxFiltros.Text = "Filtros de búsqueda";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(7, 27);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(33, 17);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "Rol:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(580, 25);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(137, 23);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(437, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(137, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(46, 26);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(385, 22);
            this.txtRol.TabIndex = 0;
            // 
            // FormABMRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 267);
            this.Controls.Add(this.gbxFiltros);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModificacion);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.gvwRoles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormABMRol";
            this.Text = "FRBA Ofertas - ABM de Roles";
            ((System.ComponentModel.ISupportInitialize)(this.gvwRoles)).EndInit();
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvwRoles;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.GroupBox gbxFiltros;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtRol;
    }
}