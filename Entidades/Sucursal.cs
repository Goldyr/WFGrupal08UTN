using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
    {
        private int Id;
        private string Nombre;
        private string Descripcion;
        private string Provincia;
        private string Direccion;

        public Sucursal(){}

        void setId(int id)
        {
            this.Id = id;
        }
        void setDescripcion(string Descripcion)
        {
            this.Descripcion = Descripcion;
        }
        void setProvincia(string Provincia)
        {
            this.Provincia = Provincia;
        }
        void setDireccion(string Direccion)
        {
            this.Descripcion = Direccion;
        }
        string getDireccion() { return Direccion; }
        string getNombre(){return Nombre;}
        string getProvincia(){return Provincia;}
        string getDescripcion() { return Descripcion;}
        int getId() { return Id; }
    }
}
