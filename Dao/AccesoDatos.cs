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

        public DataTable ObtenerTabla(String NombreTabla, String Consulta)
        {
            DataSet ds = new DataSet();
            SqlConnection Conexion = ObtenerConexion();
            SqlDataAdapter adp = ObtenerAdaptador(Consulta, Conexion);
            if(adp.Fill(ds, NombreTabla)==0)
            {
                Conexion.Close();
                return null;
            }
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
        
        public Boolean verificarID(String consulta)
        {
            Boolean estado = false;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand(consulta, Conexion);
            SqlDataReader datos = cmd.ExecuteReader();
            if (datos.Read())
            {
                estado = true;
                System.Diagnostics.Debug.WriteLine("estadotrue");
            }
            return estado;
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
