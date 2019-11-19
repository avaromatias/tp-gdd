namespace FrbaOfertas.ComprarOferta
{
    partial class FormComprarOfertas
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
            this.gbxFiltros = new System.Windows.Forms.GroupBox();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lblOferta = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtOferta = new System.Windows.Forms.TextBox();
            this.gvwOfertas = new System.Windows.Forms.DataGridView();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dudCantidad = new System.Windows.Forms.DomainUpDown();
            this.gbxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwOfertas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.dtpFechaVencimiento);
            this.gbxFiltros.Controls.Add(this.lblVencimiento);
            this.gbxFiltros.Controls.Add(this.lblProveedor);
            this.gbxFiltros.Controls.Add(this.txtProveedor);
            this.gbxFiltros.Controls.Add(this.lblOferta);
            this.gbxFiltros.Controls.Add(this.btnLimpiar);
            this.gbxFiltros.Controls.Add(this.btnBuscar);
            this.gbxFiltros.Controls.Add(this.txtOferta);
            this.gbxFiltros.Location = new System.Drawing.Point(11, 11);
            this.gbxFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Padding = new System.Windows.Forms.Padding(2);
            this.gbxFiltros.Size = new System.Drawing.Size(892, 98);
            this.gbxFiltros.TabIndex = 5;
            this.gbxFiltros.TabStop = false;
            this.gbxFiltros.Text = "Filtros de búsqueda";
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.CustomFormat = "";
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(95, 70);
            this.dtpFechaVencimiento.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(603, 20);
            this.dtpFechaVencimiento.TabIndex = 11;
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Location = new System.Drawing.Point(5, 74);
            this.lblVencimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(85, 13);
            this.lblVencimiento.TabIndex = 6;
            this.lblVencimiento.Text = "Vence antes de:";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(5, 48);
            this.lblProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(59, 13);
            this.lblProveedor.TabIndex = 5;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(95, 45);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(603, 20);
            this.txtProveedor.TabIndex = 4;
            // 
            // lblOferta
            // 
            this.lblOferta.AutoSize = true;
            this.lblOferta.Location = new System.Drawing.Point(5, 24);
            this.lblOferta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOferta.Name = "lblOferta";
            this.lblOferta.Size = new System.Drawing.Size(39, 13);
            this.lblOferta.TabIndex = 3;
            this.lblOferta.Text = "Oferta:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(703, 56);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(185, 22);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(703, 30);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(185, 22);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtOferta
            // 
            this.txtOferta.Location = new System.Drawing.Point(95, 21);
            this.txtOferta.Margin = new System.Windows.Forms.Padding(2);
            this.txtOferta.Name = "txtOferta";
            this.txtOferta.Size = new System.Drawing.Size(603, 20);
            this.txtOferta.TabIndex = 0;
            // 
            // gvwOfertas
            // 
            this.gvwOfertas.AllowUserToAddRows = false;
            this.gvwOfertas.AllowUserToDeleteRows = false;
            this.gvwOfertas.AllowUserToOrderColumns = true;
            this.gvwOfertas.AllowUserToResizeColumns = false;
            this.gvwOfertas.AllowUserToResizeRows = false;
            this.gvwOfertas.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gvwOfertas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvwOfertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvwOfertas.Location = new System.Drawing.Point(11, 113);
            this.gvwOfertas.Margin = new System.Windows.Forms.Padding(2);
            this.gvwOfertas.MultiSelect = false;
            this.gvwOfertas.Name = "gvwOfertas";
            this.gvwOfertas.ReadOnly = true;
            this.gvwOfertas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvwOfertas.RowTemplate.Height = 24;
            this.gvwOfertas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvwOfertas.Size = new System.Drawing.Size(892, 257);
            this.gvwOfertas.TabIndex = 6;
            this.gvwOfertas.MouseCaptureChanged += new System.EventHandler(this.gvwOfertas_MouseCaptureChanged);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(198, 382);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(2);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(705, 22);
            this.btnComprar.TabIndex = 12;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(16, 386);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 13;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // dudCantidad
            // 
            this.dudCantidad.Location = new System.Drawing.Point(73, 383);
            this.dudCantidad.Name = "dudCantidad";
            this.dudCantidad.Size = new System.Drawing.Size(120, 20);
            this.dudCantidad.TabIndex = 14;
            this.dudCantidad.Text = "1";
            this.dudCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dudCantidad_KeyPress);
            // 
            // FormComprarOfertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 413);
            this.Controls.Add(this.dudCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.gvwOfertas);
            this.Controls.Add(this.gbxFiltros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormComprarOfertas";
            this.Text = "FRBA Ofertas - Comprar ofertas";
            this.Load += new System.EventHandler(this.FormComprarOfertas_Load);
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwOfertas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFiltros;
        private System.Windows.Forms.Label lblOferta;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtOferta;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.DataGridView gvwOfertas;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DomainUpDown dudCantidad;
    }
}