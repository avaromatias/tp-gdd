namespace FrbaOfertas.AbmRol
{
    partial class FormAltaModificacionRol
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.lbxFuncionalidadesRol = new System.Windows.Forms.ListBox();
            this.lbxFuncionalidadesTodas = new System.Windows.Forms.ListBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblHabilitado = new System.Windows.Forms.Label();
            this.cmbHabilitado = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(9, 216);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(284, 24);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(298, 216);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(291, 24);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(9, 7);
            this.lblRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(47, 13);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "Nombre:";
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(60, 5);
            this.txtRol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(356, 20);
            this.txtRol.TabIndex = 0;
            // 
            // lbxFuncionalidadesRol
            // 
            this.lbxFuncionalidadesRol.FormattingEnabled = true;
            this.lbxFuncionalidadesRol.Location = new System.Drawing.Point(4, 16);
            this.lbxFuncionalidadesRol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxFuncionalidadesRol.Name = "lbxFuncionalidadesRol";
            this.lbxFuncionalidadesRol.Size = new System.Drawing.Size(254, 160);
            this.lbxFuncionalidadesRol.TabIndex = 4;
            // 
            // lbxFuncionalidadesTodas
            // 
            this.lbxFuncionalidadesTodas.FormattingEnabled = true;
            this.lbxFuncionalidadesTodas.Location = new System.Drawing.Point(4, 16);
            this.lbxFuncionalidadesTodas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxFuncionalidadesTodas.Name = "lbxFuncionalidadesTodas";
            this.lbxFuncionalidadesTodas.Size = new System.Drawing.Size(258, 160);
            this.lbxFuncionalidadesTodas.TabIndex = 5;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(277, 92);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(40, 24);
            this.btnQuitar.TabIndex = 6;
            this.btnQuitar.Text = ">";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(277, 121);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(40, 24);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "<";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxFuncionalidadesRol);
            this.groupBox1.Location = new System.Drawing.Point(9, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(262, 184);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionalidades del rol";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbxFuncionalidadesTodas);
            this.groupBox2.Location = new System.Drawing.Point(322, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(266, 184);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Otras funcionalidades";
            // 
            // lblHabilitado
            // 
            this.lblHabilitado.AutoSize = true;
            this.lblHabilitado.Location = new System.Drawing.Point(434, 8);
            this.lblHabilitado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHabilitado.Name = "lblHabilitado";
            this.lblHabilitado.Size = new System.Drawing.Size(57, 13);
            this.lblHabilitado.TabIndex = 10;
            this.lblHabilitado.Text = "Habilitado:";
            // 
            // cmbHabilitado
            // 
            this.cmbHabilitado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHabilitado.FormattingEnabled = true;
            this.cmbHabilitado.Items.AddRange(new object[] {
            "No",
            "Si"});
            this.cmbHabilitado.Location = new System.Drawing.Point(496, 5);
            this.cmbHabilitado.Name = "cmbHabilitado";
            this.cmbHabilitado.Size = new System.Drawing.Size(92, 21);
            this.cmbHabilitado.TabIndex = 11;
            // 
            // FormAltaModificacionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 245);
            this.Controls.Add(this.cmbHabilitado);
            this.Controls.Add(this.lblHabilitado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAltaModificacionRol";
            this.Text = "FRBA Ofertas - Modificar Rol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.ListBox lbxFuncionalidadesRol;
        private System.Windows.Forms.ListBox lbxFuncionalidadesTodas;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblHabilitado;
        private System.Windows.Forms.ComboBox cmbHabilitado;
    }
}