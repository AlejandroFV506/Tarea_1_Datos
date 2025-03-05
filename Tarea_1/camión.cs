using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    internal class camión:Vehiculo
    {
        public camión(string marca, double combustible) : base(marca, combustible)
        { 
        
        }

        //Simula que el camión avanza
        public override void Avanzar()
        {
            if (GetCombustible() > 0)
            {
                Console.WriteLine($"El camión {GetMarca()} está avanzando");
            }
            else
            {
                Console.WriteLine($"El camión {GetMarca()} no tiene combustible para arrancar.");
            }
        }

        //Simula que el camión se detiene
        public override void Detener()
        {
            Console.WriteLine($"El camión {GetMarca()} se ha detenido.");
        }
    }
}
