﻿using System;
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

       public void setId(int id)
       {
            this.Id = id;
       }
       public void setDescripcion(string Descripcion)
       {
            this.Descripcion = Descripcion;
       }
       public void setProvincia(string Provincia)
       {
            this.Provincia = Provincia;
       }
       public void setDireccion(string Direccion)
       {
            this.Descripcion = Direccion;
       }
       public string getDireccion() { return Direccion; }
       public string getNombre(){return Nombre;}
       public string getProvincia(){return Provincia;}
       public string getDescripcion() { return Descripcion;}
       public int getId() { return Id; }
    }
}
