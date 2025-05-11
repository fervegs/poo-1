using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato g1 = new Gato();
            g1.Nombre = "pedro";

            Perro p1 = new Perro();
            p1.Nombre = "patan";

            List<Animal> animales = new List<Animal>();
            animales.Add(g1);
            animales.Add(p1);
            animales.Add(new Obeja());
            animales.Add(new Lobo());

            List<Flyabelcs> ListaDeVoladores = new List<Flyabelcs>();
            ListaDeVoladores.Add(new Loro());
            ListaDeVoladores.Add(new Canario());
            ListaDeVoladores.Add(new Paloma());
            //foreach (Animal a in animales)
            //{
            //    Console.WriteLine(a.Comunicarse());
            //}


            Console.ReadKey();
        }
    }
}
