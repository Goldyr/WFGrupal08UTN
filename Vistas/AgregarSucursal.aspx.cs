using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Negocio;

namespace TP8_GRUPO7
{
    public partial class AgregarSucursal : System.Web.UI.Page
    {
        NegocioSucursal ns = new NegocioSucursal();
        NegocioProvincia np = new NegocioProvincia();
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
                np.CargarDdl(ddl_ProvinciaSucursal);
            }
            lblMensaje.Text = null;
        }

        protected void btn_Aceptar_Click(object sender, EventArgs e)
        {
            string Incorrecto = "Error al agregar, el nombre ya existe.";
            string Correcto = "La sucursal se ha agregado con éxito";
            lblMensaje.Text = ns.NS_AgregarSucursal(txtbx_NombreSucursal.Text.Trim(), txtbx_DescripcionSucursal.Text.Trim(), txtbx_DireccionSucursal.Text.Trim(), Convert.ToInt32(ddl_ProvinciaSucursal.SelectedValue)) == true ? Correcto : Incorrecto;
      
            if (lblMensaje.Text==Correcto)
            {
                txtbx_DescripcionSucursal.Text = txtbx_NombreSucursal.Text = txtbx_DireccionSucursal.Text = "";
            }       
        }

    }
}