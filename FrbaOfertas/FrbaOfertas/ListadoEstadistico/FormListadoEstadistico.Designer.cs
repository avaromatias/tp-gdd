namespace FrbaOfertas.ListadoEstadistico
{
    partial class FormListadoEstadistico
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxConsulta = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblA = new System.Windows.Forms.Label();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.cmbModos = new System.Windows.Forms.ComboBox();
            this.lblModo = new System.Windows.Forms.Label();
            this.gbxDescripcion = new System.Windows.Forms.GroupBox();
            this.gvwTop5 = new System.Windows.Forms.DataGridView();
            this.gbxConsulta.SuspendLayout();
            this.gbxDescripcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwTop5)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(6, 29);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(280, 13);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Esta pantalla permite visualizar un TOP 5 de proveedores:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "o Con mayor porcentaje de descuento ofrecido en sus ofertas\r\no Con mayor facturac" +
    "ión";
            // 
            // gbxConsulta
            // 
            this.gbxConsulta.Controls.Add(this.btnConsultar);
            this.gbxConsulta.Controls.Add(this.dtpFechaHasta);
            this.gbxConsulta.Controls.Add(this.lblA);
            this.gbxConsulta.Controls.Add(this.lblSemestre);
            this.gbxConsulta.Controls.Add(this.dtpFechaDesde);
            this.gbxConsulta.Controls.Add(this.cmbModos);
            this.gbxConsulta.Controls.Add(this.lblModo);
            this.gbxConsulta.Location = new System.Drawing.Point(12, 115);
            this.gbxConsulta.Name = "gbxConsulta";
            this.gbxConsulta.Size = new System.Drawing.Size(357, 100);
            this.gbxConsulta.TabIndex = 2;
            this.gbxConsulta.TabStop = false;
            this.gbxConsulta.Text = "Configuración del TOP 5";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(9, 70);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(342, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.CustomFormat = "MM/yyyy";
            this.dtpFechaHasta.Enabled = false;
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHasta.Location = new System.Drawing.Point(221, 44);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(130, 20);
            this.dtpFechaHasta.TabIndex = 2;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(203, 48);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(13, 13);
            this.lblA.TabIndex = 25;
            this.lblA.Text = "a";
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Location = new System.Drawing.Point(6, 48);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(54, 13);
            this.lblSemestre.TabIndex = 24;
            this.lblSemestre.Text = "Semestre:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.CustomFormat = "MM/yyyy";
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDesde.Location = new System.Drawing.Point(66, 44);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(130, 20);
            this.dtpFechaDesde.TabIndex = 1;
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.dtpFechaDesde_ValueChanged);
            // 
            // cmbModos
            // 
            this.cmbModos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModos.FormattingEnabled = true;
            this.cmbModos.Items.AddRange(new object[] {
            "Mayor porcentaje",
            "Mayor facturación"});
            this.cmbModos.Location = new System.Drawing.Point(66, 19);
            this.cmbModos.Name = "cmbModos";
            this.cmbModos.Size = new System.Drawing.Size(285, 21);
            this.cmbModos.TabIndex = 0;
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.Location = new System.Drawing.Point(6, 23);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(37, 13);
            this.lblModo.TabIndex = 0;
            this.lblModo.Text = "Modo:";
            // 
            // gbxDescripcion
            // 
            this.gbxDescripcion.Controls.Add(this.lblDescripcion);
            this.gbxDescripcion.Controls.Add(this.label1);
            this.gbxDescripcion.Location = new System.Drawing.Point(12, 9);
            this.gbxDescripcion.Name = "gbxDescripcion";
            this.gbxDescripcion.Size = new System.Drawing.Size(357, 100);
            this.gbxDescripcion.TabIndex = 3;
            this.gbxDescripcion.TabStop = false;
            this.gbxDescripcion.Text = "Descripción";
            // 
            // gvwTop5
            // 
            this.gvwTop5.AllowUserToAddRows = false;
            this.gvwTop5.AllowUserToDeleteRows = false;
            this.gvwTop5.AllowUserToResizeColumns = false;
            this.gvwTop5.AllowUserToResizeRows = false;
            this.gvwTop5.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gvwTop5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvwTop5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvwTop5.Location = new System.Drawing.Point(12, 220);
            this.gvwTop5.Margin = new System.Windows.Forms.Padding(2);
            this.gvwTop5.Name = "gvwTop5";
            this.gvwTop5.ReadOnly = true;
            this.gvwTop5.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvwTop5.RowTemplate.Height = 24;
            this.gvwTop5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvwTop5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvwTop5.Size = new System.Drawing.Size(358, 141);
            this.gvwTop5.TabIndex = 4;
            // 
            // FormListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 370);
            this.Controls.Add(this.gvwTop5);
            this.Controls.Add(this.gbxDescripcion);
            this.Controls.Add(this.gbxConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "FormListadoEstadistico";
            this.Text = "FRBA Ofertas - Listado estadístico";
            this.Load += new System.EventHandler(this.FormListadoEstadistico_Load);
            this.gbxConsulta.ResumeLayout(false);
            this.gbxConsulta.PerformLayout();
            this.gbxDescripcion.ResumeLayout(false);
            this.gbxDescripcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwTop5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxConsulta;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.ComboBox cmbModos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox gbxDescripcion;
        private System.Windows.Forms.DataGridView gvwTop5;
    }
}