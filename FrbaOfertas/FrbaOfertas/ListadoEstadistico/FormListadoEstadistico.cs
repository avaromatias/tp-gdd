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

namespace FrbaOfertas.ListadoEstadistico
{
    public partial class FormListadoEstadistico : Form
    {
        #region Variables

        SqlConnection conexion;

        #endregion

        public FormListadoEstadistico()
        {
            InitializeComponent();
            conexion = new SqlConnection(Configuracion.stringConexion);
        }

        #region Métodos

        private void realizarConsulta()
        {
            int mayorPorcentaje = 0;
            int mayorFacturacion = 1;

            if (cmbModos.SelectedIndex == mayorPorcentaje)
            {
                conexion.Open();
                SqlCommand listar = new SqlCommand("[LOS_GDDS].[cargar_listado_estadistico_mayor_porcentaje]", conexion);
                listar.CommandType = CommandType.StoredProcedure;
                listar.Parameters.AddWithValue("@FechaDesde", dtpFechaDesde.Value);
                listar.Parameters.AddWithValue("@FechaHasta", dtpFechaHasta.Value);
                SqlDataAdapter adapter = new SqlDataAdapter(listar);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                gvwTop5.DataSource = tabla;
                gvwTop5.Columns[0].Width = 158;
                gvwTop5.Columns[1].Width = 158;
                conexion.Close();
                foreach (DataGridViewColumn column in gvwTop5.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            else if (cmbModos.SelectedIndex == mayorFacturacion)
            {
                conexion.Open();
                SqlCommand listar = new SqlCommand("[LOS_GDDS].[cargar_listado_estadistico_mayor_facturacion]", conexion);
                listar.CommandType = CommandType.StoredProcedure;
                listar.Parameters.AddWithValue("@FechaDesde", dtpFechaDesde.Value);
                listar.Parameters.AddWithValue("@FechaHasta", dtpFechaHasta.Value);
                SqlDataAdapter adapter = new SqlDataAdapter(listar);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                gvwTop5.DataSource = tabla;
                gvwTop5.Columns[0].Width = 158;
                gvwTop5.Columns[1].Width = 158;
                conexion.Close();
                foreach (DataGridViewColumn column in gvwTop5.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
        }

        #endregion

        #region Eventos

        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            int cantidadMeses = 5;
            dtpFechaHasta.Value = dtpFechaDesde.Value.AddMonths(cantidadMeses);
        }

        private void FormListadoEstadistico_Load(object sender, EventArgs e)
        {
            cmbModos.SelectedIndex = 0;
            int cantidadMeses = -5;
            dtpFechaDesde.Value = DateTime.Now.AddMonths(cantidadMeses);
            this.realizarConsulta();
            foreach (DataGridViewColumn column in gvwTop5.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.realizarConsulta();
        }

        #endregion
    }
}
