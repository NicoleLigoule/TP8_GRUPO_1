using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Vistas
{
    public partial class EliminarSucursal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id_sucursal = int.Parse(txtEliminarSucu.Text);
            NegocioSucursal ds = new NegocioSucursal();
            bool elimino = ds.eliminarSucursal(id_sucursal);
            if (elimino)
            {
                txtEliminarSucu.Text = "";
                lblMensaje.Text = "La sucursal se ha eliminado con éxito";
            }
        }
    }
}