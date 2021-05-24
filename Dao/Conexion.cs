using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;
using Entidades;

namespace Dao  
{
    public class Conexion
    {
        protected string s_ruta;

        public Conexion()
        {
            s_ruta = "Data Source=localhost\\SQLEXPRESS;Initial Catalog = BDSucursales; Integrated Security = True";
        }

        protected DataSet ConsultaDataSet(string consulta)    // Metodo para hacer consultas
        {
            SqlConnection Cn_V = new SqlConnection(s_ruta);
            Cn_V.Open();
            SqlCommand cmd = new SqlCommand(consulta, Cn_V);
            SqlDataAdapter adapter_V_local = new SqlDataAdapter(cmd);
            DataSet ds_V = new DataSet();
            adapter_V_local.Fill(ds_V);
            Cn_V.Close();
            return ds_V;
        }


        virtual protected void CargarDdl(DropDownList ddl, string consulta)
        {
       
        }


    }
}