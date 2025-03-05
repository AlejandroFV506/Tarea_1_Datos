using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    internal class Bicicleta:Vehiculo
    {
        public Bicicleta(string marca, double combustible) : base(marca, combustible) { }

        //Simula que la bicicleta avanza
        public override void Avanzar()
        {
            Console.WriteLine($"La bicicleta {GetMarca()} esta avanzando");
        }

        //Simula que la bicicleta se detiene
        public override void Detener()
        {
            Console.WriteLine($"La bicicleta {GetMarca()} se ha detenido.");
        }
    }
}
