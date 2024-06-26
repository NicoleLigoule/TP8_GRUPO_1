﻿using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using Datos;
namespace Negocio
{
    public class NegocioSucursal
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
                sucursa.setId_ProvinciaSucursal(idP);
                sucursa.setDireSucursal(Direccion);
                return sucursa;
            }
            return null;
        }



        public bool agregarSucursal(Sucursal sucursal)
        {
            int cantFilas = 0;
            DatoSucursal dato = new DatoSucursal();

            if (!dato.existeSucursal(sucursal))
            {
                cantFilas = dato.agregar(sucursal);
            }

            return cantFilas == 1;
        }


        public bool eliminarSucursal(int id_sucursal)
        {
            DatoSucursal dato = new DatoSucursal();

            return dato.eliminar(id_sucursal) > 0 ? true : false;
        }

        public DataTable getGrd()
        {
            DatoSucursal dato = new DatoSucursal();
            return dato.getTableSucursal();
        }
        public DataTable getGrdFiltrado(string ID)
        {
            DatoSucursal dao = new DatoSucursal();
            return dao.getTablaFiltrada(ID);
        }

    }
}
