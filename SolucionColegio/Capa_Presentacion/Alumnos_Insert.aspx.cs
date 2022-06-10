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
    public partial class Alumnos_Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            CE_Alumno nuevo = new CE_Alumno();
            nuevo.Id_Alumno = Id_Alumno.Text;
            nuevo.Nom_Alumno = Nom_Alumno.Text;
            nuevo.Dir_Alumno = Dir_Alumno.Text;
            nuevo.Tel_Alumno = Convert.ToInt32(Tel_Alumno.Text);
            nuevo.Grp_Alumno = Grp_Alumno.Text;

            CN_Alumno capaNegocio = new CN_Alumno();

            capaNegocio.guardar_alumno(nuevo);

            Response.Redirect("Alumnos_Select.aspx");

        }
    }
}