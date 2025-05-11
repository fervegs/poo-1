using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Perro
    {
        // perro : raza, edad, nombre
        // Atrivutos, Miembros.
        private string Nombre;
        private string Raza;
        private int Edad;

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public string raza
        {
            get { return Raza; }
            set { Raza = value; }
        }

        public int edad
        {
            get { return Edad; }
            set { Edad = value; }
        }
       
    }
}
