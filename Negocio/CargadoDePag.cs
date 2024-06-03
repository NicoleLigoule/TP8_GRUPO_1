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

        public void limpiarCampos(ref TextBox txtNombreSucursal, ref TextBox txtDescripcion, ref TextBox txtDireccion, ref DropDownList ddlProvincia)
        {
            txtNombreSucursal.Text = "";
            txtDescripcion.Text = "";
            txtDireccion.Text = "";
            ddlProvincia.SelectedIndex = 0;
        }

        public void MensajeAgregar(ref Label lblmensaje,bool estado)
        {
            if (estado)
            {
                lblmensaje.Text = "La Sucursal se agrego correctamente";
            }
            else
            {
                lblmensaje.Text = "La Sucursal no se pudo agregar";
            }
        }

        public void MensajeEliminado(ref Label lblmensaje, bool estado)
        {
            if (estado)
            {
                lblmensaje.Text = "La Sucursal se elimino correctamente";
            }
            else
            {
                lblmensaje.Text = "La Sucursal no se pudo eliminar";
            }
        }

        public void Vaciartxt(ref TextBox textBox)
        {
            textBox.Text = "";
        }
}
}
