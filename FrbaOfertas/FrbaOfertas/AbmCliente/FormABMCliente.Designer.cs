namespace FrbaOfertas.AbmCliente
{
    partial class FormABMCliente
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
            this.nombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.acciones = new System.Windows.Forms.ComboBox();
            this.user = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.estadoCliente = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.ciudad = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.codigoPostal = new System.Windows.Forms.TextBox();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.filtro = new System.Windows.Forms.GroupBox();
            this.lblSrchApellido = new System.Windows.Forms.Label();
            this.srchApellido = new System.Windows.Forms.TextBox();
            this.lblSrchNombre = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.srchNombre = new System.Windows.Forms.TextBox();
            this.clientes = new System.Windows.Forms.ComboBox();
            this.lblSrchDni = new System.Windows.Forms.Label();
            this.srchBtn = new System.Windows.Forms.Button();
            this.srchDni = new System.Windows.Forms.TextBox();
            this.srchMail = new System.Windows.Forms.TextBox();
            this.lblSrchMail = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.filtro.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Enabled = false;
            this.nombre.Location = new System.Drawing.Point(69, 277);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(178, 20);
            this.nombre.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Enabled = false;
            this.lblNombre.Location = new System.Drawing.Point(19, 280);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // apellido
            // 
            this.apellido.Enabled = false;
            this.apellido.Location = new System.Drawing.Point(387, 277);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(178, 20);
            this.apellido.TabIndex = 8;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Enabled = false;
            this.lblApellido.Location = new System.Drawing.Point(337, 280);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido";
            // 
            // dni
            // 
            this.dni.Enabled = false;
            this.dni.Location = new System.Drawing.Point(387, 248);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(178, 20);
            this.dni.TabIndex = 10;
            this.dni.Leave += new System.EventHandler(this.dni_Leave);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Enabled = false;
            this.lblDni.Location = new System.Drawing.Point(355, 251);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 9;
            this.lblDni.Text = "DNI";
            this.lblDni.Click += new System.EventHandler(this.label5_Click);
            // 
            // mail
            // 
            this.mail.Enabled = false;
            this.mail.Location = new System.Drawing.Point(387, 303);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(178, 20);
            this.mail.TabIndex = 12;
            this.mail.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Enabled = false;
            this.lblMail.Location = new System.Drawing.Point(355, 306);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 11;
            this.lblMail.Text = "Mail";
            // 
            // telefono
            // 
            this.telefono.Enabled = false;
            this.telefono.Location = new System.Drawing.Point(69, 307);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(178, 20);
            this.telefono.TabIndex = 14;
            this.telefono.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Enabled = false;
            this.lblTelefono.Location = new System.Drawing.Point(14, 310);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 13;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Enabled = false;
            this.lblFecha.Location = new System.Drawing.Point(275, 336);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(106, 13);
            this.lblFecha.TabIndex = 15;
            this.lblFecha.Text = "Fecha de nacimiento";
            this.lblFecha.Click += new System.EventHandler(this.label8_Click);
            // 
            // fecha
            // 
            this.fecha.Enabled = false;
            this.fecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fecha.Location = new System.Drawing.Point(387, 330);
            this.fecha.MaxDate = new System.DateTime(3000, 11, 14, 0, 0, 0, 0);
            this.fecha.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(178, 20);
            this.fecha.TabIndex = 17;
            this.fecha.Value = new System.DateTime(2019, 11, 14, 0, 0, 0, 0);
            this.fecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // acciones
            // 
            this.acciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.acciones.FormattingEnabled = true;
            this.acciones.Items.AddRange(new object[] {
            "Modificar",
            "Crear"});
            this.acciones.Location = new System.Drawing.Point(224, 12);
            this.acciones.Name = "acciones";
            this.acciones.Size = new System.Drawing.Size(130, 21);
            this.acciones.TabIndex = 18;
            this.acciones.SelectedIndexChanged += new System.EventHandler(this.acciones_SelectedIndexChanged);
            // 
            // user
            // 
            this.user.Enabled = false;
            this.user.Location = new System.Drawing.Point(69, 244);
            this.user.Margin = new System.Windows.Forms.Padding(0);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(178, 20);
            this.user.TabIndex = 19;
            this.user.Leave += new System.EventHandler(this.username_Leave);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Enabled = false;
            this.lblUser.Location = new System.Drawing.Point(20, 247);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 13);
            this.lblUser.TabIndex = 20;
            this.lblUser.Text = "Usuario";
            this.lblUser.Click += new System.EventHandler(this.label9_Click);
            // 
            // estadoCliente
            // 
            this.estadoCliente.AutoSize = true;
            this.estadoCliente.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.estadoCliente.Enabled = false;
            this.estadoCliente.Location = new System.Drawing.Point(442, 229);
            this.estadoCliente.Name = "estadoCliente";
            this.estadoCliente.Size = new System.Drawing.Size(123, 17);
            this.estadoCliente.TabIndex = 21;
            this.estadoCliente.Text = "Cliente deshabilitado";
            this.estadoCliente.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(260, 401);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 23;
            this.saveBtn.Text = "Guardar";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // ciudad
            // 
            this.ciudad.Enabled = false;
            this.ciudad.Location = new System.Drawing.Point(69, 359);
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(178, 20);
            this.ciudad.TabIndex = 27;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Enabled = false;
            this.lblCiudad.Location = new System.Drawing.Point(14, 362);
            this.lblCiudad.Margin = new System.Windows.Forms.Padding(0);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 26;
            this.lblCiudad.Text = "Ciudad";
            // 
            // direccion
            // 
            this.direccion.Enabled = false;
            this.direccion.Location = new System.Drawing.Point(69, 333);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(178, 20);
            this.direccion.TabIndex = 25;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Enabled = false;
            this.lblDireccion.Location = new System.Drawing.Point(11, 336);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 24;
            this.lblDireccion.Text = "Dirección";
            this.lblDireccion.Click += new System.EventHandler(this.label2_Click);
            // 
            // codigoPostal
            // 
            this.codigoPostal.Enabled = false;
            this.codigoPostal.Location = new System.Drawing.Point(387, 359);
            this.codigoPostal.Name = "codigoPostal";
            this.codigoPostal.Size = new System.Drawing.Size(178, 20);
            this.codigoPostal.TabIndex = 29;
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Enabled = false;
            this.lblCodigoPostal.Location = new System.Drawing.Point(310, 362);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(71, 13);
            this.lblCodigoPostal.TabIndex = 28;
            this.lblCodigoPostal.Text = "Código postal";
            // 
            // filtro
            // 
            this.filtro.Controls.Add(this.lblSrchApellido);
            this.filtro.Controls.Add(this.srchApellido);
            this.filtro.Controls.Add(this.lblSrchNombre);
            this.filtro.Controls.Add(this.lblClientes);
            this.filtro.Controls.Add(this.srchNombre);
            this.filtro.Controls.Add(this.clientes);
            this.filtro.Controls.Add(this.lblSrchDni);
            this.filtro.Controls.Add(this.srchBtn);
            this.filtro.Controls.Add(this.srchDni);
            this.filtro.Controls.Add(this.srchMail);
            this.filtro.Controls.Add(this.lblSrchMail);
            this.filtro.Location = new System.Drawing.Point(15, 49);
            this.filtro.Name = "filtro";
            this.filtro.Size = new System.Drawing.Size(550, 169);
            this.filtro.TabIndex = 56;
            this.filtro.TabStop = false;
            this.filtro.Text = "Buscar cliente";
            // 
            // lblSrchApellido
            // 
            this.lblSrchApellido.AutoSize = true;
            this.lblSrchApellido.Location = new System.Drawing.Point(295, 27);
            this.lblSrchApellido.Name = "lblSrchApellido";
            this.lblSrchApellido.Size = new System.Drawing.Size(44, 13);
            this.lblSrchApellido.TabIndex = 67;
            this.lblSrchApellido.Text = "Apellido";
            // 
            // srchApellido
            // 
            this.srchApellido.Location = new System.Drawing.Point(345, 24);
            this.srchApellido.Name = "srchApellido";
            this.srchApellido.Size = new System.Drawing.Size(191, 20);
            this.srchApellido.TabIndex = 66;
            // 
            // lblSrchNombre
            // 
            this.lblSrchNombre.AutoSize = true;
            this.lblSrchNombre.Location = new System.Drawing.Point(6, 27);
            this.lblSrchNombre.Name = "lblSrchNombre";
            this.lblSrchNombre.Size = new System.Drawing.Size(44, 13);
            this.lblSrchNombre.TabIndex = 56;
            this.lblSrchNombre.Text = "Nombre";
            this.lblSrchNombre.Click += new System.EventHandler(this.lblSrchRazonSocial_Click);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Location = new System.Drawing.Point(71, 137);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(134, 13);
            this.lblClientes.TabIndex = 64;
            this.lblClientes.Text = "Clientes encontrados (DNI)";
            this.lblClientes.Click += new System.EventHandler(this.lblProveedores_Click);
            // 
            // srchNombre
            // 
            this.srchNombre.Location = new System.Drawing.Point(56, 24);
            this.srchNombre.Name = "srchNombre";
            this.srchNombre.Size = new System.Drawing.Size(191, 20);
            this.srchNombre.TabIndex = 57;
            // 
            // clientes
            // 
            this.clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientes.FormattingEnabled = true;
            this.clientes.Location = new System.Drawing.Point(211, 134);
            this.clientes.Name = "clientes";
            this.clientes.Size = new System.Drawing.Size(156, 21);
            this.clientes.TabIndex = 63;
            this.clientes.SelectedIndexChanged += new System.EventHandler(this.seleccionarCliente);
            // 
            // lblSrchDni
            // 
            this.lblSrchDni.AutoSize = true;
            this.lblSrchDni.Location = new System.Drawing.Point(24, 53);
            this.lblSrchDni.Name = "lblSrchDni";
            this.lblSrchDni.Size = new System.Drawing.Size(26, 13);
            this.lblSrchDni.TabIndex = 58;
            this.lblSrchDni.Text = "DNI";
            this.lblSrchDni.Click += new System.EventHandler(this.lblSrchCuit_Click);
            // 
            // srchBtn
            // 
            this.srchBtn.Location = new System.Drawing.Point(245, 95);
            this.srchBtn.Name = "srchBtn";
            this.srchBtn.Size = new System.Drawing.Size(81, 23);
            this.srchBtn.TabIndex = 62;
            this.srchBtn.Text = "Buscar";
            this.srchBtn.UseVisualStyleBackColor = true;
            this.srchBtn.Click += new System.EventHandler(this.cargarClientes);
            // 
            // srchDni
            // 
            this.srchDni.Location = new System.Drawing.Point(56, 50);
            this.srchDni.Name = "srchDni";
            this.srchDni.Size = new System.Drawing.Size(191, 20);
            this.srchDni.TabIndex = 59;
            // 
            // srchMail
            // 
            this.srchMail.Location = new System.Drawing.Point(345, 53);
            this.srchMail.Name = "srchMail";
            this.srchMail.Size = new System.Drawing.Size(191, 20);
            this.srchMail.TabIndex = 61;
            // 
            // lblSrchMail
            // 
            this.lblSrchMail.AutoSize = true;
            this.lblSrchMail.Location = new System.Drawing.Point(313, 56);
            this.lblSrchMail.Name = "lblSrchMail";
            this.lblSrchMail.Size = new System.Drawing.Size(26, 13);
            this.lblSrchMail.TabIndex = 60;
            this.lblSrchMail.Text = "Mail";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 57;
            this.button1.Text = "Limpiar campos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.limpiarCampos);
            // 
            // FormABMCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 432);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filtro);
            this.Controls.Add(this.codigoPostal);
            this.Controls.Add(this.lblCodigoPostal);
            this.Controls.Add(this.ciudad);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.estadoCliente);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.user);
            this.Controls.Add(this.acciones);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormABMCliente";
            this.Text = "ABM Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.filtro.ResumeLayout(false);
            this.filtro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.ComboBox acciones;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.CheckBox estadoCliente;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox ciudad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox codigoPostal;
        private System.Windows.Forms.Label lblCodigoPostal;
        private System.Windows.Forms.GroupBox filtro;
        private System.Windows.Forms.TextBox srchApellido;
        private System.Windows.Forms.Label lblSrchNombre;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.TextBox srchNombre;
        private System.Windows.Forms.ComboBox clientes;
        private System.Windows.Forms.Label lblSrchDni;
        private System.Windows.Forms.Button srchBtn;
        private System.Windows.Forms.TextBox srchDni;
        private System.Windows.Forms.TextBox srchMail;
        private System.Windows.Forms.Label lblSrchMail;
        private System.Windows.Forms.Label lblSrchApellido;
        private System.Windows.Forms.Button button1;

    }
}