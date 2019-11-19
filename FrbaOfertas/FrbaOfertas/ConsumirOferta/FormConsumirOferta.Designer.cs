namespace FrbaOfertas.ConsumirOferta
{
    partial class FormConsumirOferta
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
            this.lblOferta = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtOferta = new System.Windows.Forms.TextBox();
            this.gvwOfertas = new System.Windows.Forms.DataGridView();
            this.btnConsumir = new System.Windows.Forms.Button();
            this.gbxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwOfertas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.dtpFechaVencimiento);
            this.gbxFiltros.Controls.Add(this.lblVencimiento);
            this.gbxFiltros.Controls.Add(this.lblOferta);
            this.gbxFiltros.Controls.Add(this.btnLimpiar);
            this.gbxFiltros.Controls.Add(this.btnBuscar);
            this.gbxFiltros.Controls.Add(this.txtOferta);
            this.gbxFiltros.Location = new System.Drawing.Point(11, 11);
            this.gbxFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Padding = new System.Windows.Forms.Padding(2);
            this.gbxFiltros.Size = new System.Drawing.Size(618, 73);
            this.gbxFiltros.TabIndex = 5;
            this.gbxFiltros.TabStop = false;
            this.gbxFiltros.Text = "Filtros de búsqueda";
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.CustomFormat = "";
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(95, 46);
            this.dtpFechaVencimiento.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(329, 20);
            this.dtpFechaVencimiento.TabIndex = 11;
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Location = new System.Drawing.Point(5, 50);
            this.lblVencimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(85, 13);
            this.lblVencimiento.TabIndex = 6;
            this.lblVencimiento.Text = "Vence antes de:";
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
            this.btnLimpiar.Location = new System.Drawing.Point(428, 45);
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
            this.btnBuscar.Location = new System.Drawing.Point(428, 20);
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
            this.txtOferta.Size = new System.Drawing.Size(329, 20);
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
            this.gvwOfertas.Location = new System.Drawing.Point(11, 88);
            this.gvwOfertas.Margin = new System.Windows.Forms.Padding(2);
            this.gvwOfertas.MultiSelect = false;
            this.gvwOfertas.Name = "gvwOfertas";
            this.gvwOfertas.ReadOnly = true;
            this.gvwOfertas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvwOfertas.RowTemplate.Height = 24;
            this.gvwOfertas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvwOfertas.Size = new System.Drawing.Size(618, 282);
            this.gvwOfertas.TabIndex = 6;
            // 
            // btnConsumir
            // 
            this.btnConsumir.Location = new System.Drawing.Point(11, 382);
            this.btnConsumir.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsumir.Name = "btnConsumir";
            this.btnConsumir.Size = new System.Drawing.Size(618, 22);
            this.btnConsumir.TabIndex = 12;
            this.btnConsumir.Text = "Consumir";
            this.btnConsumir.UseVisualStyleBackColor = true;
            this.btnConsumir.Click += new System.EventHandler(this.btnConsumir_Click);
            // 
            // FormConsumirOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 413);
            this.Controls.Add(this.btnConsumir);
            this.Controls.Add(this.gvwOfertas);
            this.Controls.Add(this.gbxFiltros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormConsumirOferta";
            this.Text = "FRBA Ofertas - Consumir oferta";
            this.Load += new System.EventHandler(this.FormComprarOfertas_Load);
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwOfertas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFiltros;
        private System.Windows.Forms.Label lblOferta;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtOferta;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.DataGridView gvwOfertas;
        private System.Windows.Forms.Button btnConsumir;
    }
}