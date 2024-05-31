using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace Vistas
{
    public partial class AgregarSucursal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                cargarProvincias();

            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        protected void cargarProvincias()
        {
            string consulta = "SELECT DescripcionProvincia, Id_Provincia FROM dbo.Provincia";
            List<string> provincias = new List<string>();
            using (SqlConnection conexion = new SqlConnection("Data Source=localhost\\sqlexpress; Initial Catalog = BDSucursales; Integrated Security = True"))
            {
                SqlCommand commandprov = new SqlCommand(consulta, conexion);
                conexion.Open();
                SqlDataReader reader = commandprov.ExecuteReader();

                while (reader.Read())
                {
                    string provincia = reader["DescripcionProvincia"].ToString();
                    if (!provincias.Contains(provincia))
                    {
                        provincias.Add(provincia);
                        ddlProvincia.Items.Add(new ListItem(provincia, reader["Id_Provincia"].ToString()));
                    }
                }
            }
            ddlProvincia.Items.Insert(0, new ListItem("-- Seleccionar --", ""));
        }

    }
}