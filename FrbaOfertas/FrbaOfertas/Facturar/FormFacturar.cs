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

namespace FrbaOfertas.Facturar
{
    public partial class FormFacturar : Form
    {

        #region Variables

        SqlConnection conexion;
        public int idProveedor = 0;

        #endregion

        public FormFacturar()
        {
            InitializeComponent();
            conexion = new SqlConnection(Configuracion.stringConexion);
        }

        private void btnSeleccionarProveedor_Click(object sender, EventArgs e)
        {
            FormFacturarSeleccionarProveedor seleccionarProveedor = new FormFacturarSeleccionarProveedor(this);
            seleccionarProveedor.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.validarCampos())
            {
                this.cargarCompras();
            }
        }

        private bool validarCampos()
        {
            if (this.idProveedor == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor.");
                return false;
            }
            if (dtpFechaHasta.Value.CompareTo(dtpFechaDesde.Value) <= 0)
            {
                MessageBox.Show("La fecha desde debe ser menor que la fecha hasta.");
                return false;
            }
            return true;
        }

        private void cargarCompras()
        {
            conexion.Open();
            SqlCommand listar = new SqlCommand("[LOS_GDDS].[cargar_compras_a_proveedor]", conexion);
            listar.CommandType = CommandType.StoredProcedure;
            listar.Parameters.AddWithValue("@IdProveedor", this.idProveedor);
            listar.Parameters.AddWithValue("@FechaDesde", dtpFechaDesde.Value);
            listar.Parameters.AddWithValue("@FechaHasta", dtpFechaHasta.Value);
            SqlDataAdapter adapter = new SqlDataAdapter(listar);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            gvwCompras.DataSource = tabla;
            gvwCompras.Columns[1].Width = 230;
            conexion.Close();
        }

        private bool hayCompras()
        {
            return gvwCompras.RowCount > 0;
        }

        private int crearFactura()
        {
            try
            {
                conexion.Open();
                SqlCommand listar = new SqlCommand("[LOS_GDDS].[insertar_nueva_factura]", conexion);
                listar.CommandType = CommandType.StoredProcedure;
                listar.Parameters.AddWithValue("@IdProveedor", this.idProveedor);
                listar.Parameters.AddWithValue("@FechaEmision", Configuracion.fecha);
                listar.Parameters.AddWithValue("@FechaDesde", dtpFechaDesde.Value);
                listar.Parameters.AddWithValue("@FechaHasta", dtpFechaHasta.Value);
                var idFactura = listar.Parameters.Add("@IdFactura", SqlDbType.Int);
                idFactura.Direction = ParameterDirection.Output;
                SqlDataReader data = listar.ExecuteReader();
                conexion.Close();
                return (int)idFactura.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al generar una nueva factura. | " + ex.Message);
                conexion.Close();
                return -1;
            }
        }

        private int getDeFactura(int idFactura, string columna)
        {
            conexion.Open();
            string query = "SELECT CAST([" + columna + "] AS INT) FROM [LOS_GDDS].[facturas] WHERE [id_factura] = " + idFactura;
            SqlCommand ejecutar = new SqlCommand(query, conexion);
            int retorno = int.Parse(ejecutar.ExecuteScalar().ToString());
            conexion.Close();
            return retorno;
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (this.validarCampos())
            {
                this.cargarCompras();
                if (this.hayCompras())
                {
                    int idFactura = this.crearFactura();

                    if (idFactura != -1)
                    {
                        int nroFactura = this.getDeFactura(idFactura, "nro_factura");
                        int totalFacturado = this.getDeFactura(idFactura, "total");

                        MessageBox.Show("Factura N°" + nroFactura + " generada correctamente. Total facturado: $" + totalFacturado);
                    }
                    this.cargarCompras();
                }
                else
                {
                    MessageBox.Show("No hay compras realizadas a " + txtProveedor.Text + "en el período seleccionado.");
                }
            }
        }

        #region Métodos



        #endregion

        #region Eventos



        #endregion
    }
}
