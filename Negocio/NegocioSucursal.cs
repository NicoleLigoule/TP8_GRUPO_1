using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocio
{
    class NegocioSucursal
    {
        public Sucursal TraerSucursalSegunId(string ID)
        {
            string Consulta = "SELECT [Id_Sucursal], [NombreSucursal], [DescripcionSucursal],[Id_ProvinciaSucursal],[DireccionSucursal] FROM [Sucursal] WHERE [Id_Sucursal] =" + ID;

            Sucursal sucursa = new Sucursal();
            AccesoDatos acceso = new AccesoDatos();


            SqlDataReader reader = acceso.obtenerRead(Consulta, ID);
            if (reader.Read())
            {
                int id = (int)reader["Id_Sucursal"];
                string Nombre = reader["NombreSucursal"].ToString();
                string Descripcion = reader["DescripcionSucursal"].ToString();
                int idP = (int)reader["Id_ProvinciaSucursal"];
                string Direccion = reader["DireccionSucursal"].ToString();
                sucursa.setId_Sucursal(id);
                sucursa.setNombreSucursal(Nombre);
                sucursa.setDescripcionSucursal(Descripcion);
                sucursa.setId_ProvinciaSucursalr(idP);
                sucursa.setDireSucursal(Direccion);
                return sucursa;
            }
            return null;
        }
    }
}
