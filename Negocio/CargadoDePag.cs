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
                  
                    reader.Close();
                   
                }
            }

            
        }
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
                lblmensaje.Text = "La Sucursal se elimino con correctamente";
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
