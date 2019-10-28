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
            abmProveedor = 3,
            cargarCredito = 4,
            altaOferta = 5,
            comprarOferta = 6,
            consumirOferta = 7,
            facturarProveedor = 8,
            listadoEstadistico = 9;
    }
}
