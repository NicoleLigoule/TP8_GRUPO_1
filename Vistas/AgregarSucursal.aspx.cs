using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
namespace Vistas
{
    public partial class AgregarSucursal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                CargadoDePag pag = new CargadoDePag();

                pag.CargarDDLProvinciasa(ref ddlProvincia);

            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            String consulta = "insert into Sucursal(NombreSucursal,DescripcionSucursal,Id_ProvinciaSucursal,DireccionSucursal) values ('" + txtNombreSucursal.Text + "','" + txtDescripcion.Text + "','" + ddlProvincia.SelectedValue + "','" + txtDireccion.Text + "')";


            limpiarCampos();
            
        }

        public void limpiarCampos()
        {
            txtNombreSucursal.Text = "";
            txtDescripcion.Text = "";
            txtDireccion.Text = "";
            ddlProvincia.SelectedIndex = 0;
        }

       

    }
}