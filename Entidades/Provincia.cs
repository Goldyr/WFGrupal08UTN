using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincia
    {
        private int Id;
        private string Descripcion;

        public Provincia() { }
        //gets
        public int getId() { return Id; }
        public string getDescripcion() { return Descripcion; }
        //sets
        public void setDescripcion(String Descripcion)
        {
            this.Descripcion = Descripcion;
        }
        public void setId(int Id)
        {
            this.Id = Id;
        }
   
    }
}
