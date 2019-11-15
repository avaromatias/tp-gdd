namespace FrbaOfertas
{
    partial class FormRegistrarUsuario
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblNombreApp = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.pnlClientes = new System.Windows.Forms.Panel();
            this.mtxtTelefonoCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtMailCliente = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.mtxtCP = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDni = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.lblMailCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlProveedores = new System.Windows.Forms.Panel();
            this.cmbRubros = new System.Windows.Forms.ComboBox();
            this.mtxtCuit = new System.Windows.Forms.MaskedTextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtMailProveedor = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRubro = new System.Windows.Forms.Label();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.mtxtTelefonoProveedor = new System.Windows.Forms.MaskedTextBox();
            this.lblCiudadProveedor = new System.Windows.Forms.Label();
            this.lblDireccionProveedor = new System.Windows.Forms.Label();
            this.lblTelefonoProveedor = new System.Windows.Forms.Label();
            this.txtDireccionProveedor = new System.Windows.Forms.TextBox();
            this.lblMailProveedor = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.pnlClientes.SuspendLayout();
            this.pnlProveedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(142, 62);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(167, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Tag = "";
            // 
            // lblNombreApp
            // 
            this.lblNombreApp.AutoSize = true;
            this.lblNombreApp.Font = new System.Drawing.Font("Lucida Console", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreApp.Location = new System.Drawing.Point(43, 20);
            this.lblNombreApp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreApp.Name = "lblNombreApp";
            this.lblNombreApp.Size = new System.Drawing.Size(250, 27);
            this.lblNombreApp.TabIndex = 1;
            this.lblNombreApp.Text = "Crea tu cuenta";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(27, 65);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(46, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Usuario:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(27, 88);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(142, 85);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(167, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Tag = "";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Location = new System.Drawing.Point(30, 516);
            this.btnCrearCuenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(279, 19);
            this.btnCrearCuenta.TabIndex = 19;
            this.btnCrearCuenta.Text = "Crear cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(27, 111);
            this.lblRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(26, 13);
            this.lblRol.TabIndex = 7;
            this.lblRol.Text = "Rol:";
            // 
            // cmbRoles
            // 
            this.cmbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(142, 108);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(167, 21);
            this.cmbRoles.TabIndex = 2;
            this.cmbRoles.SelectionChangeCommitted += new System.EventHandler(this.cmbRoles_SelectionChangeCommitted);
            // 
            // pnlClientes
            // 
            this.pnlClientes.Controls.Add(this.dtpFechaNacimiento);
            this.pnlClientes.Controls.Add(this.mtxtTelefonoCliente);
            this.pnlClientes.Controls.Add(this.txtMailCliente);
            this.pnlClientes.Controls.Add(this.txtApellido);
            this.pnlClientes.Controls.Add(this.txtNombreCliente);
            this.pnlClientes.Controls.Add(this.mtxtCP);
            this.pnlClientes.Controls.Add(this.mtxtDni);
            this.pnlClientes.Controls.Add(this.label3);
            this.pnlClientes.Controls.Add(this.label4);
            this.pnlClientes.Controls.Add(this.label5);
            this.pnlClientes.Controls.Add(this.label6);
            this.pnlClientes.Controls.Add(this.txtDireccionCliente);
            this.pnlClientes.Controls.Add(this.lblMailCliente);
            this.pnlClientes.Controls.Add(this.label2);
            this.pnlClientes.Controls.Add(this.lblApellido);
            this.pnlClientes.Controls.Add(this.lblNombre);
            this.pnlClientes.Location = new System.Drawing.Point(12, 131);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(316, 187);
            this.pnlClientes.TabIndex = 20;
            this.pnlClientes.Visible = false;
            // 
            // mtxtTelefonoCliente
            // 
            this.mtxtTelefonoCliente.AllowPromptAsInput = false;
            this.mtxtTelefonoCliente.HidePromptOnLeave = true;
            this.mtxtTelefonoCliente.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.mtxtTelefonoCliente.Location = new System.Drawing.Point(130, 93);
            this.mtxtTelefonoCliente.Mask = "99999999";
            this.mtxtTelefonoCliente.Name = "mtxtTelefonoCliente";
            this.mtxtTelefonoCliente.PromptChar = '#';
            this.mtxtTelefonoCliente.Size = new System.Drawing.Size(167, 20);
            this.mtxtTelefonoCliente.TabIndex = 7;
            this.mtxtTelefonoCliente.ValidatingType = typeof(int);
            // 
            // txtMailCliente
            // 
            this.txtMailCliente.Location = new System.Drawing.Point(130, 70);
            this.txtMailCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtMailCliente.Name = "txtMailCliente";
            this.txtMailCliente.Size = new System.Drawing.Size(167, 20);
            this.txtMailCliente.TabIndex = 6;
            this.txtMailCliente.Tag = "";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(130, 24);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(167, 20);
            this.txtApellido.TabIndex = 4;
            this.txtApellido.Tag = "";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(130, 1);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(167, 20);
            this.txtNombreCliente.TabIndex = 3;
            this.txtNombreCliente.Tag = "";
            // 
            // mtxtCP
            // 
            this.mtxtCP.AllowPromptAsInput = false;
            this.mtxtCP.HidePromptOnLeave = true;
            this.mtxtCP.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.mtxtCP.Location = new System.Drawing.Point(130, 139);
            this.mtxtCP.Mask = "9999";
            this.mtxtCP.Name = "mtxtCP";
            this.mtxtCP.PromptChar = '#';
            this.mtxtCP.Size = new System.Drawing.Size(167, 20);
            this.mtxtCP.TabIndex = 9;
            // 
            // mtxtDni
            // 
            this.mtxtDni.AllowPromptAsInput = false;
            this.mtxtDni.HidePromptOnLeave = true;
            this.mtxtDni.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.mtxtDni.Location = new System.Drawing.Point(130, 47);
            this.mtxtDni.Mask = "99999999";
            this.mtxtDni.Name = "mtxtDni";
            this.mtxtDni.PromptChar = '#';
            this.mtxtDni.Size = new System.Drawing.Size(167, 20);
            this.mtxtDni.TabIndex = 5;
            this.mtxtDni.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Fecha de nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Código Postal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Teléfono:";
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(130, 116);
            this.txtDireccionCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccionCliente.MaxLength = 255;
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(167, 20);
            this.txtDireccionCliente.TabIndex = 8;
            this.txtDireccionCliente.Tag = "";
            // 
            // lblMailCliente
            // 
            this.lblMailCliente.AutoSize = true;
            this.lblMailCliente.Location = new System.Drawing.Point(15, 73);
            this.lblMailCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMailCliente.Name = "lblMailCliente";
            this.lblMailCliente.Size = new System.Drawing.Size(29, 13);
            this.lblMailCliente.TabIndex = 17;
            this.lblMailCliente.Text = "Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "DNI:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(15, 27);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 13;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 4);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre:";
            // 
            // pnlProveedores
            // 
            this.pnlProveedores.Controls.Add(this.cmbRubros);
            this.pnlProveedores.Controls.Add(this.mtxtCuit);
            this.pnlProveedores.Controls.Add(this.txtCiudad);
            this.pnlProveedores.Controls.Add(this.txtMailProveedor);
            this.pnlProveedores.Controls.Add(this.txtRazonSocial);
            this.pnlProveedores.Controls.Add(this.label8);
            this.pnlProveedores.Controls.Add(this.lblRubro);
            this.pnlProveedores.Controls.Add(this.txtNombreProveedor);
            this.pnlProveedores.Controls.Add(this.lblCuit);
            this.pnlProveedores.Controls.Add(this.mtxtTelefonoProveedor);
            this.pnlProveedores.Controls.Add(this.lblCiudadProveedor);
            this.pnlProveedores.Controls.Add(this.lblDireccionProveedor);
            this.pnlProveedores.Controls.Add(this.lblTelefonoProveedor);
            this.pnlProveedores.Controls.Add(this.txtDireccionProveedor);
            this.pnlProveedores.Controls.Add(this.lblMailProveedor);
            this.pnlProveedores.Controls.Add(this.lblRazonSocial);
            this.pnlProveedores.Location = new System.Drawing.Point(12, 324);
            this.pnlProveedores.Name = "pnlProveedores";
            this.pnlProveedores.Size = new System.Drawing.Size(316, 187);
            this.pnlProveedores.TabIndex = 21;
            this.pnlProveedores.Visible = false;
            // 
            // cmbRubros
            // 
            this.cmbRubros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRubros.FormattingEnabled = true;
            this.cmbRubros.Location = new System.Drawing.Point(130, 139);
            this.cmbRubros.Name = "cmbRubros";
            this.cmbRubros.Size = new System.Drawing.Size(167, 21);
            this.cmbRubros.TabIndex = 22;
            // 
            // mtxtCuit
            // 
            this.mtxtCuit.AllowPromptAsInput = false;
            this.mtxtCuit.HidePromptOnLeave = true;
            this.mtxtCuit.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.mtxtCuit.Location = new System.Drawing.Point(130, 116);
            this.mtxtCuit.Mask = "99-99999999-9";
            this.mtxtCuit.Name = "mtxtCuit";
            this.mtxtCuit.PromptChar = '#';
            this.mtxtCuit.Size = new System.Drawing.Size(167, 20);
            this.mtxtCuit.TabIndex = 38;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(130, 93);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCiudad.MaxLength = 255;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(167, 20);
            this.txtCiudad.TabIndex = 37;
            this.txtCiudad.Tag = "";
            // 
            // txtMailProveedor
            // 
            this.txtMailProveedor.Location = new System.Drawing.Point(130, 24);
            this.txtMailProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtMailProveedor.Name = "txtMailProveedor";
            this.txtMailProveedor.Size = new System.Drawing.Size(167, 20);
            this.txtMailProveedor.TabIndex = 36;
            this.txtMailProveedor.Tag = "";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(130, 1);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(2);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(167, 20);
            this.txtRazonSocial.TabIndex = 11;
            this.txtRazonSocial.Tag = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 165);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Nombre de contacto:";
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Location = new System.Drawing.Point(15, 142);
            this.lblRubro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(39, 13);
            this.lblRubro.TabIndex = 33;
            this.lblRubro.Text = "Rubro:";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(130, 162);
            this.txtNombreProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreProveedor.MaxLength = 255;
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(167, 20);
            this.txtNombreProveedor.TabIndex = 18;
            this.txtNombreProveedor.Tag = "";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(15, 119);
            this.lblCuit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(35, 13);
            this.lblCuit.TabIndex = 32;
            this.lblCuit.Text = "CUIT:";
            // 
            // mtxtTelefonoProveedor
            // 
            this.mtxtTelefonoProveedor.AllowPromptAsInput = false;
            this.mtxtTelefonoProveedor.HidePromptOnLeave = true;
            this.mtxtTelefonoProveedor.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.mtxtTelefonoProveedor.Location = new System.Drawing.Point(130, 47);
            this.mtxtTelefonoProveedor.Mask = "99999999";
            this.mtxtTelefonoProveedor.Name = "mtxtTelefonoProveedor";
            this.mtxtTelefonoProveedor.PromptChar = '#';
            this.mtxtTelefonoProveedor.Size = new System.Drawing.Size(167, 20);
            this.mtxtTelefonoProveedor.TabIndex = 13;
            // 
            // lblCiudadProveedor
            // 
            this.lblCiudadProveedor.AutoSize = true;
            this.lblCiudadProveedor.Location = new System.Drawing.Point(15, 96);
            this.lblCiudadProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCiudadProveedor.Name = "lblCiudadProveedor";
            this.lblCiudadProveedor.Size = new System.Drawing.Size(43, 13);
            this.lblCiudadProveedor.TabIndex = 23;
            this.lblCiudadProveedor.Text = "Ciudad:";
            // 
            // lblDireccionProveedor
            // 
            this.lblDireccionProveedor.AutoSize = true;
            this.lblDireccionProveedor.Location = new System.Drawing.Point(15, 73);
            this.lblDireccionProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccionProveedor.Name = "lblDireccionProveedor";
            this.lblDireccionProveedor.Size = new System.Drawing.Size(55, 13);
            this.lblDireccionProveedor.TabIndex = 21;
            this.lblDireccionProveedor.Text = "Dirección:";
            // 
            // lblTelefonoProveedor
            // 
            this.lblTelefonoProveedor.AutoSize = true;
            this.lblTelefonoProveedor.Location = new System.Drawing.Point(15, 50);
            this.lblTelefonoProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefonoProveedor.Name = "lblTelefonoProveedor";
            this.lblTelefonoProveedor.Size = new System.Drawing.Size(52, 13);
            this.lblTelefonoProveedor.TabIndex = 19;
            this.lblTelefonoProveedor.Text = "Teléfono:";
            // 
            // txtDireccionProveedor
            // 
            this.txtDireccionProveedor.Location = new System.Drawing.Point(130, 70);
            this.txtDireccionProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccionProveedor.MaxLength = 255;
            this.txtDireccionProveedor.Name = "txtDireccionProveedor";
            this.txtDireccionProveedor.Size = new System.Drawing.Size(167, 20);
            this.txtDireccionProveedor.TabIndex = 14;
            this.txtDireccionProveedor.Tag = "";
            // 
            // lblMailProveedor
            // 
            this.lblMailProveedor.AutoSize = true;
            this.lblMailProveedor.Location = new System.Drawing.Point(15, 27);
            this.lblMailProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMailProveedor.Name = "lblMailProveedor";
            this.lblMailProveedor.Size = new System.Drawing.Size(29, 13);
            this.lblMailProveedor.TabIndex = 17;
            this.lblMailProveedor.Text = "Mail:";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(15, 4);
            this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(71, 13);
            this.lblRazonSocial.TabIndex = 11;
            this.lblRazonSocial.Text = "Razón social:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "";
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(130, 162);
            this.dtpFechaNacimiento.MaxDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(167, 20);
            this.dtpFechaNacimiento.TabIndex = 10;
            // 
            // FormRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 541);
            this.Controls.Add(this.pnlProveedores);
            this.Controls.Add(this.pnlClientes);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblNombreApp);
            this.Controls.Add(this.txtUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRegistrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRBA Ofertas - Registro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRegistrarUsuario_FormClosed);
            this.Load += new System.EventHandler(this.FormRegistrarUsuario_Load);
            this.pnlClientes.ResumeLayout(false);
            this.pnlClientes.PerformLayout();
            this.pnlProveedores.ResumeLayout(false);
            this.pnlProveedores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblNombreApp;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Panel pnlClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.Label lblMailCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.MaskedTextBox mtxtDni;
        private System.Windows.Forms.MaskedTextBox mtxtCP;
        private System.Windows.Forms.Panel pnlProveedores;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.MaskedTextBox mtxtTelefonoProveedor;
        private System.Windows.Forms.Label lblCiudadProveedor;
        private System.Windows.Forms.Label lblDireccionProveedor;
        private System.Windows.Forms.Label lblTelefonoProveedor;
        private System.Windows.Forms.TextBox txtDireccionProveedor;
        private System.Windows.Forms.Label lblMailProveedor;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtMailCliente;
        private System.Windows.Forms.MaskedTextBox mtxtTelefonoCliente;
        private System.Windows.Forms.MaskedTextBox mtxtCuit;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtMailProveedor;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.ComboBox cmbRubros;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;

    }
}

