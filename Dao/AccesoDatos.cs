using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Dao
{
    public class AccesoDatos
    {
        private string rutaBDSucursales = "Data Source=localhost\\SQLEXPRESS;Initial Catalog = BDSucursales; Integrated Security = True";

        public AccesoDatos() { }

        private SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(rutaBDSucursales);
            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private SqlDataAdapter ObtenerAdaptador(String consultaSql, SqlConnection cn)
        {
            SqlDataAdapter adaptador;
            try
            {
                adaptador = new SqlDataAdapter(consultaSql, cn);
                return adaptador;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable ObtenerTabla(String NombreTabla, String Sql)
        {
            DataSet ds = new DataSet();
            SqlConnection Conexion = ObtenerConexion();
            SqlDataAdapter adp = ObtenerAdaptador(Sql, Conexion);
            adp.Fill(ds, NombreTabla);
            Conexion.Close();
            return ds.Tables[NombreTabla];
        }
        public int EjecutarProcedimientoAlmacenado(SqlCommand Comando, String NombreSP)
        {
            int FilasCambiadas;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd = Comando;
            cmd.Connection = Conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NombreSP;
            FilasCambiadas = cmd.ExecuteNonQuery();
            Conexion.Close();
            return FilasCambiadas;
        }
        public bool verificarID(string consulta)
        {
            bool existe = false;
            SqlConnection Conexion = ObtenerConexion();
            //SqlCommand cmd = new SqlCommand(consulta, Conexion);
            SqlDataAdapter adapter_V_local = ObtenerAdaptador(consulta,Conexion);
            DataSet ds_V = new DataSet();
            if (adapter_V_local.Fill(ds_V) != 0)
            {
                existe = true;
            }
            Conexion.Close();
            return existe;
        }

        public int obtenerMaximo (string consulta)
        {
            int MaxId = 0;
            SqlConnection conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataReader dt_reader = cmd.ExecuteReader();
            if (dt_reader.Read())
            {
                MaxId = Convert.ToInt32(dt_reader[0].ToString());
            }

            return MaxId; 
        }
    }
}
