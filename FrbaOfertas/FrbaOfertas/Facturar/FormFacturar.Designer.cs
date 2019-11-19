namespace FrbaOfertas.Facturar
{
    partial class FormFacturar
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
            this.pnlAdministrador = new System.Windows.Forms.Panel();
            this.btnSeleccionarProveedor = new System.Windows.Forms.Button();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPublicacion = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.gbxPeriodo = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gvwCompras = new System.Windows.Forms.DataGridView();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.pnlAdministrador.SuspendLayout();
            this.gbxPeriodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAdministrador
            // 
            this.pnlAdministrador.Controls.Add(this.btnSeleccionarProveedor);
            this.pnlAdministrador.Controls.Add(this.lblProveedor);
            this.pnlAdministrador.Controls.Add(this.txtProveedor);
            this.pnlAdministrador.Location = new System.Drawing.Point(12, 12);
            this.pnlAdministrador.Name = "pnlAdministrador";
            this.pnlAdministrador.Size = new System.Drawing.Size(490, 25);
            this.pnlAdministrador.TabIndex = 6;
            // 
            // btnSeleccionarProveedor
            // 
            this.btnSeleccionarProveedor.Location = new System.Drawing.Point(361, 0);
            this.btnSeleccionarProveedor.Name = "btnSeleccionarProveedor";
            this.btnSeleccionarProveedor.Size = new System.Drawing.Size(129, 23);
            this.btnSeleccionarProveedor.TabIndex = 10;
            this.btnSeleccionarProveedor.Text = "Seleccionar proveedor";
            this.btnSeleccionarProveedor.UseVisualStyleBackColor = true;
            this.btnSeleccionarProveedor.Click += new System.EventHandler(this.btnSeleccionarProveedor_Click);
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(5, 5);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(59, 13);
            this.lblProveedor.TabIndex = 3;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Location = new System.Drawing.Point(70, 2);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(285, 20);
            this.txtProveedor.TabIndex = 12;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.CustomFormat = "";
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(304, 23);
            this.dtpFechaHasta.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(180, 20);
            this.dtpFechaHasta.TabIndex = 13;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.CustomFormat = "";
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(53, 23);
            this.dtpFechaDesde.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(180, 20);
            this.dtpFechaDesde.TabIndex = 12;
            // 
            // lblFechaPublicacion
            // 
            this.lblFechaPublicacion.AutoSize = true;
            this.lblFechaPublicacion.Location = new System.Drawing.Point(6, 27);
            this.lblFechaPublicacion.Name = "lblFechaPublicacion";
            this.lblFechaPublicacion.Size = new System.Drawing.Size(41, 13);
            this.lblFechaPublicacion.TabIndex = 15;
            this.lblFechaPublicacion.Text = "Desde:";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(260, 27);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(38, 13);
            this.lblFechaVencimiento.TabIndex = 14;
            this.lblFechaVencimiento.Text = "Hasta:";
            // 
            // gbxPeriodo
            // 
            this.gbxPeriodo.Controls.Add(this.btnBuscar);
            this.gbxPeriodo.Controls.Add(this.lblFechaPublicacion);
            this.gbxPeriodo.Controls.Add(this.dtpFechaHasta);
            this.gbxPeriodo.Controls.Add(this.dtpFechaDesde);
            this.gbxPeriodo.Controls.Add(this.lblFechaVencimiento);
            this.gbxPeriodo.Location = new System.Drawing.Point(12, 43);
            this.gbxPeriodo.Name = "gbxPeriodo";
            this.gbxPeriodo.Size = new System.Drawing.Size(490, 82);
            this.gbxPeriodo.TabIndex = 16;
            this.gbxPeriodo.TabStop = false;
            this.gbxPeriodo.Text = "Período de facturación";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(9, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(475, 23);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gvwCompras
            // 
            this.gvwCompras.AllowUserToAddRows = false;
            this.gvwCompras.AllowUserToDeleteRows = false;
            this.gvwCompras.AllowUserToOrderColumns = true;
            this.gvwCompras.AllowUserToResizeColumns = false;
            this.gvwCompras.AllowUserToResizeRows = false;
            this.gvwCompras.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gvwCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvwCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvwCompras.Location = new System.Drawing.Point(11, 130);
            this.gvwCompras.Margin = new System.Windows.Forms.Padding(2);
            this.gvwCompras.MultiSelect = false;
            this.gvwCompras.Name = "gvwCompras";
            this.gvwCompras.ReadOnly = true;
            this.gvwCompras.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvwCompras.RowTemplate.Height = 24;
            this.gvwCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvwCompras.Size = new System.Drawing.Size(492, 227);
            this.gvwCompras.TabIndex = 17;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(12, 362);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(491, 23);
            this.btnFacturar.TabIndex = 18;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // FormFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 391);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.gvwCompras);
            this.Controls.Add(this.gbxPeriodo);
            this.Controls.Add(this.pnlAdministrador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormFacturar";
            this.Text = "FRBA Ofertas - Facturar a proveedor";
            this.pnlAdministrador.ResumeLayout(false);
            this.pnlAdministrador.PerformLayout();
            this.gbxPeriodo.ResumeLayout(false);
            this.gbxPeriodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAdministrador;
        private System.Windows.Forms.Button btnSeleccionarProveedor;
        private System.Windows.Forms.Label lblProveedor;
        public System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFechaPublicacion;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.GroupBox gbxPeriodo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView gvwCompras;
        private System.Windows.Forms.Button btnFacturar;
    }
}