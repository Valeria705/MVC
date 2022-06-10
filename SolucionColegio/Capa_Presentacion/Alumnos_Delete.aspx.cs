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
    public partial class Alumnos_Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
            CN_Alumno capaNegocio = new CN_Alumno();

            CE_Alumno x = capaNegocio.consultar_alumno(Request["Id"]);

            Id_Oculto.Value = x.Id_Alumno;
            Id_Alumno.Text = x.Id_Alumno;

            Nom_Alumno.Text = x.Nom_Alumno;
            Dir_Alumno.Text = x.Dir_Alumno;
            Tel_Alumno.Text = Convert.ToString(x.Tel_Alumno);
            Grp_Alumno.Text = x.Grp_Alumno;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Id_Alumno = Request["Id_Oculto"];

            CN_Alumno capaNegocio = new CN_Alumno();

            capaNegocio.eliminar_alumno(Id_Alumno);

            Response.Redirect("Alumnos_Select.aspx");


        }

 
    }
}