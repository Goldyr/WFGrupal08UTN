using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace TP8_GRUPO7
{
    public partial class EliminarSucursal : System.Web.UI.Page
    {
        NegocioSucursal ns_sucu = new NegocioSucursal();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

		protected void btnEliminar_Click(object sender, EventArgs e)
		{
            lbl_eliminar.Text = null;
            lbl_eliminar.Visible=true;
            string Incorrecto = "Id de Sucursal Inexistente";
            string Correcto = "La sucursal se ha eliminado con éxito”";
            lbl_eliminar.Text = ns_sucu.NS_EliminarSucursal(Convert.ToInt32(txtSucursal_eli.Text.Trim())) == true ? Correcto : Incorrecto;
            txtSucursal_eli.Text = "";
		}
	}
}
//13 Mc Donalds	Local de comidas rapidas: MC Donalds	Buenos Aires	Virrey Loreto 611