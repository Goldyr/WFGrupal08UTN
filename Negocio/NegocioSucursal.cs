using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao;
using Entidades;
using System.Data;

namespace Negocio
{
    public class NegocioSucursal
    {
        //Sucursal _Sucursal = new Sucursal();
        //DaoSucursal dao = new DaoSucursal();
        public bool NS_AgregarSucursal(string nombre, string Descripcion, string Direccion, int Id_provincia)
        {
            bool Agrego=false;

            Sucursal _Sucursal = new Sucursal();
            _Sucursal.setNombre(nombre);
            _Sucursal.setDescripcion(Descripcion);
            _Sucursal.setDireccion(Direccion);
            _Sucursal.setProvincia(Id_provincia);
            DaoSucursal dao = new DaoSucursal();
            if (!dao.ExisteSucursal(_Sucursal))  //si no existe la sucursal
            {
                Agrego = dao.AgregarSucursal(_Sucursal);  //la agrega 
            }

            return Agrego; //devuelve true si la pudo agregar
        }
        public bool NS_EliminarSucursal(int id)
        {
            
            Sucursal _Sucursal = new Sucursal();
            _Sucursal.setId(id);
            DaoSucursal dao = new DaoSucursal();

            bool filas = dao.EliminarSucursal(_Sucursal); //devuelve true si la pudo eliminar

            return filas;
        }

        public DataTable NS_ListarSucursal_ID(int id)
        {
            DataTable dt = new DataTable();
            Sucursal _Sucursal = new Sucursal();
            _Sucursal.setId(id);
            DaoSucursal dao = new DaoSucursal();

            dt = dao.ListarSucursal_ID(_Sucursal); 
            return dt;
        }

        public DataTable NS_ListarSucursal()
        {
            DataTable dt = new DataTable();
            DaoSucursal dao = new DaoSucursal();

            dt = dao.ListarSucursal();
            return dt;
        }
    }
}
