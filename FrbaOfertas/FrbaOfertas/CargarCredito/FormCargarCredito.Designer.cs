namespace FrbaOfertas
{
    partial class FormCargarCredito
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
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.cmbTiposPago = new System.Windows.Forms.ComboBox();
            this.pnlTarjeta = new System.Windows.Forms.Panel();
            this.cmbTarjetas = new System.Windows.Forms.ComboBox();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.lblDatosTarjeta = new System.Windows.Forms.Label();
            this.txtVencimientoTarjeta = new System.Windows.Forms.TextBox();
            this.txtNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.lblVencimientoTarjeta = new System.Windows.Forms.Label();
            this.lblNumeroTarjeta = new System.Windows.Forms.Label();
            this.pnlTarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(100, 6);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.ShortcutsEnabled = false;
            this.txtMonto.Size = new System.Drawing.Size(205, 20);
            this.txtMonto.TabIndex = 0;
            this.txtMonto.Tag = "";
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(23, 9);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 2;
            this.lblMonto.Text = "Monto:";
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Location = new System.Drawing.Point(23, 33);
            this.lblTipoPago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(73, 13);
            this.lblTipoPago.TabIndex = 4;
            this.lblTipoPago.Text = "Tipo de pago:";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(26, 178);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(279, 25);
            this.btnCargar.TabIndex = 5;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // cmbTiposPago
            // 
            this.cmbTiposPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTiposPago.FormattingEnabled = true;
            this.cmbTiposPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de crédito",
            "Tarjeta de débito"});
            this.cmbTiposPago.Location = new System.Drawing.Point(100, 30);
            this.cmbTiposPago.Name = "cmbTiposPago";
            this.cmbTiposPago.Size = new System.Drawing.Size(205, 21);
            this.cmbTiposPago.TabIndex = 6;
            this.cmbTiposPago.SelectionChangeCommitted += new System.EventHandler(this.cmbTiposPago_SelectionChangeCommitted);
            // 
            // pnlTarjeta
            // 
            this.pnlTarjeta.Controls.Add(this.cmbTarjetas);
            this.pnlTarjeta.Controls.Add(this.lblTarjeta);
            this.pnlTarjeta.Controls.Add(this.lblDatosTarjeta);
            this.pnlTarjeta.Controls.Add(this.txtVencimientoTarjeta);
            this.pnlTarjeta.Controls.Add(this.txtNumeroTarjeta);
            this.pnlTarjeta.Controls.Add(this.lblVencimientoTarjeta);
            this.pnlTarjeta.Controls.Add(this.lblNumeroTarjeta);
            this.pnlTarjeta.Location = new System.Drawing.Point(8, 57);
            this.pnlTarjeta.Name = "pnlTarjeta";
            this.pnlTarjeta.Size = new System.Drawing.Size(316, 116);
            this.pnlTarjeta.TabIndex = 21;
            this.pnlTarjeta.Visible = false;
            // 
            // cmbTarjetas
            // 
            this.cmbTarjetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarjetas.FormattingEnabled = true;
            this.cmbTarjetas.Location = new System.Drawing.Point(92, 1);
            this.cmbTarjetas.Name = "cmbTarjetas";
            this.cmbTarjetas.Size = new System.Drawing.Size(205, 21);
            this.cmbTarjetas.TabIndex = 16;
            this.cmbTarjetas.SelectionChangeCommitted += new System.EventHandler(this.cmbTarjetas_SelectionChangeCommitted);
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Location = new System.Drawing.Point(15, 4);
            this.lblTarjeta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(43, 13);
            this.lblTarjeta.TabIndex = 15;
            this.lblTarjeta.Text = "Tarjeta:";
            // 
            // lblDatosTarjeta
            // 
            this.lblDatosTarjeta.AutoSize = true;
            this.lblDatosTarjeta.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold);
            this.lblDatosTarjeta.Location = new System.Drawing.Point(11, 35);
            this.lblDatosTarjeta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatosTarjeta.Name = "lblDatosTarjeta";
            this.lblDatosTarjeta.Size = new System.Drawing.Size(295, 24);
            this.lblDatosTarjeta.TabIndex = 14;
            this.lblDatosTarjeta.Text = "Datos de la tarjeta";
            // 
            // txtVencimientoTarjeta
            // 
            this.txtVencimientoTarjeta.Enabled = false;
            this.txtVencimientoTarjeta.Location = new System.Drawing.Point(92, 94);
            this.txtVencimientoTarjeta.Margin = new System.Windows.Forms.Padding(2);
            this.txtVencimientoTarjeta.Name = "txtVencimientoTarjeta";
            this.txtVencimientoTarjeta.Size = new System.Drawing.Size(205, 20);
            this.txtVencimientoTarjeta.TabIndex = 4;
            this.txtVencimientoTarjeta.Tag = "";
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.Enabled = false;
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(92, 70);
            this.txtNumeroTarjeta.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(205, 20);
            this.txtNumeroTarjeta.TabIndex = 3;
            this.txtNumeroTarjeta.Tag = "";
            // 
            // lblVencimientoTarjeta
            // 
            this.lblVencimientoTarjeta.AutoSize = true;
            this.lblVencimientoTarjeta.Location = new System.Drawing.Point(15, 97);
            this.lblVencimientoTarjeta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVencimientoTarjeta.Name = "lblVencimientoTarjeta";
            this.lblVencimientoTarjeta.Size = new System.Drawing.Size(68, 13);
            this.lblVencimientoTarjeta.TabIndex = 13;
            this.lblVencimientoTarjeta.Text = "Vencimiento:";
            // 
            // lblNumeroTarjeta
            // 
            this.lblNumeroTarjeta.AutoSize = true;
            this.lblNumeroTarjeta.Location = new System.Drawing.Point(15, 73);
            this.lblNumeroTarjeta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroTarjeta.Name = "lblNumeroTarjeta";
            this.lblNumeroTarjeta.Size = new System.Drawing.Size(47, 13);
            this.lblNumeroTarjeta.TabIndex = 11;
            this.lblNumeroTarjeta.Text = "Número:";
            // 
            // FormCargarCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 208);
            this.Controls.Add(this.pnlTarjeta);
            this.Controls.Add(this.cmbTiposPago);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblTipoPago);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.txtMonto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCargarCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRBA Ofertas - Cargar crédito";
            this.Load += new System.EventHandler(this.FormCargarCredito_Load);
            this.pnlTarjeta.ResumeLayout(false);
            this.pnlTarjeta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ComboBox cmbTiposPago;
        private System.Windows.Forms.Panel pnlTarjeta;
        private System.Windows.Forms.TextBox txtVencimientoTarjeta;
        private System.Windows.Forms.TextBox txtNumeroTarjeta;
        private System.Windows.Forms.Label lblVencimientoTarjeta;
        private System.Windows.Forms.Label lblNumeroTarjeta;
        private System.Windows.Forms.ComboBox cmbTarjetas;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.Label lblDatosTarjeta;

    }
}

