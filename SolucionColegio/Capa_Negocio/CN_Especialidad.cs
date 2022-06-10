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
    public class CN_Especialidad
    {
        CD_Especialidad nuevaespecialidad = new CD_Especialidad();

        public bool guardar_especialidad(CE_Especialidad oespe4)
        {
            return nuevaespecialidad.guardar_especialidad(oespe4);
        }

        public bool anular_especialidad(CE_Especialidad oespe5)
        {
            return nuevaespecialidad.anular_especialidad(oespe5);
        }

        public DataSet consultar_especialidad(CE_Especialidad oespe6)
        {
            return nuevaespecialidad.consultar_especialidad(oespe6);
        }
    }
}
