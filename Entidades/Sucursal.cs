using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;

namespace Entidades {
        public class Sucursal : Conexion
    {
        // Clase que deriva de conexion

        //Metodo para agregar sucursales
        public int AgregarSucursal(string consulta)
        {
            SqlConnection conexion = new SqlConnection(s_ruta);
            conexion.Open();

            SqlCommand cmd = new SqlCommand(consulta, conexion);

            int FilasAfectadas = cmd.ExecuteNonQuery();

            //conexion.Close();
            return FilasAfectadas;
        }

        //Metodo para cargar las provincias en el ddl
        public void CargarProvincias(DropDownList ddl)
        {
            String consulta = "Select * from Provincia";
            CargarDdl(ddl, consulta);
        }

        //Metodo para cargar en tabla
        public void CargarEnTabla(GridView tabla, string consulta)
        {

            tabla.DataSource = ConsultaDataSet(consulta);
            tabla.DataBind();
        }

        // Metodo heredado de conexion, igual no se si hace falta que lo herede, pero puede ser
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

        public bool verificarID(string consulta)
        {
            bool existe = false;
            SqlConnection Cn_V = new SqlConnection(s_ruta);
            Cn_V.Open();
            SqlCommand cmd = new SqlCommand(consulta, Cn_V);
            SqlDataAdapter adapter_V_local = new SqlDataAdapter(cmd);
            DataSet ds_V = new DataSet();
            if (adapter_V_local.Fill(ds_V) != 0)
            {
                existe = true;
            }
            Cn_V.Close();
            return existe;
        }

    }
}