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
    public partial class Cursos_Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Id = Request["Id"];

            CN_Curso capaNegocio = new CN_Curso();

            CE_Curso x = capaNegocio.consultar_curso(Id);

            Id_Curso.Text = x.Id_Curso;
            Nom_Curso.Text = x.Nom_Curso;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CE_Curso existente = new CE_Curso();
            existente.Id_Curso = Request["Id_Curso"];
            existente.Nom_Curso = Request["Nom_Curso"];

            CN_Curso capaNegocio = new CN_Curso();

            capaNegocio.modificar_curso(existente);

            Response.Redirect("Cursos_Select.aspx");
        }
    }
}