using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace Dao
{
    public class DaoSucursal
    {
        AccesoDatos datos = new AccesoDatos(); 


    public int AgregarSucursal(string consulta)
        {

            SqlCommand cmd = new SqlCommand(consulta, conexion);

            int FilasAfectadas = cmd.ExecuteNonQuery();

            //conexion.Close();
            return FilasAfectadas;
        }
    }
}
