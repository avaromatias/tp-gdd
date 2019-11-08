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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataTable dataRol = (DataTable) lbxFuncionalidadesRol.DataSource;
            DataRow rowRol = dataRol.NewRow();
            DataRowView dataRowViewTodas = (DataRowView) lbxFuncionalidadesTodas.SelectedItem;
            rowRol["id_funcionalidad"] = dataRowViewTodas.Row["id_funcionalidad"];
            rowRol["nombre"] = dataRowViewTodas.Row["nombre"];
            dataRol.Rows.Add(rowRol);
            lbxFuncionalidadesRol.DataSource = dataRol;
            dataRowViewTodas.Row.Delete();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            DataTable dataTodas = (DataTable)lbxFuncionalidadesTodas.DataSource;
            DataRow rowRol = dataTodas.NewRow();
            DataRowView dataRowViewRol = (DataRowView)lbxFuncionalidadesRol.SelectedItem;
            rowRol["id_funcionalidad"] = dataRowViewRol.Row["id_funcionalidad"];
            rowRol["nombre"] = dataRowViewRol.Row["nombre"];
            dataTodas.Rows.Add(rowRol);
            lbxFuncionalidadesTodas.DataSource = dataTodas;
            dataRowViewRol.Row.Delete();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarDatos()
        {
            conexion.Open();

            string queryDelete = "DELETE [LOS_GDDS].[funcionalidades_rol] WHERE [id_rol] = " + idRol;
            SqlCommand ejecutar = new SqlCommand(queryDelete, conexion);
            ejecutar.ExecuteNonQuery();

            string queryInsert, idFuncionalidad;
            SqlCommand insertar;

            for (int i = 0; i < lbxFuncionalidadesRol.Items.Count; i++)
            {
                DataRowView funcionalidad = (DataRowView) lbxFuncionalidadesRol.Items[i];
                queryInsert = "INSERT INTO [LOS_GDDS].[funcionalidades_rol] VALUES (" + idRol + ", " + funcionalidad.Row["id_funcionalidad"] + ")";
                insertar = new SqlCommand(queryInsert, conexion);
                insertar.ExecuteNonQuery();
            }

            conexion.Close();
        }

        private bool camposCompletos()
        {
            return txtRol.Text != "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.camposCompletos())
            {
                guardarDatos();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre para el rol.");
            }
        }
    }
}