using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace TP8_GRUPO7
{
   
    public partial class ListarSucursal : System.Web.UI.Page
    {
        NegocioSucursal ns_sucu = new NegocioSucursal();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grdDatos.DataSource = ns_sucu.NS_ListarSucursal();
                grdDatos.DataBind();
            }
        }

		protected void btnMostrar_Click(object sender, EventArgs e)
		{
            grdDatos.DataSource = ns_sucu.NS_ListarSucursal();
            grdDatos.DataBind();
		}

		protected void btnFiltrar_Click(object sender, EventArgs e)
		{
           int id = Convert.ToInt32(txtSucursal.Text.Trim());
            string Incorrecto = "Id de Sucursal Inexistente";
            string Correcto = "Listado!";
            grdDatos.DataSource = ns_sucu.NS_ListarSucursal_ID(id);
            grdDatos.DataBind();
            if (grdDatos.DataSource == null)
            {
                lbl_inexistente.Text = Incorrecto;
            }
            else
            {
                lbl_inexistente.Text = Correcto;
            }
            
        }
	}
}