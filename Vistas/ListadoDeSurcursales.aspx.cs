using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Negocio;

namespace Vistas
{
    public partial class ListadoDeSurcursales : System.Web.UI.Page
    {
        NegocioSucursal neg = new NegocioSucursal();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

                DataTable tablaSucursal = neg.getGrd();
                grdSucursales.DataSource = tablaSucursal;
                grdSucursales.DataBind();
            }
            
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            lblMsgAdv.Visible = false;
            DataTable tablaSucursal = neg.getGrd();
            
            grdSucursales.DataSource = tablaSucursal;
            grdSucursales.DataBind();
            txtBusqueda.Text = "";
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
          
            DataTable tablaSucursal = neg.getGrdFiltrado(txtBusqueda.Text);
            if (tablaSucursal.Rows.Count > 0)
            {
                grdSucursales.DataSource = tablaSucursal;
                grdSucursales.DataBind();
                lblMsgAdv.Visible = false;
            }
            else
            {
                grdSucursales.DataSource = null;
                grdSucursales.DataBind();
                lblMsgAdv.Text = "No se encontro el ID Sucursal indicado, ingresa otro.";
                lblMsgAdv.Visible = true;
            }
            txtBusqueda.Text = "";

        }
    }
}