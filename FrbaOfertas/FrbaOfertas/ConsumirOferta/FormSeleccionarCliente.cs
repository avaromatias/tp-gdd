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
    public partial class FormSeleccionarCliente : Form
    {
        SqlConnection conexion;

        public FormSeleccionarCliente()
        {
            InitializeComponent();
            conexion = new SqlConnection(Configuracion.stringConexion);
        }

        private bool validarCampo()
        {
            return !txtUsername.Text.Equals("");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarCampo())
            {
                conexion.Open();
                string query = "SELECT [id_cliente] FROM [LOS_GDDS].[usuarios] WHERE [username] = '" + txtUsername.Text + "'";
                SqlCommand ejecutar = new SqlCommand(query, conexion);
                int idCliente = 0;
                try
                {
                    idCliente = (int)ejecutar.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    MessageBox.Show("No se encontró ningún cliente con ese nombre de usuario.");
                }
                finally
                {
                    conexion.Close();
                }

                if (idCliente != 0)
                {
                    FormConsumirOferta consumirOferta = new FormConsumirOferta(idCliente);
                    try
                    {
                        consumirOferta.Show();
                    }
                    catch
                    {

                    }
                    this.Close();
                }
            }
        }
    }
}
