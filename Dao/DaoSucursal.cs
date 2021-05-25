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

        public Boolean ExisteSucursal() { return true; }

        public DataTable getTablaSucursal(string consulta)
        {
            DataTable dt = new DataTable();
            return dt;
        }

        public void AgregarSucursal(Sucursal _Sucursal) {; }
        public void EliminarSucursal(Sucursal _Sucursal) {; }

        private void ArmarParametrosAgregarSucursal(Sucursal _Sucursal) {; }
        private void ArmarParametrosEliminarSucursal(Sucursal _Sucursal) {; }

    }
}
