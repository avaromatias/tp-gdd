namespace FrbaOfertas.CrearOferta
{
    partial class FormCrearOferta
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecioLista = new System.Windows.Forms.Label();
            this.txtPrecioLista = new System.Windows.Forms.TextBox();
            this.pnlProveedor = new System.Windows.Forms.Panel();
            this.lblHelpUnidadesMaximas = new System.Windows.Forms.Label();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaPublicacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPublicacion = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.lblUnidadesMaximas = new System.Windows.Forms.Label();
            this.txtUnidadesMaximas = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblPrecioOferta = new System.Windows.Forms.Label();
            this.txtPrecioOferta = new System.Windows.Forms.TextBox();
            this.pnlAdministrador = new System.Windows.Forms.Panel();
            this.btnSeleccionarProveedor = new System.Windows.Forms.Button();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.ttpFechaPublicacion = new System.Windows.Forms.ToolTip(this.components);
            this.btnCrearOferta = new System.Windows.Forms.Button();
            this.pnlProveedor.SuspendLayout();
            this.pnlAdministrador.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(126, 0);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(364, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(5, 3);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblPrecioLista
            // 
            this.lblPrecioLista.AutoSize = true;
            this.lblPrecioLista.Location = new System.Drawing.Point(5, 29);
            this.lblPrecioLista.Name = "lblPrecioLista";
            this.lblPrecioLista.Size = new System.Drawing.Size(76, 13);
            this.lblPrecioLista.TabIndex = 3;
            this.lblPrecioLista.Text = "Precio de lista:";
            // 
            // txtPrecioLista
            // 
            this.txtPrecioLista.Location = new System.Drawing.Point(126, 26);
            this.txtPrecioLista.Name = "txtPrecioLista";
            this.txtPrecioLista.Size = new System.Drawing.Size(364, 20);
            this.txtPrecioLista.TabIndex = 2;
            this.txtPrecioLista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioLista_KeyPress);
            // 
            // pnlProveedor
            // 
            this.pnlProveedor.Controls.Add(this.lblHelpUnidadesMaximas);
            this.pnlProveedor.Controls.Add(this.dtpFechaVencimiento);
            this.pnlProveedor.Controls.Add(this.dtpFechaPublicacion);
            this.pnlProveedor.Controls.Add(this.lblFechaPublicacion);
            this.pnlProveedor.Controls.Add(this.lblFechaVencimiento);
            this.pnlProveedor.Controls.Add(this.lblUnidadesMaximas);
            this.pnlProveedor.Controls.Add(this.txtUnidadesMaximas);
            this.pnlProveedor.Controls.Add(this.lblStock);
            this.pnlProveedor.Controls.Add(this.txtStock);
            this.pnlProveedor.Controls.Add(this.lblPrecioOferta);
            this.pnlProveedor.Controls.Add(this.txtPrecioOferta);
            this.pnlProveedor.Controls.Add(this.lblDescripcion);
            this.pnlProveedor.Controls.Add(this.lblPrecioLista);
            this.pnlProveedor.Controls.Add(this.txtDescripcion);
            this.pnlProveedor.Controls.Add(this.txtPrecioLista);
            this.pnlProveedor.Location = new System.Drawing.Point(12, 54);
            this.pnlProveedor.Name = "pnlProveedor";
            this.pnlProveedor.Size = new System.Drawing.Size(490, 178);
            this.pnlProveedor.TabIndex = 4;
            // 
            // lblHelpUnidadesMaximas
            // 
            this.lblHelpUnidadesMaximas.AutoSize = true;
            this.lblHelpUnidadesMaximas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblHelpUnidadesMaximas.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblHelpUnidadesMaximas.Location = new System.Drawing.Point(4, 102);
            this.lblHelpUnidadesMaximas.Name = "lblHelpUnidadesMaximas";
            this.lblHelpUnidadesMaximas.Size = new System.Drawing.Size(24, 22);
            this.lblHelpUnidadesMaximas.TabIndex = 14;
            this.lblHelpUnidadesMaximas.Text = "ⓘ";
            this.ttpFechaPublicacion.SetToolTip(this.lblHelpUnidadesMaximas, "Cantidad máxima de unidades que puede comprar un cliente.");
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.CustomFormat = "";
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(126, 156);
            this.dtpFechaVencimiento.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(364, 20);
            this.dtpFechaVencimiento.TabIndex = 7;
            // 
            // dtpFechaPublicacion
            // 
            this.dtpFechaPublicacion.CustomFormat = "";
            this.dtpFechaPublicacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPublicacion.Location = new System.Drawing.Point(126, 130);
            this.dtpFechaPublicacion.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpFechaPublicacion.Name = "dtpFechaPublicacion";
            this.dtpFechaPublicacion.Size = new System.Drawing.Size(364, 20);
            this.dtpFechaPublicacion.TabIndex = 6;
            // 
            // lblFechaPublicacion
            // 
            this.lblFechaPublicacion.AutoSize = true;
            this.lblFechaPublicacion.Location = new System.Drawing.Point(5, 133);
            this.lblFechaPublicacion.Name = "lblFechaPublicacion";
            this.lblFechaPublicacion.Size = new System.Drawing.Size(112, 13);
            this.lblFechaPublicacion.TabIndex = 11;
            this.lblFechaPublicacion.Text = "Fecha de publicación:";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(5, 160);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(115, 13);
            this.lblFechaVencimiento.TabIndex = 10;
            this.lblFechaVencimiento.Text = "Fecha de vencimiento:";
            // 
            // lblUnidadesMaximas
            // 
            this.lblUnidadesMaximas.AutoSize = true;
            this.lblUnidadesMaximas.Location = new System.Drawing.Point(24, 107);
            this.lblUnidadesMaximas.Name = "lblUnidadesMaximas";
            this.lblUnidadesMaximas.Size = new System.Drawing.Size(98, 13);
            this.lblUnidadesMaximas.TabIndex = 9;
            this.lblUnidadesMaximas.Text = "Unidades máximas:";
            // 
            // txtUnidadesMaximas
            // 
            this.txtUnidadesMaximas.Location = new System.Drawing.Point(126, 104);
            this.txtUnidadesMaximas.Name = "txtUnidadesMaximas";
            this.txtUnidadesMaximas.Size = new System.Drawing.Size(364, 20);
            this.txtUnidadesMaximas.TabIndex = 5;
            this.txtUnidadesMaximas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnidadesMaximas_KeyPress);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(5, 81);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(38, 13);
            this.lblStock.TabIndex = 7;
            this.lblStock.Text = "Stock:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(126, 78);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(364, 20);
            this.txtStock.TabIndex = 4;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // lblPrecioOferta
            // 
            this.lblPrecioOferta.AutoSize = true;
            this.lblPrecioOferta.Location = new System.Drawing.Point(5, 55);
            this.lblPrecioOferta.Name = "lblPrecioOferta";
            this.lblPrecioOferta.Size = new System.Drawing.Size(85, 13);
            this.lblPrecioOferta.TabIndex = 5;
            this.lblPrecioOferta.Text = "Precio de oferta:";
            // 
            // txtPrecioOferta
            // 
            this.txtPrecioOferta.Location = new System.Drawing.Point(126, 52);
            this.txtPrecioOferta.Name = "txtPrecioOferta";
            this.txtPrecioOferta.Size = new System.Drawing.Size(364, 20);
            this.txtPrecioOferta.TabIndex = 3;
            this.txtPrecioOferta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioOferta_KeyPress);
            // 
            // pnlAdministrador
            // 
            this.pnlAdministrador.Controls.Add(this.btnSeleccionarProveedor);
            this.pnlAdministrador.Controls.Add(this.lblProveedor);
            this.pnlAdministrador.Controls.Add(this.txtProveedor);
            this.pnlAdministrador.Location = new System.Drawing.Point(12, 12);
            this.pnlAdministrador.Name = "pnlAdministrador";
            this.pnlAdministrador.Size = new System.Drawing.Size(490, 25);
            this.pnlAdministrador.TabIndex = 5;
            // 
            // btnSeleccionarProveedor
            // 
            this.btnSeleccionarProveedor.Location = new System.Drawing.Point(361, 0);
            this.btnSeleccionarProveedor.Name = "btnSeleccionarProveedor";
            this.btnSeleccionarProveedor.Size = new System.Drawing.Size(129, 23);
            this.btnSeleccionarProveedor.TabIndex = 0;
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
            this.txtProveedor.Location = new System.Drawing.Point(126, 2);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(229, 20);
            this.txtProveedor.TabIndex = 9;
            // 
            // ttpFechaPublicacion
            // 
            this.ttpFechaPublicacion.AutoPopDelay = 5000;
            this.ttpFechaPublicacion.InitialDelay = 100;
            this.ttpFechaPublicacion.ReshowDelay = 100;
            // 
            // btnCrearOferta
            // 
            this.btnCrearOferta.Location = new System.Drawing.Point(12, 238);
            this.btnCrearOferta.Name = "btnCrearOferta";
            this.btnCrearOferta.Size = new System.Drawing.Size(490, 23);
            this.btnCrearOferta.TabIndex = 8;
            this.btnCrearOferta.Text = "Crear oferta";
            this.btnCrearOferta.UseVisualStyleBackColor = true;
            this.btnCrearOferta.Click += new System.EventHandler(this.btnCrearOferta_Click);
            // 
            // FormCrearOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 267);
            this.Controls.Add(this.btnCrearOferta);
            this.Controls.Add(this.pnlAdministrador);
            this.Controls.Add(this.pnlProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCrearOferta";
            this.Text = "FRBA Ofertas - Crear oferta";
            this.Load += new System.EventHandler(this.FormCrearOferta_Load);
            this.pnlProveedor.ResumeLayout(false);
            this.pnlProveedor.PerformLayout();
            this.pnlAdministrador.ResumeLayout(false);
            this.pnlAdministrador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecioLista;
        private System.Windows.Forms.TextBox txtPrecioLista;
        private System.Windows.Forms.Panel pnlProveedor;
        private System.Windows.Forms.Label lblFechaPublicacion;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.Label lblUnidadesMaximas;
        private System.Windows.Forms.TextBox txtUnidadesMaximas;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblPrecioOferta;
        private System.Windows.Forms.TextBox txtPrecioOferta;
        private System.Windows.Forms.Panel pnlAdministrador;
        private System.Windows.Forms.Button btnSeleccionarProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaPublicacion;
        private System.Windows.Forms.ToolTip ttpFechaPublicacion;
        private System.Windows.Forms.Label lblHelpUnidadesMaximas;
        private System.Windows.Forms.Button btnCrearOferta;
        public System.Windows.Forms.TextBox txtProveedor;
    }
}