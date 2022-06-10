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
    public class CN_Curso
    {
        CD_Curso capaDatos = new CD_Curso();

        public bool guardar_curso(CE_Curso curso)
        {
            return capaDatos.guardar_curso(curso);
        }

        public bool modificar_curso(CE_Curso curso)
        {
            return capaDatos.modificar_curso(curso);
        }

        public bool eliminar_curso(string Id)
        {
            return capaDatos.eliminar_curso(Id);
        }

        /*public bool anula_cursos(CE_Curso conect5)
        {
            return nuevocurso.anula_cursos(conect5);
        }*/

        public CE_Curso consultar_curso(string Id)
        {
            return capaDatos.consultar_curso(Id);
        }

        public List<CE_Curso> consultar_cursos()
        {
            return capaDatos.consultar_cursos();
        }
    }
}
