﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
     public class AccesoDatos
    {
        private string rutaBDSucursales;

        public AccesoDatos()
        {
            rutaBDSucursales = "Data Source = localhost\\sqlexpress; Initial Catalog = BDSucursales; Integrated Security = True";
        }

        public SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(rutaBDSucursales);
            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public SqlDataReader obtenerReadDDl()
        {
            try
            {
                string consulta = "SELECT DescripcionProvincia, Id_Provincia FROM dbo.Provincia";

                AccesoDatos acceso = new AccesoDatos();
                SqlConnection conexion = acceso.ObtenerConexion();

                SqlCommand commandprov = new SqlCommand(consulta, conexion);

                SqlDataReader reader = commandprov.ExecuteReader();
                return reader;
            }
            catch (Exception e)
            {

                return null;
            }
        }
        public SqlDataAdapter ObtenerAdaptador(string consulta)
        {
            SqlDataAdapter adapta;

            try
            {
                adapta = new SqlDataAdapter(consulta, ObtenerConexion());

                return adapta;

            }
            catch (Exception e)
            {
                return null;
            }
        }
        public SqlDataReader obtenerRead(string Consulta, string ID)
        {
            try
            {
                SqlCommand command = new SqlCommand(Consulta, ObtenerConexion());

                command.Parameters.AddWithValue("@Id_Sucursal", ID);


                SqlDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Boolean existe(String consulta)
        {
            Boolean estado = false;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand(consulta, Conexion);
            SqlDataReader datos = cmd.ExecuteReader();
            if (datos.Read())
            {
                estado = true;
            }
            return estado;
        }

        public int EjecutarProcedimientoAlmacenado(SqlCommand Comando, String NombreSP)
        {
            int FilasCambiadas;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd = Comando;
            cmd.Connection = Conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NombreSP;
            FilasCambiadas = cmd.ExecuteNonQuery();
            Conexion.Close();
            return FilasCambiadas;
        }

        public DataTable getTabla(String nombre, String consulta)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adp = ObtenerAdaptador(consulta);
            adp.Fill(ds, nombre);
            return ds.Tables[nombre];
        }
    }
}