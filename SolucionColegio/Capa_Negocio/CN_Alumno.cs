using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;
using System.Data;

namespace Capa_Negocio
{
    public class CN_Alumno
    {
        CD_Alumno capaDatos = new CD_Alumno();
        public bool guardar_alumno(CE_Alumno oalumno4)
        {
            return capaDatos.guardar_alumno(oalumno4);
        }

        public bool modificar_alumno(CE_Alumno oalumno4)
        {
            return capaDatos.modificar_alumno(oalumno4);
        }

        public bool eliminar_alumno(string Id_Alumno)
        {
            return capaDatos.eliminar_alumno(Id_Alumno);
        }

        /*public bool anula_alumno(CE_Alumno oalumno5)
        {
            return capaDatos.anula_alumno(oalumno5);
        }*/

        public CE_Alumno consultar_alumno(string Id_Alumno)
        {
            return capaDatos.consultar_alumno(Id_Alumno);
        }

        public List<CE_Alumno> consultar_alumnos()
        {
            return capaDatos.consultar_alumnos();
        }
    }
}
