using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using Entidades;

namespace Dao
{
    public class DaoProvincia
    {
        AccesoDatos ad = new AccesoDatos();

        public DataTable getTablaProvincias()
        {
            String consulta = "Select * from Provincia";
            DataTable dtable = ad.ObtenerTabla("Provincia", consulta);
            return dtable;
        } 
        //YATA
    }
}
