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
            bool Existe=false;

            Sucursal _Sucursal = new Sucursal();
            _Sucursal.setNombre(nombre);
            _Sucursal.setDescripcion(Descripcion);
            _Sucursal.setDireccion(Direccion);
            _Sucursal.setProvincia(Id_provincia);
            DaoSucursal dao = new DaoSucursal();
            if (!dao.ExisteSucursal(_Sucursal))
            {
                Existe = dao.AgregarSucursal(_Sucursal);
            }

            return Existe;
        }
    }
}
