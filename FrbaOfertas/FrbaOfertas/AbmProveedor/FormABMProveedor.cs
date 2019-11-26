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

namespace FrbaOfertas.AbmProveedor
{
    public partial class FormABMProveedor : Form
    {
        private DataTable proveedoresEncontrados;
        private DataRow proveedorSeleccionado;

        public FormABMProveedor()
        {
            InitializeComponent();
            acciones.SelectedIndex = 0;
            cargarRubros();
            proveedores.DisplayMember = "razon_social";
        }

        private DataTable buscar()
        {
            string query = "SELECT p.id_proveedor, p.razon_social, p.nombre_contacto, p.cuit, p.mail, p.telefono, p.id_rubro, p.direccion, p.codigo_postal, p.ciudad, p.habilitado, u.username FROM LOS_GDDS.proveedores p JOIN LOS_GDDS.usuarios u ON u.id_proveedor = p.id_proveedor WHERE ";
            string condicionRazonSocial = !srchRazonSocial.Text.Equals("") ? "p.razon_social LIKE '%" + srchRazonSocial.Text + "%'" : "";
            query += condicionRazonSocial;
            if (!srchCuit.Text.Equals(""))
            {
                string condicionCuit = "p.cuit = '" + srchCuit.Text + "'";
                query += !srchRazonSocial.Text.Equals("") ? " AND " + condicionCuit : condicionCuit;
            }
            if (!srchMail.Text.Equals(""))
            {
                string condicionMail = "p.mail LIKE '%" + srchMail.Text + "%'";
                query += !srchRazonSocial.Text.Equals("") || !srchCuit.Text.Equals("") ? " AND " + condicionMail : condicionMail;
            }

            return this.makeQuery(query);
        }

        private void cargarProveedores(object sender, EventArgs e)
        {
            if (!srchCuit.Text.Equals("") || !srchMail.Text.Equals("") || !srchRazonSocial.Text.Equals(""))
            {
                this.proveedoresEncontrados = this.buscar();
                proveedores.DataSource = this.proveedoresEncontrados;
                this.seleccionarProveedor(null, null);
            }
        }

        private void seleccionarProveedor(object sender, EventArgs e)
        {
            if (this.proveedoresEncontrados.Rows.Count > 0)
            {
                this.proveedorSeleccionado = this.proveedoresEncontrados.Rows[proveedores.SelectedIndex];
                DataRow proveedor = this.proveedorSeleccionado;
                razonSocial.Text = proveedor["razon_social"].ToString();
                contacto.Text = proveedor["nombre_contacto"].ToString();
                cuit.Text = proveedor["cuit"].ToString();
                mail.Text = proveedor["mail"].ToString();
                telefono.Text = proveedor["telefono"].ToString();
                direccion.Text = proveedor["direccion"].ToString();
                codigoPostal.Text = proveedor["codigo_postal"].ToString();
                ciudad.Text = proveedor["ciudad"].ToString();
                rubros.SelectedValue = proveedor["id_rubro"];
                estadoProveedor.Checked = !Convert.ToBoolean(proveedor["habilitado"].ToString());
                user.Text = proveedor["username"].ToString();
            }
            else
            {
                this.limpiarCampos(null, null);
            }
        }

        private void limpiarCampos(object sender, EventArgs e)
        {
            TextBox[] campos = { razonSocial, contacto, cuit, mail, ciudad, direccion, codigoPostal, telefono, user };
            foreach (TextBox campo in campos)
            {
                campo.Clear();
            }
        }

        private void acciones_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.limpiarCampos(null, null);
            user.Enabled = this.enModoCreacion();
            if (this.enModoCreacion())
            {
                estadoProveedor.Hide();
                filtro.Hide();
                lblSrchCuit.Hide();
                lblSrchMail.Hide();
                lblSrchRazonSocial.Hide();
                proveedores.Hide();
                lblProveedores.Hide();
                saveBtn.Click -= this.actualizarProveedor;
                saveBtn.Click += this.crearProveedor;
            }
            else
            {
                estadoProveedor.Show();
                filtro.Show();
                lblSrchCuit.Show();
                lblSrchMail.Show();
                lblSrchRazonSocial.Show();
                proveedores.Show();
                lblProveedores.Show();
                saveBtn.Click -= this.crearProveedor;
                saveBtn.Click += this.actualizarProveedor;
            }
        }

        private bool enModoCreacion()
        {
            return Convert.ToBoolean(acciones.SelectedIndex);
        }

