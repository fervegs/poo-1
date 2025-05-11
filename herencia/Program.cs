using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // vehiculo > auto > AutoDeportivo > AutoUrbano
            // > Camioneta
            // > moto 
            //Vehiculo V1 = new Vehiculo();
            //Camioneta C1 = new Camioneta();
            //Camioneta C2 = new Camioneta();
            //Camioneta C3 = new Camioneta();
            //Auto A1 = new Auto();
            //AutoUrbano Au1 = new AutoUrbano();
            //C1.color = "Rojo";
            //C2.color = "Verde";
            //C3.color = "Azul";

            //List<Camioneta> ListaCamionetas = new List<Camioneta>();
            //ListaCamionetas.Add(C1);
            //ListaCamionetas.Add(C2);
            //ListaCamionetas.Add(C3);

            //Console.WriteLine("Lista de camionetas " + ListaCamionetas.Count);
            //ListaCamionetas[1].color = "Amarillo";
            //C2.color = "Negro";
            //Console.WriteLine("el color de la camioneta es : " + ListaCamionetas[1].color);
            //ListaCamionetas.Remove(C3);
            //Console.WriteLine("Listas de camionetas " + ListaCamionetas.Count);

            //foreach (Camioneta camioneta in ListaCamionetas)
            //{
            //    Console.WriteLine("Color " + camioneta.color);
            //}

            Auto a1 = new Auto();
            a1.motor = new Motor();

            Console.ReadKey();


        }
    }
}
