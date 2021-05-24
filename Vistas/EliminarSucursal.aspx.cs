using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PR3TP05
{
    public partial class EliminarSucursal : System.Web.UI.Page
    {
        private Sucursal _sucursal = new Sucursal();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

		protected void btnEliminar_Click(object sender, EventArgs e)
		{
            string datoEliminar = txtSucursal_eli.Text.Trim();
           
            if (datoEliminar != "" && _sucursal.AgregarSucursal("DELETE FROM Sucursal Where Id_Sucursal =" + datoEliminar) == 1 ) {

                lbl_eliminar.Text = "La sucursal se ha eliminado con éxito";
            }else lbl_eliminar.Text = "La sucursal no existe";
            
		}
	}
}
//13 Mc Donalds	Local de comidas rapidas: MC Donalds	Buenos Aires	Virrey Loreto 611