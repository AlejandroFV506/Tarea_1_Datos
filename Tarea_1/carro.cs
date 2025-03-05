using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    internal class Carro:Vehiculo
    {
        public Carro(string marca, double combustible) : base(marca, combustible) { }

        //Simula que el carro avanza
        public override void Avanzar()
        {
            if (GetCombustible() > 0)
            {
                Console.WriteLine($"El carro {GetMarca()} está avanzando");
            }
            else
            {
                Console.WriteLine($"El carro {GetMarca()} no tiene combustible para arrancar");
            }
        }

        //Simula que el carro se detiene
        public override void Detener()
        {
            Console.WriteLine($"El carro {GetMarca()} se ha detenido");
        }
    }
}
