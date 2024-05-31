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
            CargadoDePag cargado = new CargadoDePag();
            NegocioSucursal AgregarSucursal = new NegocioSucursal();
            string nombreSuc = txtNombreSucursal.Text;
            string descripcionSuc = txtDescripcion.Text;
            int provinciaSuc = int.Parse(ddlProvincia.SelectedItem.Value);
            string direccionSuc = txtDireccion.Text;

            AgregarSucursal.agregarSucursal(nombreSuc, descripcionSuc, provinciaSuc, direccionSuc);

            cargado.limpiarCampos(ref txtNombreSucursal, ref txtDireccion, ref txtDescripcion, ref ddlProvincia);
        }

        
    }
}