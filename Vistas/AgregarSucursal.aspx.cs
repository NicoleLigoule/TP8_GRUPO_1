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
            CargadoDePag cargado = new CargadoDePag();
            NegocioSucursal AgregarSucursal = new NegocioSucursal();
            Sucursal sucu = new Sucursal(txtNombreSucursal.Text, txtDescripcion.Text, ddlProvincia.SelectedItem.Value, txtDireccion.Text);
            
            cargado.MensajeAgregar(ref lblMensaje, AgregarSucursal.agregarSucursal(sucu));

            cargado.limpiarCampos(ref txtNombreSucursal, ref txtDireccion, ref txtDescripcion, ref ddlProvincia);
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