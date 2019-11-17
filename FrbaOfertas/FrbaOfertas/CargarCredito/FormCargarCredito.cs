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
                MessageBox.Show("Debe ingresar un nombre de usuario y contraseña.");
                return false;
            }
            else
            {
                if (txtMonto.Text.Equals(""))
                {
                    MessageBox.Show("Debe ingresar un nombre de usuario.");
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region Eventos

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                try
                {
                    conexion.Open();
                    SqlCommand validarLogin = new SqlCommand("[LOS_GDDS].[validar_login]", conexion);
                    validarLogin.CommandType = CommandType.StoredProcedure;
                    validarLogin.Parameters.AddWithValue("@Usuario", txtMonto.Text);
                    validarLogin.Parameters.AddWithValue("@MaxIntentos", Configuracion.cantidadMaximaIntentosLogin);

                    var resultado = validarLogin.Parameters.Add("@Resultado", SqlDbType.Int);
                    var idUsuario = validarLogin.Parameters.Add("@Id", SqlDbType.Int);
                    var idRol = validarLogin.Parameters.Add("@Rol", SqlDbType.Int);
                    resultado.Direction = ParameterDirection.Output;
                    idUsuario.Direction = ParameterDirection.Output;
                    idRol.Direction = ParameterDirection.Output;

                    SqlDataReader data = validarLogin.ExecuteReader();

                    switch (int.Parse(resultado.Value.ToString()))
                    {
                        /* 
                         * 0: El usuario no existe
                         * 1: Intentos excedidos
                         * 2: La password no coincide
                         * 3: El usuario no está habilitado
                         * 4: Login exitoso
                        */
                        case 0:
                        case 2:
                            MessageBox.Show("Los datos ingresados son incorrectos.");
                            break;
                        case 3:
                            MessageBox.Show("El usuario se encuentra inhabilitado.");
                            break;
                        case 1:
                            MessageBox.Show("Excedió la cantidad de intentos permitidos.");
                            break;
                        case 4:
                            Configuracion.idUsuario = int.Parse(idUsuario.Value.ToString());
                            Configuracion.idRol = int.Parse(idRol.Value.ToString());
                            FormMenuPrincipal form = new FormMenuPrincipal(this);
                            form.Show();
                            this.Hide();
                            txtMonto.Text = "";
                            break;
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

        #endregion

        private void cmbTiposPago_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int tipoDePagoSeleccionado = cmbTiposPago.SelectedIndex;
            string queryTarjetas;
            DataTable table = new DataTable();
            SqlDataAdapter adapter;
            SqlCommand cargarTarjetas;
            switch(tipoDePagoSeleccionado)
            {
                case 0: //Efectivo
                    pnlTarjeta.Visible = false;
                    btnCargar.Location = new Point(btnCargar.Location.X, 60);
                    this.Height = 130;
                    break;
                case 1: //Crédito
                    conexion.Open();
                    queryTarjetas = "SELECT [numero], [fecha_vencimiento] FROM [LOS_GDDS].[tarjetas] WHERE [id_cliente] = " + idCliente + " AND [id_tipo_tarjeta] = 1";
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
    }
}