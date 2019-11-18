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
    public partial class FormSeleccionarProveedor : Form
    {
        #region Variables

        SqlConnection conexion;
        FormCrearOferta padre;

        #endregion

        public FormSeleccionarProveedor(FormCrearOferta padre)
        {
            InitializeComponent();
            conexion = new SqlConnection(Configuracion.stringConexion);
            this.padre = padre;
        }

        #region Métodos

        public void cargarProveedores()
        {
            conexion.Open();
            SqlCommand listar = new SqlCommand("[LOS_GDDS].[cargar_proveedores]", conexion);
            listar.CommandType = CommandType.StoredProcedure;
            listar.Parameters.Add("@RazonSocial", SqlDbType.VarChar).Value = txtRazonSocial.Text;
            listar.Parameters.Add("@Cuit", SqlDbType.VarChar).Value = txtCuit.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(listar);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            gvwProveedores.DataSource = tabla;
            gvwProveedores.Columns[0].Visible = false;
            conexion.Close();
        }

        #endregion

        #region Eventos

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.cargarProveedores();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRazonSocial.Text = "";
            this.cargarProveedores();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.padre.txtProveedor.Text = gvwProveedores.SelectedRows[0].Cells[5].Value.ToString();
            this.padre.idProveedor = int.Parse(gvwProveedores.SelectedRows[0].Cells[0].Value.ToString());
            this.Close();
        }

        private void FormABMRol_Load(object sender, EventArgs e)
        {
            this.cargarProveedores();
        }

        #endregion
    }
}
