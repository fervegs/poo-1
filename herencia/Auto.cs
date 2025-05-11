using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class Auto : Vehiculo
    {
        public Auto()
        {
            Chacis = new Chacis();
        }
        public string Anio { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }

        public Chacis Chacis { get; }
        // Composición

        // Agregación
        public Motor motor { get; set; }
    }
}
