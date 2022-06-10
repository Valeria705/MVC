using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class CE_Alumno
    {
        private string id_Alumno;
        private string nom_Alumno;
        private string dir_Alumno;
        private int tel_Alumno;
        private string grp_Alumno;

        public string Id_Alumno { get => id_Alumno; set => id_Alumno = value; }
        public string Nom_Alumno { get => nom_Alumno; set => nom_Alumno = value; }
        public string Dir_Alumno { get => dir_Alumno; set => dir_Alumno = value; }
        public int Tel_Alumno { get => tel_Alumno; set => tel_Alumno = value; }
        public string Grp_Alumno { get => grp_Alumno; set => grp_Alumno = value; }
    }
}
