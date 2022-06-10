using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Capa_Presentacion
{
    public partial class Cursos_Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            CE_Curso nuevo = new CE_Curso();
            nuevo.Id_Curso = Id_Curso.Text;
            nuevo.Nom_Curso = Nom_Curso.Text;

            CN_Curso capaNegocio = new CN_Curso();

            capaNegocio.guardar_curso(nuevo);

            Response.Redirect("Cursos_Select.aspx");
        }
    }
}