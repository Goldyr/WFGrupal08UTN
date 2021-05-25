using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Dao
{
    public class DaoProvincia
    {
        //Metodo para cargar las provincias en el ddl
        public void CargarProvincias(DropDownList ddl)
        {
            String consulta = "Select * from Provincia";
            CargarDdl(ddl, consulta);
        }
        protected override void CargarDdl(DropDownList ddl, string consulta)
        {
            DataSet ds = new DataSet();
            SqlConnection cn = new SqlConnection(s_ruta);
            cn.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn);
            adaptador.Fill(ds, "Provincia");
            ddl.DataSource = ds.Tables["Provincia"];
            ddl.DataTextField = "DescripcionProvincia";
            ddl.DataValueField = "Id_Provincia";
            ddl.DataBind();
            cn.Close();
        }




    }
}
