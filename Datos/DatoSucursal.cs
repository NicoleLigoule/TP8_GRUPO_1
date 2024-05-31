using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    public class DatoSucursal
    {
        AccesoDatos ds = new AccesoDatos();
        public Boolean existeSucursal(Sucursal suc)
        {
            String consulta = "Select * from Sucursal where Id_Sucursal='" + suc.GetId_Sucursal() + "'";
            return ds.existe(consulta);
        }

        public int agregar(Sucursal sucursal)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosAgregar(ref comando, sucursal);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spAgregarSucursal");
        }

        private void ArmarParametrosAgregar(ref SqlCommand Comando, Sucursal sucursal)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@ID_SUCURSAL", SqlDbType.Int);
            SqlParametros.Value = sucursal.GetId_Sucursal();
            SqlParametros = Comando.Parameters.Add("@NOMBRE_SUCURSAL", SqlDbType.VarChar);
            SqlParametros.Value = sucursal.GetNombreSucursal();
            SqlParametros = Comando.Parameters.Add("@DESCRIPCION_SUCURSAL", SqlDbType.VarChar);
            SqlParametros.Value = sucursal.GetDescripcionSucursal();
            SqlParametros = Comando.Parameters.Add("@ID_PROVINCIA_SUCURSAL", SqlDbType.Int);
            SqlParametros.Value = sucursal.GetId_ProvinciaSucursal();
            SqlParametros = Comando.Parameters.Add("@DIRECCION_SUCURSAL", SqlDbType.VarChar);
            SqlParametros.Value = sucursal.GetDireSucur();
        }



    }
}
