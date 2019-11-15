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
using System.Globalization;

namespace FrbaOfertas
{
    public partial class FormRegistrarUsuario : Form
    {
        #region Variables

        static SqlConnection conexion;
        FormLogin padre;

        #endregion

        public FormRegistrarUsuario(FormLogin padre)
        {
            InitializeComponent();
            this.padre = padre;
            conexion = new SqlConnection(Configuracion.stringConexion);
        }

        #region Métodos

        private void seleccionarPanelAMostrar()
        {
            string rolSeleccionado = cmbRoles.Text;

            switch (rolSeleccionado)
            {
                case "Cliente":
                    pnlClientes.Visible = true;
                    pnlProveedores.Visible = false;
                    break;
                case "Proveedor":
                    pnlProveedores.Visible = true;
                    pnlClientes.Visible = false;
                    break;
                default:
                    this.Height = 200;
                    this.btnCrearCuenta.Location = new Point(this.btnCrearCuenta.Location.X, 135);
                    pnlProveedores.Visible = false;
                    pnlClientes.Visible = false;
                    break;
            }
        }

        private Boolean validarCampos()
        {
            string rolSeleccionado = cmbRoles.Text;

            switch (rolSeleccionado)
            {
                case "Cliente":
                    if (txtUsername.Text.Equals("") || txtPassword.Text.Equals("") || txtNombreCliente.Text.Equals("") ||
                        txtApellido.Text.Equals("") || mtxtDni.Text.Equals("") || txtMailCliente.Text.Equals("") ||
                        mtxtTelefonoCliente.Text.Equals("") || txtDireccionCliente.Text.Equals("") || mtxtCP.Text.Equals(""))
                    {
                        MessageBox.Show("Debe completar todos los campos para continuar.");
                        return false;
                    }
                    else
                    {
                        conexion.Open();
                        SqlCommand existeUsuario = new SqlCommand("[LOS_GDDS].[existe_usuario]", conexion);
                        existeUsuario.CommandType = CommandType.StoredProcedure;
                        existeUsuario.Parameters.AddWithValue("@Username", txtUsername.Text);
                        var respuesta = existeUsuario.Parameters.Add("@Respuesta", SqlDbType.Int);
                        respuesta.Direction = ParameterDirection.Output;
                        SqlDataReader data = existeUsuario.ExecuteReader();
                        conexion.Close();

                        if (respuesta.Value.Equals(1))
                        {
                            MessageBox.Show("Ya existe una cuenta con ese usuario.");
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                case "Proveedor":
                    if (txtUsername.Text.Equals("") || txtPassword.Text.Equals("") || txtRazonSocial.Text.Equals("") ||
                        txtMailProveedor.Text.Equals("") || mtxtTelefonoProveedor.Text.Equals("") || txtDireccionProveedor.Text.Equals("") ||
                        txtCiudad.Text.Equals("") || mtxtCuit.Text.Equals("") || cmbRubros.Text.Equals("") ||
                        txtNombreProveedor.Text.Equals(""))
                    {
                        MessageBox.Show("Debe completar todos los campos para continuar.");
                        return false;
                    }
                    else
                    {
                        conexion.Open();
                        SqlCommand existeUsuario = new SqlCommand("[LOS_GDDS].[existe_usuario]", conexion);
                        existeUsuario.CommandType = CommandType.StoredProcedure;
                        existeUsuario.Parameters.AddWithValue("@Username", txtUsername.Text);
                        var resultado = existeUsuario.Parameters.Add("@Resultado", SqlDbType.Int);
                        resultado.Direction = ParameterDirection.Output;
                        SqlDataReader data = existeUsuario.ExecuteReader();
                        conexion.Close();

                        if (resultado.Equals(1))
                        {
                            MessageBox.Show("Ya existe una cuenta con ese usuario.");
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                default:
                    MessageBox.Show("No es posible registrar usuarios con este rol por el momento.");
                    return false;
            }
        }

        private void guardarDatos()
        {
            if (cmbRoles.Text.Equals("Cliente"))
            {
                // INSERTAR CLIENTE
                conexion.Open();

                SqlCommand insertarCliente = new SqlCommand("[LOS_GDDS].[insertar_nuevo_cliente]", conexion);
                insertarCliente.CommandType = CommandType.StoredProcedure;
                insertarCliente.Parameters.AddWithValue("@Nombre", txtNombreCliente.Text);
                insertarCliente.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                insertarCliente.Parameters.AddWithValue("@Dni", int.Parse(mtxtDni.Text));
                insertarCliente.Parameters.AddWithValue("@Mail", txtMailCliente.Text);
                insertarCliente.Parameters.AddWithValue("@Telefono", int.Parse(mtxtTelefonoCliente.Text));
                insertarCliente.Parameters.AddWithValue("@Direccion", txtDireccionCliente.Text);
                insertarCliente.Parameters.AddWithValue("@CodigoPostal", mtxtCP.Text);
                insertarCliente.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value);
                // Agregar parámetro ciudad
                var idCliente = insertarCliente.Parameters.Add("@IdCliente", SqlDbType.Int);
                idCliente.Direction = ParameterDirection.Output;
                SqlDataReader dataCliente = insertarCliente.ExecuteReader();
                string idNuevoCliente = idCliente.Value.ToString();

                conexion.Close();

                // INSERTAR USUARIO
                conexion.Open();

                SqlCommand insertarUsuario = new SqlCommand("[LOS_GDDS].[insertar_nuevo_usuario]", conexion);
                insertarUsuario.CommandType = CommandType.StoredProcedure;
                insertarUsuario.Parameters.AddWithValue("@Username", txtUsername.Text);
                insertarUsuario.Parameters.AddWithValue("@Password", txtPassword.Text);
                insertarUsuario.Parameters.AddWithValue("@IdCliente", idNuevoCliente);
                insertarUsuario.Parameters.AddWithValue("@IdProveedor", DBNull.Value);
                var idUsuario = insertarUsuario.Parameters.Add("@IdUsuario", SqlDbType.Int);
                idUsuario.Direction = ParameterDirection.Output;
                SqlDataReader dataUsuario = insertarUsuario.ExecuteReader();
                string idNuevoUsuario = idUsuario.Value.ToString();

                conexion.Close();

                // INSERTAR RELACIÓN ROL-USUARIO
                conexion.Open();
                
                DataRowView rolSeleccionado = (DataRowView)cmbRoles.SelectedItem;
                int idRolSeleccionado = (int)rolSeleccionado.Row["id_rol"];
                string queryInsert = "INSERT INTO [LOS_GDDS].[roles_usuario] VALUES (" + idNuevoUsuario + ", " + idRolSeleccionado + ")";
                SqlCommand ejecutarInsertRolesUsuario = new SqlCommand(queryInsert, conexion);
                ejecutarInsertRolesUsuario.ExecuteNonQuery();

                conexion.Close();

                this.Close();
                MessageBox.Show("El usuario se creó satisfactoriamente.");
                this.padre.Visible = true;
            }
            else if (cmbRoles.Text.Equals("Proveedor"))
            {
                // INSERTAR PROVEEDOR
                conexion.Open();
                SqlCommand insertarProveedor = new SqlCommand("[LOS_GDDS].[insertar_nuevo_proveedor]", conexion);
                insertarProveedor.CommandType = CommandType.StoredProcedure;
                insertarProveedor.Parameters.AddWithValue("@RazonSocial", txtRazonSocial.Text);
                insertarProveedor.Parameters.AddWithValue("@Mail", txtMailProveedor.Text);
                insertarProveedor.Parameters.AddWithValue("@Telefono", int.Parse(mtxtTelefonoProveedor.Text));
                insertarProveedor.Parameters.AddWithValue("@CodigoPostal", txtMailCliente.Text); //Fixear
                insertarProveedor.Parameters.AddWithValue("@Ciudad", txtCiudad.Text);
                insertarProveedor.Parameters.AddWithValue("@Direccion", txtDireccionProveedor.Text);
                insertarProveedor.Parameters.AddWithValue("@Cuit", mtxtCuit.Text);
                insertarProveedor.Parameters.AddWithValue("@NombreContacto", txtNombreProveedor.Text);
                DataRowView rubroSeleccionado = (DataRowView)cmbRubros.SelectedItem;
                int idRubroSeleccionado = (int)rubroSeleccionado.Row["id_rubro"];
                insertarProveedor.Parameters.AddWithValue("@Rubro", idRubroSeleccionado);
                var idProveedor = insertarProveedor.Parameters.Add("@IdProveedor", SqlDbType.Int);
                idProveedor.Direction = ParameterDirection.Output;
                SqlDataReader dataProveedor = insertarProveedor.ExecuteReader();
                string idNuevoProveedor = idProveedor.Value.ToString();

                conexion.Close();

                // INSERTAR USUARIO
                conexion.Open();

                SqlCommand insertarUsuario = new SqlCommand("[LOS_GDDS].[insertar_nuevo_usuario]", conexion);
                insertarUsuario.CommandType = CommandType.StoredProcedure;
                insertarUsuario.Parameters.AddWithValue("@Username", txtUsername.Text);
                insertarUsuario.Parameters.AddWithValue("@Password", txtPassword.Text);
                insertarUsuario.Parameters.AddWithValue("@IdCliente", idNuevoProveedor);
                insertarUsuario.Parameters.AddWithValue("@IdProveedor", DBNull.Value);
                var idUsuario = insertarUsuario.Parameters.Add("@IdUsuario", SqlDbType.Int);
                idUsuario.Direction = ParameterDirection.Output;
                SqlDataReader dataUsuario = insertarUsuario.ExecuteReader();
                string idNuevoUsuario = idUsuario.Value.ToString();

                conexion.Close();

                // INSERTAR RELACIÓN ROL-USUARIO
                conexion.Open();

                DataRowView rolSeleccionado = (DataRowView)cmbRoles.SelectedItem;
                int idRolSeleccionado = (int)rolSeleccionado.Row["id_rol"];
                string queryInsert = "INSERT INTO [LOS_GDDS].[roles_usuario] VALUES (" + idNuevoUsuario + ", " + idRolSeleccionado + ")";
                SqlCommand ejecutarInsertRolesUsuario = new SqlCommand(queryInsert, conexion);
                ejecutarInsertRolesUsuario.ExecuteNonQuery();

                conexion.Close();

                this.Close();
                MessageBox.Show("El usuario se creó satisfactoriamente.");
                this.padre.Visible = true;
            }
        }

        #endregion

        #region Eventos

        private void cmbRoles_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.Height = 390;
            this.btnCrearCuenta.Location = new Point(this.btnCrearCuenta.Location.X, 324);
            this.seleccionarPanelAMostrar();
        }

        private void FormRegistrarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.padre.Visible = true;
        }

        private void FormRegistrarUsuario_Load(object sender, EventArgs e)
        {
            this.Height = 390;
            pnlProveedores.Location = new Point(12, 131);
            this.btnCrearCuenta.Location = new Point(this.btnCrearCuenta.Location.X, 324);

            conexion.Open();
            // Cargo los roles existentes
            SqlCommand cargarRoles = new SqlCommand("SELECT [id_rol], [nombre] FROM [LOS_GDDS].[Roles] WHERE [nombre] <> 'Administrador' AND [habilitado] = 1", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(cargarRoles);
            conexion.Close();
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbRoles.DataSource = table;
            cmbRoles.DisplayMember = "nombre";
            cmbRoles.SelectedIndex = 1;

            this.seleccionarPanelAMostrar();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            if (this.validarCampos())
            {
                this.guardarDatos();
            }
        }

        #endregion
    }
}