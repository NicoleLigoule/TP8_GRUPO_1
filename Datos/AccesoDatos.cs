using System;
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
        private string rutaBDNeptuno;

        public AccesoDatos()
        {
            rutaBDNeptuno = "Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True";
        }

        private SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(rutaBDNeptuno);
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
    }
}