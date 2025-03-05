using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
   internal class Camion : Vehiculo
    {
        private int capacidad;
        private int capacidadMaxima = 10;

        public Camion(string marca, double combustible) : base(marca, combustible)
        { 
            this.capacidad = 0; // Inicializamos la capacidad
        }

        // Simula que el camión avanza
        public override void Avanzar()
        {
            if (GetCombustible() > 0)
            {
                Console.WriteLine($"El camión {GetMarca()} está avanzando.");
            }
            else
            {
                Console.WriteLine($"El camión {GetMarca()} no tiene combustible para arrancar.");
            }
        }

        // Simula que el camión se detiene
        public override void Detener()
        {
            Console.WriteLine($"El camión {GetMarca()} se ha detenido.");
        }

        // Simula que el camión se carga
        public void Cargar()
        {
            Console.WriteLine($"El camión {GetMarca()} se está cargando.");
            capacidad = 0; // Reiniciamos la capacidad antes de cargar

            while (capacidad < capacidadMaxima)
            {
                Console.WriteLine($"El camión {GetMarca()} se está cargando con {capacidad} toneladas.");
                capacidad += 1; // Aumentamos la capacidad
            }

            Console.WriteLine($"El camión {GetMarca()} se ha cargado completamente con {capacidad} toneladas.");
        }
    }
}
