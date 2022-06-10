using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capa_Entidad;
using System.Data;

namespace Capa_Datos
{
    public class CD_Oficina
    {
        Conexion casa = new Conexion();
        SqlCommand ofi = new SqlCommand();

        public bool guardar_oficina(CE_Oficina ofi1)
        {
            try
            {
                ofi.CommandType = CommandType.StoredProcedure;
                ofi.Connection = casa.conectar("BD_Colegio");
                ofi.CommandText = "insertar_oficina";
                ofi.Parameters.Add("@Id_Oficina", ofi1.Id_Oficina1);
                ofi.Parameters.Add("@Nom_Oficina", ofi1.Nom_Oficina1);
                ofi.Parameters.Add("@Tel_Oficina", ofi1.Tel_Oficina1);
                ofi.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool anular_oficina(CE_Oficina ofi2)
        {
            try
            {
                ofi.CommandType = CommandType.StoredProcedure;
                ofi.Connection = casa.conectar("BD_Colegio");
                ofi.CommandText = "modificar_oficina";
                ofi.Parameters.Add("@Id_Oficina", ofi2.Id_Oficina1);
                ofi.Parameters.Add("@Nom_Oficina", ofi2.Nom_Oficina1);
                ofi.Parameters.Add("@Tel_Oficina", ofi2.Tel_Oficina1);
                ofi.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet consultar_oficina(CE_Oficina ofi3)
        {
            ofi.CommandType = CommandType.StoredProcedure;
            ofi.Connection = casa.conectar("BD_Colegio");
            ofi.CommandText = "consultar_oficina";
            ofi.Parameters.Add("@Id_Oficina", ofi3.Id_Oficina1);
            SqlDataAdapter info = new SqlDataAdapter(ofi);
            DataSet consulta = new DataSet();
            info.Fill(consulta);
            return consulta;
        }
    }
}
