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

        NegocioProvincia np = new NegocioProvincia();
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
                np.CargarDdl(ddl_ProvinciaSucursal);
            }
        }

        protected void btn_Aceptar_Click(object sender, EventArgs e)
        {
           
        }


    }
}