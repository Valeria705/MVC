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
    public class CD_Curso
    {
        Conexion materias = new Conexion();
        SqlCommand estudios = new SqlCommand();

        public bool guardar_curso(CE_Curso conect1)
        {
            try
            {
                estudios.CommandType = CommandType.StoredProcedure;
                estudios.Connection = materias.conectar("BD_Colegio");
                estudios.CommandText = "Insertar_Curso";
                estudios.Parameters.Add("@Id_Curso", conect1.Id_Curso);
                estudios.Parameters.Add("@Nom_Curso", conect1.Nom_Curso);
                estudios.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool modificar_curso(CE_Curso curso)
        {
            try
            {
                estudios.CommandType = CommandType.StoredProcedure;
                estudios.Connection = materias.conectar("BD_Colegio");
                estudios.CommandText = "Modif_Curso";
                estudios.Parameters.Add("@Id_Curso", curso.Id_Curso);
                estudios.Parameters.Add("@Nom_Curso", curso.Nom_Curso);
                estudios.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }


        
        public bool eliminar_curso(string Id)
        {
            try
            {
                estudios.CommandType = CommandType.StoredProcedure;
                estudios.Connection = materias.conectar("BD_Colegio");
                estudios.CommandText = "Borrar_Curso";
                estudios.Parameters.Add("@Id_Curso", Id);
                estudios.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /*public bool anula_cursos(CE_Curso conect2)
        {
            try
            {
                estudios.CommandType = CommandType.StoredProcedure;
                estudios.Connection = materias.conectar("BD_Colegio");
                estudios.CommandText = "modificar_curso";
                estudios.Parameters.Add("@Id_Curso", conect2.Id_Curso);
                estudios.Parameters.Add("@Nom_Curso", conect2.Nom_Curso);
                estudios.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }*/

        public CE_Curso consultar_curso(string Id_Curso)
        {
            try
            {
                estudios.CommandType = CommandType.StoredProcedure;
                estudios.Connection = materias.conectar("BD_Colegio");
                estudios.CommandText = "Consul_Curso";
                estudios.Parameters.Add("@Id_Curso", Id_Curso);
                SqlDataAdapter informe = new SqlDataAdapter(estudios);
                DataSet consulta = new DataSet();
                informe.Fill(consulta);

                DataTable dt = consulta.Tables[0];
                DataRow row = dt.Rows[0];

                CE_Curso curso = new CE_Curso();

                curso.Id_Curso = Convert.ToString(row["Id_Curso"]);
                curso.Nom_Curso = Convert.ToString(row["Nom_Curso"]);

                return curso;

            }
            catch (Exception e)
            {

                throw e;
            }
        }


        public List<CE_Curso> consultar_cursos()
        {
            try
            {
                estudios.CommandType = CommandType.StoredProcedure;
                estudios.Connection = materias.conectar("BD_Colegio");
                estudios.CommandText = "Consul_Cursos";

                SqlDataAdapter informe = new SqlDataAdapter(estudios);
                DataSet consulta = new DataSet();
                informe.Fill(consulta);

                DataTable dt = consulta.Tables[0];

                List<CE_Curso> lista = new List<CE_Curso>();

                foreach (DataRow row in dt.Rows)
                {
                    CE_Curso x = new CE_Curso();
                    x.Id_Curso = Convert.ToString(row["Id_Curso"]);
                    x.Nom_Curso = Convert.ToString(row["Nom_Curso"]);
                    lista.Add(x);
                }

                return lista;

            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
