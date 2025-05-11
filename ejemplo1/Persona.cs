using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Persona
    {
        // persoma : edad, sueldo, nombre
        // Atributos, Miembros.

        private int edad;
        private double sueldo;
        private string nombre;

        //

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public void setEdad(int e)
        {
            edad = e;
        }

        public int getEdad()
        {
            return edad;
        }

        // METODOS 

        public string saludar()
        {
            return "Hola soy.." + nombre;
        }

        public string saludar(string personaje)
        {
            return "hola" + personaje + ", soy.." + this.nombre;
        }
    }
}
