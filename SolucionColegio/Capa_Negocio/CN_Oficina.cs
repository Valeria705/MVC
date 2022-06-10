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
    public class CN_Oficina
    {
        CD_Oficina nuevaoficina = new CD_Oficina();

        public bool guardar_oficina(CE_Oficina ofi4)
        {
            return nuevaoficina.guardar_oficina(ofi4);
        }

        public bool anular_oficina(CE_Oficina ofi5)
        {
            return nuevaoficina.anular_oficina(ofi5);
        }

        public DataSet consultar_oficina(CE_Oficina ofi6)
        {
            return nuevaoficina.consultar_oficina(ofi6);
        }
    }
}
