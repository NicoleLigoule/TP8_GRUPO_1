﻿using System;
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
            DataTable tablaSucursal = neg.getGrd();
            grdSucursales.DataSource = tablaSucursal;
            grdSucursales.DataBind();
        }
    }
}