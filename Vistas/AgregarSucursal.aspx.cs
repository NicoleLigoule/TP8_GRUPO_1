using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;
namespace Vistas
{
    public partial class AgregarSucursal : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                CargarDropDown();
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
          
            NegocioSucursal AgregarSucursal = new NegocioSucursal();
            Sucursal sucu = new Sucursal(txtNombreSucursal.Text, txtDescripcion.Text, ddlProvincia.SelectedItem.Value, txtDireccion.Text);
            
            
            if (AgregarSucursal.agregarSucursal(sucu))
            {
                lblMensaje.Text = "La Sucursal se agrego correctamente";
            }
            else
            {
                lblMensaje.Text = "La Sucursal no se pudo agregar";
            }

            txtNombreSucursal.Text = "";
            txtDireccion.Text = ""; 
            txtDescripcion.Text = "";
            ddlProvincia.SelectedIndex = 0;
        }

        private void CargarDropDown()
        {
            NegocioProvincia negocioProvincia = new NegocioProvincia();
            List<Provincia> list = negocioProvincia.ObtenerProvinciasDDL();

            foreach (Provincia provincia in list)
            {
                ddlProvincia.Items.Add(new ListItem(provincia.GetDescripcionProvincia(), provincia.GetIdProvincia().ToString()));
            }
        }

    }
}