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
    public partial class FormSeleccionarProveedor : Form
    {
        #region Variables

        SqlConnection conexion;

        #endregion

        public FormSeleccionarProveedor()
        {
            InitializeComponent();
            conexion = new SqlConnection(Configuracion.stringConexion);
        }

        #region Métodos

        public void cargarRoles()
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
            gvwRoles.Columns[1].Width = 400;
            conexion.Close();
        }

        #endregion

        #region Eventos

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
            FormAltaModificacionRol form = new FormAltaModificacionRol(this, idRol);
            form.Tag = "Modificar";
            form.ShowDialog();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FormAltaModificacionRol form = new FormAltaModificacionRol(this);
            form.Tag = "Alta";
            form.ShowDialog();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            DialogResult seleccionUsuario = MessageBox.Show("¿Está seguro de que desea inhabilitar el rol seleccionado?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (seleccionUsuario == DialogResult.Yes)
            {
                conexion.Open();

                string idRol = gvwRoles.SelectedRows[0].Cells[0].Value.ToString();
                string queryBajaLogicaRol = "UPDATE [LOS_GDDS].[roles] SET [habilitado] = 0 WHERE [id_rol] = " + idRol;
                SqlCommand ejecutar = new SqlCommand(queryBajaLogicaRol, conexion);
                ejecutar.ExecuteNonQuery();

                new SqlCommand("DELETE FROM LOS_GDDS.roles_usuario WHERE id_rol = " + idRol, conexion).ExecuteNonQuery();

                conexion.Close();

                this.cargarRoles();
            }
        }

        private void FormABMRol_Load(object sender, EventArgs e)
        {
            this.cargarRoles();
        }

        #endregion
    }
}
