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
    public partial class FormABMCliente : Form
    {
        private DataTable clientesEncontrados;
        private DataRow clienteSeleccionado;

        public FormABMCliente()
        {
            InitializeComponent();
            acciones.SelectedIndex = 0;
            clientes.DisplayMember = "dni";
        }

        private DataTable buscar()
        {
            string query = "SELECT c.id_cliente, c.nombre, c.apellido, c.dni, c.mail, c.telefono, c.fecha_nacimiento, c.direccion, c.codigo_postal, c.ciudad, c.habilitado, u.username FROM LOS_GDDS.clientes c JOIN LOS_GDDS.usuarios u ON u.id_cliente = c.id_cliente WHERE ";
            string condicionNombre = !srchNombre.Text.Equals("") ? "c.nombre LIKE '%" + srchNombre.Text + "%'" : "";
            query += condicionNombre;
            if (!srchDni.Text.Equals(""))
            {
                string condicionDni = "c.dni = '" + srchDni.Text + "'";
                query += !srchNombre.Text.Equals("") ? " AND " + condicionDni : condicionDni;
            }
            if (!srchMail.Text.Equals(""))
            {
                string condicionMail = "c.mail LIKE '%" + srchMail.Text + "%'";
                query += !srchNombre.Text.Equals("") || !srchDni.Text.Equals("") ? " AND " + condicionMail : condicionMail;
            }
            if (!srchApellido.Text.Equals(""))
            {
                string condicionApellido = "c.apellido LIKE '%" + srchApellido.Text + "%'";
                query += !srchNombre.Text.Equals("") || !srchDni.Text.Equals("") || !srchMail.Text.Equals("") ? " AND " + condicionApellido : condicionApellido;
            }

            return this.makeQuery(query);
        }

        private void cargarClientes(object sender, EventArgs e)
        {
            if (!srchDni.Text.Equals("") || !srchMail.Text.Equals("") || !srchNombre.Text.Equals("") || !srchApellido.Text.Equals(""))
            {
                this.clientesEncontrados = this.buscar();
                clientes.DataSource = this.clientesEncontrados;
                this.seleccionarCliente(null, null);
            }
        }

        private void seleccionarCliente(object sender, EventArgs e)
        {
            TextBox[] campos = { nombre, apellido, dni, mail, ciudad, direccion, codigoPostal, telefono, user };

            if (this.clientesEncontrados.Rows.Count > 0)
            {
                this.cambiarEstadoHabilitacionCampos(true);

                this.clienteSeleccionado = this.clientesEncontrados.Rows[clientes.SelectedIndex];
                DataRow cliente = this.clienteSeleccionado;
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
                user.Text = cliente["username"].ToString();
            }
            else
            {
                this.limpiarCampos(null, null);
                this.cambiarEstadoHabilitacionCampos(false);
            }
        }

        private void limpiarCampos(object sender, EventArgs e)
        {
            TextBox[] campos = { nombre, apellido, dni, mail, ciudad, direccion, codigoPostal, telefono, user };
            foreach (TextBox campo in campos)
            {
                campo.Clear();
            }
        }

        private void acciones_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.limpiarCampos(null, null);

            this.cambiarEstadoHabilitacionCampos(this.enModoCreacion());
            user.Enabled = this.enModoCreacion();
            if (this.enModoCreacion())
            {
                estadoCliente.Hide();
                filtro.Hide();
                lblSrchDni.Hide();
                lblSrchMail.Hide();
                lblSrchNombre.Hide();
                clientes.Hide();
                lblClientes.Hide();
                saveBtn.Click -= this.actualizarCliente;
                saveBtn.Click += this.crearCliente;
            }
            else
            {
                estadoCliente.Show();
                filtro.Show();
                lblSrchDni.Show();
                lblSrchMail.Show();
                lblSrchNombre.Show();
                clientes.Show();
                lblClientes.Show();
                saveBtn.Click -= this.crearCliente;
                saveBtn.Click += this.actualizarCliente;
            }
        }

        private bool enModoCreacion()
        {
            return Convert.ToBoolean(acciones.SelectedIndex);
        }

        private void crearCliente(object sender, EventArgs e)
        {
            if (this.camposSonValidos())
            {
                this.makeQuery("EXEC LOS_GDDS.insertar_nuevo_cliente '" + user.Text + "', '" + nombre.Text + "', '" + apellido.Text + "', " + dni.Text + ", '" + mail.Text + "', " + telefono.Text + ", '" + direccion.Text + "', '" + codigoPostal.Text + "', '" + fecha.Value.ToString("yyyy-MM-dd") + "T00:00:00.000', '" + ciudad.Text + "', NULL");
                MessageBox.Show("El cliente fue dado de alta correctamente.");
            }
            else
            {
                MessageBox.Show("Alguno de los datos está vacío o es inválido.");
            }
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

        private bool isInt(string number)
        {
            int n;
            return int.TryParse(number, out n);
        }

        private bool existeClienteConMismoDni()
        {
            return dni.Text.Equals("") || !isInt(dni.Text)? false : getIdClienteByDni().Rows.Count > 0;
        }

        private bool dniExisteYNoEsElPropio()
        {
            return this.clienteSeleccionado == null ? false : !this.clienteSeleccionado["dni"].Equals(dni.Text);
        }

        private void dni_Leave(object sender, EventArgs e)
        {
            if (this.existeClienteConMismoDni() && (this.enModoCreacion() || dniExisteYNoEsElPropio()))
            {
                MessageBox.Show("Ya existe un cliente con ese número de documento.");
            }
        }


        private void cambiarEstadoHabilitacionCampos(bool nuevoEstado)
        {
            TextBox[] campos = { nombre, apellido, dni, mail, ciudad, direccion, codigoPostal, telefono };
            foreach (TextBox campo in campos)
            {
                campo.Enabled = nuevoEstado;
            }

            Label[] labels = { lblNombre, lblApellido, lblMail, lblTelefono, lblCiudad, lblDireccion, lblFecha, lblCodigoPostal, lblDni, lblUser };

            foreach(Label label in labels)  {
                label.Enabled = nuevoEstado;
            }

            estadoCliente.Enabled = nuevoEstado;

            fecha.Enabled = nuevoEstado;
        }

        private bool existeClienteByUsername()
        {
            return this.getClienteByUsername().Rows.Count > 0;
        }

        private DataTable getIdUsuarioByUsername()
        {
            return this.makeQuery("SELECT id_usuario FROM LOS_GDDS.usuarios WHERE username = '" + user.Text + "'");
        }

        private bool existeUsuario()
        {
            return this.getIdUsuarioByUsername().Rows.Count > 0;
        }

        private void username_Leave(object sender, EventArgs e)
        {
            saveBtn.Enabled = true;
            if (!this.existeUsuario())
            {
                MessageBox.Show("No existe ningún usuario con ese nombre.");
                saveBtn.Enabled = false;
            }
            else if (this.existeClienteByUsername())
            {
                MessageBox.Show("El usuario ya es cliente.");
                saveBtn.Enabled = false;
            }            
        }

        private bool camposSonValidos()
        {
            TextBox[] campos = { nombre, apellido, dni, mail, telefono, ciudad, direccion, codigoPostal, user };
            foreach (TextBox campo in campos)
            {
                if (campo.Text == "")
                    return false;
            }
            return true;
        }

        private void actualizarCliente(object sender, EventArgs e)
        {
            if (this.camposSonValidos())
            {
                this.makeQuery("EXEC LOS_GDDS.modificar_cliente " + this.clienteSeleccionado["id_cliente"] + ", '" + nombre.Text + "', '" + apellido.Text + "', " + dni.Text + ", '" + mail.Text + "', " + telefono.Text + ", '" + direccion.Text + "', " + codigoPostal.Text + ", '" + fecha.Value.ToString("yyyy-MM-dd") + "T00:00:00.000', '" + ciudad.Text + "', " + (estadoCliente.Checked ? 0 : 1));
                MessageBox.Show("Los datos fueron modificados correctamente.");
            }
            else
            {
                MessageBox.Show("Alguno de los datos está vacío o es inválido.");
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

        private void lblSrchCuit_Click(object sender, EventArgs e)
        {

        }

        private void lblSrchRazonSocial_Click(object sender, EventArgs e)
        {

        }

        private void lblProveedores_Click(object sender, EventArgs e)
        {

        }
    }
}
