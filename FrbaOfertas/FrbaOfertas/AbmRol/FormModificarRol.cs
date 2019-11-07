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
    public partial class FormModificarRol : Form
    {
        SqlConnection conexion;
        int idRol;
        List<String> funcionalidades = new List<String>();
        List<String> funcionalidadesViejas = new List<String>();

        public FormModificarRol(int unIdRol)
        {
            InitializeComponent();
            idRol = unIdRol;
            conexion = new SqlConnection(Configuracion.stringConexion);
            this.cargarDatos();
        }

        private void cargarFuncionalidadesDisponibles()
        {
            SqlCommand listar = new SqlCommand("[LOS_GDDS].[cargar_funcionalidades_disponibles_rol]", conexion);
            listar.CommandType = CommandType.StoredProcedure;
            listar.Parameters.Add("@IdRol", SqlDbType.Int).Value = idRol;
            SqlDataAdapter adapter = new SqlDataAdapter(listar);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            lbxFuncionalidadesTodas.DataSource = tabla;
            lbxFuncionalidadesTodas.DisplayMember = "nombre";
        }

        private void cargarFuncionalidadesRestantes()
        {
            SqlCommand listar = new SqlCommand("[LOS_GDDS].[cargar_funcionalidades_de_rol]", conexion);
            listar.CommandType = CommandType.StoredProcedure;
            listar.Parameters.Add("@IdRol", SqlDbType.Int).Value = idRol;
            SqlDataAdapter adapter = new SqlDataAdapter(listar);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            lbxFuncionalidadesRol.DataSource = tabla;
            lbxFuncionalidadesRol.DisplayMember = "nombre";
        }

        private void cargarNombre()
        {
            string query = "SELECT [nombre] FROM [LOS_GDDS].[roles] WHERE [id_rol] = " + idRol;
            SqlCommand listar = new SqlCommand(query, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(listar);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            txtRol.Text = tabla.Rows[0]["nombre"].ToString();
        }

        public void cargarDatos()
        {
            conexion.Open();

            this.cargarFuncionalidadesDisponibles();
            this.cargarFuncionalidadesRestantes();
            this.cargarNombre();

            conexion.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (camposCompletos())
            {

            }
        }

        private void guardarDatos()
        {
            conexion.Open();
            conexion.Close();
        }

        private bool camposCompletos()
        {
            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lbxFuncionalidadesRol.Items.Add((DataRowView)lbxFuncionalidadesTodas.SelectedItem);
            lbxFuncionalidadesTodas.Items.Remove((DataRowView)lbxFuncionalidadesTodas.SelectedItem);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            lbxFuncionalidadesTodas.Items.Add((DataRowView)lbxFuncionalidadesRol.SelectedItem);
            lbxFuncionalidadesRol.Items.Remove((DataRowView)lbxFuncionalidadesRol.SelectedItem);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}