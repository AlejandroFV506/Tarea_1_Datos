using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    internal class bicicleta:Vehiculo
    {
        public bicicleta(string marca, double gasolina) : base(marca, gasolina) { }

        //Simula que el camión avanza
        public override void Avanzar()
        {
            Console.WriteLine($"La bicicleta {GetMarca()} esta avanzando");
        }

        //Simula que el camión se detiene
        public override void Detener()
        {
            Console.WriteLine($"La bicicleta {GetMarca()} se ha detenido.");
        }
    }
}
