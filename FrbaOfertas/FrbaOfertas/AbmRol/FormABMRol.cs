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
            conexion.Open();
            SqlCommand listar = new SqlCommand("[LOS_GDDS].[cargar_roles]", conexion);
            listar.CommandType = CommandType.StoredProcedure;
            listar.Parameters.Add("@Rol", SqlDbType.VarChar).Value = txtRol.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(listar);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            gvwRoles.DataSource = tabla;
            gvwRoles.Columns[0].Visible = false;
            gvwRoles.Columns[1].Width = 500;
            conexion.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.cargarRoles();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRol.Text = "";
            this.cargarRoles();
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            int idRol = int.Parse(gvwRoles.SelectedRows[0].Cells[0].Value.ToString());
            FormModificarRol form = new FormModificarRol(idRol);
            form.Tag = "Modificar";
            form.ShowDialog();
        }
    }
}
