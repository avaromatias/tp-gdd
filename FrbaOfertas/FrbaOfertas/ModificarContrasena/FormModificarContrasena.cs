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

namespace FrbaOfertas.ModificarContrasena
{
    public partial class FormModificarContrasena : Form
    {
        #region Variables

        SqlConnection conexion;

        #endregion

        public FormModificarContrasena()
        {
            InitializeComponent();
            conexion = new SqlConnection(Configuracion.stringConexion);
        }

        #region Métodos

        private bool validarCampos()
        {
            if (txtNuevaContrasena.Text.Equals("") || txtRepitaNuevaContrasena.Text.Equals(""))
            {
                MessageBox.Show("Complete los datos faltantes.");
                return false;
            }
            if (txtNuevaContrasena.Text.Equals(txtRepitaNuevaContrasena.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return false;
            }
        }

        private void guardarCambios()
        {
            conexion.Open();

            SqlCommand modificarContrasena = new SqlCommand("[LOS_GDDS].[modificar_password]", conexion);
            modificarContrasena.CommandType = CommandType.StoredProcedure;
            modificarContrasena.Parameters.AddWithValue("@IdUsuario", Configuracion.idUsuario);
            modificarContrasena.Parameters.AddWithValue("@NuevaPassword", txtNuevaContrasena.Text);
            var resultado = modificarContrasena.Parameters.Add("@Resultado", SqlDbType.Int);
            resultado.Direction = ParameterDirection.Output;
            SqlDataReader data = modificarContrasena.ExecuteReader();

            conexion.Close();

            switch (int.Parse(resultado.Value.ToString()))
            {
                /* 
                    * 0: ERROR
                    * 1: OK
                */
                case 0:
                    MessageBox.Show("Hubo un error al actualizar los datos.");
                    break;
                case 1:
                    this.Close();
                    MessageBox.Show("La password fue modificada correctamente.");
                    break;
            }
        }

        #endregion

        #region Eventos

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (this.validarCampos())
            {
                this.guardarCambios();
            }
        }

        #endregion


    }
}
