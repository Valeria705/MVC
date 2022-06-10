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
    public partial class Cursos_Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CN_Curso capaNegocio = new CN_Curso();

            CE_Curso x = capaNegocio.consultar_curso(Request["Id"]);

            Id_Oculto.Value = x.Id_Curso;
            Id_Curso.Text = x.Id_Curso;
            Nom_Curso.Text = x.Nom_Curso;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Id_Curso = Request["Id_Oculto"];

            CN_Curso capaNegocio = new CN_Curso();

            capaNegocio.eliminar_curso(Id_Curso);

            Response.Redirect("Cursos_Select.aspx");
        }
    }
}