using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Producto
    {
        //- código Articulo (3 digitos no correlativos).
        // - precio 
        // - código de marca ( 1 al 10)

        public int CodigoAticulo { get; set; }
        public float Precio { get; set; }

        private int CodigoMarca;

        public int codigomarca
        {
            get { return CodigoMarca; }
            set 
            {
                if(value > 0 && value < 11)
                {
                    CodigoMarca = value;
                }
                else
                {
                    CodigoMarca = -1;
                }
            }
        }
    }
}
