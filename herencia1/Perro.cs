﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia1
{
    internal class Perro : AnimalDomestico
    {
        public override string Comunicarse()
        {
            return " guau.... guau....";
        }

        public override string ToString()
        {
            return "Perro : " + Nombre;
        }
    }
}
