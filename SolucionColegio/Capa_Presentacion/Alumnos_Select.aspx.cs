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
    public partial class Alumnos_Select : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string contenido = "";

            CN_Alumno capaNegocio = new CN_Alumno();

            List<CE_Alumno> lista = capaNegocio.consultar_alumnos();

            foreach(CE_Alumno x in lista)
            {
                contenido = contenido + "<tr>";
                contenido = contenido + "<td>" + x.Id_Alumno +"</td>";
                contenido = contenido + "<td>" + x.Nom_Alumno + "</td>";
                contenido = contenido + "<td>" + x.Dir_Alumno + "</td>";
                contenido = contenido + "<td>" + x.Tel_Alumno + "</td>";
                contenido = contenido + "<td>" + x.Grp_Alumno + "</td>";
                contenido = contenido + "<td><a href='Alumnos_Update.aspx?Id="+ x.Id_Alumno + "'>modificar</a></td>";
                contenido = contenido + "<td><a href='Alumnos_Delete.aspx?Id="+ x.Id_Alumno + "'>eliminar</a></td>";
                contenido = contenido + "</tr>";

            }

            tabla_body.InnerHtml = contenido;
        }
    }
}