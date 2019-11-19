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

namespace FrbaOfertas.ConsumirOferta
{
    public partial class FormConsumirOferta : Form
    {

        #region Variables

        SqlConnection conexion;
        int idCliente;
        int idProveedor;

        #endregion

        public FormConsumirOferta(int idCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;
            conexion = new SqlConnection(Configuracion.stringConexion);
            conexion.Open();
            string queryIdProveedor = "SELECT [id_proveedor] FROM [LOS_GDDS].[usuarios] WHERE [id_usuario] = " + Configuracion.idUsuario;
            SqlCommand ejecutarIdProveedor = new SqlCommand(queryIdProveedor, conexion);
            try
            {
                this.idProveedor = (int)ejecutarIdProveedor.ExecuteScalar();
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Esta funcionalidad es exclusiva para proveedores.");
                conexion.Close();
                this.Close();
            }
        }

        #region Métodos

        private void cargarComprasDeCliente()
        {
            conexion.Open();
            SqlCommand listar = new SqlCommand("[LOS_GDDS].[cargar_compras_cliente]", conexion);
            listar.CommandType = CommandType.StoredProcedure;
            listar.Parameters.AddWithValue("@IdCliente", this.idCliente);
            listar.Parameters.AddWithValue("@IdProveedor", this.idProveedor);
            listar.Parameters.AddWithValue("@FechaActual", Configuracion.fecha);
            listar.Parameters.AddWithValue("@FechaVencimiento", dtpFechaVencimiento.Value);
            listar.Parameters.AddWithValue("@Oferta", txtOferta.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(listar);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            gvwOfertas.DataSource = tabla;
            gvwOfertas.Columns[1].Width = 350;
            conexion.Close();
        }

        #endregion

        #region Eventos

        private void FormComprarOfertas_Load(object sender, EventArgs e)
        {
            dtpFechaVencimiento.Value = dtpFechaVencimiento.MaxDate;
            this.cargarComprasDeCliente();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.cargarComprasDeCliente();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtOferta.Clear();
            this.cargarComprasDeCliente();
        }

        private void btnConsumir_Click(object sender, EventArgs e)
        {
            string idCompra = gvwOfertas.SelectedRows[0].Cells[0].Value.ToString();

            DialogResult seleccionUsuario = MessageBox.Show("¿Desea consumir la oferta seleccionada?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (seleccionUsuario == DialogResult.Yes)
            {
                conexion.Open();

                string queryBajaLogicaRol = "UPDATE [LOS_GDDS].[compras] SET [fecha_consumo] = '" + Configuracion.fecha.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE [id_compra] = " + idCompra;
                SqlCommand ejecutar = new SqlCommand(queryBajaLogicaRol, conexion);
                try
                {
                    ejecutar.ExecuteNonQuery();
                }
                catch //(Exception ex)
                {
                    MessageBox.Show("La fecha de consumo debe ser mayor a la fecha de compra");
                    //MessageBox.Show("Hubo un error al consumir la oferta seleccionada. | " + ex.Message);
                }

                conexion.Close();

                this.cargarComprasDeCliente();
            }
        }

        #endregion
    }
}
