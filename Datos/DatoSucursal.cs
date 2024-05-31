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
            return ds.EjecutarProcedimientoAlmacenado(comando, "SP_AGREGARSUCURSAL");
        }

        private void ArmarParametrosAgregar(ref SqlCommand Comando, Sucursal sucursal)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@NombreSucursal", SqlDbType.VarChar);
            SqlParametros.Value = sucursal.GetNombreSucursal();

            SqlParametros = Comando.Parameters.Add("@DescripcionSucursal", SqlDbType.VarChar);
            SqlParametros.Value = sucursal.GetDescripcionSucursal();

            SqlParametros = Comando.Parameters.Add("@Id_ProvinciaSucursal", SqlDbType.Int);
            SqlParametros.Value = sucursal.GetId_ProvinciaSucursal();

            SqlParametros = Comando.Parameters.Add("@DireccionSucursal", SqlDbType.VarChar);
            SqlParametros.Value = sucursal.GetDireSucur();
        }

        public int eliminar(int id_sucursal)
        {
            SqlCommand comando = new SqlCommand();
            comando.Parameters.Add("@id_sucursal", SqlDbType.Int).Value = id_sucursal;
            return ds.EjecutarProcedimientoAlmacenado(comando, "SP_ELIMINARSUCURSAL");
        }

        public DataTable getTableSucursal()
        {
            DataTable tabla = ds.getTabla("Sucursal", "SELECT Id_Sucursal, NombreSucursal AS Nombre, DescripcionSucursal AS Descripcion, DescripcionProvincia AS Provincia, DireccionSucursal AS Direccion FROM Sucursal s INNER JOIN Provincia p ON s.Id_ProvinciaSucursal = p.Id_Provincia");
            return tabla;        
        }
        public DataTable getTablaFiltrada(String ID)
        {
            DataTable tabla = ds.getTabla("Sucursal", "SELECT Id_Sucursal, NombreSucursal AS Nombre, DescripcionSucursal AS Descripcion, DescripcionProvincia AS Provincia, DireccionSucursal AS Direccion FROM Sucursal s INNER JOIN Provincia p ON s.Id_ProvinciaSucursal = p.Id_Provincia WHERE s.Id_Sucursal =" + ID);
            return tabla;
        }
    }
}
