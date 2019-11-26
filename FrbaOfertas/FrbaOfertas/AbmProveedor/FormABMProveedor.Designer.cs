namespace FrbaOfertas.AbmProveedor
{
    partial class FormABMProveedor
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
            this.codigoPostal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ciudad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.estadoProveedor = new System.Windows.Forms.CheckBox();
            this.lblSearchUser = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.acciones = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cuit = new System.Windows.Forms.TextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.contacto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.razonSocial = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.rubros = new System.Windows.Forms.ComboBox();
            this.filtro = new System.Windows.Forms.GroupBox();
            this.lblSrchRazonSocial = new System.Windows.Forms.Label();
            this.lblProveedores = new System.Windows.Forms.Label();
            this.srchRazonSocial = new System.Windows.Forms.TextBox();
            this.proveedores = new System.Windows.Forms.ComboBox();
            this.lblSrchCuit = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.srchCuit = new System.Windows.Forms.TextBox();
            this.srchMail = new System.Windows.Forms.TextBox();
            this.lblSrchMail = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.filtro.SuspendLayout();
            this.SuspendLayout();
            // 
            // codigoPostal
            // 
            this.codigoPostal.Location = new System.Drawing.Point(388, 279);
            this.codigoPostal.Name = "codigoPostal";
            this.codigoPostal.Size = new System.Drawing.Size(178, 20);
            this.codigoPostal.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Contacto";
            // 
            // ciudad
            // 
            this.ciudad.Location = new System.Drawing.Point(388, 331);
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(178, 20);
            this.ciudad.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 334);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Ciudad";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(86, 331);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(178, 20);
            this.direccion.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Dirección";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(261, 374);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 47;
            this.saveBtn.Text = "Guardar";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // estadoProveedor
            // 
            this.estadoProveedor.AutoSize = true;
            this.estadoProveedor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.estadoProveedor.Location = new System.Drawing.Point(426, 198);
            this.estadoProveedor.Name = "estadoProveedor";
            this.estadoProveedor.Size = new System.Drawing.Size(140, 17);
            this.estadoProveedor.TabIndex = 45;
            this.estadoProveedor.Text = "Proveedor deshabilitado";
            this.estadoProveedor.UseVisualStyleBackColor = true;
            // 
            // lblSearchUser
            // 
            this.lblSearchUser.AutoSize = true;
            this.lblSearchUser.Location = new System.Drawing.Point(37, 224);
            this.lblSearchUser.Name = "lblSearchUser";
            this.lblSearchUser.Size = new System.Drawing.Size(43, 13);
            this.lblSearchUser.TabIndex = 44;
            this.lblSearchUser.Text = "Usuario";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(86, 220);
            this.user.Margin = new System.Windows.Forms.Padding(0);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(178, 20);
            this.user.TabIndex = 43;
            this.user.Leave += new System.EventHandler(this.usuarioDisponible);
            // 
            // acciones
            // 
            this.acciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.acciones.FormattingEnabled = true;
            this.acciones.Items.AddRange(new object[] {
            "Modificar",
            "Crear"});
            this.acciones.Location = new System.Drawing.Point(250, 12);
            this.acciones.Name = "acciones";
            this.acciones.Size = new System.Drawing.Size(130, 21);
            this.acciones.TabIndex = 42;
            this.acciones.SelectedValueChanged += new System.EventHandler(this.acciones_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "´Código postal";
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(86, 305);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(178, 20);
            this.telefono.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 308);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Teléfono";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(388, 249);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(178, 20);
            this.mail.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Mail";
            // 
            // cuit
            // 
            this.cuit.Location = new System.Drawing.Point(86, 279);
            this.cuit.Name = "cuit";
            this.cuit.Size = new System.Drawing.Size(178, 20);
            this.cuit.TabIndex = 35;
            this.cuit.Leave += new System.EventHandler(this.cuit_Leave);
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(48, 282);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(32, 13);
            this.lblCuit.TabIndex = 34;
            this.lblCuit.Text = "CUIT";
            // 
            // contacto
            // 
            this.contacto.Location = new System.Drawing.Point(388, 305);
            this.contacto.Name = "contacto";
            this.contacto.Size = new System.Drawing.Size(178, 20);
            this.contacto.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Rubro";
            // 
            // razonSocial
            // 
            this.razonSocial.Location = new System.Drawing.Point(86, 249);
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.Size = new System.Drawing.Size(178, 20);
            this.razonSocial.TabIndex = 31;
            this.razonSocial.Leave += new System.EventHandler(this.cuit_Leave);
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(12, 252);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(68, 13);
            this.lblRazonSocial.TabIndex = 30;
            this.lblRazonSocial.Text = "Razón social";
            // 
            // rubros
            // 
            this.rubros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rubros.FormattingEnabled = true;
            this.rubros.Items.AddRange(new object[] {
            "Modificar",
            "Crear"});
            this.rubros.Location = new System.Drawing.Point(388, 220);
            this.rubros.Name = "rubros";
            this.rubros.Size = new System.Drawing.Size(178, 21);
            this.rubros.TabIndex = 54;
            // 
            // filtro
            // 
            this.filtro.Controls.Add(this.lblSrchRazonSocial);
            this.filtro.Controls.Add(this.lblProveedores);
            this.filtro.Controls.Add(this.srchRazonSocial);
            this.filtro.Controls.Add(this.proveedores);
            this.filtro.Controls.Add(this.lblSrchCuit);
            this.filtro.Controls.Add(this.searchBtn);
            this.filtro.Controls.Add(this.srchCuit);
            this.filtro.Controls.Add(this.srchMail);
            this.filtro.Controls.Add(this.lblSrchMail);
            this.filtro.Location = new System.Drawing.Point(16, 55);
            this.filtro.Name = "filtro";
            this.filtro.Size = new System.Drawing.Size(550, 137);
            this.filtro.TabIndex = 55;
            this.filtro.TabStop = false;
            this.filtro.Text = "Buscar proveedor";
            // 
            // lblSrchRazonSocial
            // 
            this.lblSrchRazonSocial.AutoSize = true;
            this.lblSrchRazonSocial.Location = new System.Drawing.Point(6, 27);
            this.lblSrchRazonSocial.Name = "lblSrchRazonSocial";
            this.lblSrchRazonSocial.Size = new System.Drawing.Size(68, 13);
            this.lblSrchRazonSocial.TabIndex = 56;
            this.lblSrchRazonSocial.Text = "Razón social";
            // 
            // lblProveedores
            // 
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.Location = new System.Drawing.Point(209, 93);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(129, 13);
            this.lblProveedores.TabIndex = 64;
            this.lblProveedores.Text = "Proveedores encontrados";
            // 
            // srchRazonSocial
            // 
            this.srchRazonSocial.Location = new System.Drawing.Point(89, 24);
            this.srchRazonSocial.Name = "srchRazonSocial";
            this.srchRazonSocial.Size = new System.Drawing.Size(191, 20);
            this.srchRazonSocial.TabIndex = 57;
            // 
            // proveedores
            // 
            this.proveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.proveedores.FormattingEnabled = true;
            this.proveedores.Location = new System.Drawing.Point(197, 109);
            this.proveedores.Name = "proveedores";
            this.proveedores.Size = new System.Drawing.Size(156, 21);
            this.proveedores.TabIndex = 63;
            this.proveedores.SelectedIndexChanged += new System.EventHandler(this.seleccionarProveedor);
            // 
            // lblSrchCuit
            // 
            this.lblSrchCuit.AutoSize = true;
            this.lblSrchCuit.Location = new System.Drawing.Point(42, 53);
            this.lblSrchCuit.Name = "lblSrchCuit";
            this.lblSrchCuit.Size = new System.Drawing.Size(32, 13);
            this.lblSrchCuit.TabIndex = 58;
            this.lblSrchCuit.Text = "CUIT";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(344, 48);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(191, 23);
            this.searchBtn.TabIndex = 62;
            this.searchBtn.Text = "Buscar";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.cargarProveedores);
            // 
            // srchCuit
            // 
            this.srchCuit.Location = new System.Drawing.Point(89, 50);
            this.srchCuit.Name = "srchCuit";
            this.srchCuit.Size = new System.Drawing.Size(191, 20);
            this.srchCuit.TabIndex = 59;
            // 
            // srchMail
            // 
            this.srchMail.Location = new System.Drawing.Point(344, 24);
            this.srchMail.Name = "srchMail";
            this.srchMail.Size = new System.Drawing.Size(191, 20);
            this.srchMail.TabIndex = 61;
            // 
            // lblSrchMail
            // 
            this.lblSrchMail.AutoSize = true;
            this.lblSrchMail.Location = new System.Drawing.Point(312, 27);
            this.lblSrchMail.Name = "lblSrchMail";
            this.lblSrchMail.Size = new System.Drawing.Size(26, 13);
            this.lblSrchMail.TabIndex = 60;
            this.lblSrchMail.Text = "Mail";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 58;
            this.button1.Text = "Limpiar campos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.limpiarCampos);
            // 
            // FormABMProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(592, 408);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filtro);
            this.Controls.Add(this.rubros);
            this.Controls.Add(this.codigoPostal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ciudad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.estadoProveedor);
            this.Controls.Add(this.lblSearchUser);
            this.Controls.Add(this.user);
            this.Controls.Add(this.acciones);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cuit);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.contacto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.razonSocial);
            this.Controls.Add(this.lblRazonSocial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormABMProveedor";
            this.Text = "ABM Proveedores";
            this.filtro.ResumeLayout(false);
            this.filtro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codigoPostal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ciudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.CheckBox estadoProveedor;
        private System.Windows.Forms.Label lblSearchUser;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.ComboBox acciones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cuit;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.TextBox contacto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox razonSocial;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.ComboBox rubros;
        private System.Windows.Forms.GroupBox filtro;
        private System.Windows.Forms.Label lblSrchRazonSocial;
        private System.Windows.Forms.TextBox srchRazonSocial;
        private System.Windows.Forms.ComboBox proveedores;
        private System.Windows.Forms.Label lblSrchCuit;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox srchCuit;
        private System.Windows.Forms.TextBox srchMail;
        private System.Windows.Forms.Label lblSrchMail;
        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.Button button1;


    }
}