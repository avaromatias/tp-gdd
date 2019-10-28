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

        SqlConnection conexion;
        int posicionEnX = 0, proximaPosicionEnY = 0;

        public FormMenuPrincipal()
        {
            InitializeComponent();
            conexion = new SqlConnection(Configuraciones.stringConexion);
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            conexion.Open();
            cargarUsuario();
            cargarFuncionalidades();
            conexion.Close();
        }

        private void cargarUsuario()
        {
            String query = "SELECT username FROM LOS_GDDS.usuarios WHERE id_usuario = " + Configuraciones.id_usuario;

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
            String query = "SELECT f.id_funcionalidad, f.nombre FROM LOS_GDDS.funcionalidades f JOIN LOS_GDDS.funcionalidades_rol fr ON fr.id_funcionalidad = f.id_funcionalidad WHERE fr.id_rol = " + Configuraciones.id_rol;

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

            if (this.Height != alturaOriginalForm)
            {
                this.Height += 10;
                pnlOpciones.Height += 10;
            }
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

            return boton;
        }

        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Configuraciones.formLogin.Show();
            this.Close();
        }

    }
}