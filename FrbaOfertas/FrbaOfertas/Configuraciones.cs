using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace FrbaOfertas
{
    class Configuraciones
    {
        public static FormLogin formLogin;
        public static String stringConexion = ConfigurationManager.ConnectionStrings["FrbaOfertas.Properties.Settings.Setting"].ConnectionString;
        public static int cantidadMaximaIntentosLogin = 3;
        public static int usuario;
    }
}
