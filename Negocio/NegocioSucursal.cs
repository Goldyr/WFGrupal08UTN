using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao;
using Entidades;

namespace Negocio
{
    public class NegocioSucursal
    {
        public bool NS_AgregarSucursal(string nombre, string Descripcion, string Direccion, int Id_provincia)
        {
            bool Agrego=false;

            Sucursal _Sucursal = new Sucursal();
            _Sucursal.setNombre(nombre);
            _Sucursal.setDescripcion(Descripcion);
            _Sucursal.setDireccion(Direccion);
            _Sucursal.setProvincia(Id_provincia);
            DaoSucursal dao = new DaoSucursal();
            if (!dao.ExisteSucursal(_Sucursal))
            {
                Agrego = dao.AgregarSucursal(_Sucursal);
            }

            return Agrego;
        }
        public bool NS_EliminarSucursal(int id)
        {
            
            Sucursal _Sucursal = new Sucursal();
            _Sucursal.setId(id);
            DaoSucursal dao = new DaoSucursal();

            bool filas = dao.EliminarSucursal(_Sucursal);

            return filas;
        }
    }
}
