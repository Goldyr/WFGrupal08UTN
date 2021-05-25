using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using Dao;
using Entidades;

namespace Negocio
{
    public class NegocioProvincia
    {
        DaoProvincia _Daoprovincia = new DaoProvincia();

        public void CargarDdl(DropDownList ddl)
        {
            DataTable dt = _Daoprovincia.getTablaProvincias();
            ddl.DataSource = dt;
            ddl.DataTextField = "DescripcionProvincia";
            ddl.DataValueField = "Id_Provincia";
            ddl.DataBind();

        }

    }
}
