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
    public partial class FormComprarOfertas : Form
    {

        #region Variables

        SqlConnection conexion;

        #endregion

        public FormComprarOfertas()
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
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            int idOferta = int.Parse(gvwOfertas.SelectedRows[0].Cells[0].Value.ToString());


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

        #endregion

        private void dudCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
