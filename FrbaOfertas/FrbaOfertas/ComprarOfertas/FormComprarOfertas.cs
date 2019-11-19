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

namespace FrbaOfertas.ComprarOferta
{
    public partial class FormConsumirOferta : Form
    {

        #region Variables

        SqlConnection conexion;

        #endregion

        public FormConsumirOferta()
        {
            InitializeComponent();
            conexion = new SqlConnection(Configuracion.stringConexion);
        }

        #region Métodos

        private void buscarOfertas()
        {
            conexion.Open();
            SqlCommand listar = new SqlCommand("[LOS_GDDS].[cargar_ofertas_vigentes]", conexion);
            listar.CommandType = CommandType.StoredProcedure;
            listar.Parameters.Add("@FechaActual", SqlDbType.DateTime).Value = Configuracion.fecha;
            listar.Parameters.Add("@DescripcionOferta", SqlDbType.NVarChar).Value = txtOferta.Text;
            listar.Parameters.Add("@RazonSocialProveedor", SqlDbType.NVarChar).Value = txtProveedor.Text;
            listar.Parameters.Add("@FechaVencimiento", SqlDbType.DateTime).Value = dtpFechaVencimiento.Value;
            SqlDataAdapter adapter = new SqlDataAdapter(listar);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            gvwOfertas.DataSource = tabla;
            gvwOfertas.Columns[0].Visible = false;
            conexion.Close();
        }

        #endregion

        #region Eventos

        private void FormComprarOfertas_Load(object sender, EventArgs e)
        {
            dtpFechaVencimiento.Value = dtpFechaVencimiento.MaxDate;
            this.buscarOfertas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.buscarOfertas();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtOferta.Clear();
            txtProveedor.Clear();
            this.buscarOfertas();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            string idOferta = gvwOfertas.SelectedRows[0].Cells[0].Value.ToString();
            int idCliente = 0;
            conexion.Open();
            string queryIdCliente = "SELECT [id_cliente] FROM [LOS_GDDS].[usuarios] WHERE [id_usuario] = " + Configuracion.idUsuario;
            SqlCommand ejecutarIdCliente = new SqlCommand(queryIdCliente, conexion);
            try
            {
                idCliente = (int)ejecutarIdCliente.ExecuteScalar();
            }
            catch
            {
                MessageBox.Show("Esta funcionalidad es exclusiva para clientes.");
                this.Close();
            }
            finally
            {
                conexion.Close();
            }

            if (idCliente != 0)
            {
                try
                {
                    conexion.Open();
                    SqlCommand crearOferta = new SqlCommand("[LOS_GDDS].[comprar_oferta]", conexion);
                    crearOferta.CommandType = CommandType.StoredProcedure;
                    crearOferta.Parameters.AddWithValue("@IdOferta", idOferta);
                    crearOferta.Parameters.AddWithValue("@IdCliente", idCliente);
                    crearOferta.Parameters.AddWithValue("@Fecha", Configuracion.fecha);
                    crearOferta.Parameters.AddWithValue("@Cantidad", dudCantidad.Text);
                    var respuesta = crearOferta.Parameters.Add("@Respuesta", SqlDbType.Int);
                    var idCompra = crearOferta.Parameters.Add("@IdCompra", SqlDbType.Int);
                    respuesta.Direction = ParameterDirection.Output;
                    idCompra.Direction = ParameterDirection.Output;

                    SqlDataReader dataOferta = crearOferta.ExecuteReader();
                    conexion.Close();
                    switch (int.Parse(respuesta.Value.ToString()))
                    {
                        case 0:
                            MessageBox.Show("Saldo insuficiente.");
                            break;
                        case 1:
                            MessageBox.Show("No puede superar el límite de unidades máximas por cliente.");
                            break;
                        case 2:
                            MessageBox.Show("La compra N°" + idCompra.Value + " fue efectuada correctamente.");
                            this.buscarOfertas();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error al comprar la oferta solicitada. | " + ex.Message);
                    conexion.Close();
                }
            }
        }

        private void gvwOfertas_MouseCaptureChanged(object sender, EventArgs e)
        {
            dudCantidad.Items.Clear();
            int stockDisponible = int.Parse(gvwOfertas.SelectedRows[0].Cells[5].Value.ToString());
            for (int i = 1; i <= stockDisponible; i++)
            {
                dudCantidad.Items.Add(i);
            }
            dudCantidad.SelectedIndex = 0;
        }

        private void dudCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion
    }
}
