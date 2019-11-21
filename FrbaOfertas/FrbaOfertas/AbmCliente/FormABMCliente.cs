﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaOfertas.AbmCliente
{
    public partial class FormABMCliente : Form
    {
        private DataRow clienteEncontrado;

        public FormABMCliente()
        {
            InitializeComponent();
            acciones.SelectedIndex = 0;
        }

        private bool enModoCreacion()
        {
            return Convert.ToBoolean(acciones.SelectedIndex);
        }


        private void acciones_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            nombre.Clear();
            apellido.Clear();
            dni.Clear();
            mail.Clear();
            ciudad.Clear();
            direccion.Clear();
            codigoPostal.Clear();
            telefono.Clear();
            if (this.enModoCreacion())
            {
                estadoCliente.Hide();
                saveBtn.Click -= this.actualizarCliente;
                saveBtn.Click += this.crearCliente;
            }
            else
            {
                estadoCliente.Show();
                saveBtn.Click -= this.crearCliente;
                saveBtn.Click += this.actualizarCliente;
            }
        }

        private void crearCliente(object sender, EventArgs e)
        {
            this.makeQuery("EXEC LOS_GDDS.insertar_nuevo_cliente " + nombre.Text + " " + apellido.Text + " " + dni.Text + " " + mail.Text + " " + telefono.Text + " " + direccion.Text + " " + codigoPostal.Text + " " + fecha.Value.ToShortDateString());
        }

        private DataTable makeQuery(String query)
        {
            SqlConnection conexion = new SqlConnection(Configuracion.stringConexion);
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            conexion.Close();
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        private DataTable getIdClienteByDni()
        {
            return this.makeQuery("SELECT TOP 1 id_cliente FROM LOS_GDDS.clientes WHERE dni = " + dni.Text);
        }

        private DataTable getClienteByUsername()
        {
            return this.makeQuery("SELECT TOP 1 c.id_cliente, c.nombre, c.apellido, c.dni, c.mail, c.telefono, c.fecha_nacimiento, c.direccion, c.codigo_postal, c.ciudad, c.habilitado FROM LOS_GDDS.usuarios u JOIN LOS_GDDS.clientes c ON u.id_cliente = c.id_cliente WHERE u.username = '" + user.Text + "'");
        }

        private bool existeClienteConMismoDni()
        {
            return getIdClienteByDni().Rows.Count > 0;
        }

        private void dni_Leave(object sender, EventArgs e)
        {
            if (this.enModoCreacion() && this.existeClienteConMismoDni())
            {
                MessageBox.Show("Ya existe un cliente con ese número de documento.");
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (user.Text != "")
            {
                DataTable clienteEncontrado = this.getClienteByUsername();
                if (clienteEncontrado.Rows.Count > 0)
                {
                    DataRow cliente = clienteEncontrado.Rows[0];
                    this.clienteEncontrado = cliente;
                    nombre.Text = cliente["nombre"].ToString();
                    apellido.Text = cliente["apellido"].ToString();
                    dni.Text = cliente["dni"].ToString();
                    mail.Text = cliente["mail"].ToString();
                    telefono.Text = cliente["telefono"].ToString();
                    direccion.Text = cliente["direccion"].ToString();
                    codigoPostal.Text = cliente["codigo_postal"].ToString();
                    ciudad.Text = cliente["ciudad"].ToString();
                    fecha.Text = cliente["fecha_nacimiento"].ToString();
                    estadoCliente.Checked = !Convert.ToBoolean(cliente["habilitado"].ToString());
                }
                else
                {
                    MessageBox.Show("No se encontró ningún cliente con ese nombre de usuario.");
                }
            }
        }

        private bool camposSonValidos() {
            string[] campos = {nombre.Text, apellido.Text, dni.Text, mail.Text, fecha.Text, telefono.Text, ciudad.Text, direccion.Text, codigoPostal.Text};
            foreach(string campo in campos)    {
                if(campo == "")
                    return false;
            }
            return true;
        }

        private void actualizarCliente(object sender, EventArgs e)
        {
            if(this.camposSonValidos()) {
                this.makeQuery("EXEC LOS_GDDS.modificar_cliente " + this.clienteEncontrado["id_cliente"] + ", '" + nombre.Text + "', '" + apellido.Text + "', " + dni.Text + ", '" + mail.Text + "', " + telefono.Text + ", '" + direccion.Text + "', " + codigoPostal.Text + ", '" + fecha.Value.ToString("yyyy-MM-dd") + @"T00:00:00.000', '" + ciudad.Text + "', " + (estadoCliente.Checked ? 0 : 1));
            }
            else
            {
                MessageBox.Show("Alguno de los dátos está vacío.");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
