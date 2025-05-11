using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class botella
    {
        // CAPCIDAD MÁXIMA : 100
        // cantidadActual : inicia en cero
        // Método recarga : carga al 100 y devuelve el costo de recarga. 50 cada 100
        public botella(string color, string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 200;
            cantidadActual = 0;
        }
        // sobre carga de constructor

        public botella()
        {

        }
        //botella : capacidad, color, material

        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual = 0;

        public int Capacidad
        {
            get { return capacidad; }
        }

        public int CantidadActual
        {
            get { return cantidadActual; }
        }

        // métodos

        public float recarga()
        {
            if (cantidadActual > 0)
            {
                int dif = capacidad - cantidadActual;
                // 100 50
                // dif
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }
            cantidadActual = 100;
            return 50;
        }
        public float recarga(int cantidad)
        {
            cantidadActual += cantidad;
            return cantidad * 50 / 100;
            // 100 50
            // cant x=??
        }
        // propiedad 
        //public int Capacidad
        //{
        //    get { return capacidad; }
        //    set { capacidad = value; }
        //}

    }
}
