using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // primer lote con 10 registros de poductos, cada producto tiene:
            // - código Articulo (3 digitos no correlativos).
            // - precio 
            // - código de marca ( 1 al 10)
            // segun lote con las ventas de la  semana, cada venta tiene:
            //
            //Este lote corta con codigo Cliente cero

            Producto p1 = new Producto();
            p1.codigomarca = 1;

            Producto[] productos = new Producto[10];

            for(int x = 0; x < 0; x++)
            {
                productos[x] = new Producto();
                Console.WriteLine("Ingrese el código de aticulo");
                productos[x].CodigoAticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el precio");
                productos[x].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el código de marca");
                productos[x].codigomarca = int.Parse(Console.ReadLine());

            }
            Ventas venta = new Ventas();

            Console.WriteLine("Ingrese la venta ");
            Console.WriteLine("Ingrese el código de cliente");
            venta.CodigoClente = int.Parse(Console.ReadLine());

            while(venta.CodigoClente != 0)
            {
                Console.WriteLine("Ingrese el código del articulo");
                venta.CodigoAticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad");

                Console.WriteLine("Ingrese la venta ");
                Console.WriteLine("Ingrese el código de cliente");
                venta.CodigoClente = int.Parse(Console.ReadLine());
            }
        }
    }
}
