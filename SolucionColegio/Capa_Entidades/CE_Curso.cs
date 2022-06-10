using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class CE_Curso
    {
        private string id_Curso;
        private string nom_Curso;

        public string Id_Curso { get => id_Curso; set => id_Curso = value; }
        public string Nom_Curso { get => nom_Curso; set => nom_Curso = value; }
    }
}
