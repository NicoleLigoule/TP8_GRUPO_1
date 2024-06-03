using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class NegocioProvincia
    {
        public List<Provincia> ObtenerProvinciasDDL()
        {
            DatoProvincia dp = new DatoProvincia();
            return dp.ObtenerProvincias();
        }
    }
}
