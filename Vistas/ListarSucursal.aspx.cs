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

        }

		protected void btnMostrar_Click(object sender, EventArgs e)
		{
            grdDatos.DataSource = ns_sucu.NS_ListarSucursal();
            grdDatos.DataBind();
		}

		protected void btnFiltrar_Click(object sender, EventArgs e)
		{
           int id = Convert.ToInt32(txtSucursal.Text.Trim());
           grdDatos.DataSource = ns_sucu.NS_ListarSucursal_ID(id);
           grdDatos.DataBind();
        }
	}
}