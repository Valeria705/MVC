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
    public class CD_Docente
    {
        Conexion profesores = new Conexion();
        SqlCommand saber = new SqlCommand();

        public bool guardar_Docente(CE_Docente oprofesor1)
        {
            try
            {
                saber.CommandType = CommandType.StoredProcedure;
                saber.Connection = profesores.conectar("BD_Colegio");
                saber.CommandText = "agregar_Docente";
                saber.Parameters.Add("@ID_Docente", oprofesor1.ID_Docente1);
                saber.Parameters.Add("@Nom_Docente", oprofesor1.Nom_Docente1);
                saber.Parameters.Add("@Dire_Docente", oprofesor1.Dire_Docente1);
                saber.Parameters.Add("@Tel_Docente", oprofesor1.Tel_Docente1);
                saber.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool anular_Docente(CE_Docente oprofesor2)
        {
            try
            {
                saber.CommandType = CommandType.StoredProcedure;
                saber.Connection = profesores.conectar("BD_Colegio");
                saber.CommandText = "modificar_Docente";
                saber.Parameters.Add("@ID_Docente", oprofesor2.ID_Docente1);
                saber.Parameters.Add("@Nom_Docente", oprofesor2.Nom_Docente1);
                saber.Parameters.Add("@Dire_Docente", oprofesor2.Dire_Docente1);
                saber.Parameters.Add("@Tel_Docente", oprofesor2.Tel_Docente1);
                saber.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet Consultar_Docente(CE_Docente oprofesor3)
        {
            try
            {
                saber.CommandType = CommandType.StoredProcedure;
                saber.Connection = profesores.conectar("BD_Colegio");
                saber.CommandText = "consultar_Docente";
                saber.Parameters.Add("@ID_Docente", oprofesor3.ID_Docente1);
                SqlDataAdapter info = new SqlDataAdapter(saber);
                DataSet consulta = new DataSet();
                info.Fill(consulta);
                return consulta;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
