using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Capa_Datos
{
    public class Conexion
    {
        public SqlConnection conectar(string cnx)
        {
            try
            {
                SqlConnection oconectar = new SqlConnection(ConfigurationSettings.AppSettings[cnx].ToString());
                oconectar.Open();//abrir la BD
                return oconectar; //Se le retorna al que lo necesite
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
