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

namespace FrbaOfertas
{
    public partial class FormMenuPrincipal : Form
    {
        #region Variables

        SqlConnection conexion;
        Form padre;
        int posicionEnX = 0, proximaPosicionEnY = 0;

        #endregion

        public FormMenuPrincipal(Form padre)
        {
            InitializeComponent();
            this.padre = padre;
            conexion = new SqlConnection(Configuracion.stringConexion);
        }

        #region Métodos

        private void cargarUsuario()
        {
            String query = "SELECT username FROM LOS_GDDS.usuarios WHERE id_usuario = " + Configuracion.idUsuario;

            SqlCommand listar = new SqlCommand(query, conexion);

            DataTable tabla = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = listar;
            adapter.Fill(tabla);

            if (tabla.Rows.Count == 1)
            {
                lblUsername.Text = "Bienvenido " + tabla.Rows[0]["username"].ToString();
            }
        }

        private void cargarFuncionalidades()
        {
            String query = "SELECT f.id_funcionalidad, f.nombre FROM LOS_GDDS.funcionalidades f JOIN LOS_GDDS.funcionalidades_rol fr ON fr.id_funcionalidad = f.id_funcionalidad WHERE fr.id_rol = " + Configuracion.idRol;

            SqlCommand listar = new SqlCommand(query, conexion);

            DataTable tabla = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = listar;
            adapter.Fill(tabla);

            int alturaOriginalForm = this.Height;

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                pnlOpciones.Controls.Add(crearBoton(tabla.Rows[i]["nombre"].ToString(), decimal.Parse(tabla.Rows[i]["id_funcionalidad"].ToString())));
            }

            // Agrego un poco de espacio entre el último botón y el borde inferior de la ventana
            this.Height += 10;
            pnlOpciones.Height += 10;
        }

        private Button crearBoton(String descripcion, decimal funcionalidad)
        {
            Button boton = new Button();
            int alturaBoton = 30;
            boton.Text = descripcion;
            boton.Tag = funcionalidad;
            boton.Width = 235;
            boton.Height = alturaBoton;

            boton.Location = new Point(posicionEnX, proximaPosicionEnY);
            if (proximaPosicionEnY > pnlOpciones.Height)
            {
                this.Height += boton.Height;
                pnlOpciones.Height += boton.Height;
            }

            proximaPosicionEnY += alturaBoton;

            boton.Click += new EventHandler(this.abrirFuncionalidad);
            return boton;
        }

        private void abrirFuncionalidad(object sender, System.EventArgs e)
        {
            Button botonClickeado = sender as Button;

            switch ((int.Parse(botonClickeado.Tag.ToString())))
            {
                case Configuracion.abmRoles:
                    AbmRol.FormSeleccionarProveedor abmRol = new AbmRol.FormSeleccionarProveedor();
                    abmRol.Show();
                    break;
                case Configuracion.abmClientes:
                    AbmCliente.FormABMCliente abmCliente = new AbmCliente.FormABMCliente();
                    abmCliente.Show();
                    break;
                case Configuracion.abmProveedores:
                    break;
                case Configuracion.modificarPassword:
                    ModificarContrasena.FormModificarContrasena modificarContrasena = new ModificarContrasena.FormModificarContrasena();
                    modificarContrasena.Show();
                    break;
                case Configuracion.cargarCredito:
                    conexion.Open();
                    string query = "SELECT [id_cliente] FROM [LOS_GDDS].[usuarios] WHERE [id_usuario] = " + Configuracion.idUsuario;
                    SqlCommand ejecutar = new SqlCommand(query, conexion);
                    int idCliente = 0;
                    try
                    {
                        idCliente = (int)ejecutar.ExecuteScalar();
                    }
                    catch
                    {
                        MessageBox.Show("Esta funcionalidad es exclusiva para clientes.");
                        break;
                    }
                    finally
                    {
                        conexion.Close();
                    }
                    conexion.Close();
                    FormCargarCredito formCargarCredito = new FormCargarCredito(idCliente);
                    formCargarCredito.Show();
                    break;
                case Configuracion.altaOferta:
                    CrearOferta.FormCrearOferta crearOferta = new CrearOferta.FormCrearOferta();
                    crearOferta.Show();
                    break;
                case Configuracion.comprarOferta:
                    ComprarOferta.FormComprarOferta comprarOfertas = new ComprarOferta.FormComprarOferta();
                    comprarOfertas.Show();
                    break;
                case Configuracion.consumirOferta:
                    ConsumirOferta.FormSeleccionarCliente seleccionarCliente = new ConsumirOferta.FormSeleccionarCliente();
                    seleccionarCliente.Show();
                    break;
                case Configuracion.facturarProveedor:
                    break;
                case Configuracion.listadoEstadistico:
                    break;
            }
        }

        #endregion

        #region Eventos

        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            conexion.Open();
            cargarUsuario();
            cargarFuncionalidades();
            conexion.Close();
        }

        #endregion

        private void FormMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult seleccionUsuario = MessageBox.Show("¿Cerrar sesión?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (seleccionUsuario == DialogResult.Yes)
            {
                this.padre.Visible = true;
            }
            else
            {
                e.Cancel = true;
            }
        }

    }
}