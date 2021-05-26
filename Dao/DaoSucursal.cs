using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Dao
{
    public class DaoSucursal
    {
        AccesoDatos datos = new AccesoDatos();

        public Boolean ExisteSucursal(Sucursal _Sucursal) 
        {
            string consulta = $"SELECT NombreSucursal FROM Sucursal WHERE NombreSucursal = '{_Sucursal.getNombre()}'";
            if (datos.verificarID(consulta) == true)
            {
                return true;
            }

            return false; 
        }

        public DataTable getTablaSucursal(string consulta)
        {
            DataTable dt = new DataTable();
            return dt;
        }

        public bool AgregarSucursal(Sucursal _Sucursal) 
        {
            SqlCommand Comando = new SqlCommand();
            ArmarParametrosAgregarSucursal(ref Comando, _Sucursal);
            int filas = datos.EjecutarProcedimientoAlmacenado(Comando, "spAgregarSucursal");
            if (filas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EliminarSucursal(Sucursal _Sucursal) 
        {
            SqlCommand Comando = new SqlCommand();
            ArmarParametrosEliminarSucursal(ref Comando, _Sucursal);
            int filas = datos.EjecutarProcedimientoAlmacenado(Comando, "spEliminarSucursal");
            if(filas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ArmarParametrosAgregarSucursal(ref SqlCommand Comando, Sucursal _Sucursal) 
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 100);
            SqlParametros.Value = _Sucursal.getNombre();
            SqlParametros = Comando.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100);
            SqlParametros.Value = _Sucursal.getDescripcion();
            SqlParametros = Comando.Parameters.Add("@IdProvincia", SqlDbType.Int);
            SqlParametros.Value = _Sucursal.getProvincia();
            SqlParametros = Comando.Parameters.Add("@Direccion", SqlDbType.VarChar, 100);
            SqlParametros.Value = _Sucursal.getDireccion();
        }
        private void ArmarParametrosEliminarSucursal(ref SqlCommand Comando,Sucursal _Sucursal) 
        {
            SqlParameter Parametros = new SqlParameter();
            Parametros = Comando.Parameters.Add("@Id", SqlDbType.Int);
            Parametros.Value = _Sucursal.getId();
        }

    }
}

//-------AGREGAR SUCURSAL----------
//CREATE PROCEDURE spAgregarSucursal
//@Nombre VARCHAR(100), @Descripcion VARCHAR(100), @IdProvincia INT, @Direccion VARCHAR(100)
//AS
//INSERT INTO Sucursal(NombreSucursal, DescripcionSucursal, Id_ProvinciaSucursal, DireccionSucursal) VALUES(@Nombre, @Descripcion, @IdProvincia, @Direccion)
//GO

//-------ELIMINAR SUCURSAL----------
//CREATE PROCEDURE spEliminarSucursal
//@Id INT
//AS
//DELETE FROM Sucursal WHERE Id_Sucursal=@Id
//GO
