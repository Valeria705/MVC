using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;
using System.Data;

namespace Capa_Negocio
{
    public class CN_Docente
    {
        CD_Docente nuevodocente = new CD_Docente();

        public bool guardar_Docente(CE_Docente oprefesor4)
        {
            return nuevodocente.guardar_Docente(oprefesor4);
        }

        public bool anular_Docente(CE_Docente oprofesor5)
        {
            return nuevodocente.anular_Docente(oprofesor5);
        }

        public DataSet Consultar_Docente(CE_Docente oprofesor6)
        {
            return nuevodocente.Consultar_Docente(oprofesor6);
        }

    }
}
