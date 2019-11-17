using System;
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
    public partial class AbmCliente : Form
    {
        private DataRow clienteEncontrado;

        public AbmCliente()
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
            this.makeQuery("EXEC LOS_GDDS.insertar_nuevo_cliente " + nombre.Text + " " + apellido.Text + " " + dni.Text + " " + mail.Text + " " + telefono.Text + " " + direccion.Text + " " + codigoPostal.Text + " " + fecha.Text);
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
            return this.makeQuery("SELECT TOP 1 c.id_cliente, c.nombre, c.apellido, c.dni, c.mail, c.telefono, c.fecha_nacimiento, c.direccion, c.codigo_postal, c.ciudad FROM LOS_GDDS.usuarios u JOIN LOS_GDDS.clientes c ON u.id_cliente = c.id_cliente WHERE u.username = '" + user.Text + "'");
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
                }
                else
                {
                    MessageBox.Show("No se encontró ningún cliente con ese nombre de usuario.");
                }
            }
        }

        private void actualizarCliente(object sender, EventArgs e)
        {
            this.makeQuery(@"
                UPDATE LOS_GDDS.clientes
                    SET nombre = " + nombre.Text + @",
                    apellido = " + apellido.Text + @",
                    dni = " + dni.Text + @",
                    mail = " + mail.Text + @",
                    fecha_nacimiento = " + fecha.Text + @",
                    telefono = " + telefono.Text + @",
                    ciudad = " + ciudad.Text + @",
                    direccion = " + direccion.Text + @",
                    codigo_postal = " + codigoPostal.Text + @"
                    WHERE id_cliente = " + this.clienteEncontrado["id_cliente"] + @"
            ");
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
