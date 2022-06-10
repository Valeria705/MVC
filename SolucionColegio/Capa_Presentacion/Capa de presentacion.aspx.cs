using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Entidad;
using Capa_Negocio;
using System.Data;

namespace Colegio_Capas
{
    public partial class Capa_de_presentacion : System.Web.UI.Page
    {

        CN_Alumno ONalumno = new CN_Alumno();
        CE_Alumno OEalumno = new CE_Alumno();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTNguardar_Click(object sender, EventArgs e)
        {
            
        }

        protected void BTNconsultar_Click(object sender, EventArgs e)
        {

        }

        protected void BTNguardar_Click1(object sender, EventArgs e)
        {
            OEalumno.Id_Alumno = Convert.ToString(txt1.Text);
            OEalumno.Nom_Alumno = Convert.ToString(txt2.Text);
            OEalumno.Dir_Alumno = Convert.ToString(txt3.Text);
            OEalumno.Tel_Alumno = Convert.ToInt32(txt4.Text);
            OEalumno.Grp_Alumno = Convert.ToString(txt5.Text);

            if (ONalumno.guardar_alumno(OEalumno))
            {
                lblrespuesta.Text = "Informacion del alumno guardado.";
            }
            else
            {
                lblrespuesta.Text = "No se puedo guardar la informcion.";
            }
        }
    }
}