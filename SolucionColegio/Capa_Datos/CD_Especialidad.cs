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
    public class CD_Especialidad
    {
        Conexion titulo = new Conexion();
        SqlCommand experiencia = new SqlCommand();

        public bool guardar_especialidad(CE_Especialidad oespe1)
        {
            try
            {
                experiencia.CommandType = CommandType.StoredProcedure;
                experiencia.Connection = titulo.conectar("BD_Colegio");
                experiencia.CommandText = "insertar_especialidad";
                experiencia.Parameters.Add("@Id_Especialidad", oespe1.Id_Especialidad1);
                experiencia.Parameters.Add("@Nom_Especialidad", oespe1.Id_Especialidad1);
                experiencia.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool anular_especialidad(CE_Especialidad oespe2)
        {
            try
            {
                experiencia.CommandType = CommandType.StoredProcedure;
                experiencia.Connection = titulo.conectar("BD_Colegio");
                experiencia.CommandText = "modificar_especialidad";
                experiencia.Parameters.Add("@Id_Especialidad", oespe2.Id_Especialidad1);
                experiencia.Parameters.Add("@Nom_Especialidad", oespe2.Id_Especialidad1);
                experiencia.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet consultar_especialidad(CE_Especialidad oespe3)
        {
            try
            {
                experiencia.CommandType = CommandType.StoredProcedure;
                experiencia.Connection = titulo.conectar("BD_Colegio");
                experiencia.CommandText = "consultar_especialidad";
                experiencia.Parameters.Add("@Id_Especialidad", oespe3.Id_Especialidad1);
                SqlDataAdapter info = new SqlDataAdapter(experiencia);
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
