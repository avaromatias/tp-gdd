using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace FrbaOfertas
{
    class Configuracion
    {
        /* LOGIN */
        public static FormLogin formLogin;
        public static String stringConexion = ConfigurationManager.ConnectionStrings["FrbaOfertas.Properties.Settings.Setting"].ConnectionString;
        public static int cantidadMaximaIntentosLogin = 3;
        public static int idUsuario;
        public static int idRol;

        /* FUNCIONALIDADES */
        public const int abmRoles = 1,
            abmClientes = 2,
            abmProveedores = 3,
            modificarPassword = 4,
            bajaUsuario = 5,
            cargarCredito = 6,
            comprarOferta = 7,
            altaOferta = 8,
            facturarProveedor = 9,
            listadoEstadistico = 10,
            consumirOferta = 11;
    }
}
