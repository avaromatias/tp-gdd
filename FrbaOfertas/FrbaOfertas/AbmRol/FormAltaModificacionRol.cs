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
    public partial class FormAltaModificacionRol : Form
    {
        #region Variables

        SqlConnection conexion;
        FormSeleccionarProveedor padre;
        int idRol;
        Boolean esAlta;

        #endregion

        // Constructor Alta
        public FormAltaModificacionRol(FormSeleccionarProveedor padre)
        {
            InitializeComponent();
            conexion = new SqlConnection(Configuracion.stringConexion);
            this.padre = padre;
            lblHabilitado.Visible = false;
            cmbHabilitado.Visible = false;
            txtRol.Width = 528;
            this.cargarTodasLasFuncionalidades();
            this.cargarEstructuraTabla();
            esAlta = true;
        }

        // Constructor modificación
        public FormAltaModificacionRol(FormSeleccionarProveedor padre, int unIdRol)
        {
            InitializeComponent();
            conexion = new SqlConnection(Configuracion.stringConexion);
            this.padre = padre;
            idRol = unIdRol;
            this.cargarDatos();
            esAlta = false;
        }

        #region Métodos

        private void cargarTodasLasFuncionalidades()
        {
            conexion.Open();
            string query = "SELECT [id_funcionalidad], [nombre] FROM [LOS_GDDS].[funcionalidades]";
            SqlCommand listar = new SqlCommand(query, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(listar);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            lbxFuncionalidadesTodas.DataSource = tabla;
            lbxFuncionalidadesTodas.DisplayMember = "nombre";
            conexion.Close();
        }

        private void cargarEstructuraTabla()
        {
            conexion.Open();
            string query = "SELECT [id_funcionalidad], [nombre] FROM [LOS_GDDS].[funcionalidades] WHERE [id_funcionalidad] IS NULL";
            SqlCommand listar = new SqlCommand(query, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(listar);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            lbxFuncionalidadesRol.DataSource = tabla;
            lbxFuncionalidadesRol.DisplayMember = "nombre";
            conexion.Close();
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

        private void cargarHabilitado()
        {
            string query = "SELECT CAST([habilitado] AS INT) FROM [LOS_GDDS].[roles] WHERE [id_rol] = " + idRol;
            SqlCommand ejecutar = new SqlCommand(query, conexion);
            cmbHabilitado.SelectedIndex = int.Parse(ejecutar.ExecuteScalar().ToString());
        }

        public void cargarDatos()
        {
            conexion.Open();

            this.cargarFuncionalidadesDisponibles();
            this.cargarFuncionalidadesRestantes();
            this.cargarNombre();
            if (!esAlta)
            {
                this.cargarHabilitado();
            }

            conexion.Close();
        }

        private void guardarDatos()
        {
            if (!esAlta)
            {
                conexion.Open();

                string queryUpdateNombre = "UPDATE [LOS_GDDS].[roles] SET [nombre] = '" + txtRol.Text + "' WHERE [id_rol] = " + idRol;
                SqlCommand ejecutarUpdateNombre = new SqlCommand(queryUpdateNombre, conexion);
                ejecutarUpdateNombre.ExecuteNonQuery();

                string queryUpdateHabilitado = "UPDATE [LOS_GDDS].[roles] SET [habilitado] = '" + cmbHabilitado.SelectedIndex + "' WHERE [id_rol] = " + idRol;
                SqlCommand ejecutarUpdateHabilitado = new SqlCommand(queryUpdateHabilitado, conexion);
                ejecutarUpdateHabilitado.ExecuteNonQuery();

                string queryDelete = "DELETE [LOS_GDDS].[funcionalidades_rol] WHERE [id_rol] = " + idRol;
                SqlCommand ejecutarDelete = new SqlCommand(queryDelete, conexion);
                ejecutarDelete.ExecuteNonQuery();

                string queryInsert, idFuncionalidad;
                SqlCommand insertar;

                for (int i = 0; i < lbxFuncionalidadesRol.Items.Count; i++)
                {
                    DataRowView funcionalidad = (DataRowView)lbxFuncionalidadesRol.Items[i];
                    idFuncionalidad = funcionalidad.Row["id_funcionalidad"].ToString();
                    queryInsert = "INSERT INTO [LOS_GDDS].[funcionalidades_rol] VALUES (" + idRol + ", " + idFuncionalidad + ")";
                    insertar = new SqlCommand(queryInsert, conexion);
                    insertar.ExecuteNonQuery();
                }

                conexion.Close();
            }
            else
            {
                conexion.Open();

                string queryInsertFuncionalidades, idFuncionalidad;
                SqlCommand insertarFuncionalidad, insertarRol;

                // INSERTAR ROL
                insertarRol = new SqlCommand("[LOS_GDDS].[insertar_nuevo_rol]", conexion);
                insertarRol.CommandType = CommandType.StoredProcedure;
                insertarRol.Parameters.AddWithValue("@Nombre", txtRol.Text);
                insertarRol.Parameters.AddWithValue("@Habilitado", 1);

                var idRol = insertarRol.Parameters.Add("@IdRol", SqlDbType.Int);
                idRol.Direction = ParameterDirection.Output;
                SqlDataReader data = insertarRol.ExecuteReader();
                string idNuevoRol = idRol.Value.ToString();

                conexion.Close();

                // INSERTAR FUNCIONALIDADES DEL ROL
                for (int i = 0; i < lbxFuncionalidadesRol.Items.Count; i++)
                {
                    conexion.Open();

                    DataRowView funcionalidad = (DataRowView)lbxFuncionalidadesRol.Items[i];
                    idFuncionalidad = funcionalidad.Row["id_funcionalidad"].ToString();
                    queryInsertFuncionalidades = "INSERT INTO [LOS_GDDS].[funcionalidades_rol] VALUES (" + idNuevoRol + ", " + idFuncionalidad + ")";
                    insertarFuncionalidad = new SqlCommand(queryInsertFuncionalidades, conexion);
                    insertarFuncionalidad.ExecuteNonQuery();

                    conexion.Close();
                }
            }
        }

        private bool camposCompletos()
        {
            return txtRol.Text != "";
        }

        #endregion

        #region Eventos

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataTable dataRol = (DataTable)lbxFuncionalidadesRol.DataSource;
            DataRow rowRol = dataRol.NewRow();
            DataRowView dataRowViewTodas = (DataRowView)lbxFuncionalidadesTodas.SelectedItem;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.camposCompletos())
            {
                guardarDatos();
                this.Close();
                this.padre.cargarRoles();
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre para el rol.");
            }
        }

        #endregion
    }
}