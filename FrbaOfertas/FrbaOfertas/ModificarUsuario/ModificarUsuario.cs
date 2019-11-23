using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FrbaOfertas.ModificarUsuario
{
    public partial class ModificarUsuario : Form
    {
        private DataRow clienteEncontrado;
        public ModificarUsuario()
        {
            InitializeComponent();
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

        private DataTable getClienteByUsername()
        {
            return this.makeQuery("SELECT TOP 1 u.id_usuario,u.habilitado FROM LOS_GDDS.usuarios u WHERE u.username = '" + user.Text + "'");
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
                    int habilitado = Convert.ToInt32(this.clienteEncontrado["habilitado"]);
                    if (habilitado == 0)
                    {
                        button2.Text = "Activar";
                    }
                    else
                    {
                        button2.Text = "Desactivar";
                    }
                    button1.Visible = true;
                    button2.Visible = true;

                }
                else
                {
                    MessageBox.Show("No se encontró ningún cliente con ese nombre de usuario.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idUsuario =Convert.ToInt32(this.clienteEncontrado["id_usuario"]);
            ModificarContrasena.FormModificarContrasena modificarContrasena = new ModificarContrasena.FormModificarContrasena(idUsuario);
            modificarContrasena.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idUsuario = Convert.ToInt32(this.clienteEncontrado["id_usuario"]);
            int habilitado = Convert.ToInt32(this.clienteEncontrado["habilitado"]);
            if (habilitado == 0)
            {
                habilitado = 1;
                button2.Text = "Desactivar";
            } else
            {
                habilitado = 0;
                button2.Text = "Activar";
            }
            this.clienteEncontrado["habilitado"] = habilitado;
            this.makeQuery("UPDATE LOS_GDDS.usuarios SET habilitado=" + habilitado.ToString() + " WHERE id_usuario=" + idUsuario);
        }
    }

   
}
