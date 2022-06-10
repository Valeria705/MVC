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
    public partial class Cursos_Select : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string contenido = "";

            CN_Curso capaNegocio = new CN_Curso();

            List<CE_Curso> lista = capaNegocio.consultar_cursos();

            foreach (CE_Curso x in lista)
            {
                contenido = contenido + "<tr>";
                contenido = contenido + "<td>" + x.Id_Curso + "</td>";
                contenido = contenido + "<td>" + x.Nom_Curso + "</td>";
                contenido = contenido + "<td><a href='Cursos_Update.aspx?Id=" + x.Id_Curso + "'>modificar</a></td>";
                contenido = contenido + "<td><a href='Cursos_Delete.aspx?Id=" + x.Id_Curso + "'>eliminar</a></td>";
                contenido = contenido + "</tr>";

            }

            tabla_body.InnerHtml = contenido;
        }
    }
}