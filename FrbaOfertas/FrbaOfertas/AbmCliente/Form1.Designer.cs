namespace FrbaOfertas.AbmCliente
{
    partial class AbmCliente
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
            this.label3 = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.acciones = new System.Windows.Forms.ComboBox();
            this.user = new System.Windows.Forms.TextBox();
            this.lblSearchUser = new System.Windows.Forms.Label();
            this.estadoCliente = new System.Windows.Forms.CheckBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.ciudad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codigoPostal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(62, 137);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(178, 20);
            this.nombre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(380, 137);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(178, 20);
            this.apellido.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellido";
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(62, 166);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(178, 20);
            this.dni.TabIndex = 10;
            this.dni.Leave += new System.EventHandler(this.dni_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "DNI";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(380, 169);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(178, 20);
            this.mail.TabIndex = 12;
            this.mail.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mail";
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(62, 192);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(178, 20);
            this.telefono.TabIndex = 14;
            this.telefono.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 195);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Teléfono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fecha de nacimiento";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // fecha
            // 
            this.fecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fecha.Location = new System.Drawing.Point(380, 195);
            this.fecha.MaxDate = new System.DateTime(2019, 11, 14, 0, 0, 0, 0);
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
            this.acciones.Location = new System.Drawing.Point(244, 27);
            this.acciones.Name = "acciones";
            this.acciones.Size = new System.Drawing.Size(130, 21);
            this.acciones.TabIndex = 18;
            this.acciones.SelectedIndexChanged += new System.EventHandler(this.acciones_SelectedIndexChanged);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(199, 74);
            this.user.Margin = new System.Windows.Forms.Padding(0);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(185, 20);
            this.user.TabIndex = 19;
            this.user.Enter += new System.EventHandler(this.searchBtn_Click);
            // 
            // lblSearchUser
            // 
            this.lblSearchUser.AutoSize = true;
            this.lblSearchUser.Location = new System.Drawing.Point(153, 77);
            this.lblSearchUser.Name = "lblSearchUser";
            this.lblSearchUser.Size = new System.Drawing.Size(43, 13);
            this.lblSearchUser.TabIndex = 20;
            this.lblSearchUser.Text = "Usuario";
            this.lblSearchUser.Click += new System.EventHandler(this.label9_Click);
            // 
            // estadoCliente
            // 
            this.estadoCliente.AutoSize = true;
            this.estadoCliente.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.estadoCliente.Location = new System.Drawing.Point(435, 114);
            this.estadoCliente.Name = "estadoCliente";
            this.estadoCliente.Size = new System.Drawing.Size(123, 17);
            this.estadoCliente.TabIndex = 21;
            this.estadoCliente.Text = "Cliente deshabilitado";
            this.estadoCliente.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(401, 72);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 22;
            this.searchBtn.Text = "Buscar";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(253, 299);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 23;
            this.saveBtn.Text = "Guardar";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // ciudad
            // 
            this.ciudad.Location = new System.Drawing.Point(62, 244);
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(178, 20);
            this.ciudad.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ciudad";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(62, 218);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(178, 20);
            this.direccion.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Dirección";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // codigoPostal
            // 
            this.codigoPostal.Location = new System.Drawing.Point(380, 221);
            this.codigoPostal.Name = "codigoPostal";
            this.codigoPostal.Size = new System.Drawing.Size(178, 20);
            this.codigoPostal.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(303, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Código postal";
            // 
            // AbmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 334);
            this.Controls.Add(this.codigoPostal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ciudad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.estadoCliente);
            this.Controls.Add(this.lblSearchUser);
            this.Controls.Add(this.user);
            this.Controls.Add(this.acciones);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label3);
            this.Name = "AbmCliente";
            this.Text = "ABM Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.ComboBox acciones;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label lblSearchUser;
        private System.Windows.Forms.CheckBox estadoCliente;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox ciudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codigoPostal;
        private System.Windows.Forms.Label label9;

    }
}