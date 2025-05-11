using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona p1 = new Persona("francisco");
            //p1.setEdad(20);

            botella b1 = new botella("ROJO", "aluminio");
            botella b2 = new botella();
            //Console.WriteLine(p1.saludar());
            //Console.WriteLine(p1.saludar("maxi"));
            //Console.WriteLine("la edad es : " + p1.getEdad());  

            //b1.Capacidad = 500;
            int algo = b1.Capacidad;
            //Console.WriteLine(algo);


            //Perro P2 = new Perro();
            //Console.WriteLine("Ingrese el nombre de su perro : ");
            //P2.nombre = Console.ReadLine();
            //Console.WriteLine("el nombre de su perro es : ");
            //Console.WriteLine("cual es la raza de su perrro");
            //P2.raza = Console.ReadLine();
            //Console.WriteLine("ingrese la edad de su perro");
            //P2.edad = int.Parse(Console.ReadLine());

            Console.WriteLine(" la capacidad actual es  : " + b1.Capacidad);
            Console.WriteLine(" La cantidad actual es : " + b1.CantidadActual);

            b1.recarga(20);
            Console.WriteLine("Despues de la recarga la cantidad actual es : " + b1.CantidadActual);

            b1.recarga();
            Console.WriteLine("Despues de la recarga la cantidad actual es : " + b1.CantidadActual);
            Console.ReadKey();
        }

        
    }
}
