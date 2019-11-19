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

namespace FrbaOfertas.CrearOferta
{
    public partial class FormCrearOferta : Form
    {
        #region Variables

        static SqlConnection conexion;
        public int idProveedor;
        bool esAdmin;

        #endregion

        public FormCrearOferta()
        {
            InitializeComponent();
            conexion = new SqlConnection(Configuracion.stringConexion);
        }

        #region Métodos

        private bool validarCampos()
        {
            if (this.esAdmin && this.txtProveedor.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos vacíos.");
                return false;
            }
            if (txtDescripcion.Text.Equals("") || txtPrecioLista.Text.Equals("") || txtPrecioOferta.Text.Equals("") ||
                txtStock.Text.Equals("") || txtUnidadesMaximas.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos vacíos.");
                return false;
            }
            else if (int.Parse(txtPrecioOferta.Text) > int.Parse(txtPrecioLista.Text))
            {
                MessageBox.Show("El precio de oferta debe ser menor al precio de lista.");
                return false;
            }
            else if (int.Parse(txtUnidadesMaximas.Text) > int.Parse(txtStock.Text))
            {
                MessageBox.Show("Las unidades máximas por cliente no pueden exceder el stock.");
                return false;
            }
            else if (dtpFechaVencimiento.Value.CompareTo(dtpFechaPublicacion.Value) <= 0)
            {
                MessageBox.Show("La fecha de vencimiento debe ser posterior a la de publicación.");
                return false;
            }
            return true;
        }

        private void crearOferta()
        {
            try
            {
                conexion.Open();
                SqlCommand insertarOferta = new SqlCommand("[LOS_GDDS].[insertar_nueva_oferta]", conexion);
                insertarOferta.CommandType = CommandType.StoredProcedure;
                insertarOferta.Parameters.AddWithValue("@IdOferta", txtCodigoOferta.Text);
                insertarOferta.Parameters.AddWithValue("@IdProveedor", this.idProveedor);
                insertarOferta.Parameters.AddWithValue("@PrecioLista", int.Parse(txtPrecioLista.Text));
                insertarOferta.Parameters.AddWithValue("@PrecioOferta", int.Parse(txtPrecioOferta.Text));
                insertarOferta.Parameters.AddWithValue("@Stock", int.Parse(txtStock.Text));
                insertarOferta.Parameters.AddWithValue("@UnidadesMaximas", int.Parse(txtUnidadesMaximas.Text));
                insertarOferta.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                insertarOferta.Parameters.AddWithValue("@FechaVencimiento", dtpFechaVencimiento.Value);
                insertarOferta.Parameters.AddWithValue("@FechaPublicacion", dtpFechaPublicacion.Value);
                SqlDataReader dataCliente = insertarOferta.ExecuteReader();
                MessageBox.Show("La oferta fue creada correctamente.");
                conexion.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al crear la oferta solicitada. | " + ex.Message);
                conexion.Close();
            }
        }

        #endregion

        #region Eventos

        private void FormCrearOferta_Load(object sender, EventArgs e)
        {
            conexion.Open();
            string query = "SELECT [nombre] FROM [LOS_GDDS].[roles] WHERE [id_rol] = " + Configuracion.idRol;
            SqlCommand ejecutar = new SqlCommand(query, conexion);
            string nombreRol = "";
            try
            {
                nombreRol = (string)ejecutar.ExecuteScalar();
            }
            catch
            {
                MessageBox.Show("No es posible verificar que su rol tenga permisos para acceder a esta funcionalidad.");
            }
            finally
            {
                conexion.Close();
            }
            if (!nombreRol.Equals("Administrador"))
            {
                pnlAdministrador.Visible = false;
                pnlProveedor.Location = new Point(12, 12);
                btnCrearOferta.Location = new Point(btnCrearOferta.Location.X, 220);
                this.Height = 290;
                conexion.Open();
                string queryIdProveedor = "SELECT [id_proveedor] FROM [LOS_GDDS].[usuarios] WHERE [id_usuario] = " + Configuracion.idUsuario;
                SqlCommand ejecutarIdProveedor = new SqlCommand(queryIdProveedor, conexion);
                try
                {
                    this.idProveedor = (int)ejecutarIdProveedor.ExecuteScalar();
                    this.esAdmin = false;
                }
                catch
                {
                    MessageBox.Show("Esta funcionalidad es exclusiva para proveedores.");
                    this.Close();
                }
                finally
                {
                    conexion.Close();
                }
            }
            else
            {
                this.esAdmin = true;
            }
            dtpFechaPublicacion.MinDate = Configuracion.fecha.ToLocalTime();
            dtpFechaVencimiento.MinDate = Configuracion.fecha.ToLocalTime();
        }

        private void txtPrecioLista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioOferta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUnidadesMaximas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSeleccionarProveedor_Click(object sender, EventArgs e)
        {
            FormSeleccionarProveedor seleccionarProveedor = new FormSeleccionarProveedor(this);
            seleccionarProveedor.ShowDialog();
        }

        private void btnCrearOferta_Click(object sender, EventArgs e)
        {
            if (this.validarCampos())
            {
                this.crearOferta();
            }
        }

        #endregion
    }
}
