using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmRol
{
    public partial class FormABMRol : Form
    {
        SqlConnection conexion;

        public FormABMRol()
        {
            InitializeComponent();
            conexion = new SqlConnection(Configuracion.stringConexion);
            cargarRoles();
        }

        private void cargarRoles()
        {
            String query = "SELECT nombre FROM LOS_GDDS.roles";
            SqlCommand listar = new SqlCommand(query, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(listar);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            gvwRoles.DataSource = tabla;
            gvwRoles.Columns[0].Width = 500;
            conexion.Close();
        }
    }
}
