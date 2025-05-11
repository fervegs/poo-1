using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia1
{
    internal class Canario : AnimalDomestico, Flyabelcs
    {
        public string Volar()
        {
            return "vuela como un canario...";
        }
    }
}
