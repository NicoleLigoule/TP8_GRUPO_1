using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace Negocio
{
    public class CargadoDePag
    {
        public CargadoDePag() { }
        public void CargarDDLProvinciasa(ref DropDownList dropDownList)
        {
            AccesoDatos ac = new AccesoDatos();
            List<string> provincias = new List<string>();
            SqlDataReader reader = ac.obtenerReadDDl();



            if (reader != null)
            {
                try
                {
                    while (reader.Read())
                    {
                        string provincia = reader["DescripcionProvincia"].ToString();
                        if (!provincias.Contains(provincia))
                        {
                            provincias.Add(provincia);
                            dropDownList.Items.Add(new ListItem(provincia, reader["Id_Provincia"].ToString()));
                        }
                    }
                }

                finally
                {
                    dropDownList.Items.Insert(0, new ListItem("-- Seleccionar --", ""));
                    // Asegúrate de cerrar el reader y la conexión
                    reader.Close();
                    /// reader.Connection.Close();
                }
            }

        }

    }
}
