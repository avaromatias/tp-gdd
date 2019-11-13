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
    public partial class formRegistrarUsuario : Form
    {

        static SqlConnection conexion;
        FormLogin padre;

        public formRegistrarUsuario(FormLogin padre)
        {
            InitializeComponent();
            conexion = new SqlConnection(Configuracion.stringConexion);
            this.padre = padre;
            this.Height = 390;
            pnlProveedores.Location = new Point(12, 131);
            this.btnCrearCuenta.Location = new Point(this.btnCrearCuenta.Location.X, 324);

            conexion.Open();
            // Cargo los roles existentes
            SqlCommand cargarRoles = new SqlCommand("SELECT [id_rol], [nombre] FROM [LOS_GDDS].[Roles] WHERE [nombre] <> 'Administrador'", conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(cargarRoles);
            conexion.Close();
            DataTable table = new DataTable();
            adapter.Fill(table);
            cmbRoles.DataSource = table;
            cmbRoles.DisplayMember = "nombre";
            cmbRoles.SelectedIndex = 1;

            this.seleccionarPanelAMostrar();
        }

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
                    break;
            }
        }

        private void cmbRoles_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.seleccionarPanelAMostrar();
        }

        private void formRegistrarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.padre.Visible = true;
        }

        private Boolean validarCampos()
        {
            if (txtUsername.Text.Equals("") && txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar un nombre de usuario y contraseña.");
                return false;
            }
            else
            {
                if (txtUsername.Text.Equals(""))
                {
                    MessageBox.Show("Debe ingresar un nombre de usuario.");
                    return false;
                }

                if (txtPassword.Text.Equals(""))
                {
                    MessageBox.Show("Debe ingresar una contraseña.");
                    return false;
                }
            }
            return true;
        }
    }
}