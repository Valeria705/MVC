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
    public class CD_Alumno
    {
        Conexion estudio = new Conexion();
        SqlCommand avanzados = new SqlCommand();

        public bool guardar_alumno(CE_Alumno oalumno)
        {
            try
            {
                avanzados.CommandType = CommandType.StoredProcedure;
                avanzados.Connection = estudio.conectar("BD_Colegio");
                avanzados.CommandText = "Insertar_Alumno";
                avanzados.Parameters.Add("@Id_Alumno", oalumno.Id_Alumno);
                avanzados.Parameters.Add("@Nom_Alumno", oalumno.Nom_Alumno);
                avanzados.Parameters.Add("@Dir_Alumno", oalumno.Dir_Alumno);
                avanzados.Parameters.Add("@Tel_Alumno", oalumno.Tel_Alumno);
                avanzados.Parameters.Add("@Grp_Alumno", oalumno.Grp_Alumno);
                avanzados.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public bool modificar_alumno(CE_Alumno oalumno)
        {
            try
            {
                avanzados.CommandType = CommandType.StoredProcedure;
                avanzados.Connection = estudio.conectar("BD_Colegio");
                avanzados.CommandText = "Modif_Alumno";



                avanzados.Parameters.Add("@Id_Alumno", oalumno.Id_Alumno);
                avanzados.Parameters.Add("@Nom_Alumno", oalumno.Nom_Alumno);
                avanzados.Parameters.Add("@Dir_Alumno", oalumno.Dir_Alumno);
                avanzados.Parameters.Add("@Tel_Alumno", oalumno.Tel_Alumno);
                avanzados.Parameters.Add("@Grp_Alumno", oalumno.Grp_Alumno);
                avanzados.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool eliminar_alumno(string Id_Alumno)
        {
            try
            {
                avanzados.CommandType = CommandType.StoredProcedure;
                avanzados.Connection = estudio.conectar("BD_Colegio");
                avanzados.CommandText = "Borrar_Alumno";
                avanzados.Parameters.Add("@Id_Alumno", Id_Alumno);
                avanzados.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /*public bool anula_alumno(CE_Alumno oalumno2)
        {
            try
            {
                avanzados.CommandType = CommandType.StoredProcedure;
                avanzados.Connection = estudio.conectar("BD_Colegio");
                avanzados.CommandText = "modificar_alumno";
                avanzados.Parameters.Add("@Id_Alumno", oalumno2.Id_Alumno);
                avanzados.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }*/

        public CE_Alumno consultar_alumno(string Id_Alumno)
        {
            try
            {
                avanzados.CommandType = CommandType.StoredProcedure;
                avanzados.Connection = estudio.conectar("BD_Colegio");
                avanzados.CommandText = "consul_alumno";
                avanzados.Parameters.Add("@Id_Alumno", Id_Alumno);
                SqlDataAdapter da = new SqlDataAdapter(avanzados);
                DataSet consulta = new DataSet();
                da.Fill(consulta);

                DataTable dt = consulta.Tables[0];

                CE_Alumno item = new CE_Alumno();

                DataRow row = dt.Rows[0];
                
                CE_Alumno x = new CE_Alumno();

                x.Id_Alumno = Convert.ToString(row["Id_Alumno"]);
                x.Tel_Alumno = Convert.ToInt32(row["Tel_Alumno"]);
                x.Nom_Alumno = Convert.ToString(row["Nom_Alumno"]);
                x.Dir_Alumno = Convert.ToString(row["Dir_Alumno"]);
                x.Grp_Alumno = Convert.ToString(row["Grp_Alumno"]);

                return x;
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<CE_Alumno> consultar_alumnos()
        {
            try
            {
                avanzados.CommandType = CommandType.StoredProcedure;
                avanzados.Connection = estudio.conectar("BD_Colegio");
                avanzados.CommandText = "consul_alumnos";
                
                SqlDataAdapter da = new SqlDataAdapter(avanzados);
                DataSet ds = new DataSet();
                da.Fill(ds);


                DataTable dt = ds.Tables[0];

                List<CE_Alumno> lista = new List<CE_Alumno>();

                foreach (DataRow row in dt.Rows)
                {
                    CE_Alumno x = new CE_Alumno();

                    x.Id_Alumno = Convert.ToString(row["Id_Alumno"]);
                    x.Tel_Alumno = Convert.ToInt32(row["Tel_Alumno"]);
                    x.Nom_Alumno = Convert.ToString(row["Nom_Alumno"]);
                    x.Dir_Alumno = Convert.ToString(row["Dir_Alumno"]);
                    x.Grp_Alumno = Convert.ToString(row["Grp_Alumno"]);

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
