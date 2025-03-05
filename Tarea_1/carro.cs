using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    internal class carro:Vehiculo
    {
        public carro(string marca, double gasolina) : base(marca, gasolina) { }

        //Simula que el carro avanza
        public override void Avanzar()
        {
            if (GetGasolina() > 0)
            {
                Console.WriteLine($"El carro {GetMarca()} está avanzando");
            }
            else
            {
                Console.WriteLine($"El carro {GetMarca()} no tiene gasolina para arrancar");
            }
        }

        //Simula que el carro se detiene
        public override void Detener()
        {
            Console.WriteLine($"El carro {GetMarca()} se ha detenido");
        }
    }
}
