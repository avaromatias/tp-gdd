using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaOfertas
{
    public partial class FormCargarCredito : Form
    {
        #region Variables

        static SqlConnection conexion;
        int idCliente;

        #endregion

        public FormCargarCredito(int idCliente)
        {
            InitializeComponent();
            conexion = new SqlConnection(Configuracion.stringConexion);
            this.idCliente = idCliente;
        }

        #region Métodos

        private Boolean validarCampos()
        {
            if (txtMonto.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar un monto.");
                return false;
            }
            else if (int.Parse(txtMonto.Text) < 0)
            {
                MessageBox.Show("Debe ingresar un monto válido.");
                return false;
            }
            else if (cmbTiposPago.SelectedIndex < 0 || cmbTiposPago.SelectedIndex > 2)
            {
                MessageBox.Show("Seleccione un tipo de pago válido.");
                return false;
            }
            return true;
        }

        #endregion

        #region Eventos

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (this.validarCampos())
            {
                try
                {
                    conexion.Open();

                    if(cmbTiposPago.SelectedIndex == 0) // Efectivo
                    {
                        string queryInsert = "INSERT INTO [LOS_GDDS].[cargas_realizadas] VALUES (" + this.idCliente + ", NULL, " + "(CONVERT(DATETIME, '" + Configuracion.fecha + "', 105)), " + txtMonto.Text + ")";
                        SqlCommand ejecutarInsertCargasRealizadas = new SqlCommand(queryInsert, conexion);
                        ejecutarInsertCargasRealizadas.ExecuteNonQuery();
                    }
                    else if (cmbTiposPago.SelectedIndex == 1 || cmbTiposPago.SelectedIndex == 2) // Crédito o débito
                    {
                        DataRowView TarjetaSeleccionada = (DataRowView)cmbTarjetas.SelectedItem;
                        int idTarjetaSeleccionada = (int)TarjetaSeleccionada.Row["id_tarjeta"];
                        string queryInsert = "INSERT INTO [LOS_GDDS].[cargas_realizadas] VALUES (" + this.idCliente + ", " + idTarjetaSeleccionada + ", " + "(CONVERT(DATETIME, '" + Configuracion.fecha + "', 105)), " + txtMonto.Text + ")";
                        SqlCommand ejecutarInsertCargasRealizadas = new SqlCommand(queryInsert, conexion);
                        ejecutarInsertCargasRealizadas.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un tipo de pago válido.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void FormCargarCredito_Load(object sender, EventArgs e)
        {
            btnCargar.Location = new Point(btnCargar.Location.X ,60);
            this.Height = 130;
        }

        private void cmbTiposPago_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int tipoDePagoSeleccionado = cmbTiposPago.SelectedIndex;
            string queryTarjetas;
            DataTable table = new DataTable();
            SqlDataAdapter adapter;
            SqlCommand cargarTarjetas;
            switch (tipoDePagoSeleccionado)
            {
                case 0: //Efectivo
                    pnlTarjeta.Visible = false;
                    btnCargar.Location = new Point(btnCargar.Location.X, 60);
                    this.Height = 130;
                    break;
                case 1: //Crédito
                    conexion.Open();
                    queryTarjetas = "SELECT [id_tarjeta], [numero], [fecha_vencimiento] FROM [LOS_GDDS].[tarjetas] WHERE [id_cliente] = " + idCliente + " AND [id_tipo_tarjeta] = 1";
                    cargarTarjetas = new SqlCommand(queryTarjetas, conexion);
                    adapter = new SqlDataAdapter(cargarTarjetas);
                    conexion.Close();
                    adapter.Fill(table);
                    cmbTarjetas.DataSource = table;
                    cmbTarjetas.DisplayMember = "numero";
                    pnlTarjeta.Visible = true;
                    btnCargar.Location = new Point(btnCargar.Location.X, 178);
                    this.Height = 247;
                    break;
                case 2: //Débito
                    conexion.Open();
                    queryTarjetas = "SELECT [numero], [fecha_vencimiento] FROM [LOS_GDDS].[tarjetas] WHERE [id_cliente] = " + idCliente + " AND [id_tipo_tarjeta] = 2";
                    cargarTarjetas = new SqlCommand(queryTarjetas, conexion);
                    adapter = new SqlDataAdapter(cargarTarjetas);
                    conexion.Close();
                    adapter.Fill(table);
                    cmbTarjetas.DataSource = table;
                    cmbTarjetas.DisplayMember = "numero";
                    pnlTarjeta.Visible = true;
                    btnCargar.Location = new Point(btnCargar.Location.X, 178);
                    this.Height = 247;
                    break;
                default:
                    break;
            }
        }

        private void cmbTarjetas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRowView tarjetaSeleccionada = (DataRowView)cmbTarjetas.SelectedItem;
            string numeroTarjetaSeleccionada = cmbTarjetas.Text;
            string fechaVencimientoTarjetaSeleccionada = tarjetaSeleccionada.Row["fecha_vencimiento"].ToString();
            this.txtNumeroTarjeta.Text = numeroTarjetaSeleccionada;
            this.txtVencimientoTarjeta.Text = fechaVencimientoTarjetaSeleccionada;
        }

        // Para que el textbox solo acepte números
        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}