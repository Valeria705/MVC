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
    public partial class Alumnos_Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Id = Request["Id"];

            CN_Alumno capaNegocio = new CN_Alumno();

            CE_Alumno x = capaNegocio.consultar_alumno(Id);

            Id_Alumno.Text = x.Id_Alumno;
            Nom_Alumno.Text = x.Nom_Alumno;
            Dir_Alumno.Text = x.Dir_Alumno;
            Tel_Alumno.Text = Convert.ToString(x.Tel_Alumno);
            Grp_Alumno.Text = x.Grp_Alumno;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CE_Alumno existente = new CE_Alumno();
            existente.Id_Alumno = Request["Id_Alumno"];
            existente.Nom_Alumno = Request["Nom_Alumno"];
            existente.Dir_Alumno = Request["Dir_Alumno"];
            existente.Tel_Alumno = Convert.ToInt32(Request["Tel_Alumno"]);
            existente.Grp_Alumno = Request["Grp_Alumno"];

            CN_Alumno capaNegocio = new CN_Alumno();

            capaNegocio.modificar_alumno(existente);

            Response.Redirect("Alumnos_Select.aspx");
        }
    }
}