        public void cargarRubros()
        {
            rubros.DisplayMember = "descripcion";
            rubros.ValueMember = "id_rubro";
            rubros.DataSource = this.makeQuery("SELECT id_rubro, descripcion FROM LOS_GDDS.rubros");
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

        private DataTable getIdProveedorByCuit()
        {
            return this.makeQuery("SELECT TOP 1 id_proveedor FROM LOS_GDDS.proveedores WHERE cuit = '" + cuit.Text + "'");
        }

        private DataTable getIdProveedorByRazonSocial()
        {
            return this.makeQuery("SELECT TOP 1 id_proveedor FROM LOS_GDDS.proveedores WHERE razon_social = '" + razonSocial.Text + "'");
        }

        private DataTable getProveedorByUsername()
        {
            return this.makeQuery("SELECT TOP 1 p.id_proveedor, p.razon_social, p.nombre_contacto, p.cuit, p.mail, p.telefono, p.id_rubro, p.direccion, p.codigo_postal, p.ciudad, p.habilitado FROM LOS_GDDS.usuarios u JOIN LOS_GDDS.proveedores p ON u.id_proveedor = p.id_proveedor WHERE u.username = '" + user.Text + "'");
        }

        private bool existeProveedorConMismoCuit()
        {
            return this.getIdProveedorByCuit().Rows.Count > 0;
        }

        private bool existeProveedorConMismaRazonSocial()
        {
            return this.getIdProveedorByRazonSocial().Rows.Count > 0;
        }

        private void cuit_Leave(object sender, EventArgs e)
        {
            if (!this.cuit.Text.Equals("") && this.cuitOcupado())
            {
                MessageBox.Show("Ya existe un proveedor con ese CUIT.");
            }
        }

        private bool cuitOcupado()
        {
            return this.existeProveedorConMismoCuit() && (this.enModoCreacion() || !this.proveedorSeleccionado["cuit"].Equals(cuit.Text));
        }

        private bool razonSocialOcupada()
        {
            return this.existeProveedorConMismaRazonSocial() && (this.enModoCreacion() || !this.proveedorSeleccionado["razon_social"].Equals(razonSocial.Text));
        }

        private void razonSocial_Leave(object sender, EventArgs e)
        {
            if (!razonSocial.Text.Equals("") && this.razonSocialOcupada())
            {
                MessageBox.Show("Ya existe un proveedor con esa razón social.");
            }
        }

        private DataTable getIdUsuarioByUsername()
        {
            return this.makeQuery("SELECT id_usuario FROM LOS_GDDS.usuarios WHERE username = '" + user.Text + "'");
        }

        private bool existeUsuario()
        {
            return this.getIdUsuarioByUsername().Rows.Count > 0;
        }

        private void usuarioDisponible(object sender, EventArgs e)
        {
            saveBtn.Enabled = true;
            if (!this.existeUsuario())
            {
                MessageBox.Show("No existe ningún usuario con ese nombre.");
                saveBtn.Enabled = false;
            }
            else if(this.existeProveedorConMismoUsername()) {
                MessageBox.Show("Ya existe una empresa proveedora registrada para ese nombre de usuario.");
                saveBtn.Enabled = false;
            }
        }

        private bool existeProveedorConMismoUsername()
        {
            return this.getProveedorByUsername().Rows.Count > 0;
        }

        private bool camposSonValidos()
        {
            TextBox[] campos = { razonSocial, contacto, cuit, mail, telefono, ciudad, direccion, codigoPostal };
            bool sonTodosValidos = true;
            foreach (TextBox campo in campos)
            {
                if (campo.Text == "")
                {
                    sonTodosValidos = false;
                    campo.BackColor = System.Drawing.ColorTranslator.FromHtml("#F99");
                }
                else
                {
                    campo.BackColor = System.Drawing.Color.White;
                }
            }
            return sonTodosValidos && !this.razonSocialOcupada();
        }

        private void crearProveedor(object sender, EventArgs e)
        {
            if(this.camposSonValidos())
            {
                this.makeQuery("EXEC LOS_GDDS.insertar_nuevo_proveedor '" + user.Text + "', '" + razonSocial.Text + "', '" + mail.Text + "', " + telefono.Text + ", '" + codigoPostal.Text + "', '" + ciudad.Text + "', '" + direccion.Text + "', '" + cuit.Text + "', '" + contacto.Text + "', " + rubros.SelectedValue + ", NULL");
                MessageBox.Show("El proveedor fue creado correctamente.");
            }
            else
            {
                MessageBox.Show("Alguno de los datos está vacío o es inválido.");
            }
        }

        private void actualizarProveedor(object sender, EventArgs e)
        {
            if (this.camposSonValidos())
            {
                this.makeQuery("EXEC LOS_GDDS.modificar_proveedor " + this.proveedorSeleccionado["id_proveedor"] + ", '" + razonSocial.Text + "', '" + contacto.Text + "', '" + cuit.Text + "', '" + mail.Text + "', " + telefono.Text + ", '" + direccion.Text + "', '" + codigoPostal.Text + "', " + rubros.SelectedValue + ", '" + ciudad.Text + "', " + (estadoProveedor.Checked ? 0 : 1));
                MessageBox.Show("Los datos fueron modificados correctamente.");
            }
            else
            {
                MessageBox.Show("Alguno de los datos está vacío o es inválido.");
            }
        }
    }
}
